using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xulychuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int vtbd=0;
        void TimKiem(TextBox X, TextBox Y)
        {
            int a = X.Text.IndexOf(textBox2.Text);
            int b = Y.TextLength;
            //textBox1.Select(a, b);
            if (b == 0)
                MessageBox.Show("Mời nhập nội dung tìm kiếm", "Thông báo");
            else
            {
                if (X.Text.Contains(Y.Text))
                {
                    X.Select(a, b);
                    //vtbd = X.Text.IndexOf(X.SelectedText) + X.TextLength;
                }
                else
                    MessageBox.Show("Không tìm thấy kết quả.", "Thông báo");
            }
            X.Focus();
        }

        void FindNext(TextBox X,TextBox Y)
        {
            int vtbd = X.Text.IndexOf(X.SelectedText);
            //string chuoicl = "";
            //if(vtbd-Y.TextLength>0)
            string     chuoicl = X.Text.Remove(0, vtbd+ Y.TextLength);
            vtbd += chuoicl.IndexOf(Y.Text) + Y.TextLength;
            X.Select(vtbd, Y.TextLength);
            X.Focus();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Trong aaaaaa công công công công công nghiêp hiện nay, nhiều quốc gia trên thế giới đều đầu tư rất mạnh vào lĩnh vực Công Nghệ Thông Tin, cụ thể là Tin học hóa Công việc văn phòng, đẩy mạnh Thương mại điện tử...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimKiem(textBox1, textBox2);
            //textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0 || textBox3.TextLength == 0)
                MessageBox.Show("Mời nhập giá trị!");
            else
                textBox1.Text = textBox1.Text.Replace(textBox2.Text, textBox3.Text);
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 0)
                MessageBox.Show("Mời nhập giá trị cần thay thế!");
            else
                textBox1.Text = textBox3.Text;
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Trong thời đại công nghiêp hiện nay, nhiều quốc gia trên thế giới đều đầu tư rất mạnh vào lĩnh vực Công Nghệ Thông Tin, cụ thể là Tin học hóa Công việc văn phòng, đẩy mạnh Thương mại điện tử...";
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindNext(textBox1, textBox2);
        }
    }
}
