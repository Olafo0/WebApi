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





        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBox1.Text);

            try
            {
                var emp = await _client.DeleteFromJsonAsync<EmployeeData>($"Employees/{id}");
            }
            catch (System.Net.Http.HttpRequestException)
            {
                MessageBox.Show($"Employee ({id}) has not been found!");
            }
            catch (System.Text.Json.JsonException)
            {
                MessageBox.Show($"Employee ({id}) has been removed!");
                this.Hide();
            }
            
            




        }
    }
}
