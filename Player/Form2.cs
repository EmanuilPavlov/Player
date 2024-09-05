using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form2 : Form
    {
        private MP3 player = new MP3();
        public OpenFileDialog openFile = new OpenFileDialog();
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                StreamWriter sw = File.AppendText(@"C:\Users\Nitro 5\source\repos\Player\Player\bin\text.txt");
                sw.WriteLine(input);
                sw.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar ==95)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
