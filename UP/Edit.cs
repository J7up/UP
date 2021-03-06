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
    public partial class Edit : Form
    {
        static string conStr = " Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = ABD_18UP; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public MainForm mainForm;
        public Edit(MainForm form)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 225);
            Edit2.BackColor = Color.FromArgb(255, 156, 26);
            Cancel2.BackColor = Color.FromArgb(255, 156, 26);
            mainForm = form;
            if (mainForm.comboBox1.SelectedIndex == 0)
            {
                Client edit0 = context.GetTable<Client>().FirstOrDefault(x => x.ID == Convert.ToInt32(mainForm.TableGV.CurrentRow.Cells[0].Value));
                ServiceTitleTB.Text = edit0.FirstName;
                ServiceCostTB.Text=edit0.LastName;
                ServiceDurationTB.Text = edit0.Patronymic;
                ServiceDescriptionTB.Text = edit0.Email;
                ServiceDiscountTB.Text = edit0.Phone;
                PathCB.Text = edit0.PhotoPath;
                GenderCB.SelectedValue = edit0.GenderCode;
                BirthdayDTP.Value = edit0.Birthday;
                RegDTP.Value = edit0.RegistrationDate;
            }
            if (mainForm.comboBox1.SelectedIndex == 1)
            {
                Service edit = context.GetTable<Service>().FirstOrDefault(x => x.ID == Convert.ToInt32(mainForm.TableGV.CurrentRow.Cells[0].Value));
                ServiceTitleTB.Text = edit.Title;
                ServiceCostTB.Text = Convert.ToString(edit.Cost);
                ServiceDurationTB.Text = Convert.ToString(edit.DurationInSeconds);
                ServiceDescriptionTB.Text = Convert.ToString(edit.Description);
                ServiceDiscountTB.Text = Convert.ToString(edit.Discount);
                PathCB.Text = edit.MainImagePath;
            }
            if (mainForm.comboBox1.SelectedIndex == 2)
            {
                ClientService edit2 = context.GetTable<ClientService>().FirstOrDefault(x => x.ID == Convert.ToInt32(mainForm.TableGV.CurrentRow.Cells[0].Value));
                ClientIDCB.SelectedValue = edit2.ClientID;
                ServiceIDCB.SelectedValue = edit2.ServiceID;
                StartTimeDTP.Value = edit2.StartTime;
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aBD_18UPDataSet.ServicePhoto". При необходимости она может быть перемещена или удалена.
            this.servicePhotoTableAdapter.Fill(this.aBD_18UPDataSet.ServicePhoto);
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
                Edit2.Location = new Point(12, 114);
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

        private void Edit2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменено");
            if (mainForm.comboBox1.SelectedIndex == 0)
            {
                Client edit0 = context.GetTable<Client>().FirstOrDefault(x => x.ID == Convert.ToInt32(mainForm.TableGV.CurrentRow.Cells[0].Value));
                edit0.FirstName = ServiceTitleTB.Text;
                edit0.LastName = ServiceCostTB.Text;
                edit0.Patronymic = ServiceDurationTB.Text;
                edit0.Email = ServiceDescriptionTB.Text;
                edit0.Phone = ServiceDiscountTB.Text;
                edit0.PhotoPath = PathCB.Text;
                edit0.GenderCode = Convert.ToChar(GenderCB.SelectedValue);
                edit0.Birthday = BirthdayDTP.Value;
                edit0.RegistrationDate = RegDTP.Value;
                context.SubmitChanges();
                Table<Client> Client = context.GetTable<Client>();
                mainForm.TableGV.DataSource = Client.ToList();
            }
            if (mainForm.comboBox1.SelectedIndex == 1)
            {
            Service edit = context.GetTable<Service>().FirstOrDefault(x => x.ID == Convert.ToInt32(mainForm.TableGV.CurrentRow.Cells[0].Value));
            edit.Title = ServiceTitleTB.Text;
            edit.Cost = Convert.ToDecimal(ServiceCostTB.Text);
            edit.DurationInSeconds = Convert.ToInt32(ServiceDurationTB.Text);
            edit.Description = ServiceDescriptionTB.Text;
            edit.Discount = Convert.ToInt32(ServiceDiscountTB.Text);
            edit.MainImagePath = PathCB.Text;
            context.SubmitChanges();
            Table<Service> Service = context.GetTable<Service>();
            mainForm.TableGV.DataSource = Service.ToList();
            }
            if (mainForm.comboBox1.SelectedIndex == 2)
            {
                ClientService edit2 = context.GetTable<ClientService>().FirstOrDefault(x => x.ID == Convert.ToInt32(mainForm.TableGV.CurrentRow.Cells[0].Value));
                edit2.ClientID = Convert.ToChar(ClientIDCB.SelectedValue);
                edit2.ServiceID = Convert.ToChar(ServiceIDCB.SelectedValue);
                edit2.StartTime = StartTimeDTP.Value;
                context.GetTable<ClientService>().InsertOnSubmit(edit2);
                context.SubmitChanges();
                Table<ClientService> ClientService = context.GetTable<ClientService>();
                mainForm.TableGV.DataSource = ClientService.ToList();
            }
        }

        private void Cancel2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
