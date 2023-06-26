using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form3 : Form
    {

        public HttpClient _client;
        public List<EmployeeData> Emp { get; set; }

        public Form3()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            var empId = await _client.GetFromJsonAsync<List<EmployeeData>>("Employees");
            List<int> idnum = new List<int>();

            var ids = empId.Where(x => x.EmployeeId > 0).ToList();

            for (int i = 0; i < ids.Count; i++)
            {
                int h = ids[i].EmployeeId;
                idnum.Add(h);
            }
            List<int> unique_id = new HashSet<int>(idnum).ToList();

            foreach (int x in unique_id)
            {
                idCB.Items.Add(x);
            }



        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var id = idCB.Items[idCB.SelectedIndex];

                var emp = await _client.GetFromJsonAsync<EmployeeData>($"Employees/{id}");

                textBoxFN.Text = emp.FirstName;
                textBoxMN.Text = emp.MiddleName;
                textBoxLN.Text = emp.LastName;
                textBoxJobID.Text = Convert.ToString(emp.JobId);
                textBoxS.Text = Convert.ToString(emp.Salary);
                textBoxBD.Text = Convert.ToString(emp.BirthDate);
                textBoxHD.Text = Convert.ToString(emp.HireDate);
                textBoxDepId.Text = Convert.ToString(emp.DepartmentId);
                textBoxManID.Text = Convert.ToString(emp.ManagerId);
                textBoxPhone.Text = Convert.ToString(emp.Phone);
                textBoxAdd.Text = emp.StreetAddress;
                textBoxCity.Text = emp.City;
                textBoxSP.Text = emp.StateProvince;
                textBoxPhone.Text = emp.PostalCode;
                textBoxCountryId.Text = Convert.ToString(emp.CountryId);

            }
            catch (System.Text.Json.JsonException)
            {
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }


        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
