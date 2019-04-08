using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszMezykLab1
{
    public partial class FormName : Form
    {
        // Zmienna do której będziemy dodawać wartość z textBoxNumber
        int counter;

        // Zmienna zwiększająca swoją wartość w zależności od ilości upłyniętych sekund w timerCounter
        int timerValue=0;

        // Zmienna do stworzenia nowego okna
        FormAbout formAbout;

        /// <summary>
        /// Okno główne
        /// </summary>
        public FormName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja zamykająca okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Zamykanie okna
            Close();
        }

        /// <summary>
        /// Funkcja zmieniająca kolor tła przycisku buttonClose oraz okna FormName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            // Zmiana koloru przycisku
            buttonClose.BackColor = Color.Red;

            // Zmiana koloru okna
            BackColor = SystemColors.HotTrack;
        }

        /// <summary>
        /// Funkcja zmieniająca napis imię i nazwisko na numer zajęć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            // Zmiana napisu
            labelName.Text = "Laboratorium 1";
        }

        /// <summary>
        /// Funkcja pobierająca wartość z testBoxNumber i wyświetlająca na ekranie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Przypisanie nowej wartości z textBoxNumber
            int newNamber = Int32.Parse(textBoxNumber.Text);

            // Zwiększenie wartości zmiennej counter o wartość z textBoxNumber
            counter += newNamber;

            // Wyświetlenie aktualnej wartości zmiennej counter w textBoxShowNumber
            textBoxShowNumber.Text = counter.ToString() ;

            // Jeśli wartość zmiennej counter jest większa niż 5, to wyświetlenie odpowiedniego komunikatu i zmiana koloru tła
            if (counter>5)
            {
                // Komunikat
                MessageBox.Show("Wartość jest większa niż 5");

                // Zmiana koloru tła
                BackColor = SystemColors.ControlDark;
            }
        }

        /// <summary>
        /// Funkcja obsługująca pracę timerCounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            // Zwiększenie wartości zmiennej
            timerValue++;

            // Wyświetlenie wartości zmiennej timerValue w textBoxShowTimer
            textBoxShowTimer.Text = timerValue.ToString();

            // Zmiana rozmiaru przycisku buttonClose
            buttonClose.Height = buttonClose.Height + 1;
            buttonClose.Width = buttonClose.Width + 2;
        }

        /// <summary>
        /// Funkcja włączająca timerCounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRunTimer_Click(object sender, EventArgs e)
        {
            // Włączenie timerCounter
            timerCounter.Start();
        }

        /// <summary>
        /// Funkcja tworząca i wyświetlająca nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            // Stworzenie i wyświetlenie nowego okna
            formAbout = new FormAbout();
            formAbout.Show();
        }
    }
}
