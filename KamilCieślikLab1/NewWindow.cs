using System;
using System.Windows.Forms;

namespace KamilCieślikLab1
{
    public partial class NewWindow : Form
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja generująca choinke skladajaca sie z trojkatow z gwiazdek.
        /// Uzytkownik podaje szerokosc choinki (najwiekszego trojkata u podstawy drzewka).
        /// </summary>
        public void ChristmasTree()
        {
            try
            {
                textBoxTree.Clear();
                textBoxTree.TextAlign = HorizontalAlignment.Center;
                textBoxTree.Multiline = true;
                textBoxTree.ScrollBars = ScrollBars.Vertical;
                textBoxTree.AppendText(Environment.NewLine);
                var part = int.Parse(textBoxTreeHeight.Text);
                if ((part < 2) || (part > 15)) throw new Exception("Drzewko może sie składać z 2-15 części!");
                var basis = 2;
                for (var i = basis; i <= part; i++)
                {
                    var asterix = 1;
                    for (var j = 0; j < basis; j++)
                    {
                        for (var k = 0; k < asterix; k++)
                        {

                            textBoxTree.AppendText("* ");
                        }
                        textBoxTree.AppendText(Environment.NewLine);
                        asterix = asterix + 5;

                    }
                    basis++;
                }
                textBoxTree.AppendText((basis % 2) == 0 ? "* " : "* * ");
            }
            catch (FormatException fEx)
            {
                textBoxTree.AppendText(fEx.Message);
            }
            catch (Exception ex)
            {
                textBoxTree.AppendText(ex.Message);
            }
        }

        /// <summary>
        /// Wywolanie metody rysującej choinkę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ChristmasTree();
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
