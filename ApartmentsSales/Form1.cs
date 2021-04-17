using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmentsSales.Entities;

namespace ApartmentsSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var types = new List<string>();
            types.Add("Exchange");
            types.Add("Buy");
            types.Add("Sale");

            this.saleRequestType.DataSource = types.ToList();
            this.saleRequestTypeSearch.DataSource = types.ToList();

            this.Update();
        }

        private void makeSaleRequest_Click(object sender, EventArgs e)
        {
            using (var db = new DbController())
            {
                var newSaleRequest = new SaleRequest();
                newSaleRequest.AgentName = this.agentName.Text;
                newSaleRequest.ClientName= this.clientName.Text;
                newSaleRequest.ApartmentRoomCount = int.Parse(this.apartmentRoomCount.Text);
                newSaleRequest.ApartmentFloor = int.Parse(this.apartmentFloor.Text);
                newSaleRequest.ApartmentArea = float.Parse(this.apartmentArea.Text);
                newSaleRequest.Type = this.saleRequestType.Text;

                db.SetSaleRequest(newSaleRequest);
            }

            this.Update();
        }

        private void Update()
        {
            using (var db = new DbController())
            {
                this.saleRequests.DataSource = db.GetSaleRequests(this.saleRequestTypeSearch.Text);
            }
        }

        private void saleRequestTypeSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}
