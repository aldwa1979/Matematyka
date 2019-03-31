using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Globalization;

namespace Matematyka
{
    class Speech
    {
        public void GoodText()
        {
           
        }

        public void ListaTekstowDone()
        {
            List<string> tekstyDone = new List<string>();
            tekstyDone.Add("Dobrze ale nie wystawiaj języka bo ci krowa nasika.");
            tekstyDone.Add("Świetny dżob ale weź coś trudniejszego.");
            tekstyDone.Add("Świetnie, jak to robisz że wszystko wiesz?");
            tekstyDone.Add("Dobrze wykonane działanie jak na pięciolatka");
            tekstyDone.Add("Bardzo dobrze jak na przedszkolaka");
            tekstyDone.Add("Zgadłeś robaczku.");
            tekstyDone.Add("Super, chcesz stówe mróweczko?");
            tekstyDone.Add("Brawo, dostajesz piwo, ale nie mów rodzicom.");
            tekstyDone.Add("Super, jesteś jak formuła jeden, tylko tak dalej.");
            tekstyDone.Add("Gratulacje, nawet lewandowski nie potrafiłby lepiej.");

            Random random = new Random();
            SpeechSynthesizer done = new SpeechSynthesizer();
            //CultureInfo polska = new CultureInfo("fr-FR", false);
            //done.GetInstalledVoices(polska);
            int x = random.Next(tekstyDone.Count);
            done.Speak(tekstyDone[x]);

        }

        public void ListaTekstowBad()
        {
            List<String> tekstyBad = new List<string>();
            tekstyBad.Add("Źle i niech cię kura jajem trzaśnie.");
            tekstyBad.Add("Źle i kręcisz się jak smród po gaciach.");
            tekstyBad.Add("Źle, ja się tak nie bawię.");
            tekstyBad.Add("Źle, idź do swojego pokoju.");
            tekstyBad.Add("Źle, bo nie jesz warzyw, małpeczko.");
            tekstyBad.Add("Źle, idż się doucz i dopiero wtedy wróć.");
            tekstyBad.Add("No no, a myślałam że wiesz.");
            tekstyBad.Add("Nie żartuj, naprawdę nie wiesz malutka dziewczynko?");
            tekstyBad.Add("Jaja sobie robisz? Źle");
            tekstyBad.Add("Źle, mam zadzonić po mamę?");
            tekstyBad.Add("Źle, i nawet nie zwalaj to na brudne skarpetki.");
            tekstyBad.Add("Źle i wyglądasz jak pokemon w piżamie.");
            tekstyBad.Add("Źle, rusz głową mopsiku.");
            tekstyBad.Add("No wiesz, dlaczego tak źle? Zjedz lepiej paróweczkę");
            tekstyBad.Add("Źle, za karę tracisz tygodniówkę");

            Random random = new Random();
            SpeechSynthesizer done = new SpeechSynthesizer();

            int x = random.Next(tekstyBad.Count);
            done.Speak(tekstyBad[x]);
        }
    }
}
