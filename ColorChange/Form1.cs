using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Size buttonSize = new Size(90, 40);
            int x = 50, y = 100;
                
            int z = 0;
            for (int k = 0; k < 9; k++)
            {
                Button button = new Button();
                button.Text = " ";
                button.Location = new Point(x, y);
                button.Size = buttonSize;
                button.BackColor = ColorChange.colos[z];
                button.Click += new EventHandler(button_Click);
                this.Controls.Add(button);
                x += buttonSize.Width + 10;
                if (x>1200)
                {
                    x = 50;
                }
                z++;                
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.BackColor = btn.BackColor;
        }
      

    }
}