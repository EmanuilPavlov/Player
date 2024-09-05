
namespace Player
{

    public partial class main : Form
    {
        Form2 child2 = new Form2();
        Form3 child = new Form3();
        private MP3 mp3Player = new MP3();

        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mp3Player.open(openFile.FileName);
            mp3Player.play(0, openFile.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mp3Player.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp3Player.close(openFile.FileName);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            child.ShowDialog();           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            child2.ShowDialog();          
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(listBox1.SelectedItems))
            {
                listBox1.Items.Remove(listBox1.Text);
                child2.textBox1.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(child2.textBox1.Text))
            {
                listBox1.Items.Add(child2.textBox1.Text);
            }
            else
            {
                MessageBox.Show("This item esists");
            }
            child2.textBox1.Clear();
        }
        public OpenFileDialog openFile = new OpenFileDialog();
        private void button8_Click(object sender, EventArgs e)
        {
            openFile.InitialDirectory = @"Desktop";
            openFile.FileName = " ";
            openFile.Filter = "Mp3 Files|*.mp3";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                mp3Player.open(openFile.FileName);
                child.textBox1.Text = openFile.SafeFileName.ToString();
                try
                {
                    if (!listBox1.Items.Contains(openFile.SafeFileName))
                    {
                        listBox1.Items.Add(openFile.SafeFileName.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }           
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Nitro 5\source\repos\Player\Player\bin\text.txt");
            try
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
             
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}