using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace orderapp2
{
    public partial class AddNewOrder : Form
    {
        private static string customerName, addneworderfrm = string.Empty;
        private static decimal distanceNeededToTravel;
      
        public AddNewOrder()
        {
            InitializeComponent();
            
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            customerName = txtCustomerName.Text;
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnSubmitOrderData_Click(object sender, EventArgs e)
        {
            //a recuring check to insure that the value that was entered was the correct type
            if (Decimal.TryParse(txtDistance.Text, out distanceNeededToTravel))
            {
                //if the error text is showing disable it
                if (lblError.Visible = true)
                {
                    lblError.Visible = false;
                }
                //calculate total
                decimal PerMilesCharge = 3;
                decimal BookingCharge = 2;
                decimal totalAmount = PerMilesCharge * distanceNeededToTravel + BookingCharge;
                string PrintAmount = "£" + totalAmount.ToString();
                lblTotal.Text = "The total is: " + PrintAmount;
                lblTotal.Visible = true;
                SendData(PrintAmount);

            }
            else
            {
                //if the data type is not the desired one then throw a error 
                lblError.Text = "A decimal value was not enterd please try again";
                lblError.Visible = true;
            }
        }
        private async void SendData(string TotalAmount)
        {
            //gets the data ready to be sent 
            var payload = new OrderDataToSend
            {
                CustomerName = customerName,
                Distance = distanceNeededToTravel,
                TotalPrice = TotalAmount
            };
            //serializes the data as the API only accepts json data 
            var stringPayload = JsonConvert.SerializeObject(payload);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();
            //sends the data to the api
            var httpResponse = await httpClient.PostAsync("https://college-work-api.projectredacted.org/api/v1/orders-endpoint/Add-New-Order", httpContent);
            Form1 MainForm = new Form1();
            MainForm.Show();
            this.Hide();
        }
        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            lblTotal.Visible = false;
        }
    }
    class OrderDataToSend
    {
        public string CustomerName { get; set; }
        public decimal Distance { get; set; }
        public string TotalPrice { get; set; }
    }
}
