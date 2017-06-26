using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using KamilCieslikLab1;

namespace KamilCieślikLab1
{
    public partial class Calculator : Form
    {
        private readonly MathematicalDefinitions _mathematicaldefinitions = new MathematicalDefinitions();

        private const string ZipPath = "ziphistory.zip";
        private static string _history = "";
        private double _resultValue = 0;
        private string _activeOperation = "";
        private bool _isActiveOperation;
        private bool _isSoundOn = true;
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dekompresacja pliku tekstowego w celu odczytu historii.
        /// </summary>
        /// <param name="history"></param>
        /// <param name="textBoxHistory"></param>
        public static void ReadFromFile(string history, TextBox textBoxHistory)
        {
            if (history == null) throw new ArgumentNullException(nameof(history));
            try
            {
                var fsInput = new FileStream(ZipPath, FileMode.Open);
                var gZip = new GZipStream(fsInput, CompressionMode.Decompress);
                var reader = new StreamReader(gZip);
                history = reader.ReadToEnd();
                reader.Close();
                gZip.Close();
                fsInput.Close();
                textBoxHistory.Text = history;
                MessageBox.Show(@"Pomyślnie odczytano historię.");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Zapis historii do skompresowanego pliku.
        /// </summary>
        /// <param name="history"></param>
        public static void WriteToFile(string history)
        {
            var fsOutput = new FileStream(ZipPath, FileMode.Create);
            var gZip = new GZipStream(fsOutput, CompressionMode.Compress);
            var writer = new StreamWriter(gZip);
            writer.Write(history);
            writer.Close();
            gZip.Close();
            fsOutput.Close();
            MessageBox.Show(@"Pomyślnie zapisano historię.");
        }

        /// <summary>
        /// Metoda odtwarzajaca plik dzwiekowy z wybranej lokalizacji na dysku.
        /// Dzwiek odtwarzany kiedy uzytkownik sprobuje podzielic przez zero.
        /// </summary>
        public void LaughSoundGenerator()
        {
            var myPlayerEvilLaugh = new System.Media.SoundPlayer { SoundLocation = "evil_laugh.wav" };
            myPlayerEvilLaugh.PlaySync();
        }

        /// <summary>
        /// Image button - wlaczanie/wylaczenie dziekow przyciskow.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSoundOnOff_Click(object sender, EventArgs e)
        {
            _isSoundOn = _isSoundOn != true;
        }

        /// <summary>
        /// Obsługa przyciskóww numerycznych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNumbers_Click(object sender, EventArgs e)
        {
            if (_isSoundOn) Console.Beep(400, 30);
            if ((textBoxResult.Text == @"0") || (_isActiveOperation)) textBoxResult.Clear();
            _isActiveOperation = false;
            var button = (Button)sender;

            if (button.Text == @",")
            {
                if (!textBoxResult.Text.Contains(","))
                    textBoxResult.AppendText(button.Text);
            }
            else
            {
                textBoxResult.AppendText(button.Text);
            }

            if ((_activeOperation == "/") && (button.Text == @"0")) LaughSoundGenerator();

        }
        /// <summary>
        /// Obsługa przycisków do operacji matematycznych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonsOperators_Click(object sender, EventArgs e)
        {
            if (_isSoundOn) Console.Beep(400, 30);
            var button = (Button)sender;
            if (_resultValue != 0)
            {
                _resultValue = double.Parse(textBoxResult.Text);
                textBoxResult.Text = @"0";
                _activeOperation = button.Text;
                labelActualOperation.Text = _resultValue + @" " + _activeOperation;
                _isActiveOperation = true;
            }
            else
            {
                _resultValue = Double.Parse(textBoxResult.Text);
                _activeOperation = button.Text;
                labelActualOperation.Text = _resultValue + @" " + _activeOperation;
                _isActiveOperation = true;
            }
        }

        /// <summary>
        /// Przycisk wyłączający kalkulator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOFF_Click(object sender, EventArgs e)
        {
            Close();
            if (ActiveForm != null) ActiveForm.Visible = true;
        }

        /// <summary>
        /// Przycisk usuwający wprowadzoną liczbe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (_isSoundOn) Console.Beep(400, 30);
            textBoxResult.Text = @"0";
        }

        /// <summary>
        /// Przycisk usuwający wprowadzoną liczbę oraz dotychczasowy wynik.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (_isSoundOn) Console.Beep(400, 30);
            textBoxResult.Text = @"0";
            _resultValue = 0;
        }

        /// <summary>
        /// Obsługa przycisku = sluzacego do zatwierdzenia operacji matematycznej.
        /// W metodzie odbywa sie wybor funkcji odpowiadajacej danemu operatorowi matematycznemu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEqualsSign_Click(object sender, EventArgs e)
        {
            var isOperationLaunched = false;
            switch (_activeOperation)
            {
                case "+":
                    if (_resultValue != 0)
                    { textBoxHistory.AppendText(_resultValue + " " + _activeOperation + " " + textBoxResult.Text); isOperationLaunched = true; }
                    textBoxResult.Text = (_resultValue + double.Parse(textBoxResult.Text)).ToString(CultureInfo.InvariantCulture);
                    if (isOperationLaunched) textBoxHistory.AppendText(" = " + textBoxResult.Text);
                    textBoxHistory.AppendText(Environment.NewLine);
                    _isActiveOperation = true;
                    break;
                case "-":
                    if (_resultValue != 0)
                    { textBoxHistory.AppendText(_resultValue + " " + _activeOperation + " " + textBoxResult.Text); isOperationLaunched = true; }
                    textBoxResult.Text = (_resultValue - double.Parse(textBoxResult.Text)).ToString(CultureInfo.InvariantCulture);
                    if (isOperationLaunched) textBoxHistory.AppendText(" = " + textBoxResult.Text);
                    textBoxHistory.AppendText(Environment.NewLine);
                    _isActiveOperation = true;

                    break;
                case "*":
                    if (_resultValue != 0)
                    { textBoxHistory.AppendText(_resultValue + " " + _activeOperation + " " + textBoxResult.Text); isOperationLaunched = true; }
                    textBoxResult.Text = (_resultValue * double.Parse(textBoxResult.Text)).ToString(CultureInfo.InvariantCulture);
                    if (isOperationLaunched) textBoxHistory.AppendText(" = " + textBoxResult.Text);
                    textBoxHistory.AppendText(Environment.NewLine);
                    _isActiveOperation = true;
                    break;
                case "/":
                    if (_resultValue != 0)
                    { textBoxHistory.AppendText(_resultValue + " " + _activeOperation + " " + textBoxResult.Text); isOperationLaunched = true; }
                    textBoxResult.Text = (_resultValue / double.Parse(textBoxResult.Text)).ToString(CultureInfo.InvariantCulture);
                    if (isOperationLaunched) textBoxHistory.AppendText(" = " + textBoxResult.Text);
                    textBoxHistory.AppendText(Environment.NewLine);
                    _isActiveOperation = true;
                    break;
            }
            try
            {
                _resultValue = double.Parse(textBoxResult.Text);
            }
            catch (FormatException)
            {

            }
            labelActualOperation.Text = "";
            _history = textBoxHistory.Text;

        }

        /// <summary>
        /// Przycisk ktory powoduje przejscie do nowego okna - _mathematicaldefinitions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchDefinitions_Click(object sender, EventArgs e)
        {
            Visible = false;
            _mathematicaldefinitions.ShowDialog();
            if (_mathematicaldefinitions.IsAccessible == false) Visible = true;
        }

        private void buttonMathematicalCuriosities_Click(object sender, EventArgs e)
        {
            var mathematicalcuriosities = new MathematicalCuriosities();
            Visible = false;
            mathematicalcuriosities.ShowDialog();
            if (mathematicalcuriosities.IsAccessible == false) Visible = true;
        }

        /// <summary>
        /// Wywołanie metody zapisującej historię do skompresowanego pliku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveHistory_Click(object sender, EventArgs e)
        {
            WriteToFile(_history);
        }
        /// <summary>
        /// Wywolanie metody pobierajacej historie ze skompresowanego pliku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadHistory_Click(object sender, EventArgs e)
        {
            ReadFromFile(_history, textBoxHistory);
        }

        /// <summary>
        /// Czyszczenie okienka roboczego historii.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEraseHistory_Click(object sender, EventArgs e)
        {
            if (_isSoundOn) Console.Beep(200, 40);
            textBoxHistory.Clear();
        }

        /// <summary>
        /// Wyświetlanie informacji o tym jak posługiwa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"S - Zapis historii do pliku.
L - Odczyt historii z pliku.
Głośnik - SOUND ON / OFF.
C - Usuwa wprowadzoną, i nie objętą jeszcze żadną operacją matematyczną, liczbę.
AC - Jak wyżej + nie pamięta Ans - wynik poprzednich operacji nie wpływa na następne.
Gumka - Wymaż historię z okienka.");
        }
    }
}
