
namespace UP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.режимыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.TableGV = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.SearchLB = new System.Windows.Forms.Label();
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.FilterLB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимыToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // режимыToolStripMenuItem
            // 
            this.режимыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.администраторToolStripMenuItem});
            this.режимыToolStripMenuItem.Name = "режимыToolStripMenuItem";
            this.режимыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.режимыToolStripMenuItem.Text = "Режимы";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обычныйToolStripMenuItem.Text = "Пользователь";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.администраторToolStripMenuItem.Text = "Администратор";
            this.администраторToolStripMenuItem.Click += new System.EventHandler(this.администраторToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.записиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.клиентToolStripMenuItem.Text = "Клиент";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.клиентToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // записиToolStripMenuItem
            // 
            this.записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            this.записиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.записиToolStripMenuItem.Text = "Записи";
            this.записиToolStripMenuItem.Click += new System.EventHandler(this.записиToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(708, 366);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 25);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(7, 366);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 25);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(88, 366);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 25);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Visible = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.Location = new System.Drawing.Point(169, 366);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 25);
            this.Del.TabIndex = 6;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Visible = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // TableGV
            // 
            this.TableGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGV.Location = new System.Drawing.Point(12, 27);
            this.TableGV.Name = "TableGV";
            this.TableGV.Size = new System.Drawing.Size(776, 283);
            this.TableGV.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(231, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Visible = false;
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(12, 340);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(100, 20);
            this.SearchTB.TabIndex = 8;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // SearchLB
            // 
            this.SearchLB.AutoSize = true;
            this.SearchLB.Location = new System.Drawing.Point(41, 324);
            this.SearchLB.Name = "SearchLB";
            this.SearchLB.Size = new System.Drawing.Size(41, 13);
            this.SearchLB.TabIndex = 9;
            this.SearchLB.Text = "Search";
            // 
            // FilterCB
            // 
            this.FilterCB.FormattingEnabled = true;
            this.FilterCB.Items.AddRange(new object[] {
            "от 0 до 5%",
            "от 5% до 15%",
            "от 15% до 30%",
            "от 30% до 70%",
            "от 70% до 100%",
            "Все"});
            this.FilterCB.Location = new System.Drawing.Point(123, 339);
            this.FilterCB.Name = "FilterCB";
            this.FilterCB.Size = new System.Drawing.Size(121, 21);
            this.FilterCB.TabIndex = 10;
            this.FilterCB.SelectedIndexChanged += new System.EventHandler(this.FilterCB_SelectedIndexChanged);
            // 
            // FilterLB
            // 
            this.FilterLB.AutoSize = true;
            this.FilterLB.Location = new System.Drawing.Point(166, 324);
            this.FilterLB.Name = "FilterLB";
            this.FilterLB.Size = new System.Drawing.Size(29, 13);
            this.FilterLB.TabIndex = 11;
            this.FilterLB.Text = "Filter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 403);
            this.Controls.Add(this.FilterLB);
            this.Controls.Add(this.FilterCB);
            this.Controls.Add(this.SearchLB);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TableGV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem режимыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Button Add;
        public System.Windows.Forms.Button Edit;
        public System.Windows.Forms.Button Del;
        public System.Windows.Forms.DataGridView TableGV;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label SearchLB;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.Label FilterLB;
    }
}