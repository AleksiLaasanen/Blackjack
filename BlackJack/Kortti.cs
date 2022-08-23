using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Kortti
    {
        //Mahdolliset maat korteille
        public enum Suites
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades,
        }
        //Tekee listan maista
        public static List<Suites> AllSuites = new List<Suites>();
        //Tekee "value" propertyn
        public int value { get; set; }
        //Tekee objekti "Suite", Suites luokasta.
        public Suites Suite { get; set; }
        //Constructor
        public Kortti(int value, Suites Suite)
        {
            this.value = value;
            this.Suite = Suite;
        }
        //Pisteiden laskemis funktio
        public int getPoints()
        {
            switch (value)
            {
                //Jos kortin arvo on 11, 12 tai 13, asettaa sen 10. Muissa tapauksissa tulee kortin oma arvo.
                case 1:
                    return 11;
                case 11:
                case 12:
                case 13:
                    return 10;
                default:
                    return value;
            }
        }
        public static Bitmap GetPictureResx(string key)
        {
            return BlackJack.Resource1.ResourceManager.GetObject(key) as Bitmap;
        }
        public string getPictureKey() 
            {
            char suite = getSuiteId();
            string value = getValueId();
            return suite + value;
            }
        private char getSuiteId()
        {
            switch(Suite.ToString())
            {
                case "Clubs": return 'C';
                case "Hearts": return 'H';
                case "Spades": return 'S';
                case "Diamonds": return 'D';
                default: return 'x';
            }
        }
        private string getValueId()
        {
            switch(value)
            {
                case 11: return "J";
                case 12: return "Q";
                case 13: return "K";
                default:
                    return Convert.ToString(value);
            }
        }
    }
}
