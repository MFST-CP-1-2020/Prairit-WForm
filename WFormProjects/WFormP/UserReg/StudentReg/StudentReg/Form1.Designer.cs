﻿namespace StudentReg
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(166, 53);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(198, 22);
            this.nameBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(44, 419);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(149, 41);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 407);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gender";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "State";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Checked = true;
            this.maleButton.Location = new System.Drawing.Point(166, 133);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(59, 21);
            this.maleButton.TabIndex = 7;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(291, 133);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(75, 21);
            this.femaleButton.TabIndex = 8;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(166, 196);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(198, 22);
            this.numberBox.TabIndex = 10;
            // 
            // countryBox
            // 
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(166, 260);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(198, 24);
            this.countryBox.TabIndex = 11;
            // 
            // stateBox
            // 
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(166, 327);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(198, 24);
            this.stateBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(400, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Registration Form";
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(222, 419);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(142, 40);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 533);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateButton;
    }
}

