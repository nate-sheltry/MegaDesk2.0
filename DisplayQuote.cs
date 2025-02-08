using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        private String WORK_DIR = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private DeskQuote deskQuote = null;
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        internal void LoadQuote(DeskQuote quote)
        {
            this.deskQuote = quote;
            nameView.Text = quote.customerName;
            dateView.Text = quote.date.ToString("MM/dd/yyyy");
            widthView.Text = quote.width.ToString()+" in.";
            depthView.Text = quote.depth.ToString()+" in.";
            drawerView.Text = quote.drawers.ToString();
            materialView.Text = quote.material.ToString();
            orderView.Text = quote.order.ToString() + " days";
            priceView.Text = "$"+quote.price.ToString();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //load from file
            List<DeskQuote> quotes = new List<DeskQuote>();
            if (File.Exists(WORK_DIR + "\\"  + Constants.QUOTES_FILE))
            {
                using (StreamReader r = new StreamReader(WORK_DIR + "\\" + Constants.QUOTES_FILE))
                {
                    string json = r.ReadToEnd();
                    quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                }
            }
            quotes.Add(deskQuote);

            var jsonToOutput = JsonConvert.SerializeObject(quotes, Formatting.Indented);
            System.IO.File.WriteAllText(WORK_DIR + "\\" + Constants.QUOTES_FILE, jsonToOutput);
            BtnSave.Enabled = false;
        }
    }
}
