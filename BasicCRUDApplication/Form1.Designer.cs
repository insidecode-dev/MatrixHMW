namespace BasicCRUDApplication
{
    partial class Form1
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
            this.button1_add = new System.Windows.Forms.Button();
            this.button2_update = new System.Windows.Forms.Button();
            this.button4_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.textBox2_surName = new System.Windows.Forms.TextBox();
            this.textBox3_SourceBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_add
            // 
            this.button1_add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1_add.Location = new System.Drawing.Point(242, 276);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(118, 49);
            this.button1_add.TabIndex = 0;
            this.button1_add.Text = "add";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // button2_update
            // 
            this.button2_update.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2_update.Location = new System.Drawing.Point(477, 271);
            this.button2_update.Name = "button2_update";
            this.button2_update.Size = new System.Drawing.Size(118, 49);
            this.button2_update.TabIndex = 1;
            this.button2_update.Text = "update";
            this.button2_update.UseVisualStyleBackColor = true;
            this.button2_update.Click += new System.EventHandler(this.button2_update_Click);
            // 
            // button4_delete
            // 
            this.button4_delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4_delete.Location = new System.Drawing.Point(743, 276);
            this.button4_delete.Name = "button4_delete";
            this.button4_delete.Size = new System.Drawing.Size(118, 49);
            this.button4_delete.TabIndex = 3;
            this.button4_delete.Text = "delete";
            this.button4_delete.UseVisualStyleBackColor = true;
            this.button4_delete.Click += new System.EventHandler(this.button4_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 245);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // textBox1_name
            // 
            this.textBox1_name.Location = new System.Drawing.Point(416, 83);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(264, 23);
            this.textBox1_name.TabIndex = 5;
            // 
            // textBox2_surName
            // 
            this.textBox2_surName.Location = new System.Drawing.Point(416, 130);
            this.textBox2_surName.Name = "textBox2_surName";
            this.textBox2_surName.Size = new System.Drawing.Size(264, 23);
            this.textBox2_surName.TabIndex = 6;
            // 
            // textBox3_SourceBalance
            // 
            this.textBox3_SourceBalance.Location = new System.Drawing.Point(416, 184);
            this.textBox3_SourceBalance.Name = "textBox3_SourceBalance";
            this.textBox3_SourceBalance.Size = new System.Drawing.Size(264, 23);
            this.textBox3_SourceBalance.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(305, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "name      :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(305, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "surname :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(305, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "balans    :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3_SourceBalance);
            this.Controls.Add(this.textBox2_surName);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4_delete);
            this.Controls.Add(this.button2_update);
            this.Controls.Add(this.button1_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.Button button2_update;
        private System.Windows.Forms.Button button4_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1_name;
        private System.Windows.Forms.TextBox textBox2_surName;
        private System.Windows.Forms.TextBox textBox3_SourceBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
