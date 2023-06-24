using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsApp
{
    public partial class Form4 : Form
    {

        public HttpClient _client;
        public List<EmployeeData> Emp { get; set; }


        public Form4()
        {
            Emp = getemp();
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7165/api/")
            };
            InitializeComponent();
        }


        private List<EmployeeData> getemp()
        {
            var list = new List<EmployeeData>();

            return list;
        }


        private async void Form4_Load(object sender, EventArgs e)
        {
            // -- Manager ID 
            var emp = await _client.GetFromJsonAsync<List<EmployeeData>>("Employees");
            List<int?> num = new List<int?>();

            // Gets only the employees who have an Manager 
            var person = emp.Where(x => x.ManagerId > 1).ToList();

            // Goes through each employee and appends their manager id to a list
            for (int i = 0; i < person.Count; i++)
            {
                int? h = person[i].ManagerId;
                num.Add(h);
            }
            // Gets only the uniueq managers
            List<int?> unique_man_id = new HashSet<int?>(num).ToList();

            // Adds each manager ID to the dropbox 
            foreach (int? x in unique_man_id)
            {
                DepIdCb.Items.Add(x);
            }

            // -- Job ID 
            // code  will go here

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                EmployeeData newEmployee = new EmployeeData()
                {
                    FirstName = textBoxFN.Text,
                    MiddleName = textBoxMD.Text,
                    LastName = textBoxLN.Text,
                    JobId = int.Parse(textBoxJobID.Text),
                    Salary = decimal.Parse(textBoxSala.Text),
                    BirthDate = DateTime.Parse(textBoxBD.Text),
                    HireDate = DateTime.Parse(textBoxHD.Text),
                    DepartmentId = int.Parse(textBoxDepID.Text),
                    ManagerId = (int?)DepIdCb.Items[DepIdCb.SelectedIndex],
                    Phone = textBoxPhone.Text,
                    StreetAddress = textBoxSA.Text,
                    City = textBoxC.Text,
                    StateProvince = textBoxSP.Text,
                    PostalCode = textBoxPhone.Text,
                    CountryId = int.Parse(textBoxCountryID.Text)
                };



                var emp = await _client.PostAsJsonAsync<EmployeeData>("Employees", newEmployee);
                if (emp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Employee has been added to the system!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR : Employee has not been added!");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ERROR : Missing input field(s)");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
