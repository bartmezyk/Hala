using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszMezykLab1Zad1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja otwierająca okno z grą właściwą
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            // Otwarcie okna z grą właściwą
            FormGame formGame = new FormGame();
            formGame.Show();
        }

        /// <summary>
        /// Funkcja otwierająca okno z instrukcją gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            // Otwarcie okna z instrukcją gry
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.Show();
        }

        /// <summary>
        /// Funkcja zamykająca grę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Zamknięcie gry
            Close();
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego uruchomienia nowej gry na nowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_MouseEnter(object sender, EventArgs e)
        {
            buttonNewGame.BackColor = Color.Goldenrod;
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego uruchomienia nowej gry na początkowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_MouseLeave(object sender, EventArgs e)
        {
            buttonNewGame.BackColor = Color.Gold;
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego uruchomienia instrukcji na nowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstruction_MouseEnter(object sender, EventArgs e)
        {
            buttonInstruction.BackColor = Color.Goldenrod;
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego uruchomienia instrukcji na początkowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstruction_MouseLeave(object sender, EventArgs e)
        {
            buttonInstruction.BackColor = Color.Gold;
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego wyjścia z gry na nowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Goldenrod;
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego wyjścia z gry na początkowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Gold;
        }
    }
}
