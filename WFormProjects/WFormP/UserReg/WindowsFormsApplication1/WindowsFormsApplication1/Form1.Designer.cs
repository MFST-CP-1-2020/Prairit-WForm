namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.stateBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(171, 81);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(167, 22);
            this.fnameBox.TabIndex = 3;
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(171, 148);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(167, 22);
            this.lnameBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(451, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 429);
            this.dataGridView1.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(48, 540);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(290, 39);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(171, 217);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(59, 21);
            this.maleButton.TabIndex = 8;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(171, 265);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(75, 21);
            this.femaleButton.TabIndex = 9;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Country";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(171, 324);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(167, 22);
            this.numberBox.TabIndex = 14;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(171, 384);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(167, 22);
            this.emailBox.TabIndex = 15;
            // 
            // countryBox
            // 
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(171, 446);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(167, 24);
            this.countryBox.TabIndex = 16;
            this.countryBox.DropDownClosed += new System.EventHandler(this.countryBox_DropDownClosed);
            // 
            // stateBox
            // 
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(171, 498);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(167, 24);
            this.stateBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 604);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.ComboBox stateBox;
    }
}

