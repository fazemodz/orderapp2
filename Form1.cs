using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Data;
#nullable disable warnings
namespace orderapp2
{
    public partial class Form1 : Form
    {
        public static string Selectedcustomer = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllOrders();
        }
        [STAThread]
        private async void GetAllOrders()
        {
            
            using var client = new HttpClient();
            var request = await client.GetAsync("https://college-delevery-app-api.herokuapp.com/api/v1/orders-endpoint/Get-All-Orders");
            var response = await request.Content.ReadAsStringAsync();
            var orders = JsonConvert.DeserializeObject<List<OrderInfo>>(response);
            BindingSource OrderData = new BindingSource();
            OrderData.DataSource = orders;
            DGWAllOrders.DataSource = orders;
            DGWAllOrders.BackgroundColor = Color.White;
            DGWAllOrders.RowHeadersVisible = false;
        }

        private void BtnAddNewOrder_Click(object sender, EventArgs e)
        {
            AddNewOrder Addneworderfrm = new AddNewOrder();
            Addneworderfrm.Show();
            this.Hide();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            GetAllOrders();
        }
    }
    class OrderInfo
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "Orders")]
        public int RowID;
        public string _id { get; set; }
        public string OrderUUID  { get; set; }
        public string CustomerName { get; set; }
        public string Distance { get; set; }
        public string TotalPrice { get; set; }
    }
}
