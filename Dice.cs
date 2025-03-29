using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Charakter_sheet
{
    internal class Dice
    {
        Random dice;
        int baseRange;
        public Dice() 
        {
            Random dice = new Random();
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

        public int multiRoll(int number)
        {
            int value = 0;
            for (int i = 0;i<number;i++)
            {
                value += roll();
            }
            return value;
        }

        public int multiRoll(int number,int max) 
        {
            int value = 0;
            for(int i = 0;i<number;i++)
            {
                value += roll(max);
            }
            return value;
        }

        public int statMultiRoll()
        {
            int value = 0;
            int[] tab = new int[4];
            for (int i = 0; i < 4; i++)
            {
                tab[i] = roll(20);
            }
            Array.Sort(tab);
            tab[3] = 0;
            for(int i = 0;i<3;i++)
            {
                value += tab[i];
            }
            return value;
        }


        public int[] statRoll() 
        {
            int[] result = new int[6];
            for (int i = 0;i<6;i++)
            {
                result[i] = statMultiRoll();
            }
            return result;
        }

        public bool isValid(int[] stats)
        {
            bool result = false;
            int value = 0;
            for (int i = 0;i<6;i++) 
            {
                value += (stats[i]/2)-5;
            }
            if (value <= 6)
            {
                result = true;
            }
            return result;
        }
    }
}
