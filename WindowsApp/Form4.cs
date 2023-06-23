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


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void AddBtn_Click(object sender, EventArgs e)
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
                ManagerId = int.Parse(textBoxManID.Text),
                Phone = textBoxPhone.Text,
                StreetAddress = textBoxSA.Text,
                City = textBoxC.Text,
                StateProvince = textBoxSP.Text,
                PostalCode = textBoxPhone.Text,
                CountryId = int.Parse(textBoxCountryID.Text)
            };



            var emp = await _client.PostAsJsonAsync<EmployeeData>("Employees",newEmployee);
            if (emp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
