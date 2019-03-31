using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Speech.Synthesis;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Globalization;

namespace Matematyka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string imie;
        int x = 0, y = 0;
        bool dodawanie_bool = false;
        bool odejmowanie_bool = false;
        bool mnozenie_bool = false;
        bool dzielenie_bool = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Mojeimie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                WidocznoscDzialan();
                imie = ((sender as TextBox).Text.ToString());
                Przywitanie();
            }
        }

        private void WidocznoscDzialan()
        {
            easydzielenie.Visibility = Visibility.Hidden;
            normaldzielenie.Visibility = Visibility.Hidden;
            harddzielenie.Visibility = Visibility.Hidden;
            easymnozenie.Visibility = Visibility.Hidden;
            normalmnozenie.Visibility = Visibility.Hidden;
            hardmnozenie.Visibility = Visibility.Hidden;
            easydodawanie.Visibility = Visibility.Hidden;
            normaldodawanie.Visibility = Visibility.Hidden;
            harddodawanie.Visibility = Visibility.Hidden;
            easyodejowanie.Visibility = Visibility.Hidden;
            normalodejmowanie.Visibility = Visibility.Hidden;
            hardodejmowanie.Visibility = Visibility.Hidden;
            zadanie.Visibility = Visibility.Hidden;
            exercise.Visibility = Visibility.Hidden;
            score.Visibility = Visibility.Hidden;
            wynik.Visibility = Visibility.Hidden;
            potwierdz.Visibility = Visibility.Hidden;
            wynik1.Visibility = Visibility.Hidden;
            kontynuuj.Visibility = Visibility.Hidden;
            dzialanie.Visibility = 0;
            dodawanie.Visibility = 0;
            odejmowanie.Visibility = 0;
            mnozenie.Visibility = 0;
            dzielenie.Visibility = 0;
        }

       private void WidocznoscZadania()
        {
            easydzielenie.Visibility = Visibility.Hidden;
            normaldzielenie.Visibility = Visibility.Hidden;
            harddzielenie.Visibility = Visibility.Hidden;
            easymnozenie.Visibility = Visibility.Hidden;
            normalmnozenie.Visibility = Visibility.Hidden;
            hardmnozenie.Visibility = Visibility.Hidden;
            easydodawanie.Visibility = Visibility.Hidden;
            normaldodawanie.Visibility = Visibility.Hidden;
            harddodawanie.Visibility = Visibility.Hidden;
            easyodejowanie.Visibility = Visibility.Hidden;
            normalodejmowanie.Visibility = Visibility.Hidden;
            hardodejmowanie.Visibility = Visibility.Hidden;
            zadanie.Visibility = Visibility.Hidden;
            exercise.Visibility = Visibility.Hidden;
            score.Visibility = Visibility.Hidden;
            wynik.Visibility = Visibility.Hidden;
            potwierdz.Visibility = Visibility.Hidden;
            wynik1.Visibility = Visibility.Hidden;
            kontynuuj.Visibility = Visibility.Hidden;
            odejmowanie_bool = false;
            mnozenie_bool = false;
            dzielenie_bool = false;
            dodawanie_bool = false;
            level.Visibility = 0;
        }

        private void WidocznoscDzialanEnd()
        {
            zadanie.Visibility = 0;
            exercise.Visibility = 0;
            score.Visibility = 0;
            wynik.Visibility = 0;
            potwierdz.Visibility = 0;
            potwierdz.IsEnabled = true;
            score.Text = "";
        }

        public void Przywitanie()
        {
            SpeechSynthesizer podaneimie = new SpeechSynthesizer();
            CultureInfo polska = new CultureInfo("pl-PL", false);
            podaneimie.GetInstalledVoices(polska);
            podaneimie.Speak("Cześć" + imie + "      " + ",wybierz zadanko");
        }

        private void Dodawanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscZadania();
            easydodawanie.Visibility = 0;
            normaldodawanie.Visibility = 0;
            harddodawanie.Visibility = 0;
            dodawanie_bool = true;
            SpeechSynthesizer dodawanie = new SpeechSynthesizer();
            if (imie == "Ala" | imie == "Alicja" | imie == "Beata" | imie == "Beatka")
            {
                dodawanie.Speak("Wybrałaś dodawanie, ustaw poziom trudności");
            }
            else
                dodawanie.Speak("Wybrałeś dodawanie, ustaw poziom trudności");
        }

        private void Odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscZadania();
            easyodejowanie.Visibility = 0;
            normalodejmowanie.Visibility = 0;
            hardodejmowanie.Visibility = 0;
            odejmowanie_bool = true;
            SpeechSynthesizer odejmowanie = new SpeechSynthesizer();
            if (imie == "Ala" | imie == "Alicja" | imie == "Beata" | imie == "Beatka")
            {
                odejmowanie.Speak("Wybrałaś odejmowanie, ustaw poziom trudności");
            }
            else
                odejmowanie.Speak("Wybrałeś odejmowanie, ustaw poziom trudności");
        }

        private void Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscZadania();
            easymnozenie.Visibility = 0;
            normalmnozenie.Visibility = 0;
            hardmnozenie.Visibility = 0;
            mnozenie_bool = true;
            SpeechSynthesizer mnozenie = new SpeechSynthesizer();
            if (imie == "Ala" | imie == "Alicja" | imie == "Beata" | imie == "Beatka")
            {
                mnozenie.Speak("Wybrałaś mnożenie, ustaw poziom trudności");
            }
            else
                mnozenie.Speak("Wybrałeś mnożenie, ustaw poziom trudności");
        }

        private void Dzielenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscZadania();
            easydzielenie.Visibility = 0;
            normaldzielenie.Visibility = 0;
            harddzielenie.Visibility = 0;
            dzielenie_bool = true;
            SpeechSynthesizer dzielenie = new SpeechSynthesizer();
            if (imie == "Ala" | imie == "Alicja" | imie == "Beata" | imie == "Beatka")
            {
                dzielenie.Speak("Wybrałaś dzielenie, ustaw poziom trudności");
            }
            else
                dzielenie.Speak("Wybrałeś dzielenie, ustaw poziom trudności");
        }

        public string DodawanieEasy()
        {
            Dzialania dodawanie1 = new Dzialania();
            x = dodawanie1.DanaEasyDodawanie();
            Thread.Sleep(100);
            Dzialania dodawanie2 = new Dzialania();
            y = dodawanie2.DanaEasyDodawanie();
            return (x.ToString() + " + " + y.ToString());
        }

        public string DodawanieNormal()
        {
            Dzialania dodawanie1 = new Dzialania();
            x = dodawanie1.DanaNormalDodawanie();
            Thread.Sleep(100);
            Dzialania dodawanie2 = new Dzialania();
            y = dodawanie2.DanaNormalDodawanie();
            return (x.ToString() + " + " + y.ToString());
        }

        public string DodawanieHard()
        {
            Dzialania dodawanie1 = new Dzialania();
            x = dodawanie1.DanaHardDodawanie();
            Thread.Sleep(100);
            Dzialania dodawanie2 = new Dzialania();
            y = dodawanie2.DanaHardDodawanie();
            return (x.ToString() + " + " + y.ToString());
        }

        public string OdejmowanieEasy()
        {
            Dzialania odejmowanie1 = new Dzialania();
            x = odejmowanie1.Dana1EasyOdejmowanie();
            Thread.Sleep(100);
            Dzialania odejmowanie2 = new Dzialania();
            y = odejmowanie2.Dana2EasyOdejmowanie();
            return (x.ToString() + " - " + y.ToString());
        }

        public string OdejmowanieNormal()
        {
            Dzialania odejmowanie1 = new Dzialania();
            x = odejmowanie1.Dana1NormalOdejmowanie();
            Thread.Sleep(100);
            Dzialania odejmowanie2 = new Dzialania();
            y = odejmowanie2.Dana2NormalOdejmowanie();
            return (x.ToString() + " - " + y.ToString());
        }

        public string OdejmowanieHard()
        {
            Dzialania odejmowanie1 = new Dzialania();
            x = odejmowanie1.Dana1HardOdejmowanie();
            Thread.Sleep(100);
            Dzialania odejmowanie2 = new Dzialania();
            y = odejmowanie2.Dana2HardOdejmowanie();
            return (x.ToString() + " - " + y.ToString());
        }

        public string MnozenieEasy()
        {
            Dzialania mnozenie1 = new Dzialania();
            x = mnozenie1.DanaEasyMnozenie();
            Thread.Sleep(100);
            Dzialania mnozenie2 = new Dzialania();
            y = mnozenie2.DanaEasyMnozenie();
            return (x.ToString() + " * " + y.ToString());
        }

        public string MnozenieNormal()
        {
            Dzialania mnozenie1 = new Dzialania();
            x = mnozenie1.DanaNormalMnozenie();
            Thread.Sleep(100);
            Dzialania mnozenie2 = new Dzialania();
            y = mnozenie2.DanaNormalMnozenie();
            return (x.ToString() + " * " + y.ToString());
        }

        public string MnozenieHard()
        {
            Dzialania mnozenie1 = new Dzialania();
            x = mnozenie1.DanaHardMnozenie();
            Thread.Sleep(100);
            Dzialania mnozenie2 = new Dzialania();
            y = mnozenie2.DanaHardMnozenie();
            return (x.ToString() + " * " + y.ToString());
        }

        public string DzielenieEasy()
        {
            Start:
            do
            {
                Dzialania dzielenie1 = new Dzialania();
                x = dzielenie1.Dana1EasyDzielenie();
                Thread.Sleep(100);
                Dzialania dzielenie2 = new Dzialania();
                y = dzielenie2.Dana2EasyDzielenie();
                if (x % y == 0)
                {
                    return (x.ToString() + " / " + y.ToString());
                }
            } while (x % y == 0);
            goto Start;
        }

        public string DzielenieNormal()
        {
            Start:
            do
            {
                Dzialania dzielenie1 = new Dzialania();
                x = dzielenie1.Dana1NormalDzielenie();
                Thread.Sleep(100);
                Dzialania dzielenie2 = new Dzialania();
                y = dzielenie2.Dana2NormalDzielenie();
                if (x % y == 0)
                {
                    return (x.ToString() + " / " + y.ToString());
                }
            } while (x % y == 0);
            goto Start;
        }

        public string DzielenieHard()
        {
            Start:
            do
            {
                Dzialania dzielenie1 = new Dzialania();
                x = dzielenie1.Dana1HardDzielenie();
                Thread.Sleep(100);
                Dzialania dzielenie2 = new Dzialania();
                y = dzielenie2.Dana2HardDzielenie();
                if (x % y == 0)
                {
                    return (x.ToString() + " / " + y.ToString());
                }
            } while (x % y == 0);
            goto Start;
        }

        private void Easydodawanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = DodawanieEasy();
        }

        private void Normaldodawanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = DodawanieNormal();
        }

        private void Harddodawanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = DodawanieHard();
        }

        private void Easyodejowanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = OdejmowanieEasy();
        }

        private void Normalodejmowanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = OdejmowanieNormal();
        }

        private void Hardodejmowanie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = OdejmowanieHard();
        }

        private void Easymnozenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = MnozenieEasy();
        }

        private void Normalmnozenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = MnozenieNormal();
        }

        private void Hardmnozenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = MnozenieHard();
        }

        private void Easydzielenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = DzielenieEasy();
        }

        private void Normaldzielenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = DzielenieNormal();
        }

        private void Harddzielenie_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscDzialanEnd();
            exercise.Content = DzielenieHard();
        }

        private void Nowa_gra_Click(object sender, RoutedEventArgs e)
        {
            WidocznoscZadania();
            dodawanie.Visibility = Visibility.Hidden;
            odejmowanie.Visibility = Visibility.Hidden;
            mnozenie.Visibility = Visibility.Hidden;
            dzielenie.Visibility = Visibility.Hidden;
            level.Visibility = Visibility.Hidden;
            score.Text = "";
        }

        private void Potwierdz_Click(object sender, RoutedEventArgs e)
        {
            nowa_gra.Visibility = 0;
            wynik1.Visibility = 0;
            potwierdz.IsEnabled = false;
            int i = int.Parse(score.Text);
            Speech wynik_dodawanie = new Speech();
            Speech wynik_odejmowanie = new Speech();
            Speech wynik_mnozenie = new Speech();
            Speech wynik_dzielenie = new Speech();

            if (dodawanie_bool == true)
            {
                if ((x + y) == i)
                {
                    wynik1.Content = "Dobrze";
                    wynik_dodawanie.ListaTekstowDone();
                }
                else
                {
                    wynik1.Content = "Źle";
                    wynik_dodawanie.ListaTekstowBad();
                }
            }
            else if (odejmowanie_bool == true)
            {
                if ((x - y) == i)
                {
                    wynik1.Content = "Dobrze";
                    wynik_odejmowanie.ListaTekstowDone();
                }
                else
                {
                    wynik1.Content = "Źle";
                    wynik_odejmowanie.ListaTekstowBad();
                }
            }
            else if (mnozenie_bool == true)
            {
                if ((x * y) == i)
                {
                    wynik1.Content = "Dobrze";
                    wynik_mnozenie.ListaTekstowDone();
                }
                else
                {
                    wynik1.Content = "Źle";
                    wynik_mnozenie.ListaTekstowBad();
                }
            }
            else if (dzielenie_bool == true)
            {
                if ((x / y) == i)
                {
                    wynik1.Content = "Dobrze";
                    wynik_dzielenie.ListaTekstowDone();
                }
                else
                {
                    wynik1.Content = "Źle";
                    wynik_dzielenie.ListaTekstowBad();
                }
            }
        }
    }
}
