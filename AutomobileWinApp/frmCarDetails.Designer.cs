namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarID = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            lbCarName = new Label();
            lbManufacturer = new Label();
            cboManufacturer = new ComboBox();
            lbPrice = new Label();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            lbReleaseYear = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(30, 28);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            txtCarID.BorderStyle = BorderStyle.FixedSingle;
            txtCarID.Location = new Point(134, 25);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(209, 27);
            txtCarID.TabIndex = 1;
            // 
            // txtCarName
            // 
            txtCarName.BorderStyle = BorderStyle.FixedSingle;
            txtCarName.Location = new Point(134, 67);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(209, 27);
            txtCarName.TabIndex = 3;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(30, 70);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(30, 112);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 4;
            lbManufacturer.Text = "Manufacturer";
            // 
            // cboManufacturer
            // 
            cboManufacturer.BackColor = SystemColors.ScrollBar;
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "KIA", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(134, 109);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(210, 28);
            cboManufacturer.TabIndex = 5;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(30, 152);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(134, 150);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0_________";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BorderStyle = BorderStyle.FixedSingle;
            txtReleaseYear.Location = new Point(134, 186);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(209, 27);
            txtReleaseYear.TabIndex = 9;
            txtReleaseYear.Text = "0_________";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(30, 188);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(92, 20);
            lbReleaseYear.TabIndex = 8;
            lbReleaseYear.Text = "Release Year";
            // 
            // btnSave
            // 
            btnSave.AccessibleRole = AccessibleRole.None;
            btnSave.BackColor = SystemColors.ScrollBar;
            btnSave.Location = new Point(134, 232);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 33);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ScrollBar;
            btnCancel.Location = new Point(252, 232);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 33);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 277);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(cboManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarName;
        private Label lbCarID;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Label lbManufacturer;
        private ComboBox cboManufacturer;
        private Label lbPrice;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Label lbReleaseYear;
        private Button btnSave;
        private Button btnCancel;
    }
}