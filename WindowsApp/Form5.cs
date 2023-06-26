using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace WindowsApp
{




    public partial class Form5 : Form
    {


        public HttpClient _client;

        public List<EmployeeData> Emp { get; set; }


        public Form5()
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





        private async void Form5_Load(object sender, EventArgs e)
        {

        }
        private async void Form5_Load_1(object sender, EventArgs e)
        {
            var empId = await _client.GetFromJsonAsync<List<EmployeeData>>("Employees");

            List<int> idnum = new List<int>();

            var ids = empId.Where(x => x.EmployeeId > 0).ToList();

            for (int i = 0; i < ids.Count; i++)
            {
                int h = ids[i].EmployeeId;
                idnum.Add(h);
            }
            List<int> uni_id = new HashSet<int>(idnum).ToList();

            foreach (int x in uni_id)
            {
                idsCB.Items.Add(x);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var id = idsCB.Items[idsCB.SelectedIndex];


            var emp = await _client.DeleteAsync($"Employees/{id}");

            if (emp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Employee {id} has been removed");
                this.Hide();
            }
            else
            {
                MessageBox.Show(" ERROR:");
            }
        }
    }
}
