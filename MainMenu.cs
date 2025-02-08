using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
            MakeNecessaryFiles();
        }

        private void MakeNecessaryFiles()
        {
            if (!File.Exists(Constants.RUSH_ORDER_PRICES_FILE))
            {
                using (FileStream fs = File.Create(Constants.RUSH_ORDER_PRICES_FILE));
                TextWriter tw = new StreamWriter(Constants.RUSH_ORDER_PRICES_FILE);
                tw.WriteLine(
                    "60\n70\n80\n40\n50\n60\n30\n35\n40"
                    );
                tw.Close();
            }

            if (!File.Exists(Constants.QUOTES_FILE))
            {
                using (FileStream fs = File.Create(Constants.QUOTES_FILE));
                TextWriter tw = new StreamWriter(Constants.QUOTES_FILE);
                tw.WriteLine(
                    "[]"
                    );
                tw.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show(this);
            this.Hide();
        }

        private void DisplayQuoteBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes displayQuoteForm = new ViewAllQuotes();
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            this.Hide();
        }

        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
