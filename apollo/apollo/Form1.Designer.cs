namespace apollo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            ts_open = new ToolStripMenuItem();
            ts_rep = new ToolStripMenuItem();
            ts_speed = new ToolStripMenuItem();
            xToolStripMenuItem = new ToolStripMenuItem();
            xToolStripMenuItem1 = new ToolStripMenuItem();
            xToolStripMenuItem2 = new ToolStripMenuItem();
            xToolStripMenuItem3 = new ToolStripMenuItem();
            ts_fordwar = new ToolStripMenuItem();
            ts_back = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ts_play = new ToolStripMenuItem();
            ts_pause = new ToolStripMenuItem();
            ts_stop = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsb_play = new ToolStripButton();
            tsb_pause = new ToolStripButton();
            tsb_stop = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsb_back = new ToolStripButton();
            tsb_fordwar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tbs_volumeD = new ToolStripButton();
            tsb_mute = new ToolStripButton();
            tsb_volume = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            trackBar1 = new TrackBar();
            labelTime = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ts_open, ts_rep });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ts_open
            // 
            ts_open.Name = "ts_open";
            ts_open.Size = new Size(45, 20);
            ts_open.Text = "Abrir";
            ts_open.ToolTipText = "Abrir";
            ts_open.Click += ts_open_Click;
            // 
            // ts_rep
            // 
            ts_rep.DropDownItems.AddRange(new ToolStripItem[] { ts_speed, ts_fordwar, ts_back, toolStripSeparator1, ts_play, ts_pause, ts_stop });
            ts_rep.Name = "ts_rep";
            ts_rep.Size = new Size(93, 20);
            ts_rep.Text = "Reproducción";
            ts_rep.ToolTipText = "Reproducción";
            // 
            // ts_speed
            // 
            ts_speed.DropDownItems.AddRange(new ToolStripItem[] { xToolStripMenuItem, xToolStripMenuItem1, xToolStripMenuItem2, xToolStripMenuItem3 });
            ts_speed.Name = "ts_speed";
            ts_speed.Size = new Size(166, 22);
            ts_speed.Text = "Velocidad";
            ts_speed.ToolTipText = "Velocidad";
            // 
            // xToolStripMenuItem
            // 
            xToolStripMenuItem.CheckOnClick = true;
            xToolStripMenuItem.Name = "xToolStripMenuItem";
            xToolStripMenuItem.Size = new Size(95, 22);
            xToolStripMenuItem.Text = ".5x";
            xToolStripMenuItem.Click += xToolStripMenuItem_Click;
            // 
            // xToolStripMenuItem1
            // 
            xToolStripMenuItem1.Checked = true;
            xToolStripMenuItem1.CheckOnClick = true;
            xToolStripMenuItem1.CheckState = CheckState.Checked;
            xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            xToolStripMenuItem1.Size = new Size(95, 22);
            xToolStripMenuItem1.Text = "1x";
            xToolStripMenuItem1.Click += xToolStripMenuItem1_Click;
            // 
            // xToolStripMenuItem2
            // 
            xToolStripMenuItem2.CheckOnClick = true;
            xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            xToolStripMenuItem2.Size = new Size(95, 22);
            xToolStripMenuItem2.Text = "1.5x";
            xToolStripMenuItem2.Click += xToolStripMenuItem2_Click;
            // 
            // xToolStripMenuItem3
            // 
            xToolStripMenuItem3.CheckOnClick = true;
            xToolStripMenuItem3.Name = "xToolStripMenuItem3";
            xToolStripMenuItem3.Size = new Size(95, 22);
            xToolStripMenuItem3.Text = "2x";
            xToolStripMenuItem3.Click += xToolStripMenuItem3_Click;
            // 
            // ts_fordwar
            // 
            ts_fordwar.Name = "ts_fordwar";
            ts_fordwar.Size = new Size(166, 22);
            ts_fordwar.Text = "Adelantar 10 sec.";
            ts_fordwar.ToolTipText = "Adelantar 10 sec";
            ts_fordwar.Click += tsb_fordwar_Click;
            // 
            // ts_back
            // 
            ts_back.Name = "ts_back";
            ts_back.Size = new Size(166, 22);
            ts_back.Text = "Retroceder 10 sec";
            ts_back.ToolTipText = "Retroceder 10 sec";
            ts_back.Click += tsb_back_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(163, 6);
            // 
            // ts_play
            // 
            ts_play.Name = "ts_play";
            ts_play.Size = new Size(166, 22);
            ts_play.Text = "Play";
            ts_play.ToolTipText = "Reproducir";
            ts_play.Click += tsb_play_Click;
            // 
            // ts_pause
            // 
            ts_pause.Name = "ts_pause";
            ts_pause.Size = new Size(166, 22);
            ts_pause.Text = "Pausa";
            ts_pause.ToolTipText = "Pausar";
            ts_pause.Click += tsb_pause_Click;
            // 
            // ts_stop
            // 
            ts_stop.Name = "ts_stop";
            ts_stop.Size = new Size(166, 22);
            ts_stop.Text = "Detener";
            ts_stop.ToolTipText = "Detener";
            ts_stop.Click += tsb_stop_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_play, tsb_pause, tsb_stop, toolStripSeparator3, tsb_back, tsb_fordwar, toolStripSeparator4, tbs_volumeD, tsb_mute, tsb_volume });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsb_play
            // 
            tsb_play.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_play.Image = (Image)resources.GetObject("tsb_play.Image");
            tsb_play.ImageTransparentColor = Color.Magenta;
            tsb_play.Name = "tsb_play";
            tsb_play.Size = new Size(23, 22);
            tsb_play.Text = "toolStripButton1";
            tsb_play.ToolTipText = "Reproducir";
            tsb_play.Click += tsb_play_Click;
            // 
            // tsb_pause
            // 
            tsb_pause.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_pause.Image = (Image)resources.GetObject("tsb_pause.Image");
            tsb_pause.ImageTransparentColor = Color.Magenta;
            tsb_pause.Name = "tsb_pause";
            tsb_pause.Size = new Size(23, 22);
            tsb_pause.Text = "toolStripButton2";
            tsb_pause.ToolTipText = "Pausar";
            tsb_pause.Click += tsb_pause_Click;
            // 
            // tsb_stop
            // 
            tsb_stop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_stop.Image = (Image)resources.GetObject("tsb_stop.Image");
            tsb_stop.ImageTransparentColor = Color.Magenta;
            tsb_stop.Name = "tsb_stop";
            tsb_stop.Size = new Size(23, 22);
            tsb_stop.Text = "toolStripButton3";
            tsb_stop.ToolTipText = "Detener";
            tsb_stop.Click += tsb_stop_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // tsb_back
            // 
            tsb_back.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_back.Image = (Image)resources.GetObject("tsb_back.Image");
            tsb_back.ImageTransparentColor = Color.Magenta;
            tsb_back.Name = "tsb_back";
            tsb_back.Size = new Size(23, 22);
            tsb_back.Text = "toolStripButton4";
            tsb_back.ToolTipText = "Atrás";
            tsb_back.Click += tsb_back_Click;
            // 
            // tsb_fordwar
            // 
            tsb_fordwar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_fordwar.Image = (Image)resources.GetObject("tsb_fordwar.Image");
            tsb_fordwar.ImageTransparentColor = Color.Magenta;
            tsb_fordwar.Name = "tsb_fordwar";
            tsb_fordwar.Size = new Size(23, 22);
            tsb_fordwar.Text = "toolStripButton5";
            tsb_fordwar.ToolTipText = "Adelante";
            tsb_fordwar.Click += tsb_fordwar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // tbs_volumeD
            // 
            tbs_volumeD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbs_volumeD.Image = (Image)resources.GetObject("tbs_volumeD.Image");
            tbs_volumeD.ImageTransparentColor = Color.Magenta;
            tbs_volumeD.Name = "tbs_volumeD";
            tbs_volumeD.Size = new Size(23, 22);
            tbs_volumeD.Text = "toolStripButton1";
            tbs_volumeD.ToolTipText = "Disminuir volumen";
            tbs_volumeD.Click += tbs_volumeD_Click;
            // 
            // tsb_mute
            // 
            tsb_mute.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_mute.Image = (Image)resources.GetObject("tsb_mute.Image");
            tsb_mute.ImageTransparentColor = Color.Magenta;
            tsb_mute.Name = "tsb_mute";
            tsb_mute.Size = new Size(23, 22);
            tsb_mute.Text = "toolStripButton2";
            tsb_mute.ToolTipText = "Silenciar";
            tsb_mute.Click += tsb_mute_Click;
            // 
            // tsb_volume
            // 
            tsb_volume.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_volume.Image = (Image)resources.GetObject("tsb_volume.Image");
            tsb_volume.ImageTransparentColor = Color.Magenta;
            tsb_volume.Name = "tsb_volume";
            tsb_volume.Size = new Size(23, 22);
            tsb_volume.Text = "toolStripButton6";
            tsb_volume.ToolTipText = "Volumen";
            tsb_volume.Click += tsb_volume_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            trackBar1.Cursor = Cursors.NoMoveHoriz;
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Location = new Point(0, 380);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(800, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.BackColor = SystemColors.WindowFrame;
            labelTime.Location = new Point(699, 362);
            labelTime.Margin = new Padding(3, 0, 20, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(72, 15);
            labelTime.TabIndex = 3;
            labelTime.Text = "00:00 / 00:00";
            labelTime.Click += labelTime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTime);
            Controls.Add(trackBar1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Apollo";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ts_rep;
        private ToolStripMenuItem ts_speed;
        private ToolStripMenuItem ts_fordwar;
        private ToolStripMenuItem ts_back;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ts_play;
        private ToolStripMenuItem ts_pause;
        private ToolStripMenuItem ts_stop;
        private ToolStrip toolStrip1;
        private ToolStripButton tsb_play;
        private ToolStripButton tsb_pause;
        private ToolStripButton tsb_stop;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsb_back;
        private ToolStripButton tsb_fordwar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsb_volume;
        private ToolStripMenuItem ts_open;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton tbs_volumeD;
        private ToolStripButton tsb_mute;
        private TrackBar trackBar1;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem1;
        private ToolStripMenuItem xToolStripMenuItem2;
        private ToolStripMenuItem xToolStripMenuItem3;
        private Label labelTime;
    }
}
