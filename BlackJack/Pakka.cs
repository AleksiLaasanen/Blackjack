using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Pakka
    {
        //Luodaan random luokasta objekti nimeltä rng. Tätä käytetään pakka luokassa generoidessa
        //satunnaisia lukuja.
        private static Random rng = new Random();
        //Lista kortti objekteista joka on property
        public List<Kortti> cardsList = new List<Kortti>();
        //Generoi pakkaan kortti objektit niin että kaikille maille on arvot 1-13.
        public void fillDeck()
        {
                Kortti.Suites suiteH = (Kortti.Suites)(0);
                Kortti.Suites suiteD = (Kortti.Suites)(1);
                Kortti.Suites suiteC = (Kortti.Suites)(2);
                Kortti.Suites suiteS = (Kortti.Suites)(3);
                //loop through card values 1-13
                for (int i = 1; i <= 13; i++)
                {
                    cardsList.Add(new Kortti(i, suiteH));
                    cardsList.Add(new Kortti(i, suiteD));
                    cardsList.Add(new Kortti(i, suiteC));
                    cardsList.Add(new Kortti(i, suiteS));
                }
        }
        //Sekoittaa pakan järjestyksen
        public void Shuffle()
        {
            //tekee muuttujan "n", jonka arvo on sama kuin korttilistan pituus
            int n = cardsList.Count;

            //Loop niin kauan kun n on suurempi kuin 1.
            while (n > 1)
            {
                //n - 1
                n--;
                //Valitsee satunnaisen kortin
                int randomindex = rng.Next(n + 1);
                //Tallentaa kortin "temp" muuttujaan kohdasta "randomindex"
                Kortti temp = cardsList[randomindex];
                //Asettaa kortin kohdasta "n", kohtaan "randomindex"
                cardsList[randomindex] = cardsList[n];
                //tallentaa temp kortin kohtaan "n".
                cardsList[n] = temp;
            }
        }
        public Kortti pickCard()
        {
            //Generoi satunnaisen numeron cardsListin pituudesta.
            int randomindex = rng.Next(cardsList.Count);
            //Tallentaa kortin "temp" muuttujaan kohdasta "randomindex"
            Kortti temp = cardsList[randomindex];
            //Poistaa valitun kortin  pakasta
            cardsList.RemoveAt(randomindex);
            //Palauttaa "temp" kortin
            return temp;
        }
        public int countPoints()
        {
            //Tekee int muuttujan "total", jonka arvo on 0.
            int total = 0;


            int aces = 0;
            foreach (Kortti c in cardsList)
            {
                if(c.value == 1)
                {
                    aces++;
                }
                total += c.getPoints();
            }
            for (int i = 0; i<aces; i++)
            {
                if (total > 21)
                {
                    total -= 10;
                }
            }
            
            //palauttaa totalin.
            return total;
        }
        public double countPointsAceOne()
        {
            int returnvalue = 0;
            int aces = 0;
            foreach (Kortti c in cardsList)
            {
                if (c.value == 1)
                {
                    aces++;
                }
                returnvalue += c.getPoints();
            }
            for (int i = 0; i < aces; i++)
            {
                returnvalue -= 10;
            }
            return returnvalue;
        }
    }
}
