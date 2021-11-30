
namespace UP
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.ServiceDiscountTB = new System.Windows.Forms.TextBox();
            this.ServiceDescriptionTB = new System.Windows.Forms.TextBox();
            this.ServiceDurationTB = new System.Windows.Forms.TextBox();
            this.ServiceCostTB = new System.Windows.Forms.TextBox();
            this.ServiceTitleTB = new System.Windows.Forms.TextBox();
            this.aBD_18UPDataSet = new UP.ABD_18UPDataSet();
            this.Cancel2 = new System.Windows.Forms.Button();
            this.Edit2 = new System.Windows.Forms.Button();
            this.servicePhotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicePhotoTableAdapter = new UP.ABD_18UPDataSetTableAdapters.ServicePhotoTableAdapter();
            this.PathCB = new System.Windows.Forms.TextBox();
            this.PathLB = new System.Windows.Forms.Label();
            this.DiscountLB = new System.Windows.Forms.Label();
            this.DescriptionLB = new System.Windows.Forms.Label();
            this.DurLB = new System.Windows.Forms.Label();
            this.CostLB = new System.Windows.Forms.Label();
            this.TitleLB = new System.Windows.Forms.Label();
            this.StartTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.ServiceIDCB = new System.Windows.Forms.ComboBox();
            this.ClientIDCB = new System.Windows.Forms.ComboBox();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.GenderLB = new System.Windows.Forms.Label();
            this.RegDateLB = new System.Windows.Forms.Label();
            this.BirthLB = new System.Windows.Forms.Label();
            this.RegDTP = new System.Windows.Forms.DateTimePicker();
            this.BirthdayDTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.aBD_18UPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePhotoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceDiscountTB
            // 
            this.ServiceDiscountTB.Location = new System.Drawing.Point(88, 115);
            this.ServiceDiscountTB.Name = "ServiceDiscountTB";
            this.ServiceDiscountTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDiscountTB.TabIndex = 10;
            // 
            // ServiceDescriptionTB
            // 
            this.ServiceDescriptionTB.Location = new System.Drawing.Point(88, 89);
            this.ServiceDescriptionTB.Name = "ServiceDescriptionTB";
            this.ServiceDescriptionTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDescriptionTB.TabIndex = 9;
            // 
            // ServiceDurationTB
            // 
            this.ServiceDurationTB.Location = new System.Drawing.Point(88, 63);
            this.ServiceDurationTB.Name = "ServiceDurationTB";
            this.ServiceDurationTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDurationTB.TabIndex = 8;
            // 
            // ServiceCostTB
            // 
            this.ServiceCostTB.Location = new System.Drawing.Point(88, 37);
            this.ServiceCostTB.Name = "ServiceCostTB";
            this.ServiceCostTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceCostTB.TabIndex = 7;
            // 
            // ServiceTitleTB
            // 
            this.ServiceTitleTB.Location = new System.Drawing.Point(88, 11);
            this.ServiceTitleTB.Name = "ServiceTitleTB";
            this.ServiceTitleTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceTitleTB.TabIndex = 6;
            // 
            // aBD_18UPDataSet
            // 
            this.aBD_18UPDataSet.DataSetName = "ABD_18UPDataSet";
            this.aBD_18UPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cancel2
            // 
            this.Cancel2.Location = new System.Drawing.Point(147, 179);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(75, 23);
            this.Cancel2.TabIndex = 13;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = true;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // Edit2
            // 
            this.Edit2.Location = new System.Drawing.Point(10, 179);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new System.Drawing.Size(75, 23);
            this.Edit2.TabIndex = 12;
            this.Edit2.Text = "Edit";
            this.Edit2.UseVisualStyleBackColor = true;
            this.Edit2.Click += new System.EventHandler(this.Edit2_Click);
            // 
            // servicePhotoBindingSource
            // 
            this.servicePhotoBindingSource.DataMember = "ServicePhoto";
            this.servicePhotoBindingSource.DataSource = this.aBD_18UPDataSet;
            // 
            // servicePhotoTableAdapter
            // 
            this.servicePhotoTableAdapter.ClearBeforeFill = true;
            // 
            // PathCB
            // 
            this.PathCB.Location = new System.Drawing.Point(88, 141);
            this.PathCB.Name = "PathCB";
            this.PathCB.Size = new System.Drawing.Size(121, 20);
            this.PathCB.TabIndex = 14;
            // 
            // PathLB
            // 
            this.PathLB.AutoSize = true;
            this.PathLB.Location = new System.Drawing.Point(53, 145);
            this.PathLB.Name = "PathLB";
            this.PathLB.Size = new System.Drawing.Size(29, 13);
            this.PathLB.TabIndex = 27;
            this.PathLB.Text = "Path";
            // 
            // DiscountLB
            // 
            this.DiscountLB.AutoSize = true;
            this.DiscountLB.Location = new System.Drawing.Point(33, 118);
            this.DiscountLB.Name = "DiscountLB";
            this.DiscountLB.Size = new System.Drawing.Size(49, 13);
            this.DiscountLB.TabIndex = 26;
            this.DiscountLB.Text = "Discount";
            // 
            // DescriptionLB
            // 
            this.DescriptionLB.AutoSize = true;
            this.DescriptionLB.Location = new System.Drawing.Point(22, 92);
            this.DescriptionLB.Name = "DescriptionLB";
            this.DescriptionLB.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLB.TabIndex = 25;
            this.DescriptionLB.Text = "Description";
            // 
            // DurLB
            // 
            this.DurLB.AutoSize = true;
            this.DurLB.Location = new System.Drawing.Point(36, 66);
            this.DurLB.Name = "DurLB";
            this.DurLB.Size = new System.Drawing.Size(47, 13);
            this.DurLB.TabIndex = 24;
            this.DurLB.Text = "Duration";
            // 
            // CostLB
            // 
            this.CostLB.AutoSize = true;
            this.CostLB.Location = new System.Drawing.Point(55, 40);
            this.CostLB.Name = "CostLB";
            this.CostLB.Size = new System.Drawing.Size(28, 13);
            this.CostLB.TabIndex = 23;
            this.CostLB.Text = "Cost";
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Location = new System.Drawing.Point(58, 14);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(27, 13);
            this.TitleLB.TabIndex = 22;
            this.TitleLB.Text = "Title";
            // 
            // StartTimeDTP
            // 
            this.StartTimeDTP.Location = new System.Drawing.Point(88, 64);
            this.StartTimeDTP.Name = "StartTimeDTP";
            this.StartTimeDTP.Size = new System.Drawing.Size(121, 20);
            this.StartTimeDTP.TabIndex = 34;
            this.StartTimeDTP.Visible = false;
            // 
            // ServiceIDCB
            // 
            this.ServiceIDCB.DisplayMember = "Title";
            this.ServiceIDCB.FormattingEnabled = true;
            this.ServiceIDCB.Location = new System.Drawing.Point(88, 38);
            this.ServiceIDCB.Name = "ServiceIDCB";
            this.ServiceIDCB.Size = new System.Drawing.Size(121, 21);
            this.ServiceIDCB.TabIndex = 33;
            this.ServiceIDCB.ValueMember = "ID";
            this.ServiceIDCB.Visible = false;
            // 
            // ClientIDCB
            // 
            this.ClientIDCB.DisplayMember = "FirstName";
            this.ClientIDCB.FormattingEnabled = true;
            this.ClientIDCB.Location = new System.Drawing.Point(88, 11);
            this.ClientIDCB.Name = "ClientIDCB";
            this.ClientIDCB.Size = new System.Drawing.Size(121, 21);
            this.ClientIDCB.TabIndex = 32;
            this.ClientIDCB.ValueMember = "ID";
            this.ClientIDCB.Visible = false;
            // 
            // GenderCB
            // 
            this.GenderCB.DisplayMember = "Name";
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Location = new System.Drawing.Point(308, 12);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(121, 21);
            this.GenderCB.TabIndex = 40;
            this.GenderCB.ValueMember = "Code";
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Location = new System.Drawing.Point(260, 15);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(42, 13);
            this.GenderLB.TabIndex = 39;
            this.GenderLB.Text = "Gender";
            // 
            // RegDateLB
            // 
            this.RegDateLB.AutoSize = true;
            this.RegDateLB.Location = new System.Drawing.Point(301, 93);
            this.RegDateLB.Name = "RegDateLB";
            this.RegDateLB.Size = new System.Drawing.Size(89, 13);
            this.RegDateLB.TabIndex = 38;
            this.RegDateLB.Text = "Registration Date";
            // 
            // BirthLB
            // 
            this.BirthLB.AutoSize = true;
            this.BirthLB.Location = new System.Drawing.Point(328, 41);
            this.BirthLB.Name = "BirthLB";
            this.BirthLB.Size = new System.Drawing.Size(45, 13);
            this.BirthLB.TabIndex = 37;
            this.BirthLB.Text = "Birthday";
            // 
            // RegDTP
            // 
            this.RegDTP.Location = new System.Drawing.Point(247, 116);
            this.RegDTP.Name = "RegDTP";
            this.RegDTP.Size = new System.Drawing.Size(200, 20);
            this.RegDTP.TabIndex = 36;
            // 
            // BirthdayDTP
            // 
            this.BirthdayDTP.Location = new System.Drawing.Point(247, 64);
            this.BirthdayDTP.Name = "BirthdayDTP";
            this.BirthdayDTP.Size = new System.Drawing.Size(200, 20);
            this.BirthdayDTP.TabIndex = 35;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.GenderLB);
            this.Controls.Add(this.RegDateLB);
            this.Controls.Add(this.BirthLB);
            this.Controls.Add(this.RegDTP);
            this.Controls.Add(this.BirthdayDTP);
            this.Controls.Add(this.StartTimeDTP);
            this.Controls.Add(this.ServiceIDCB);
            this.Controls.Add(this.ClientIDCB);
            this.Controls.Add(this.PathLB);
            this.Controls.Add(this.DiscountLB);
            this.Controls.Add(this.DescriptionLB);
            this.Controls.Add(this.DurLB);
            this.Controls.Add(this.CostLB);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.PathCB);
            this.Controls.Add(this.Cancel2);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.ServiceDiscountTB);
            this.Controls.Add(this.ServiceDescriptionTB);
            this.Controls.Add(this.ServiceDurationTB);
            this.Controls.Add(this.ServiceCostTB);
            this.Controls.Add(this.ServiceTitleTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aBD_18UPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePhotoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox ServiceDiscountTB;
        public System.Windows.Forms.TextBox ServiceDescriptionTB;
        public System.Windows.Forms.TextBox ServiceDurationTB;
        public System.Windows.Forms.TextBox ServiceCostTB;
        public System.Windows.Forms.TextBox ServiceTitleTB;
        private ABD_18UPDataSet aBD_18UPDataSet;
        private System.Windows.Forms.Button Cancel2;
        private System.Windows.Forms.Button Edit2;
        private System.Windows.Forms.BindingSource servicePhotoBindingSource;
        private ABD_18UPDataSetTableAdapters.ServicePhotoTableAdapter servicePhotoTableAdapter;
        public System.Windows.Forms.TextBox PathCB;
        private System.Windows.Forms.Label PathLB;
        private System.Windows.Forms.Label DiscountLB;
        private System.Windows.Forms.Label DescriptionLB;
        private System.Windows.Forms.Label DurLB;
        private System.Windows.Forms.Label CostLB;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.DateTimePicker StartTimeDTP;
        private System.Windows.Forms.ComboBox ServiceIDCB;
        private System.Windows.Forms.ComboBox ClientIDCB;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.Label GenderLB;
        private System.Windows.Forms.Label RegDateLB;
        private System.Windows.Forms.Label BirthLB;
        private System.Windows.Forms.DateTimePicker RegDTP;
        private System.Windows.Forms.DateTimePicker BirthdayDTP;
    }
}