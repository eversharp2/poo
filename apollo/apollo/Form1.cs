using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace apollo
{
    public partial class Form1 : Form
    {
        private LibVLC libVLC;
        private MediaPlayer mediaPlayer;
        private VideoView videoView1;

        private System.Windows.Forms.Timer timer;
        private bool isDragging = false;

        private string rutaInicial;

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
                            mediaPlayer.Play(media);
                        }));
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
            mediaPlayer.Time += 10000;
        }

        private void tsb_back_Click(object sender, EventArgs e)
        {
            mediaPlayer.Time -= 10000;
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
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(1.0f);
            xToolStripMenuItem.Checked = false;
            xToolStripMenuItem2.Checked = false;
            xToolStripMenuItem3.Checked = false;
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(1.5f);
            xToolStripMenuItem.Checked = false;
            xToolStripMenuItem1.Checked = false;
            xToolStripMenuItem3.Checked = false;
        }

        private void xToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetRate(2.0f);
            xToolStripMenuItem.Checked = false;
            xToolStripMenuItem1.Checked = false;
            xToolStripMenuItem2.Checked = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}