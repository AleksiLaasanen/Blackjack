using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class OddsCalculator
    {
        // Row = dealer visible card 1-10, column = chance to get 17, 18, 19, 20, 21
        private static double[,] dealerOddsTable = new double[,] {
//         17      18      19      20      21
/* 1 */ { 0.1889, 0.1889, 0.1889, 0.1889, 0.0778 },
/* 2 */ { 0.1398, 0.1349, 0.1296, 0.1240, 0.1179 },
/* 3 */ { 0.1350, 0.1304, 0.1255, 0.1203, 0.1147 },
/* 4 */ { 0.1304, 0.1259, 0.1213, 0.1164, 0.1112 },
/* 5 */ { 0.1222, 0.1222, 0.1177, 0.1131, 0.1082 },
/* 6 */ { 0.1654, 0.1062, 0.1062, 0.1017, 0.0971 },
/* 7 */ { 0.3685, 0.1377, 0.0786, 0.0786, 0.0740 },
/* 8 */ { 0.1285, 0.3593, 0.1285, 0.0693, 0.0693 },
/* 9 */ { 0.1199, 0.1199, 0.3507, 0.1199, 0.0608 },
/* 10 */ { 0.1207, 0.1207, 0.1207, 0.3707, 0.0373 }
};
        public static double Overdraw(Pakka pCards, Pakka allCards)
        {
            double overdraw = 0;
            double returnvalue = 0;
            double maxPointsToDraw = 21 - pCards.countPoints();
            foreach (Kortti c in allCards.cardsList)
            {
                if (c.getPoints() > maxPointsToDraw && c.getPoints() != 11)
                {
                    overdraw++;
                }
            }
            if (pCards.countPoints() == 11)
            {
                return 100;
            }
            else if (pCards.countPointsAceOne() < 12)
            {
                return 0;
            }
            else
            {
                returnvalue = overdraw / allCards.cardsList.Count() * 100;
                return returnvalue;
            }
        }
        public static double DealerWins(Kortti dealerVisibleCard, int pPoints)
        {
            double returnvalue = 0;
            int rowIndex = dealerVisibleCard.getPoints() - 1 == 10 ? 0 : dealerVisibleCard.getPoints() - 1;
            int columIndex = pPoints - 17 > 0 ? pPoints - 17
                : 0;
            for (int i = columIndex; i < dealerOddsTable.GetLength(1); i++)
            {
                returnvalue += dealerOddsTable[rowIndex, i] * 100;
            }

            return returnvalue;
        }
    }
}
