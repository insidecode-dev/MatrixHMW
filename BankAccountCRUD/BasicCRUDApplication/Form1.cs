using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BasicCRUDApplication
{
    public partial class Form1 : Form
    {
        
        ConnectionHelper connectionHelper = new ConnectionHelper();
        DataTable dataTable= new DataTable();   
        public Form1()
        {
            InitializeComponent();
        } 
        
        private void Form1_Load(object sender, EventArgs e)
        {
             
            if (!this.connectionHelper.Connect())
            {
                MessageBox.Show("Configure your connection and try again", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadGridData();
            dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            
                
        }

        private void LoadGridData()
        {            
            using (SqlCommand cmd = new SqlCommand("select * from dbo.Person", this.connectionHelper.Con))
            {
                this.connectionHelper.DtRd = cmd.ExecuteReader();
                this.dataTable.Clear();
                this.dataTable.Load(this.connectionHelper.DtRd);
                dataGridView1.DataSource = this.dataTable;                
            }          
        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            Person person = this.GetPerson();
            bool stat = person.AddPerson(this.connectionHelper);
            if (stat)
            {
                using (SqlCommand cmd = new SqlCommand("select * from dbo.Person", this.connectionHelper.Con))
                {
                    this.connectionHelper.DtRd = cmd.ExecuteReader();
                    this.dataTable.Clear();
                    this.dataTable.Load(this.connectionHelper.DtRd);
                    dataGridView1.DataSource = this.dataTable;
                }
            }
            else
            {
                MessageBox.Show("Configure your connection and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_update_Click(object sender, EventArgs e)
        {
            if (textBox1_name.ToString().Trim().Length!=0 || textBox2_surName.ToString().Trim().Length != 0 || textBox3_SourceBalance.ToString().Trim().Length != 0)
            {
               Person person= this.GetPerson(); 
                bool stat = person.UpdatePerson(this.connectionHelper, ID);
                if (stat)
                {
                    using (SqlCommand cmd = new SqlCommand("select * from dbo.Person", this.connectionHelper.Con))
                    {
                        this.connectionHelper.DtRd = cmd.ExecuteReader();
                        this.dataTable.Clear();
                        this.dataTable.Load(this.connectionHelper.DtRd);
                        dataGridView1.DataSource = this.dataTable;
                    }
                }
                else
                {
                    MessageBox.Show("Configure your connection and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_delete_Click(object sender, EventArgs e)
        {
            Person person = this.GetPerson();
            bool stat = person.DeletePerson(this.connectionHelper, ID);
            if (stat)
            {
                using (SqlCommand cmd = new SqlCommand("select * from dbo.Person", this.connectionHelper.Con))
                {
                    this.connectionHelper.DtRd = cmd.ExecuteReader();
                    this.dataTable.Clear();
                    this.dataTable.Load(this.connectionHelper.DtRd);
                    dataGridView1.DataSource = this.dataTable;
                }
            }
            else
            {
                MessageBox.Show("Configure your connection and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Person GetPerson()
        {
            return new Person(textBox1_name.Text.Trim(), textBox2_surName.Text.Trim(),
                textBox3_SourceBalance.Text.Trim());
        }



        int selectedIndex;
        int ID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
             
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedIndex = dataGridView1.SelectedRows[0].Index;
            }
            try
            {
                ID = Convert.ToInt32(dataTable.Rows[selectedIndex][0].ToString());
                textBox1_name.Text = dataTable.Rows[selectedIndex][1].ToString();
                textBox2_surName.Text = dataTable.Rows[selectedIndex][2].ToString();
                textBox3_SourceBalance.Text = dataTable.Rows[selectedIndex][3].ToString();
            }
            catch (Exception)
            { }                          
        }


        //private void Dynamically()
        //{
        //    int selectedIndex = 3;
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        selectedIndex = dataGridView1.SelectedRows[0].Index;
        //    }

        //}

    }
}
