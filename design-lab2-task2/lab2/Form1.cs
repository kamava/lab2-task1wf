using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        string[,] mass = new string[1,1];
        
        public Form1()
        {
            InitializeComponent();
            EnterValue.KeyPress += EnterValue_KeyPress;
            EnterIndex.KeyPress += EnterIndex_KeyPress;
          
        }

        public void EnterIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter )
            {
                for(int i = 0; i < mass.Length; i++)
                {
                    i =Convert.ToInt32( EnterIndex.Text);
                    string firstElement = Convert.ToString(OutputValue.Items[i]);
                    OutputIndex.Text += firstElement.ToString();
                    EnterIndex.Clear();

                }
            }
        }
        public void EnterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s;
            TextBox tb = sender as TextBox;
            if (e.KeyChar == (char)Keys.Enter && tb.Text.Length != 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    s = "";
                    for (int j = 0; j < 1; j++)
                    {
                        mass[i, j] = EnterValue.Text;
                        s +=(mass[i, j]).ToString() + "  ";
                        OutputValue.Items.Add(s);
                        EnterValue.Clear();
                    }

                }
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IndexButton_Click(object sender, EventArgs e)
        {    
                string firstElement = Convert.ToString(OutputValue.Items[2]);
                OutputIndex.Text += firstElement.ToString();    
        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SearchCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = OutputValue.Items.Count;
                OutputCount.Text = n.ToString();

            }
            catch
            {
                MessageBox.Show("Enter correct value");

            }

        }

        private void OutputValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnterValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
