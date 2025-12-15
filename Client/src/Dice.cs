using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Charakter_sheet
{
    // wielofunkcyjna kostka która będzie nam łatwiej pozwalała losować dane wszelkiej maści i rollować
    internal class Dice
    {
        Random dice;
        int baseRange;
        //możemy podać bazowy zakres kostki co powinno być inną klasą ale to to do
        public Dice() 
        {
            Random dice = new Random();
            this.baseRange = 20;
        }
        public Dice(int baseRange)
        {
            Random dice = new Random();
            this.baseRange = baseRange;
        }

        public int roll(int max)
        {
            int result = dice.Next(1,max);
            return result;
        }

        public int roll()
        {
            int result = dice.Next(1, baseRange);
            return result;
        }

        public int roll(int number,int max) 
        {
            int value = 0;
            for(int i = 0;i<number;i++)
            {
                value += roll(max);
            }
            return value;
        }

        public int[] nBestOutOfm(int n, int m)
        {
            int[] tab = new int[m];
            for (int i = 0; i < m; i++)
            {
                tab[i] = roll(6);
            }
            Array.Sort(tab);
            tab[n] = 0;
            return tab;
        }


        public int[] statRoll() // standardowe rzuty statystyk DnD 6x(3d6, drop lowest)
        {
            int[] result = new int[6];
            for (int i = 0;i<6;i++)
            {
                result[i] = nBestOutOfm(3,4).Sum();
            }
            return result;
        }

        public bool isValid(int[] stats,int min)
        {
            int value = 0;
            for (int i = 0;i<6;i++) 
            {
                value += (stats[i]/2)-5;
            }
            return value >= min;
        }

                public bool isValid(int[] stats)
        {
            int value = 0;
            for (int i = 0;i<6;i++) 
            {
                value += (stats[i]/2)-5;
            }
            return value >= 6;
        }
    }
}
