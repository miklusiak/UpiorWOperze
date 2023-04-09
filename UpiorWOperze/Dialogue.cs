using System;
using System.Collections.Generic;
using System.Text;

namespace UpiorWOperze
{
    class Dialogue
    {
        public void Wellcome(int x, int y)
        {
            Console.SetCursorPosition((x-30)/2 , (y-8)/2);            
            Console.WriteLine("ZAPRASZAM!");            
            Console.ReadKey();
            Console.Clear();
        }
        public void GetIn()
        {
            //cz1. -wstep

            Console.WriteLine("");
            Console.WriteLine(" Z przyjemnością zawiadamiam, że nie jest to gra dla każdego.");
            Console.WriteLine(" Aby ukończyć grę i mieć satysfakje z wygranej należy być pasjonatem i znawcą 'Upiora z Opery',");
            Console.WriteLine(" gdyż gra bada znajomość bohaterów, a także tekstów utworów muzycznych. ");
            Console.WriteLine(" Zapraszam do przeżycia wspaniałej przygody oraz sprawdzenia wiedzy na temat tej wspaniałej historii!");
            
            //cz.2. - wprowadzenie

            Console.WriteLine("");
            Console.WriteLine(" Niech wszyscy będą mogli usłyszeć najpiękniejszy śpiew, najcudowniejszą muzykę, zaopiekuj się Operą i zostań Aniołem Muzyki!");
            Console.WriteLine("");
            Console.WriteLine(" Czeka Cię kilka zadań, ukończ wszystkie a już nikt nie stanie Ci na przeszkodzie! ");
            Console.WriteLine("");
            Console.WriteLine(" Naciśnij dowolny klawisz na klawiaturze, by przejść dalej. ");
            Console.ReadKey();
            Console.Clear();
        }
        public void Task1()
        {
            Console.WriteLine(" ZADANIE 1.");
            Console.WriteLine("");
            Console.WriteLine(" Jeżeli wybierasz którąś z opcji, wybierz na klawiaturze odpowiadający jej numer, wybranie innego przycisku oznacza pominięcie zadania!!!");
            Console.WriteLine(" Wciśnięcie klawisza ESCAPE oznacza rezygnację z całej gry i powoduje jej zakończenie");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Każdy Anioł ma kogoś kim się opiekuje, nie możesz wyjawić swojej tożsamości, ani pokazać swojej twarzy, więc potrzebujesz kogoś kto pomoże Ci upiększać ten świat...");
            Console.WriteLine("");
            Console.WriteLine(" A Ty już wiesz, która z tych wspaniałych kobiet jest najpiękniejsza i której głos może brzmieć jak diament błyszczy wśród zlóż węgla...");
            Console.ReadKey();
            Console.Clear();
            Seduction.StartSeduction();
        }
        public void Task2()
        {
            Console.Clear();
            Console.WriteLine(" ZADANIE 2.");
            Console.WriteLine("");
            Console.WriteLine(" Masz do przejścia labirynt, poruszasz się za pomocą strzałek, zatrzymujesz się przy użyciu spacji, ");
            Console.WriteLine(" ale uważaj - jeśli sie zatrzymasz nie będziesz widzieć gdzie jesteś!!!");
            Console.WriteLine("");
            Console.WriteLine(" Jeżeli wejdziesz w ścianę lub przeszkodę uniemożliwi Ci to dalszą grę i będziesz zmuszony zrezygnować...");
            Console.WriteLine("");
            Console.WriteLine(" Wciśnięcie klawisza ESCAPE oznacza rezygnację z całej gry i powoduje jej zakończenie");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Musisz znac każdy zakątek opery, w końcu to ma być Twoje imperium piękna! Pora zejść do podziemi, o tej części nikt z żyjących nie wie...");
            Console.WriteLine("");
            Console.WriteLine(" To będzie Twój sposób na dotarcie w każde miejsce niezauważonym, pora dotrzeć zza lustra Christine na zaplecze sceny, już niedługo scena finałowa...");
            Console.ReadKey();
            Console.Clear();            
        }
        public void TheEnd(int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition((x - 30) / 2, (y - 8) / 2);
            Console.WriteLine(" Dziękuję za uwagę! ");
            Console.WriteLine("");
            Console.SetCursorPosition((x - 44) / 2, (y - 6) / 2);
            Console.WriteLine(" Twórca gry - Krystyna Miklusiak ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
