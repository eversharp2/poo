using System.Drawing.Text;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace textualizer
{
    public partial class Textualizer : Form
    {
        public Textualizer()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".txt")
                {

                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                }
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName).ToLower() == ".txt")
                {

                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
                }
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName);

            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void codigoRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codigo = richTextBox1.SelectedRtf;
            MessageBox.Show(codigo);
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void derechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            richTextBox1.Width = this.ClientSize.Width;
            richTextBox1.Height = this.ClientSize.Height - toolStrip1.Height;
        }

       
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int lineas = richTextBox1.Lines.Length;
            tslbl_lineas.Text = "Lineas: " + lineas.ToString();
        }

        

        


       

    }
}
