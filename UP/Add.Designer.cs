
namespace UP
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.ServiceTitleTB = new System.Windows.Forms.TextBox();
            this.ServiceCostTB = new System.Windows.Forms.TextBox();
            this.ServiceDurationTB = new System.Windows.Forms.TextBox();
            this.ServiceDescriptionTB = new System.Windows.Forms.TextBox();
            this.ServiceDiscountTB = new System.Windows.Forms.TextBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBD_18UPDataSet = new UP.ABD_18UPDataSet();
            this.serviceTableAdapter = new UP.ABD_18UPDataSetTableAdapters.ServiceTableAdapter();
            this.Add2 = new System.Windows.Forms.Button();
            this.Cancel2 = new System.Windows.Forms.Button();
            this.PathCB = new System.Windows.Forms.TextBox();
            this.TitleLB = new System.Windows.Forms.Label();
            this.CostLB = new System.Windows.Forms.Label();
            this.DurLB = new System.Windows.Forms.Label();
            this.DescriptionLB = new System.Windows.Forms.Label();
            this.DiscountLB = new System.Windows.Forms.Label();
            this.PathLB = new System.Windows.Forms.Label();
            this.BirthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.RegDTP = new System.Windows.Forms.DateTimePicker();
            this.BirthLB = new System.Windows.Forms.Label();
            this.RegDateLB = new System.Windows.Forms.Label();
            this.GenderLB = new System.Windows.Forms.Label();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new UP.ABD_18UPDataSetTableAdapters.GenderTableAdapter();
            this.ClientIDCB = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServiceIDCB = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new UP.ABD_18UPDataSetTableAdapters.ClientTableAdapter();
            this.StartTimeDTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBD_18UPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceTitleTB
            // 
            this.ServiceTitleTB.Location = new System.Drawing.Point(88, 12);
            this.ServiceTitleTB.Name = "ServiceTitleTB";
            this.ServiceTitleTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceTitleTB.TabIndex = 0;
            // 
            // ServiceCostTB
            // 
            this.ServiceCostTB.Location = new System.Drawing.Point(88, 38);
            this.ServiceCostTB.Name = "ServiceCostTB";
            this.ServiceCostTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceCostTB.TabIndex = 1;
            // 
            // ServiceDurationTB
            // 
            this.ServiceDurationTB.Location = new System.Drawing.Point(88, 64);
            this.ServiceDurationTB.Name = "ServiceDurationTB";
            this.ServiceDurationTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDurationTB.TabIndex = 2;
            // 
            // ServiceDescriptionTB
            // 
            this.ServiceDescriptionTB.Location = new System.Drawing.Point(88, 90);
            this.ServiceDescriptionTB.Name = "ServiceDescriptionTB";
            this.ServiceDescriptionTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDescriptionTB.TabIndex = 3;
            // 
            // ServiceDiscountTB
            // 
            this.ServiceDiscountTB.Location = new System.Drawing.Point(88, 116);
            this.ServiceDiscountTB.Name = "ServiceDiscountTB";
            this.ServiceDiscountTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDiscountTB.TabIndex = 4;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.aBD_18UPDataSet;
            // 
            // aBD_18UPDataSet
            // 
            this.aBD_18UPDataSet.DataSetName = "ABD_18UPDataSet";
            this.aBD_18UPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // Add2
            // 
            this.Add2.Location = new System.Drawing.Point(12, 176);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(75, 23);
            this.Add2.TabIndex = 6;
            this.Add2.Text = "Add";
            this.Add2.UseVisualStyleBackColor = true;
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // Cancel2
            // 
            this.Cancel2.Location = new System.Drawing.Point(147, 176);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(75, 23);
            this.Cancel2.TabIndex = 7;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = true;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // PathCB
            // 
            this.PathCB.Location = new System.Drawing.Point(88, 143);
            this.PathCB.Name = "PathCB";
            this.PathCB.Size = new System.Drawing.Size(121, 20);
            this.PathCB.TabIndex = 15;
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Location = new System.Drawing.Point(55, 15);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(27, 13);
            this.TitleLB.TabIndex = 16;
            this.TitleLB.Text = "Title";
            // 
            // CostLB
            // 
            this.CostLB.AutoSize = true;
            this.CostLB.Location = new System.Drawing.Point(55, 41);
            this.CostLB.Name = "CostLB";
            this.CostLB.Size = new System.Drawing.Size(28, 13);
            this.CostLB.TabIndex = 17;
            this.CostLB.Text = "Cost";
            // 
            // DurLB
            // 
            this.DurLB.AutoSize = true;
            this.DurLB.Location = new System.Drawing.Point(36, 67);
            this.DurLB.Name = "DurLB";
            this.DurLB.Size = new System.Drawing.Size(47, 13);
            this.DurLB.TabIndex = 18;
            this.DurLB.Text = "Duration";
            // 
            // DescriptionLB
            // 
            this.DescriptionLB.AutoSize = true;
            this.DescriptionLB.Location = new System.Drawing.Point(22, 93);
            this.DescriptionLB.Name = "DescriptionLB";
            this.DescriptionLB.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLB.TabIndex = 19;
            this.DescriptionLB.Text = "Description";
            // 
            // DiscountLB
            // 
            this.DiscountLB.AutoSize = true;
            this.DiscountLB.Location = new System.Drawing.Point(33, 119);
            this.DiscountLB.Name = "DiscountLB";
            this.DiscountLB.Size = new System.Drawing.Size(49, 13);
            this.DiscountLB.TabIndex = 20;
            this.DiscountLB.Text = "Discount";
            // 
            // PathLB
            // 
            this.PathLB.AutoSize = true;
            this.PathLB.Location = new System.Drawing.Point(53, 146);
            this.PathLB.Name = "PathLB";
            this.PathLB.Size = new System.Drawing.Size(29, 13);
            this.PathLB.TabIndex = 21;
            this.PathLB.Text = "Path";
            // 
            // BirthdayDTP
            // 
            this.BirthdayDTP.Location = new System.Drawing.Point(240, 64);
            this.BirthdayDTP.Name = "BirthdayDTP";
            this.BirthdayDTP.Size = new System.Drawing.Size(200, 20);
            this.BirthdayDTP.TabIndex = 22;
            // 
            // RegDTP
            // 
            this.RegDTP.Location = new System.Drawing.Point(240, 116);
            this.RegDTP.Name = "RegDTP";
            this.RegDTP.Size = new System.Drawing.Size(200, 20);
            this.RegDTP.TabIndex = 23;
            // 
            // BirthLB
            // 
            this.BirthLB.AutoSize = true;
            this.BirthLB.Location = new System.Drawing.Point(321, 41);
            this.BirthLB.Name = "BirthLB";
            this.BirthLB.Size = new System.Drawing.Size(45, 13);
            this.BirthLB.TabIndex = 24;
            this.BirthLB.Text = "Birthday";
            // 
            // RegDateLB
            // 
            this.RegDateLB.AutoSize = true;
            this.RegDateLB.Location = new System.Drawing.Point(294, 93);
            this.RegDateLB.Name = "RegDateLB";
            this.RegDateLB.Size = new System.Drawing.Size(89, 13);
            this.RegDateLB.TabIndex = 25;
            this.RegDateLB.Text = "Registration Date";
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Location = new System.Drawing.Point(253, 15);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(42, 13);
            this.GenderLB.TabIndex = 27;
            this.GenderLB.Text = "Gender";
            // 
            // GenderCB
            // 
            this.GenderCB.DataSource = this.genderBindingSource;
            this.GenderCB.DisplayMember = "Name";
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Location = new System.Drawing.Point(301, 12);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(121, 21);
            this.GenderCB.TabIndex = 28;
            this.GenderCB.ValueMember = "Code";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.aBD_18UPDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // ClientIDCB
            // 
            this.ClientIDCB.DataSource = this.clientBindingSource;
            this.ClientIDCB.DisplayMember = "FirstName";
            this.ClientIDCB.FormattingEnabled = true;
            this.ClientIDCB.Location = new System.Drawing.Point(88, 11);
            this.ClientIDCB.Name = "ClientIDCB";
            this.ClientIDCB.Size = new System.Drawing.Size(121, 21);
            this.ClientIDCB.TabIndex = 29;
            this.ClientIDCB.ValueMember = "ID";
            this.ClientIDCB.Visible = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.aBD_18UPDataSet;
            // 
            // ServiceIDCB
            // 
            this.ServiceIDCB.DataSource = this.serviceBindingSource1;
            this.ServiceIDCB.DisplayMember = "Title";
            this.ServiceIDCB.FormattingEnabled = true;
            this.ServiceIDCB.Location = new System.Drawing.Point(88, 38);
            this.ServiceIDCB.Name = "ServiceIDCB";
            this.ServiceIDCB.Size = new System.Drawing.Size(121, 21);
            this.ServiceIDCB.TabIndex = 30;
            this.ServiceIDCB.ValueMember = "ID";
            this.ServiceIDCB.Visible = false;
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.aBD_18UPDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // StartTimeDTP
            // 
            this.StartTimeDTP.Location = new System.Drawing.Point(88, 64);
            this.StartTimeDTP.Name = "StartTimeDTP";
            this.StartTimeDTP.Size = new System.Drawing.Size(121, 20);
            this.StartTimeDTP.TabIndex = 31;
            this.StartTimeDTP.Visible = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 212);
            this.Controls.Add(this.StartTimeDTP);
            this.Controls.Add(this.ServiceIDCB);
            this.Controls.Add(this.ClientIDCB);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.GenderLB);
            this.Controls.Add(this.RegDateLB);
            this.Controls.Add(this.BirthLB);
            this.Controls.Add(this.RegDTP);
            this.Controls.Add(this.BirthdayDTP);
            this.Controls.Add(this.PathLB);
            this.Controls.Add(this.DiscountLB);
            this.Controls.Add(this.DescriptionLB);
            this.Controls.Add(this.DurLB);
            this.Controls.Add(this.CostLB);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.PathCB);
            this.Controls.Add(this.Cancel2);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.ServiceDiscountTB);
            this.Controls.Add(this.ServiceDescriptionTB);
            this.Controls.Add(this.ServiceDurationTB);
            this.Controls.Add(this.ServiceCostTB);
            this.Controls.Add(this.ServiceTitleTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBD_18UPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ServiceTitleTB;
        public System.Windows.Forms.TextBox ServiceCostTB;
        public System.Windows.Forms.TextBox ServiceDurationTB;
        public System.Windows.Forms.TextBox ServiceDescriptionTB;
        public System.Windows.Forms.TextBox ServiceDiscountTB;
        private ABD_18UPDataSet aBD_18UPDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private ABD_18UPDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Button Add2;
        private System.Windows.Forms.Button Cancel2;
        public System.Windows.Forms.TextBox PathCB;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.Label CostLB;
        private System.Windows.Forms.Label DurLB;
        private System.Windows.Forms.Label DescriptionLB;
        private System.Windows.Forms.Label DiscountLB;
        private System.Windows.Forms.Label PathLB;
        private System.Windows.Forms.DateTimePicker BirthdayDTP;
        private System.Windows.Forms.DateTimePicker RegDTP;
        private System.Windows.Forms.Label BirthLB;
        private System.Windows.Forms.Label RegDateLB;
        private System.Windows.Forms.Label GenderLB;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private ABD_18UPDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.ComboBox ClientIDCB;
        private System.Windows.Forms.ComboBox ServiceIDCB;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ABD_18UPDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private System.Windows.Forms.DateTimePicker StartTimeDTP;
    }
}