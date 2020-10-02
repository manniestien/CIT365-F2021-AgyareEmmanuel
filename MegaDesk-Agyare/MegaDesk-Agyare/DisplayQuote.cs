using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Agyare
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(Desk desk, DeskQuote quote)

        {

            InitializeComponent();

            lblName.Text = quote.CustomerName;

            lblWidth.Text = desk.Width.ToString() + " inches";

            lblDepth.Text = desk.Depth.ToString() + " inches";

            lblDrawerCount.Text = desk.Drawers.ToString();

            lblSurfaceMaterial.Text = desk.Material.ToString();
            //=====TT??? The desk.Rush is not being set anywhere
            lbldeliveryTime.Text = desk.Rush.ToString() + " Days";
            DateTime quoteDate = quote.QuoteDate;

            lblBaseCost.Text = "$" + DeskQuote.BASEPRICE;

            lblAreaCost.Text = "$" + quote.SurfaceAreaCost.ToString();

            lblMaterialCost.Text = "$" + quote.MaterialCost.ToString();

            lblRushCost.Text = "$" + quote.RushCost.ToString();

            lblDrawerCost.Text = "$" + quote.DrawerCost.ToString();

            lblTotalCost.Text = "$" + quote.QuoteTotal.ToString();

            lblQuoteDate.Text = quote.QuoteDate.ToString("dd MMMM yyyy");



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            List<NewQuote> newQuote = new List<NewQuote>();

            var filePath = @"../../docs/quotes.json";
            var jsonData = System.IO.File.ReadAllText(filePath);
            var quoteList = JsonConvert.DeserializeObject<List<NewQuote>>(jsonData)
                  ?? new List<NewQuote>();
            quoteList.Add(new NewQuote()
            {
                SpecName = lblName.Text,
                SpecDate = Convert.ToDateTime(lblQuoteDate.Text),
                SpecMaterial = lblSurfaceMaterial.Text,
                SpecWidth = lblWidth.Text,
                SpecDepth = lblDepth.Text,
                SpecDrawers = lblDrawerCost.Text,
                SpecRush = lblRushCost.Text,
                SpecTotal = lblTotalCost.Text
            });

            jsonData = JsonConvert.SerializeObject(quoteList);
            System.IO.File.WriteAllText(filePath, jsonData);



            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();

        }

        private void lblRushCost_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}