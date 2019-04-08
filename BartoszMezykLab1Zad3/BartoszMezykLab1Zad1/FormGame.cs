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
    public partial class FormGame : Form
    {
        /// <summary>
        /// Ilość upłyniętych w grze dni (1 dzień w grze to 1 sekunda w rzeczywistości)
        /// </summary>
        int days = 0;

        /// <summary>
        /// Ilość pieniędzy
        /// </summary>
        int money = 6000;

        /// <summary>
        /// Poziom zużycia sprzętu i mebli
        /// </summary>
        int equipmentExhaustion = 0;

        /// <summary>
        /// Poziom zadowolenia klientów
        /// </summary>
        float clientsGladness = 0;

        /// <summary>
        /// Poziom popularności restauracji
        /// </summary>
        int restaurantPopularity = 0;

        /// <summary>
        /// Punkty zmęczenia (zwiększane z każdym dniem)
        /// </summary>
        int fatiguePoints = 0;

        /// <summary>
        /// Zmęczenie właściciela (zwiększane z osiąganiem wielokrotności cyfry 2 punktów zmęczenia)
        /// </summary>
        float ownerFatigue = 0;

        /// <summary>
        /// Czy nastąpiła wygrana (jeśli tak to już nie będzie mogła w grze nastąpić porażka podczas kontynuowania rozgrywki)
        /// </summary>
        bool win = false;

        /// <summary>
        /// Ilość posiadanego sprzętu i mebli
        /// </summary>
        int amountOfEquipement = 0;

        /// <summary>
        /// Koszt dokupienia sprzętu i mebli
        /// </summary>
        int costEquipement = 200;

        /// <summary>
        /// Współczynnik opisujący zależność pomiędzy poziomem zużycia sprzętu i mebli, a zadowoleniem klientów (im wyższy poziom zużycia sprzętu i mebli, tym szybciej spada zadowolenie klientów)
        /// </summary>
        int relationshipEquipementExhaustionClientGladness = 0;

        /// <summary>
        /// Koszt naprawy sprzętui mebli
        /// </summary>
        int costRepair = 0;

        /// <summary>
        /// Poziom rozbudowania restauracji
        /// </summary>
        int levelRestaurant = 0;

        /// <summary>
        /// Koszt rozbudowania restauracji
        /// </summary>
        int costLevelUp = 30000;

        /// <summary>
        /// Punkty karne zapamiętywane, gdy poziom zadowolenia klientów jest równy 0
        /// </summary>
        int penaltyPoints = 0;

        /// <summary>
        /// Koszt urlopu na kempingu
        /// </summary>
        int costCampsite = 200;

        /// <summary>
        /// Koszt urlopu w hotelu
        /// </summary>
        int costHotel = 1000;

        /// <summary>
        /// Koszt promocji
        /// </summary>
        int costOffer = 100;

        /// <summary>
        /// Poziom wynajętego biura rachunkowego
        /// </summary>
        int levelAccountingOffice = 0;

        /// <summary>
        /// Koszt wynajęcia lepszego biura rachunkowego
        /// </summary>
        int costAccountingOffice = 6500;

        public FormGame()
        {
            InitializeComponent();

            // Ustawienie interwału timera na 1s
            timerTime.Interval = 1000;

            // Wyświetlenie ilości posiadanych pieniędzy (przydatne, gdy dla testów zmieniamy wartość zmiennej money i wtedy od razu widzimy ilość posiadanych pieniędzy)
            labelMoney.Text = "Pieniądze: "+money.ToString();
        }

        /// <summary>
        /// Funkcja timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            // Sprawdzenie, czy nastąpiła porażka (gdy poziom zadowolenia klientów jest równy 0 [czyli nie dostajemy więcej pieniędzy] oraz gdy nie stać nas na zakup sprzętu i mebli, rozbudowę restauracji oraz na promocję). Sprawdzenie to następuje tylko wtedy, gdy zmienna win ma wartość false, tzn. gdy jeszcze nie nastąpiła wygrana
            if (win == false) Lose();

            // Zwiększenie ilości dni
            days++;

            Revenue();

            AmountOfMoney();

            EquipmentExhaustion();

            Popularity();

            Fatigue();

            ShowRates();
        }

        /// <summary>
        /// Funkcja sprawdzająca, czy nie nastąpiła porażka
        /// </summary>
        private void Lose()
        {
            // Sprawdzenie, czy nie nastąpiła porażka (gdy poziom zadowolenia klientów jest równy 0 [czyli nie dostajemy więcej pieniędzy] oraz gdy nie stać nas na zakup sprzętu i mebli, rozbudowę restauracji oraz na promocję)
            if ((clientsGladness == 0) && (money < costEquipement) && (money < costLevelUp) && (money < costOffer))
            {
                // Zatrzymanie pracy timera
                timerTime.Stop();

                // Komunikat o porażce i pokazanie niektórych osiągniętych statystyk
                MessageBox.Show("Koniec gry. W " + days + " dni osiągnąłeś " + levelRestaurant + ". poziom rozbudowy restauracji i miałeś " + amountOfEquipement + " sprzętu i mebli. Zacznij ponownie :) ");

                // Zamknięcie aktywnego okna
                this.Close();
            }
        }

        /// <summary>
        /// Funkcja realizująca możliwość kontroli urzędu skarbowego
        /// </summary>
        private void Revenue()
        {
            // Zakres, w jakim musi mieścić się wylosowana liczba (zmienna int number), aby nastąpiła kontrola urzędu skarbowego (czym wyższy poziom biura rachunkowego, tym ten zakres niższy)
            int range = 0;

            // Kwota zabrana przez urząd skarbowy
            int revenueMoney;

            // Wylosowanie liczby potrzebnej do sprawdzenia, czy nastąpiła kontrola urzędu skarbowego
            Random x = new Random();
            int number = x.Next(1, 1001);

            // W zależności od poziomu biura rachunkowego zakres, w jakim musi mieścić się wylosowana liczba (zmienna number), aby nastąpiła kontrola urzędu skarbowego różni się
            switch (levelAccountingOffice)
            {
                case 0:
                    range = 20;
                    break;
                case 1:
                    range = 6;
                    break;
                case 2:
                    range = 1;
                    break;
                case 3:
                    range = 0;
                    break;
            }

            // Jeśli wylosowania liczba jest w wybranym wyżej przedziale
            if (number <= range)
            {
                // Kwota zabrana przez urząd skarbowy to 40% posiadanej ilości pieniędzy właściciela
                revenueMoney = (int)(money * 0.4);

                // Zmniejszenie ilości posiadanych pieniędzy o kwotę zabraną przez urząd skarbowy
                money -= revenueMoney;

                ShowRates();

                // Komunikat o okradzeniu i o zabranym procencie pieniędzy
                MessageBox.Show("Urząd skarbowy dopatrzył się nieprawidłowości w twoich zeznaniach podatkowych! Zostałeś ukarany i zabrano ci 40% pieniędzy (" + revenueMoney + " zł). Postaraj się wynająć lepsze biuro rachunkowe.");
            }
        }

        /// <summary>
        /// Funkcja zmieniająca ilość posiadanych pieniędzy
        /// </summary>
        private void AmountOfMoney()
        {
            // Ilość pieniędzy zależy od zadowolenia klientów, ilości sprzętu i mebli oraz poziomu popularności restauracji
            money += (int)((clientsGladness * amountOfEquipement * restaurantPopularity) / 2);
        }

        /// <summary>
        /// Funkcja zmieniająca poziom zużycia sprzętu i mebli
        /// </summary>
        private void EquipmentExhaustion()
        {
            // Poziom zużycia sprzętu i mebli może spadać tylko w przypadku, gdy poziom zadowolenia klientów jest większy od 0 (tzn. tylko wtedy, gdy ktoś do restauracji jeszcze chodzi)
            if (clientsGladness > 0)
            {
                // Zwiększenie poziomu zużycia sprzetu i mebli
                equipmentExhaustion += 3;

                // Jeśli poziom zużycia sprzętu i mebli jest większy od 100%, to wyrównanie jego poziomu do 100%
                if (equipmentExhaustion > 100) equipmentExhaustion = 100;

                // Zwiększenie współczynnika opisującego zależność pomiędzy poziomem zużycia sprzętu i mebli, a zadowoleniem klientów o wartość poziomu zużycia sprzętu i mebli (czym wyższy poziom zużycia sprzetu i mebli, tym ten współczynnik będzie szybciej rosnął, a co za tym idzie szybciej będzie spadał poziom zadowolenia klientów)
                relationshipEquipementExhaustionClientGladness += equipmentExhaustion;

                // Jeśli powyższy współczynnik jest większy od 90%, to następuje zmniejszenie poziomu zadowolenia
                if (relationshipEquipementExhaustionClientGladness >= 90)
                {
                    // Zmniejszenie poziomu zadowolenia klientów
                    clientsGladness--;

                    // Jeśli poziom zużycia sprzętu i mebli wynosi 100%, to dodatkowo zmniejszenie poziomu zadowolenia klientów o 1%
                    if (equipmentExhaustion == 100) clientsGladness--;

                    // Jeśli poziom zadowolenia klientów jest mniejszy niż 0, to wyrównanie jego poziomu do 0
                    if (clientsGladness < 0) clientsGladness = 0;

                    // Wyzerowanie współczynnika opisującego zależność pomiędzy poziomem zużycia sprzętu, a zadowoleniem klientów
                    relationshipEquipementExhaustionClientGladness = 0;
                }
            }
        }

        /// <summary>
        /// Funkcja zwiększająca poziom popularności restauracji
        /// </summary>
        private void Popularity()
        {
            // Zwiększenie punktów karnych, gdy poziom zadowolenia klientów podczas gry osiągnął wartość 0 (wtedy poziom popularności restauracji będzie maleć)
            if (clientsGladness == 0)
            {
                penaltyPoints++;
            }

            // Zwiększenie poziomu popularności restauracji w zależności od upłyniętych dni (niewielki wpływ - tylko co 1000 dni poziom popularności zwiększa się o 1%) oraz od poziomu rozbudowania restauracji (duży wpływ)
            switch (levelRestaurant)
            {
                case 1:
                    restaurantPopularity = 30;
                    break;
                case 2:
                    restaurantPopularity = 50;
                    break;
                case 3:
                    restaurantPopularity = 63;
                    break;
                case 4:
                    restaurantPopularity = 72;
                    break;
                case 5:
                    restaurantPopularity = 78;
                    break;
                case 6:
                    restaurantPopularity = 82;
                    break;
                case 7:
                    restaurantPopularity = 85;
                    break;
                case 8:
                    restaurantPopularity = 87;
                    break;
                case 9:
                    restaurantPopularity = 89;
                    break;
                case 10:
                    restaurantPopularity = 90;
                    break;
            }

            // Zwiększenie poziomu popularności restauracji w zależności od upłyniętych dni oraz zmniejszenie, jeśli są jakieś punkty karne
            restaurantPopularity = restaurantPopularity + (days / 1000) - penaltyPoints;

            // Jeśli poziom popularności restauracji jest większy od 100% (za sprawą upłyniętych dni) to wyrównanie jego poziomu do 100%
            if (restaurantPopularity > 100) restaurantPopularity = 100;
            // Jeśli poziom popularności restauracji jest natomiast mniejszy od 1% (za sprawą punktów karnych), to wyrównanie jego poziomu do 1%
            else if (restaurantPopularity < 1) restaurantPopularity = 1;
        }

        /// <summary>
        /// Funkcja zwiększająca poziom zmęczenia właściciela
        /// </summary>
        private void Fatigue()
        {
            // Zwiększenie punktów zmęczenia
            fatiguePoints++;

            // Z każdą wielokrotnością liczby 2 zmiennej fatiguePoints zwiększa się wartość zmiennej fatigue o 1
            if (fatiguePoints % 2 == 0) ownerFatigue += 1;

            // Jeśli poziom zmęcznia właściciela jest większy od 100% to wyrównanie jego poziomu do 100%
            if (ownerFatigue > 100) ownerFatigue = 100;
        }

        /// <summary>
        /// Funkcja aktualizująca wartości parametrów gracza
        /// </summary>
        private void ShowRates()
        {
            // Wyświetlenie ilości upłyniętych dni
            labelDays.Text = "Dzień: " + days.ToString();

            // Wyświetlenie ilości pieniędzy
            labelMoney.Text = "Pieniądze: " + money + " zł";

            // Wyświetlenie poziomu popularności restauracji
            labelRestaurantPopularity.Text = "Popularność restauracji: " + restaurantPopularity + "%";

            // Wyświetlenie poziomu zadowolenia klientów
            labelClientsGladness.Text = "Zadowolenie klientów: " + clientsGladness + "%";

            // Wyświetlenie poziomu zużycia sprzętu
            labelEquipementExhaustion.Text = "Zużycie sprzętu i mebli: " + equipmentExhaustion + "%";

            // Wyświetlenie poziomu zmęczenia właściciela
            labelOwnerFatigue.Text = "Zmęczenie właściciela: " + ownerFatigue + "%";

            // Wyświetlenie ilości posiadanego sprzętu i mebli
            labelEquipementAmount.Text = "Ilość sprzętu i mebli: " + amountOfEquipement;

            // Wyświetlenie poziomu wynajętego biura rachunkowego
            labelAccountingOfficeLevel.Text = "Poziom biura rachunkowego: " + levelAccountingOffice+"/3";
        }

        /// <summary>
        /// Funkcja aktualizująca napisy dotyczące kosztów kupna sprzętu i mebli, naprawy sprzętu i mebli oraz promocji
        /// </summary>
        private void StringsUpdate()
        {
            // Zaktualizowanie tekstu na przycisku dotyczącym dokupienia sprzętu i mebli o koszt jego dokupienia
            labelBuyEquipement.Text = "Kup sprzęt lub meble (" + costEquipement + " zł)";

            // Zaktualizowanie tekstu na przycisku dotyczącym naprawienia sprzętu i mebli o koszt jego naprawienia
            labelRepairEquipement.Text = "Napraw sprzęt lub meble (" + costRepair + " zł)";

            // Zaktualizowanie tekstu na przycisku dotyczącym promocji o koszt tej promocji
            labelMakeOffer.Text = "Zorganizuj promocję (" + costOffer + " zł)";
        }

        /// <summary>
        /// Funkcja zmniejszająca poziom zużycia sprzętu i mebli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRepairEquipement_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy ilość posiadanego sprzętu i mebli jest różna od 0 (czyli czy nie jest początek gry)
            if (amountOfEquipement != 0)
            {
                // Sprawdzenie, czy jest odpowiedni poziom zmęczenia właściciela
                if (ownerFatigue < 95)
                {
                    // Sprawdzenie, czy jest odpowiednia ilość pieniędzy
                    if (costRepair <= money)
                    {
                        // Zmniejszenie poziomu zużycia sprzętu i mebli o 50%
                        equipmentExhaustion -= 50;

                        // Jeśli poziom zużycia sprzętu i mebli jest mniejszy niż 0, to wyrównanie jego poziomu do 1%
                        if (equipmentExhaustion < 0) equipmentExhaustion = 0;

                        // Zmniejszenie posiadanej ilości pieniędzy o koszt naprawy sprzętu i mebli
                        money -= costRepair;

                        // Zwiększenie kosztu naprawy sprzętu i mebli w zależności od ilości posiadanego sprzętu i mebli i poziomu rozbudowy restauracji
                        costRepair = amountOfEquipement * 100 * (levelRestaurant + 1);

                        // Zwiększenie poziomu zadowolenia klientów o 1%
                        clientsGladness += 1;

                        // Jeśli poziom zadowolenia klientów jest większy od 100%, to wyrównanie jego poziomu do 100%
                        if (clientsGladness > 100) clientsGladness = 100;

                        StringsUpdate();

                        ShowRates();
                    }
                    // W przeciwnym wypadku wyświetlenie komunikatu
                    else
                    {
                        // Komunikat o niewystarczającej ilości pieniędzy
                        MessageBox.Show("Masz zbyt mało pieniędzy!");
                    }
                }
                // W przeciwnym wypadku wyświetlenie komunikatu
                else
                {
                    // Komunikat o zbyt wysokim poziomie zmęczenia właściciela
                    MessageBox.Show("Jesteś zbyt zmęczony, odpocznij.");
                }
            }
            // W przeciwnym wypadku wyświetlenie komunikatu
            else
            {
                // Komunikat o nie kupieniu żadnego sprzętu i mebli do restauracji
                MessageBox.Show("Najpierw kup sprzęt i meble do restauracji!");
            }
        }

        /// <summary>
        /// Funkcja powodująca rozbudowę restauracji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExtendRestaurant_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy ilość posiadanego sprzętu i mebli jest różna od 0 (czyli czy nie jest początek gry)
            if (amountOfEquipement != 0)
            {
                // Sprawdzenie, czy jest odpowiedni poziom zmęczenia właściciela
                if (ownerFatigue < 95)
                {
                    // Sprawdzenie, czy poziom rozbudowania restauracji jest mniejszy niż 10
                    if (levelRestaurant < 10)
                    {
                        // Sprawdzenie, czy jest odpowiednia ilość pieniędzy
                        if (costLevelUp <= money)
                        {
                            // Zwiększenie poziomu rozbudowy restauracji
                            levelRestaurant++;

                            // Zwiększenie wypełnienia paska progressbar dotyczącego poziomu rozbudowy restauracji
                            progressBarRestaurantLevel.Increment(1);

                            // Wyświetlenie poziomu rozbudowania restauracji
                            labelRestaurantLevel.Text = "Poziom rozbudowania restauracji: "+levelRestaurant.ToString()+"/10";

                            Popularity();

                            // Zmniejszenie ilości pieniędzy o koszt rozbudowy danego poziomu restauracji
                            money -= costLevelUp;

                            CostLevelUp();

                            // Zaktualizowanie ceny dotyczącej kosztu naprawy sprzętu i mebli w zależności od ilości posiadanego sprzętu i mebli i poziomu rozbudowy restauracji
                            costRepair = amountOfEquipement * 100 * (levelRestaurant + 1);

                            // Zaktualizowanie ceny dotyczącej promocji w zależności od ilości posiadanego sprzętu i mebli i poziomu rozbudowy restauracji
                            costOffer = amountOfEquipement * 100 * (levelRestaurant + 1);

                            StringsUpdate();

                            ShowRates();

                            // Jeśli poziom rozbudowy restauracji wynosi 10, to następuje wygrana
                            if (levelRestaurant == 10)
                            {
                                // Komunikat o wygranej i pokazanie niektórych osiągniętych statystyk
                                MessageBox.Show("Wygrałeś! W " + days + " dni osiągnąłeś najwyższy " + levelRestaurant + ". poziom rozbudowy restauracji i miałeś " + amountOfEquipement + " sprzętu i mebli w restauracji. Kontynuuj lub zacznij ponownie :) ");

                                // Nastąpiła wygrana, więc zmienna przyjmuje teraz wartość true (już nie będzie mogła wystąpić porażka w tej rozgrywce)
                                win = true;
                            }
                        }
                        // W przeciwnym wypadku wyświetlenie komunikatu
                        else
                        {
                            // Komunikat o niewystarczającej ilości pieniędzy
                            MessageBox.Show("Masz zbyt mało pieniędzy!");
                        }
                    }
                    // W przeciwnym wypadku wyświetlenie komunikatu
                    else
                    {
                        // Komunikat o osiągnięciu maksymalnego poziomu rozbudowy restauracji
                        MessageBox.Show("Osiągnąłeś maksymalny poziom rozbudowy restauracji!");
                    }
                }
                // W przeciwnym wypadku wyświetlenie komunikatu
                else
                {
                    // Komunikat o zbyt wysokim poziomie zmęczenia właściciela
                    MessageBox.Show("Jesteś zbyt zmęczony, odpocznij.");
                }
            }
            // W przeciwnym wypadku wyświetlenie komunikatu
            else
            {
                // Komunikat o nie kupieniu żadnego sprzętu i mebli do restauracji
                MessageBox.Show("Najpierw kup sprzęt i meble do restauracji!");
            }
        }

        /// <summary>
        /// Funkcja zmieniająca koszt rozbudowy kolejnego poziomu restauracji
        /// </summary>
        private void CostLevelUp()
        {
            // Koszt rozbudowy kolejnego poziomu restauracji w zależności od aktualnego poziomu rozbudowy restauracji
            switch (levelRestaurant)
            {
                case 1:
                    costLevelUp = 100000;
                    break;
                case 2:
                    costLevelUp = 200000;
                    break;
                case 3:
                    costLevelUp = 500000;
                    break;
                case 4:
                    costLevelUp = 1000000;
                    break;
                case 5:
                    costLevelUp = 2500000;
                    break;
                case 6:
                    costLevelUp = 5000000;
                    break;
                case 7:
                    costLevelUp = 10000000;
                    break;
                case 8:
                    costLevelUp = 30000000;
                    break;
                case 9:
                    costLevelUp = 100000000;
                    break;
            }

            // Zaktualizowanie tekstu nad pictureBox'em w przypadku, gdy poziom rozbudowy restauracji jest równy 10
            if (levelRestaurant == 10)
            {
                // Zmiana napisu dotyczącego poziomu rozbudowy restauracji
                labelExtendRestaurant.Text = "MAKSYMALNY POZIOM";

                // Wyłączenie pictureBox'a
                pictureBoxExtendRestaurant.Enabled = false;
            }
            // W przeciwnym wypadku zaktualizowanie tekstu nad pictureBox'em dotyczącym rozbudowy restauracji o koszt kolejnej rozbudowy
            else
            {
                labelExtendRestaurant.Text = "Rozbuduj restaurację (" + costLevelUp + " zł)";
            }
        }

        /// <summary>
        /// Funkcja realizująca napad w zależności od miejsca pobytu w czasie urlopu
        /// </summary>
        /// <param name=""></param>
        private void Robbery(int kind)
        {
            // Ukradziony procent pieniędzy (losowany w instrukcji switch() ) (poniżej jest wartość 0, ponieważ jeśli nie dojdzie do rabunku, to 0 po podzieleniu przez 100 będzie równe 0, więc ilość ukradzionych pieniędzy będzie równa 0)
            float stole = 0;

            // Ilość ukradzionych pieniędzy
            int stolenMoney = 0;

            // Wylosowanie wartości zmiennej z przedziału od 0 do 100 (od niej będzie zależało, czy gracz został okradziony)
            Random x = new Random();
            int robbery = x.Next(100);

            // W zależności od miejsca spędzania urlopu jest różne prawdopodobieństwo okradzenia
            switch (kind)
            {
                // Miejsce urlopu - kemping
                case 1:
                    // W przypadku kempingu prawdopodobieństwo okradzenia to 30%
                    if (robbery < 30)
                    {
                        // Wylosowanie procentu posiadanej ilości pieniędzy, jaką ukradł złodziej (z zakresu 1 do 50%)
                        Random y = new Random();
                        stole = y.Next(1, 50);

                        // Obliczenie kwoty ukradzionej przez złodzieja
                        stolenMoney = (int)(money * (stole / 100));

                        // Odjęcie ukradzionej kwoty od posiadanej ilości pieniędzy
                        money -= stolenMoney;

                        // Komunikat o okradzeniu i o zabranym procencie pieniędzy
                        MessageBox.Show("Zostałeś okradziony! Złodziej zabrał Ci " + stole + "% pieniędzy (" + stolenMoney + " zł).");
                    }
                    break;
                // Miejsce urlopu - hotel
                case 2:
                    // W przypadku hotelu prawdopodobieństwo okradzenia to 5%
                    if (robbery < 5)
                    {
                        // Wylosowanie procentu posiadanej ilości pieniędzy, jaką ukradł złodziej (z zakresu 1 do 40%)
                        Random y = new Random();
                        stole = y.Next(1, 40);

                        // Obliczenie kwoty ukradzionej przez złodzieja
                        stolenMoney = (int)(money * (stole / 100));

                        // Odjęcie ukradzionej kwoty od posiadanej ilości pieniędzy
                        money -= stolenMoney;

                        // Komunikat o okradzeniu i o zabranym procencie pieniędzy
                        MessageBox.Show("Zostałeś okradziony! Złodziej zabrał Ci " + stole + "% pieniędzy (" + stolenMoney + " zł).");
                    }
                    break;
            }
            AmountOfMoney();

            ShowRates();
        }

        /// <summary>
        /// Funkcja realizująca zorganizowanie promocji, co podnosi poziom zadowolenia klientów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMakeOffer_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy ilość posiadanego sprzętu i mebli jest różna od 0 (czyli czy nie jest początek gry)
            if (amountOfEquipement != 0)
            {
                // Sprawdzenie, czy jest odpowiedni poziom zmęczenia właściciela
                if (ownerFatigue < 95)
                {
                    // Sprawdzenie, czy jest odpowiednia ilość pieniędzy
                    if (costOffer <= money)
                    {
                        // Zwiększenie poziomu zadowolenia klientów
                        clientsGladness += 30;

                        // Jeśli poziom zadowolenia jest większy od 100%, to wyrównanie jego poziomu do 100%
                        if (clientsGladness > 100) clientsGladness = 100;

                        // Zmniejszenie posiadanej ilości pieniędzy o koszt promocji
                        money -= costOffer;

                        ShowRates();
                    }
                    // W przeciwnym wypadku wyświetlenie komunikatu
                    else
                    {
                        // Komunikat o niewystarczającej ilości pieniędzy
                        MessageBox.Show("Masz zbyt mało pieniędzy!");
                    }
                }
                // W przeciwnym wypadku wyświetlenie komunikatu
                else
                {
                    // Komunikat o zbyt wysokim poziomie zmęczenia właściciela
                    MessageBox.Show("Jesteś zbyt zmęczony, odpocznij.");
                }
            }
            // W przeciwnym wypadku wyświetlenie komunikatu
            else
            {
                // Komunikat o nie kupieniu żadnego sprzętu i mebli do restauracji
                MessageBox.Show("Najpierw kup sprzęt i meble do restauracji!");
            }
        }

        /// <summary>
        /// Funkcja realizująca zwiększenie poziomu biura rachunkowego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxHireAccountingOffice_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy ilość posiadanego sprzętu jest różna od 0 (czyli czy nie jest początek gry)
            if (amountOfEquipement != 0)
            {
                // Sprawdzenie, czy jest odpowiedni poziom zmęczenia właściciela
                if (ownerFatigue < 95)
                {
                    // Możliwość zwiększenia poziomu biura rachunkowego tylko w przypadku, gdy jego wartość nie jest równa 3
                    if (levelAccountingOffice != 3)
                    {
                        // Sprawdzenie, czy jest odpowiednia ilość pieniędzy
                        if (costAccountingOffice <= money)
                        {
                            // Zwiększenie poziomu wynajętego biura rachunkowego
                            levelAccountingOffice++;

                            // Zmniejszenie posiadanej ilości pieniędzy
                            money -= costAccountingOffice;

                            ShowRates();

                            // Zmiana kosztu wynajęcia kolejnego poziomu biura rachunkowego w zależności od aktualnego poziomu wynajętego biura
                            if (levelAccountingOffice == 1)
                            {
                                // Zmiana kosztu wynajęcia biura rachunkowego na poziomie 2
                                costAccountingOffice = 20000;

                                // Zaktualizowanie tekstu na przycisku dotyczącym zwiększenia poziomu biura rachunkowego o koszt jego zwiększenia na poziom 2
                                labelHireAccountingOffice.Text = "Wynajmij lepsze biuro rachunkowe (" + costAccountingOffice + " zł)";
                            }
                            else if (levelAccountingOffice == 2)
                            {
                                // Zmiana kosztu wynajęcia biura rachunkowego na poziomie 3
                                costAccountingOffice = 100000;

                                // Zaktualizowanie tekstu na przycisku dotyczącym zwiększenia poziomu biura rachunkowego o koszt jego zwiększenia na poziom 3
                                labelHireAccountingOffice.Text = "Zwiększ poziom biura rachunkowego (" + costAccountingOffice + " zł)";
                            }
                            else
                            {
                                // Zaktualizowanie tekstu na przycisku dotyczącym zwiększenia poziomu biura rachunkowego o koszt tego zwiększenia
                                labelHireAccountingOffice.Text = "MAKSYMALNY POZIOM";

                                // Wyłączenie pictureBox'a odpowiedzialnego za podniesienie poziomu wynajętego biura rachunkowego
                                pictureBoxHireAccountingOffice.Enabled = false;
                            }

                            // Zwiększenie wypełnienia paska progressbar
                            progressBarAccountingOfficeLevel.Increment(1);
                        }
                        else
                        {
                            // Komunikat o niewystarczającej ilości pieniędzy
                            MessageBox.Show("Masz zbyt mało pieniędzy!");
                        }
                    }
                    // W przeciwnym wypadku wyświetlenie komunikatu
                    else
                    {
                        // Komunikat o osiągnięciu maksymalnego poziomu biura rachunkowego
                        MessageBox.Show("Osiągnąłeś maksymalny poziom biura rachunkowego!");
                    }
                }
                // W przeciwnym wypadku wyświetlenie komunikatu
                else
                {
                    // Komunikat o zbyt wysokim poziomie zmęczenia właściciela
                    MessageBox.Show("Jesteś zbyt zmęczony, odpocznij.");
                }
            }
            // W przeciwnym wypadku wyświetlenie komunikatu
            else
            {
                // Komunikat o nie kupieniu żadnego sprzętu i mebli do restauracji
                MessageBox.Show("Najpierw kup sprzęt i meble do restauracji!");
            }
        }

        /// <summary>
        /// Funkcja realizująca procedurę odpoczynku na kempingu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRestCampsite_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy ilość posiadanego sprzętu i mebli jest różna od 0 (czyli czy nie jest początek gry)
            if (amountOfEquipement != 0)
            {
                // Sprawdzenie, czy jest odpowiednia ilość pieniędzy
                if (costCampsite <= money)
                {
                    // Wylosowanie wartości zmiennej z przedziału od 70 do 90 (od niej będzie zależeć o ile odpoczniemy)
                    Random x = new Random();
                    double decreaseFatigue = x.Next(70, 90);

                    // Zmniejszenie zmęczenia poprzez wymnożenie poprzedniej wartości zmęczenia razy wartość z zakresu 0.7 do 0.9 (aby zmęczenie nie spadło całkowicie)
                    ownerFatigue = ownerFatigue - (int)(ownerFatigue * (decreaseFatigue / 100));

                    // Wyzerowanie punktów zmęczenia 
                    fatiguePoints = 0;

                    // Zmniejszenie ilości pieniędzy o koszt pobytu na kempingu
                    money -= costCampsite;

                    // Zwiększenie kosztu kolejnego pobytu na kempingu
                    costCampsite += 100 + (levelRestaurant * 400);

                    // Zaktualizowanie tekstu na napisie dotyczącym urlopu na kempingu o jego koszt
                    labelCampsiteRest.Text = "Odpocznij na kempingu (" + costCampsite + " zł)";

                    // Zwiększenie ilości upłyniętych w grze dni
                    days += 3;

                    ShowRates();

                    // Sprawdzenie, czy nie zostaliśmy napadnięci (cyfra 1 jako argument oznacza, że miejscem pobytu jest kemping)
                    Robbery(1);
                }
                else
                {
                    // Komunikat o niewystarczającej ilości pieniędzy
                    MessageBox.Show("Masz zbyt mało pieniędzy!");
                }
            }
            // W przeciwnym wypadku wyświetlenie komunikatu
            else
            {
                // Komunikat o nie kupieniu żadnego sprzętu i mebli do restauracji
                MessageBox.Show("Najpierw kup sprzęt i meble do restauracji!");
            }
        }

        /// <summary>
        /// Funkcja realizująca procedurę odpoczynku w hotelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRestHotel_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy ilość posiadanego sprzętu i mebli jest różna od 0 (czyli czy nie jest początek gry)
            if (amountOfEquipement != 0)
            {
                // Sprawdzenie, czy jest odpowiednia ilość pieniędzy
                if (costHotel <= money)
                {
                    // Wylosowanie wartości zmiennej z przedziału od 90 do 100 (od niej będzie zależeć o ile odpoczniemy)
                    Random x = new Random();
                    double decreaseFatigue = x.Next(90, 100);

                    // Zmniejszenie zmęczenia poprzez wymnożenie poprzedniej wartości zmęczenia razy wartość z zakresu 0.9 do 1.0 (aby zmęczenie nie spadło całkowicie)
                    ownerFatigue = ownerFatigue - (int)(ownerFatigue * (decreaseFatigue / 100));

                    // Wyzerowanie punktów zmęczenia 
                    fatiguePoints = 0;

                    // Zmniejszenie ilości pieniędzy o koszt pobytu w hotelu
                    money -= costHotel;

                    // Zwiększenie kosztu kolejnego pobytu w hotelu
                    costHotel += 400 + (levelRestaurant * 1000);

                    // Zaktualizowanie tekstu na napisie dotyczącym urlopu w hotelu o jego koszt
                    labelHotelRest.Text = "Odpocznij w hotelu (" + costHotel + " zł)";

                    // Zwiększenie ilości upłyniętych w grze dni
                    days += 5;

                    ShowRates();

                    // Sprawdzenie, czy nie zostaliśmy napadnięci (cyfra 2 jako argument oznacza, że miejscem pobytu jest hotel)
                    Robbery(2);
                }
                else
                {
                    // Komunikat o niewystarczającej ilości pieniędzy
                    MessageBox.Show("Masz zbyt mało pieniędzy!");
                }
            }
            // W przeciwnym wypadku wyświetlenie komunikatu
            else
            {
                // Komunikat o nie kupieniu żadnego sprzętu i mebli do restauracji
                MessageBox.Show("Najpierw kup sprzęt i meble do restauracji!");
            }
        }

        /// <summary>
        /// Funkcja zwiększająca ilość posiadanego sprzętu po kliknięciu na odpowiedni pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBuyEquip_Click(object sender, EventArgs e)
        {
            // Jeśli naciśnięto pierwszy raz, to rozpoczęcie pracy timera (po pierwszym kliknięciu zmienna amountOfEquipement ma wartość 1 i ten if już się nigdy nie wykona)
            if (amountOfEquipement == 0)
            {
                // Rozpoczęcie pracy timera
                timerTime.Start();

                // Zmiana poziomu popularności restauracji na 1%
                restaurantPopularity = 1;
            }

            // Sprawdzenie, czy jest odpowiedni poziom zmęczenia właściciela
            if (ownerFatigue < 95)
            {
                // Sprawdzenie, czy jest odpowiednia ilość pieniędzy
                if (costEquipement <= money)
                {
                    // Zwiększenie ilości posiadanego sprzętu i mebli
                    amountOfEquipement++;

                    // Zmniejszenie posiadanej ilości pieniędzy o koszt dokupionego sprzętu i mebli
                    money -= costEquipement;

                    // Zwiększenie poziomu zadowolenia klientów o 2%
                    clientsGladness += 2;

                    // Jeśli poziom zadowolenia klientów jest większy od 100%, to wyrównanie jego poziomu do 100%
                    if (clientsGladness > 100) clientsGladness = 100;

                    ShowRates();

                    // Zwiększenie kosztu dokupienia sprzętu i mebli w zależności od ilości posiadanego już sprzętu i mebli
                    costEquipement += amountOfEquipement * 150;

                    // Zaktualizowanie ceny dotyczącej kosztu naprawy sprzętu i mebli oraz ceny dotyczącej promocji w zależności od ilości posiadanego sprzętu i mebli i poziomu rozbudowy restauracji
                    costRepair = costOffer = amountOfEquipement * 100 * (levelRestaurant + 1);

                    StringsUpdate();
                }
                // W przeciwnym wypadku wyświetlenie komunikatu
                else
                {
                    // Komunikat o niewystarczającej ilości pieniędzy
                    MessageBox.Show("Masz zbyt mało pieniędzy!");
                }
            }
            // W przeciwnym wypadku wyświetlenie komunikatu
            else
            {
                // Komunikat o zbyt wysokim poziomie zmęczenia
                MessageBox.Show("Jesteś zbyt zmęczony, odpocznij.");
            }
        }
    }
}
