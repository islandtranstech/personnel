namespace PersonnelApplication
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add an Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Record Type";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 816);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Types",
            "People"});
            this.comboBox1.Location = new System.Drawing.Point(194, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Load Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 31);
            this.textBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(742, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(68, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 1048);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1292, 1010);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1292, 1010);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1292, 1010);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1524, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "Manage Permits";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1743);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ApplicationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button4;
    }
}

