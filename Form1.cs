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
        public static string Selectedcustomer, IDToDelete = string.Empty;
        public Form1()
        {
            //initialises the form components 
            InitializeComponent();
        }
        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllOrders();
        }
        //this is responsibe of getting all the data needed from the database through and API
        [STAThread]
        private async void GetAllOrders()
        {
            //creates a new client
            using var client = new HttpClient();
            //sends request to the api
            var request = await client.GetAsync("https://college-delevery-app-api.herokuapp.com/api/v1/orders-endpoint/Get-All-Orders");
            var response = await request.Content.ReadAsStringAsync();
            //deserializes the Json data sent from the API into a readable c# class
            var orders = JsonConvert.DeserializeObject<List<OrderInfo>>(response);
            //binds the Deserialized json data to a data source
            BindingSource OrderData = new BindingSource();
            OrderData.DataSource = orders;
            DGWAllOrders.DataSource = orders;
            DGWAllOrders.BackgroundColor = Color.White;
            DGWAllOrders.RowHeadersVisible = false;
            cbIDTodelete.DataSource = OrderData;
            cbIDTodelete.DisplayMember = "_id";
            cbIDTodelete.ValueMember = "_id";

        }
        private async void DeleteDeliveryData()
        {
            using var client = new HttpClient();
            var uri = "http://localhost:5000/api/v1/orders-endpoint/Delete-order-by-id/" + IDToDelete;
            var request = await client.DeleteAsync(uri);
            GetAllOrders();
            
        }
        private void BtnAddNewOrder_Click(object sender, EventArgs e)
        {
            //creates a new form and adds it to the viewport
            AddNewOrder Addneworderfrm = new AddNewOrder();
            Addneworderfrm.Show();
            this.Hide();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            GetAllOrders();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteDeliveryData();
        }

        private void cbIDTodelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDToDelete = cbIDTodelete.Text;
            Debug.WriteLine(IDToDelete);
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
