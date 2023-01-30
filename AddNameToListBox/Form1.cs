using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNameToListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            if (listBox1.Items.Count == 0)
            {
                button2.Enabled = false;
            }
        }
        Stack<string> stack = new Stack<string>();
        private void button1_Click(object sender, EventArgs e)
        {

            string str1 = textBox1.Text;
            string str2 = null;

            for (int i = 0; i < str1.Length; i++)
            {

                if (Char.IsLetter(str1[i]))
                {

                    str2 += str1[i];
                }

                else if (str1[i] != ' ')
                {

                    stack.Push(str2);
                    str2 = null;
                    str1 = str1.Substring(i);
                    i = 0;
                }

            }
            stack.Push(str2);

            while (stack.Count != 0)
            {
                listBox1.Items.Add(stack.Peek());
                stack.Pop();
            }
            textBox1.Text = null;
            
                button1.Enabled = false;
        
                button2.Enabled = true;
        
        }

        public void RemoveSelectedRow()
        {
            int a = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(a);
            if (listBox1.Items.Count==0)
            {
                button2.Enabled=false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveSelectedRow();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                button1.Enabled = true;
            
        }
    }
}
