using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private List<DeskQuote> allQuotes = new List<DeskQuote>();

        public ViewAllQuotes()
        {
            InitializeComponent();
            LoadQuotes();
        }

        private void LoadQuotes()
        {
            if (File.Exists(Constants.QUOTES_FILE))
            {
                try
                {
                    string json = File.ReadAllText(Constants.QUOTES_FILE);
                    allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                    var formattedQuotes = allQuotes
                        .Select(q => new
                        {
                            Customer = q.customerName,
                            Date = q.date.ToString("MM/dd/yyyy"),
                            Width = q.width + " in.",
                            Depth = q.depth + " in.",
                            Drawers = q.drawers,
                            Material = q.material.ToString(),
                            OrderTime = q.order + " days",
                            Price = "$" + q.price.ToString("F2")
                        })
                        .ToList();
                    gridAllQuotes.DataSource = formattedQuotes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading quotes: " + ex.Message);
                }
            }
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }
    }
}
