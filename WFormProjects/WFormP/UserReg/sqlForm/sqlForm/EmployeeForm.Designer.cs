namespace PAL
{
    partial class EmployeeForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewForSQL = new System.Windows.Forms.DataGridView();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxGender = new System.Windows.Forms.TextBox();
            this.txtBoxEmailID = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(450, 31);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(357, 31);
            this.lblHeading.TabIndex = 43;
            this.lblHeading.Text = "Employee Registration Form";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(241, 562);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(82, 35);
            this.updateButton.TabIndex = 42;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(343, 562);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(89, 35);
            this.loadButton.TabIndex = 41;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(140, 562);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 35);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(28, 562);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 35);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridViewForSQL
            // 
            this.dataGridViewForSQL.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewForSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForSQL.Location = new System.Drawing.Point(456, 85);
            this.dataGridViewForSQL.Name = "dataGridViewForSQL";
            this.dataGridViewForSQL.RowTemplate.Height = 24;
            this.dataGridViewForSQL.Size = new System.Drawing.Size(847, 434);
            this.dataGridViewForSQL.TabIndex = 38;
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(194, 497);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(189, 22);
            this.txtBoxCountry.TabIndex = 37;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(194, 439);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(189, 22);
            this.txtBoxState.TabIndex = 36;
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.Location = new System.Drawing.Point(194, 374);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.Size = new System.Drawing.Size(189, 22);
            this.txtBoxGender.TabIndex = 35;
            // 
            // txtBoxEmailID
            // 
            this.txtBoxEmailID.Location = new System.Drawing.Point(194, 318);
            this.txtBoxEmailID.Name = "txtBoxEmailID";
            this.txtBoxEmailID.Size = new System.Drawing.Size(189, 22);
            this.txtBoxEmailID.TabIndex = 34;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(194, 262);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(189, 22);
            this.txtBoxPhoneNumber.TabIndex = 33;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(194, 204);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(189, 22);
            this.txtBoxLastName.TabIndex = 32;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(194, 144);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(189, 22);
            this.txtBoxFirstName.TabIndex = 31;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(194, 85);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(189, 22);
            this.txtBoxID.TabIndex = 30;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(44, 85);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.lblEmployeeID.TabIndex = 29;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(40, 497);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 28;
            this.lblCountry.Text = "Country";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(41, 439);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 27;
            this.lblState.Text = "State";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(40, 374);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.Location = new System.Drawing.Point(41, 318);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(59, 17);
            this.lblEmailID.TabIndex = 25;
            this.lblEmailID.Text = "Email ID";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(41, 262);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 24;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(41, 204);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(41, 144);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 634);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridViewForSQL);
            this.Controls.Add(this.txtBoxCountry);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.txtBoxGender);
            this.Controls.Add(this.txtBoxEmailID);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmailID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridViewForSQL;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxGender;
        private System.Windows.Forms.TextBox txtBoxEmailID;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}