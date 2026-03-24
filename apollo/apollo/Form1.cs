using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Globalization;

namespace apollo
{
    public partial class Form1 : Form
    {
        string filename;
        string FilePath;
        private LibVLC libVLC;
        private MediaPlayer mediaPlayer;
        private VideoView videoView1;

        private System.Windows.Forms.Timer timer;
        private bool isDragging = false;

        private string rutaInicial;
        private Process ffmpegProcess; // Para poder acceder desde cualquier botón
        public Form1(string rutaVideo)
        {
            InitializeComponent();

            rutaInicial = rutaVideo;

            Core.Initialize();


            libVLC = new LibVLC(new string[] {
                "--no-video-title-show",
                "--verbose=2"
            });

            // Suscribirse al log
            libVLC.Log += (sender, e) =>
            {
                System.Diagnostics.Debug.WriteLine($"[VLC] {e.FormattedLog}");
            };
            mediaPlayer = new MediaPlayer(libVLC);

            videoView1 = new VideoView
            {
                Dock = DockStyle.Fill,
                MediaPlayer = mediaPlayer
            };

            this.Controls.Add(videoView1);

            this.Load += Form1_Load;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (!string.IsNullOrEmpty(rutaInicial))
            {
                this.BeginInvoke(new Action(() =>
                {
                    var media = new Media(libVLC, rutaInicial, FromType.FromPath);
                    mediaPlayer.Play(media);
                }));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            //-----------------------------------------------



            //---------------------------------------------




            // Configurar TrackBar
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 1000;

            // Crear Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Eventos del TrackBar
            trackBar1.MouseDown += trackBar1_MouseDown;
            trackBar1.MouseUp += trackBar1_MouseUp;

            tsc_frames.Items.Clear();
            tsc_frames.Items.Insert(0, "Frame actual");
            tsc_frames.Items.Insert(1, "Intervalo");
            tsc_frames.SelectedIndex = 0;

            tsc_format.Items.Clear();
            tsc_format.Items.Insert(0, "jpg");
            tsc_format.Items.Insert(1, "png");
            tsc_frames.SelectedIndex = 0;

            tsc_frames.SelectedIndexChanged += tsc_frames_SelectedIndexChanged;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer == null || mediaPlayer.Length <= 0)
                return;

            // Tiempo actual
            TimeSpan current = TimeSpan.FromMilliseconds(mediaPlayer.Time);

            // Duración total
            TimeSpan total = TimeSpan.FromMilliseconds(mediaPlayer.Length);

            // Tiempo restante
            TimeSpan remaining = total - current;

            // Formato mm:ss
            string currentStr = current.ToString(@"mm\:ss");
            string totalStr = total.ToString(@"mm\:ss");
            string remainingStr = remaining.ToString(@"mm\:ss");

            string format = total.TotalHours >= 1 ? @"hh\:mm\:ss" : @"mm\:ss";

            // Mostrar
            labelTime.Text = $"{current.ToString(format)} / {total.ToString(format)}";


        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

            float newPos = (float)trackBar1.Value / trackBar1.Maximum;
            mediaPlayer.Position = newPos;
        }
        private void ts_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Videos|*.mp4;*.avi;*.mkv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {


                        mediaPlayer.Stop();

                        this.BeginInvoke(new Action(() =>
                        {
                            var media = new Media(libVLC, ofd.FileName, FromType.FromPath);
                            ;
                            mediaPlayer.Play(media);

                        }));
                        filename = Path.GetFileName(ofd.FileName);
                        FilePath = Path.GetDirectoryName(ofd.FileName);
                        Form1.ActiveForm.Text = $"FrameForge - {filename}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void tsb_play_Click(object sender, EventArgs e)
        {
            mediaPlayer.Play();
        }

        private void tsb_pause_Click(object sender, EventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void tsb_stop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void tsb_fordwar_Click(object sender, EventArgs e)
        {
            mediaPlayer.Time += int.Parse(tst_ms.Text);
        }

        private void tsb_back_Click(object sender, EventArgs e)
        {
            mediaPlayer.Time -= int.Parse(tst_ms.Text);
        }

        private void tsb_volume_Click(object sender, EventArgs e)
        {
            mediaPlayer.Volume += 10;
        }

        private void tbs_volumeD_Click(object sender, EventArgs e)
        {
            mediaPlayer.Volume -= 10;
        }

        private void tsb_mute_Click(object sender, EventArgs e)
        {
            mediaPlayer.Volume = 0;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(0.5f);
            xToolStripMenuItem1.Checked = false;
            xToolStripMenuItem2.Checked = false;
            xToolStripMenuItem3.Checked = false;
            tsMenuItem4.Checked = false;
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(1.0f);
            xToolStripMenuItem.Checked = false;
            xToolStripMenuItem2.Checked = false;
            xToolStripMenuItem3.Checked = false;
            tsMenuItem4.Checked = false;
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(1.5f);
            xToolStripMenuItem.Checked = false;
            xToolStripMenuItem1.Checked = false;
            xToolStripMenuItem3.Checked = false;
            tsMenuItem4.Checked = false;
        }

        private void xToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(2.0f);
            xToolStripMenuItem.Checked = false;
            xToolStripMenuItem1.Checked = false;
            xToolStripMenuItem2.Checked = false;
            tsMenuItem4.Checked = false;
        }

        

        private void tsMenuItem4_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(0.25f);
            xToolStripMenuItem.Checked = false;
            xToolStripMenuItem1.Checked = false;
            xToolStripMenuItem2.Checked = false;
            xToolStripMenuItem3.Checked = false;
        }

        private void RunFFmpeg(string arguments)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = @"C:\ffmpeg\bin\ffmpeg.exe",
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    MessageBox.Show(output); // CLAVE
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RunFFmpegWithProgress(string arguments, long totalDurationMs)
        {
            progressBar1.Visible = true;
            btn_cancelar.Visible = true;    
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            btn_cancelar.Enabled = true; // Habilitamos el botón de cancelar
            tsb_export.Enabled = false;  // Deshabilitamos exportar para evitar doble proceso

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\ffmpeg\bin\ffmpeg.exe",
                Arguments = arguments,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true
            };

            ffmpegProcess = new Process { StartInfo = psi, EnableRaisingEvents = true };

            ffmpegProcess.ErrorDataReceived += (sender, e) =>
            {
                // SI EL PROCESO SE CANCELÓ (ffmpegProcess es null), SALIMOS
                if (ffmpegProcess == null || string.IsNullOrEmpty(e.Data)) return;

                if (e.Data.Contains("time="))
                {
                    string timeString = ExtractTime(e.Data);
                    if (TimeSpan.TryParse(timeString, out TimeSpan currentTime))
                    {
                        // DECLARAMOS Y CALCULAMOS PERCENT AQUÍ
                        double percent = (currentTime.TotalMilliseconds / totalDurationMs) * 100;

                        // Actualizamos la UI de forma segura
                        this.BeginInvoke(new Action(() =>
                        {
                            // Volvemos a chequear que no se haya cancelado en este milisegundo
                            if (ffmpegProcess != null)
                            {
                                int value = (int)percent;
                                if (value >= 0 && value <= 100) progressBar1.Value = value;
                            }
                        }));
                    }
                }
            };

            ffmpegProcess.Exited += (sender, e) => {
                this.BeginInvoke(new Action(() => {
                    if (ffmpegProcess != null) // Si terminó solo (no por cancelar)
                    {
                        progressBar1.Value = 100;
                        MessageBox.Show("¡Exportación completada con éxito!");
                    }
                    btn_cancelar.Visible = false;
                    progressBar1.Visible = false;
                    tsb_export.Enabled = true;
                    ffmpegProcess = null;
                }));
            };

            ffmpegProcess.Start();
            ffmpegProcess.BeginErrorReadLine();
        }


        // Función auxiliar para sacar el tiempo del texto de FFmpeg
        private string ExtractTime(string data)
        {
            // Buscamos donde empieza "time=" y tomamos los siguientes 11 caracteres
            int index = data.IndexOf("time=") + 5;
            return data.Substring(index, 11);
        }

        public void ExportFramesInterval(string videoPath, int intervalSeconds, string outputFolder, string format)
        {

            string fileNamePattern = $"frame_%04d.{format}";
            string outputPattern = Path.Combine(outputFolder, fileNamePattern);
            string args = $"-y -i \"{videoPath}\" -vf  fps=1/60 -fps_mode cfr -an -q:v 2 \"{outputPattern}\"";

            RunFFmpeg(args);
        }

        private void tsb_export_Click(object sender, EventArgs e)
        {
            string video = filename;
            string format = "jpg";

            if (tsc_frames.SelectedIndex == 0)
            {
                Directory.CreateDirectory(FilePath + "\\output\\");

                mediaPlayer.TakeSnapshot(0, Path.Combine(FilePath + "\\output\\", "frame.jpg"), 0, 0);
            }
            else
            {

                // Dentro de tsb_export_Click, en el bloque else:
                int intervalo = int.Parse(tst_interval.Text);
                long duration = mediaPlayer.Length; // Duración total en milisegundos

                string output = Path.Combine(FilePath + "\\output\\");
                if (!Directory.Exists(output)) Directory.CreateDirectory(output);

                string tempVideo = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".mp4");
                File.Copy(Path.Combine(FilePath, filename), tempVideo, true);

                // Preparamos los argumentos
                string args = $"-y -i \"{tempVideo}\" -vf \"fps=1/{intervalo}\" -fps_mode cfr -an -q:v 2 \"{output}\\frame_%04d.{format}\"";

                // Lanzamos el proceso con progreso
                RunFFmpegWithProgress(args, duration);
            }


        }

        private void tsc_frames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se habilita solo si el índice seleccionado es mayor a 0
            tst_interval.Enabled = (tsc_frames.SelectedIndex > 0);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (ffmpegProcess != null)
            {
                try
                {
                    // Bloqueamos eventos para que no salten errores mientras cerramos
                    ffmpegProcess.EnableRaisingEvents = false;

                    if (!ffmpegProcess.HasExited)
                    {
                        ffmpegProcess.Kill();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error al matar FFmpeg: " + ex.Message);
                }
                finally
                {
                    // LIBERAMOS LOS RECURSOS
                    ffmpegProcess.Dispose();
                    ffmpegProcess = null;

                    // REHABILITAMOS LA INTERFAZ MANUALMENTE
                    this.BeginInvoke(new Action(() => {
                        tsb_export.Enabled = true;   // El botón de exportar vuelve a brillar
                        btn_cancelar.Visible = false; // El de cancelar se apaga
                        progressBar1.Value = 0;      // Reiniciamos la barra
                        progressBar1.Visible = false;   // Y la escondemos  
                        MessageBox.Show("Exportación cancelada y proceso liberado.");
                    }));
                }
            }
        }
    }
}