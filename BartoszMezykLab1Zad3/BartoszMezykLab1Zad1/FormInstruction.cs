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
    public partial class FormInstruction : Form
    {
        public FormInstruction()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja zamykająca instrukcję
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Zamknięcie instrukcji
            this.Close();
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego wyjścia z instrukcji na nowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Goldenrod;
        }

        /// <summary>
        /// Funkcja zmieniająca kolor przycisku dotyczącego wyjścia z instrukcji na początkowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Gold;
        }
    }
}
