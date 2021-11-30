using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;

namespace UP
{
    public partial class MainForm : Form
    {
        static string conStr = " Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = ABD_18UP; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public MainForm()
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.FromArgb(255, 156, 26);
            this.BackColor = Color.FromArgb(255, 255, 225);
            Add.BackColor = Color.FromArgb(255, 156, 26);
            Edit.BackColor = Color.FromArgb(255, 156, 26);
            Del.BackColor = Color.FromArgb(255, 156, 26);
            Exit.BackColor = Color.FromArgb(255, 156, 26);
            Table<Service> Service = context.GetTable<Service>();
            var services = Service.Select(s => s.MainImagePath);
            //Dictionary<string, Image> images = new Dictionary<string, Image>();
            //foreach (string s in services)
            //{
            //    string path = $"{Environment.CurrentDirectory}\\{s.Remove(0, 1)}";
            //    if (s != "")
            //        images[s] = Image.FromFile(path);
            //    images[s].Size = new Size(50,50);
            //}
            //List<Service> allServices = Service.ToList();
            //foreach (var service in allServices)
            //{
            //    foreach (var image in images.Keys)
            //    {
            //        if (service.MainImagePath == image)
            //        {
            //            service.Image = images[image];
            //            continue;
            //        }
            //    }
            //}
            //TableGV.DataSource = allServices;
            TableGV.DataSource = Service.ToList();
        }

        public void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode mode = new Mode(this);
            mode.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.ShowDialog();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add.Visible = false;
            Edit.Visible = false;
            Del.Visible = false;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var result = MessageBox.Show("Are you sure about deleting this row?", "Delete question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Client client = context.GetTable<Client>().OrderByDescending(x => x.ID).FirstOrDefault();
                    context.GetTable<Client>().DeleteOnSubmit(client);
                    context.SubmitChanges();
                    Table<Client> Client = context.GetTable<Client>();
                    TableGV.DataSource = Client.ToList();
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
            var result = MessageBox.Show("Are you sure about deleting this row?", "Delete question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Service serv = context.GetTable<Service>().OrderByDescending(x => x.ID).FirstOrDefault();
                context.GetTable<Service>().DeleteOnSubmit(serv);
                context.SubmitChanges();
                Table<Service> Service = context.GetTable<Service>();
                TableGV.DataSource = Service.ToList();
            }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var result = MessageBox.Show("Are you sure about deleting this row?", "Delete question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClientService clientservice = context.GetTable<ClientService>().OrderByDescending(x => x.ID).FirstOrDefault();
                    context.GetTable<ClientService>().DeleteOnSubmit(clientservice);
                    context.SubmitChanges();
                    Table<ClientService> ClientService = context.GetTable<ClientService>();
                    TableGV.DataSource = ClientService.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this);
            edit.ShowDialog();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Table<Client> Service = context.GetTable<Client>();
            TableGV.DataSource = Service.ToList();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            Table<Service> Service = context.GetTable<Service>();
            TableGV.DataSource = Service.ToList();
        }

        private void записиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            comboBox1.SelectedIndex = 2;
            Table<ClientService> Service = context.GetTable<ClientService>();
            TableGV.DataSource = Service.ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var f = context.GetTable<Client>().Where(x => x.FirstName.Contains(SearchTB.Text));
                TableGV.DataSource = f.ToList();
            }
            if (comboBox1.SelectedIndex == 1)
            {
             var f = context.GetTable<Service>().Where(x => x.Title.Contains(SearchTB.Text));
             TableGV.DataSource = f.ToList();
            }
        }

        private void FilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Service> serv = null;
            switch (FilterCB.SelectedIndex)
            {
                case 0: serv = context.GetTable<Service>().Where(x => x.Discount <= 0.05 && x.Discount > 0).ToList(); break;
                case 1: serv = context.GetTable<Service>().Where(x => x.Discount <= 0.15 && x.Discount > 0.05).ToList(); break;
                case 2: serv = context.GetTable<Service>().Where(x => x.Discount <= 0.3 && x.Discount > 0.15).ToList(); break;
                case 3: serv = context.GetTable<Service>().Where(x => x.Discount <= 0.7 && x.Discount > 0.3).ToList(); break;
                case 4: serv = context.GetTable<Service>().Where(x => x.Discount <= 1 && x.Discount > 0.7).ToList(); break;
                case 5: serv = context.GetTable<Service>().Where(x => x.Discount <= 1 && x.Discount > 0).ToList(); break;
            }
            TableGV.DataSource = serv;
        }
    }
}
