using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilCieslikLab1
{
    public partial class MathematicalDefinitions : Form
    {
        public MathematicalDefinitions()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string category = comboBoxCategoryFirst.Text;
            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("https://pl.wikipedia.org/wiki/Kategoria:");

                if (category != string.Empty)
                {
                    queryadress.Append(category);
                }
                webBrowserMathematicalDefinitions.Navigate(queryadress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Błąd");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
