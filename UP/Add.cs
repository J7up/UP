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

namespace UP
{
    public partial class Add : Form
    {
        static string conStr = " Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = ABD_18UP; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public MainForm mainForm;
        public Add(MainForm form)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 225);
            Add2.BackColor = Color.FromArgb(255, 156, 26);
            Cancel2.BackColor = Color.FromArgb(255, 156, 26);
            mainForm = form;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aBD_18UPDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.aBD_18UPDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aBD_18UPDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.aBD_18UPDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aBD_18UPDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.aBD_18UPDataSet.Service);
            if (mainForm.comboBox1.SelectedIndex == 0)
            {
                Size = new Size(500, 250);
                Cancel2.Location = new Point(397, 176);
                TitleLB.Location = new Point(28, 15);
                CostLB.Location = new Point(28, 41);
                DurLB.Location = new Point(28, 67);
                DescriptionLB.Location = new Point(53, 93);
                DiscountLB.Location = new Point(50, 119);
                TitleLB.Text = "First Name";
                CostLB.Text = "Last Name";
                DurLB.Text = "Patronymic";
                DescriptionLB.Text = "Email";
                DiscountLB.Text = "Phone";
                
            }
            if (mainForm.comboBox1.SelectedIndex == 1)
            {
                Size = new Size(250, 250);
                Cancel2.Location = new Point(147, 176);
                ServiceTitleTB.Visible = true;
                ServiceCostTB.Visible = true;
                ServiceDurationTB.Visible = true;
                ServiceDescriptionTB.Visible = true;
                ServiceDiscountTB.Visible = true;
                PathCB.Visible = true;
            }
            if (mainForm.comboBox1.SelectedIndex == 2)
            {
                Size = new Size(250, 180);
                Cancel2.Location = new Point(147, 114);
                Add2.Location = new Point(12, 114);
                ServiceTitleTB.Visible = false;
                ServiceCostTB.Visible = false;
                ServiceDurationTB.Visible = false;
                ServiceDiscountTB.Visible = false;
                PathCB.Visible = false;
                StartTimeDTP.Visible = true;
                ClientIDCB.Visible = true;
                ServiceIDCB.Visible = true;
                DiscountLB.Visible = false;
                TitleLB.Text = "Cliet ID";
                CostLB.Text = "Service ID";
                DurLB.Text = "Start time";
                DescriptionLB.Text = "Comment";
                TitleLB.Location = new Point(45, 15);
                CostLB.Location = new Point(28, 41);
                DescriptionLB.Location = new Point(32, 93);
            }
        }

        private void Cancel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавлено");
            if (mainForm.comboBox1.SelectedIndex == 0)
            {
                Client add0 = new Client();
                add0.FirstName = ServiceTitleTB.Text;
                add0.LastName = ServiceCostTB.Text;
                add0.Patronymic = ServiceDurationTB.Text;
                add0.Email = ServiceDescriptionTB.Text;
                add0.Phone = ServiceDiscountTB.Text;
                add0.PhotoPath = PathCB.Text;
                add0.GenderCode = Convert.ToChar(GenderCB.SelectedValue);
                add0.Birthday = BirthdayDTP.Value;
                add0.RegistrationDate = RegDTP.Value;
                context.GetTable<Client>().InsertOnSubmit(add0);
                context.SubmitChanges();
                Table<Client> Client = context.GetTable<Client>();
                mainForm.TableGV.DataSource = Client.ToList();
            }
            if (mainForm.comboBox1.SelectedIndex == 1)
            {
            Service add = new Service();
            add.Title = ServiceTitleTB.Text;
            add.Cost = Convert.ToDecimal(ServiceCostTB.Text);
            add.DurationInSeconds = Convert.ToInt32(ServiceDurationTB.Text);
            add.Description = ServiceDescriptionTB.Text;
            add.Discount= Convert.ToInt32(ServiceDiscountTB.Text);
            add.MainImagePath = PathCB.Text;
            context.GetTable<Service>().InsertOnSubmit(add);
            context.SubmitChanges();
            Table<Service> Service = context.GetTable<Service>();
            mainForm.TableGV.DataSource = Service.ToList();
            }
            if (mainForm.comboBox1.SelectedIndex == 2)
            {
                ClientService add1 = new ClientService();
                add1.ClientID = Convert.ToChar(ClientIDCB.SelectedValue);
                add1.ServiceID = Convert.ToChar(ServiceIDCB.SelectedValue);
                add1.StartTime = StartTimeDTP.Value;
                context.GetTable<ClientService>().InsertOnSubmit(add1);
                context.SubmitChanges();
                Table<ClientService> ClientService = context.GetTable<ClientService>();
                mainForm.TableGV.DataSource = ClientService.ToList();
            }
        }
    }
}
