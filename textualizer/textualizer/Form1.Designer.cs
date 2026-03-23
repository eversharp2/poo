namespace textualizer
{
    partial class Textualizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Textualizer));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            ediciónToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            justificarToolStripMenuItem = new ToolStripMenuItem();
            centroToolStripMenuItem = new ToolStripMenuItem();
            izquierdaToolStripMenuItem = new ToolStripMenuItem();
            derechaToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            tsbtn_open = new ToolStripButton();
            tsbtn_save = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbtn_fonts = new ToolStripButton();
            tsbtn_color = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbtn_left = new ToolStripButton();
            tsbtn_center = new ToolStripButton();
            tsb_right = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            tslbl_lineas = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ediciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, cerrarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(105, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(105, 22);
            cerrarToolStripMenuItem.Text = "Salvar";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // ediciónToolStripMenuItem
            // 
            ediciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem, colorToolStripMenuItem, justificarToolStripMenuItem });
            ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            ediciónToolStripMenuItem.Size = new Size(58, 20);
            ediciónToolStripMenuItem.Text = "Edición";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(120, 22);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(120, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // justificarToolStripMenuItem
            // 
            justificarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centroToolStripMenuItem, izquierdaToolStripMenuItem, derechaToolStripMenuItem });
            justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            justificarToolStripMenuItem.Size = new Size(120, 22);
            justificarToolStripMenuItem.Text = "Justificar";
            // 
            // centroToolStripMenuItem
            // 
            centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            centroToolStripMenuItem.Size = new Size(122, 22);
            centroToolStripMenuItem.Text = "Centro";
            centroToolStripMenuItem.Click += centroToolStripMenuItem_Click;
            // 
            // izquierdaToolStripMenuItem
            // 
            izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            izquierdaToolStripMenuItem.Size = new Size(122, 22);
            izquierdaToolStripMenuItem.Text = "Izquierda";
            izquierdaToolStripMenuItem.Click += izquierdaToolStripMenuItem_Click;
            // 
            // derechaToolStripMenuItem
            // 
            derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            derechaToolStripMenuItem.Size = new Size(122, 22);
            derechaToolStripMenuItem.Text = "Derecha";
            derechaToolStripMenuItem.Click += derechaToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 373);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Rich Text(rtf)|*.rtf|Text(txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Rich Text(RTF)|*.rtf|TXT|*.txt";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtn_open, tsbtn_save, toolStripSeparator1, tsbtn_fonts, tsbtn_color, toolStripSeparator2, tsbtn_left, tsbtn_center, tsb_right, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbtn_open
            // 
            tsbtn_open.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_open.Image = (Image)resources.GetObject("tsbtn_open.Image");
            tsbtn_open.ImageTransparentColor = Color.Magenta;
            tsbtn_open.Name = "tsbtn_open";
            tsbtn_open.Size = new Size(23, 22);
            tsbtn_open.Text = "toolStripButton1";
            tsbtn_open.ToolTipText = "Abrir";
            tsbtn_open.Click += abrirToolStripMenuItem_Click;
            // 
            // tsbtn_save
            // 
            tsbtn_save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_save.Image = (Image)resources.GetObject("tsbtn_save.Image");
            tsbtn_save.ImageTransparentColor = Color.Magenta;
            tsbtn_save.Name = "tsbtn_save";
            tsbtn_save.Size = new Size(23, 22);
            tsbtn_save.Text = "toolStripButton1";
            tsbtn_save.ToolTipText = "Save";
            tsbtn_save.Click += cerrarToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbtn_fonts
            // 
            tsbtn_fonts.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_fonts.Image = (Image)resources.GetObject("tsbtn_fonts.Image");
            tsbtn_fonts.ImageTransparentColor = Color.Magenta;
            tsbtn_fonts.Name = "tsbtn_fonts";
            tsbtn_fonts.Size = new Size(23, 22);
            tsbtn_fonts.Text = "toolStripButton1";
            tsbtn_fonts.ToolTipText = "fonts";
            tsbtn_fonts.Click += fuenteToolStripMenuItem_Click;
            // 
            // tsbtn_color
            // 
            tsbtn_color.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_color.Image = (Image)resources.GetObject("tsbtn_color.Image");
            tsbtn_color.ImageTransparentColor = Color.Magenta;
            tsbtn_color.Name = "tsbtn_color";
            tsbtn_color.Size = new Size(23, 22);
            tsbtn_color.Text = "toolStripButton1";
            tsbtn_color.Click += colorToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsbtn_left
            // 
            tsbtn_left.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_left.Image = (Image)resources.GetObject("tsbtn_left.Image");
            tsbtn_left.ImageTransparentColor = Color.Magenta;
            tsbtn_left.Name = "tsbtn_left";
            tsbtn_left.Size = new Size(23, 22);
            tsbtn_left.Text = "toolStripButton1";
            tsbtn_left.ToolTipText = "Justifi Left";
            tsbtn_left.Click += izquierdaToolStripMenuItem_Click;
            // 
            // tsbtn_center
            // 
            tsbtn_center.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_center.Image = (Image)resources.GetObject("tsbtn_center.Image");
            tsbtn_center.ImageTransparentColor = Color.Magenta;
            tsbtn_center.Name = "tsbtn_center";
            tsbtn_center.Size = new Size(23, 22);
            tsbtn_center.Text = "toolStripButton1";
            tsbtn_center.ToolTipText = "Center";
            tsbtn_center.Click += centroToolStripMenuItem_Click;
            // 
            // tsb_right
            // 
            tsb_right.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_right.Image = (Image)resources.GetObject("tsb_right.Image");
            tsb_right.ImageTransparentColor = Color.Magenta;
            tsb_right.Name = "tsb_right";
            tsb_right.Size = new Size(23, 22);
            tsb_right.Text = "toolStripButton1";
            tsb_right.ToolTipText = "Justify Right";
            tsb_right.Click += derechaToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslbl_lineas });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslbl_lineas
            // 
            tslbl_lineas.AutoSize = false;
            tslbl_lineas.BorderStyle = Border3DStyle.Sunken;
            tslbl_lineas.Name = "tslbl_lineas";
            tslbl_lineas.Size = new Size(60, 17);
            tslbl_lineas.Text = "Líneas: 0";
            // 
            // Textualizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Textualizer";
            Text = "Form1";
            
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem justificarToolStripMenuItem;
        private ToolStripMenuItem centroToolStripMenuItem;
        private ToolStripMenuItem izquierdaToolStripMenuItem;
        private ToolStripMenuItem derechaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtn_open;
        private ToolStripButton tsbtn_save;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbtn_fonts;
        private ToolStripButton tsbtn_color;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbtn_left;
        private ToolStripButton tsbtn_center;
        private ToolStripButton tsb_right;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslbl_lineas;
        private ToolStripSeparator toolStripSeparator3;
    }
}
