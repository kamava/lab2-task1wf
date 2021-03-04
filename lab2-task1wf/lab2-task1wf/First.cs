using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_task1wf
{
    public partial class First : Form
    {
        string[] list= new string[0];
        string[] mylist = new string[0];
       

        
        public First()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox1_KeyPress;
            textBox2.KeyPress += textBox2_KeyPress;
           /* textBox6.KeyPress += textBox6_KeyPress;*/
        }
       
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyChar == (char)Keys.Enter && tb.Text.Length != 0)
            {//Если нажата кнопка Enter
                Array.Resize<string>(ref list, list.Length + 1);//Увеличение размера массива на 1
                list[list.Length - 1] = tb.Text;//Запись нового значения в массив
                listBox1.Items.Clear();//очистка ListBox
                listBox1.Items.AddRange(list);//Добавление в ListBox данных из массива
                tb.Text = string.Empty;//Очистка текстового поля
               
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb1 = sender as TextBox;
            if (e.KeyChar == (char)Keys.Enter && tb1.Text.Length != 0)
            {//Если нажата кнопка Enter
                Array.Resize<string>(ref mylist, mylist.Length + 1);//Увеличение размера массива на 1
                mylist[mylist.Length - 1] = tb1.Text;//Запись нового значения в массив
                listBox2.Items.Clear();//очистка ListBox
                listBox2.Items.AddRange(mylist);//Добавление в ListBox данных из массива
                tb1.Text = string.Empty;//Очистка текстового поля

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                textBox7.Text += list.Length.ToString();
                textBox8.Text += mylist.Length.ToString();
            }
            catch
            {
                MessageBox.Show("Enter correct value");
            }
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            
            try
            {
                int x = Convert.ToInt32(textBox6.Text);
                textBox4.Text += list[x].ToString();
                
                
            }
            catch
            {
                MessageBox.Show("Enter correct value");
            }
            
            
              


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                int x1 = Convert.ToInt32(textBox3.Text);
                textBox5.Text += mylist[x1].ToString();
                
            }
            catch
            {
                MessageBox.Show("Enter correct value");
               
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
