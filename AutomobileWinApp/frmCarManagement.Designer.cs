namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            txtCarId = new TextBox();
            txtCarName = new TextBox();
            lbCarName = new Label();
            lbManufacturer = new Label();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            lbPrice = new Label();
            txtReleaseYear = new TextBox();
            lbReleaseYear = new Label();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Segoe UI", 9F);
            lbCarID.Location = new Point(31, 46);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 2;
            lbCarID.Text = "Car ID";
            // 
            // txtCarId
            // 
            txtCarId.BorderStyle = BorderStyle.FixedSingle;
            txtCarId.Font = new Font("Segoe UI", 9F);
            txtCarId.Location = new Point(155, 46);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(214, 27);
            txtCarId.TabIndex = 8;
            // 
            // txtCarName
            // 
            txtCarName.BorderStyle = BorderStyle.FixedSingle;
            txtCarName.Font = new Font("Segoe UI", 9F);
            txtCarName.Location = new Point(155, 91);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(214, 27);
            txtCarName.TabIndex = 10;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 9F);
            lbCarName.Location = new Point(31, 93);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 9;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Segoe UI", 9F);
            lbManufacturer.Location = new Point(31, 134);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 11;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.BorderStyle = BorderStyle.FixedSingle;
            txtManufacturer.Font = new Font("Segoe UI", 9F);
            txtManufacturer.Location = new Point(155, 134);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(214, 27);
            txtManufacturer.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 9F);
            txtPrice.Location = new Point(554, 46);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 14;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 9F);
            lbPrice.Location = new Point(450, 48);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 13;
            lbPrice.Text = "Price";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BorderStyle = BorderStyle.FixedSingle;
            txtReleaseYear.Font = new Font("Segoe UI", 9F);
            txtReleaseYear.Location = new Point(554, 91);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(209, 27);
            txtReleaseYear.TabIndex = 16;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 9F);
            lbReleaseYear.Location = new Point(450, 93);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(92, 20);
            lbReleaseYear.TabIndex = 15;
            lbReleaseYear.Text = "Release Year";
            // 
            // btnLoad
            // 
            btnLoad.AccessibleRole = AccessibleRole.None;
            btnLoad.BackColor = SystemColors.ScrollBar;
            btnLoad.BackgroundImageLayout = ImageLayout.None;
            btnLoad.Location = new Point(155, 174);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(108, 33);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.AccessibleRole = AccessibleRole.None;
            btnNew.BackColor = SystemColors.ScrollBar;
            btnNew.BackgroundImageLayout = ImageLayout.None;
            btnNew.Location = new Point(340, 174);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(108, 33);
            btnNew.TabIndex = 18;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.AccessibleRole = AccessibleRole.None;
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Location = new Point(569, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 33);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(31, 213);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.Size = new Size(732, 151);
            dgvCarList.TabIndex = 20;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ScrollBar;
            btnCancel.Location = new Point(340, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 33);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 403);
            Controls.Add(btnCancel);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(txtCarId);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCarID;
        private TextBox txtCarId;
        private TextBox txtCarName;
        private Label lbCarName;
        private Label lbManufacturer;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private Label lbPrice;
        private TextBox txtReleaseYear;
        private Label lbReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnCancel;
    }
}