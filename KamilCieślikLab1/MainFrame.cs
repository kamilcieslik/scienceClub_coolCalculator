using System;
using System.Drawing;
using System.Windows.Forms;
using KamilCieslikLab1;

namespace KamilCieślikLab1
{
    public partial class MainFrame : Form
    {
        int _counter;
        public string LoggedUser = " ";
        readonly NewWindow _window = new NewWindow();
        readonly Calculator _calculator = new Calculator();

        /// <summary>
        /// Metoda weryfikujaca wprowadzone dane do pól textBoxLogin i textBoxPassword.
        /// W zaleznosci od poprawnosci wprowadzonych danych odbywa sie logowanie lub pojawia sie stosowny komunikat przyczyny odmowy.
        /// </summary>
        public void Login()
        {
            if ((textBoxLogin.Text != "") && (textBoxPassword.Text != ""))
            {
                if (_counter < 8)
                {
                    if ((textBoxLogin.Text == @"test") && (textBoxPassword.Text == @"test"))
                    {
                        labelStatus.Text = @"Zalogowano";
                        _counter = 0;
                        MessageBox.Show(@"Logowanie przebieglo pomyslnie.");
                        buttonLogin.Visible = false;
                        buttonLogout.Visible = true;
                        labelStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        _counter++;
                        MessageBox.Show(@"Podano nieprawidlowe dane!");
                    }
                }
                else
                {
                    labelStatus.Text = @"Konto zablokowane.";
                    MessageBox.Show(@"Wyczerpales limit zalogowan");
                }
            }
            else
                MessageBox.Show(@"Nie podano wystarczajacych danych");
        }
        public MainFrame()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Przejście do nowego okna z przykładową pętlą generującą choinkę.
        /// Przejście odbywa się tylko w sytuacji kiedy użytkownik jest zalogowany.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            if (labelStatus.Text == @"Zalogowano")
            {
                Visible = false;
                _window.ShowDialog();
                if (_window.IsAccessible == false) Visible = true;
            }
            else
                MessageBox.Show(@"Aby skorzystac z tej opcji musisz byc zalogowany!");
        }

        /// <summary>
        /// Przycisk służący wylogowaniu się.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            labelStatus.Text = @"Niezalogowany";
            labelStatus.ForeColor = Color.Red;
            buttonLogin.Visible = true;
            buttonLogout.Visible = false;
        }

        /// <summary>
        /// Przejście do nowego okna - kalkulator.
        /// Przejście odbywa się tylko w sytuacji kiedy użytkownik jest zalogowany.
        /// </summary>
        /// <param name="sender"></param>   
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            if (labelStatus.Text == @"Zalogowano")
            {
                Visible = false;
                _calculator.ShowDialog();
                if (_calculator.IsAccessible == false) Visible = true;
            }
            else
                MessageBox.Show(@"Aby skorzystac z tej opcji musisz byc zalogowany!");
        }
    }
}
