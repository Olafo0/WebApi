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

namespace WindowsApp
{
    public partial class Form2 : Form
    {




        public HttpClient _client;
        public List<EmployeeMinData> Emp { get; set; }


        public Form2()
        {


            Emp = getemp();
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7165/api/")
            };

            InitializeComponent();
        }

        private List<EmployeeMinData> getemp()
        {
            var list = new List<EmployeeMinData>();

            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Form2_Load(object sender, EventArgs e)
        {

            var emp = this.Emp;
            emp = await _client.GetFromJsonAsync<List<EmployeeMinData>>("Employees");
            dataGridView1.DataSource = emp;
            this.Refresh();
        }
    }
}
