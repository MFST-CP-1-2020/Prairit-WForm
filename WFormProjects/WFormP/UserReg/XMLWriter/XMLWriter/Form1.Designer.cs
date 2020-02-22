namespace XMLWriter
{
    partial class Form1
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
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(152, 80);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(166, 22);
            this.fnameBox.TabIndex = 0;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(152, 466);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(166, 22);
            this.countryBox.TabIndex = 1;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(152, 411);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(166, 22);
            this.stateBox.TabIndex = 2;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(152, 345);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(166, 22);
            this.numberBox.TabIndex = 3;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(152, 272);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(166, 22);
            this.emailBox.TabIndex = 4;
            // 
            // genderBox
            // 
            this.genderBox.Location = new System.Drawing.Point(152, 203);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(166, 22);
            this.genderBox.TabIndex = 5;
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(152, 144);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(166, 22);
            this.lnameBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(383, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "XML Reader/Writer";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(32, 515);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(286, 31);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 402);
            this.dataGridView1.TabIndex = 16;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(388, 74);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(679, 35);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 558);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.fnameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadButton;
    }
}

