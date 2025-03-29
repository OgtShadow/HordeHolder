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
            for (int i = 0; i < number; i++)
            {
                value += roll(max);
            }
            return value;
        }


        public int[] statRoll() 
        {
            int[] result = new int[6];
            for (int i = 0;i<4;i++) 
            {
                result[i] += multiRoll(4,20);
            }
            
            return result;
        }

        public bool isValid(int stat)
        {
            bool result = false;
            if (stat > 0) { }
            return result;
        }
    }
}
