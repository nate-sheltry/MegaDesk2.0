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
using Newtonsoft.Json;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        private const string FILE_NAME = "quote.json"; // File where quotes are stored or txt file， I don't see where the quote is saved right now
        private List<DeskQuote> allQuotes = new List<DeskQuote>();

        public SearchQuotes()
        {
            InitializeComponent();
            LoadMaterials();
            LoadQuotes();
        }

        // Load available materials
        private void LoadMaterials()
        {
            comboMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            comboMaterial.SelectedIndex = -1;
        }

        private void LoadQuotes()
        {
            if (File.Exists(FILE_NAME))
            {
                try
                {
                    string json = File.ReadAllText(FILE_NAME);
                    allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading quotes: " + ex.Message);
                }
            }
        }

        // For selecting a material in the combo box
        private void comboMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMaterial.SelectedItem == null)
                return;

            DesktopMaterial selectedMaterial = (DesktopMaterial)comboMaterial.SelectedItem;

            var filteredQuotes = allQuotes
                .Where(q => q.material == selectedMaterial)
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

            // Display results
            gridQuotes.DataSource = filteredQuotes;
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }
    }
}
