using System;
using System.Security.Cryptography.X509Certificates;
using Charakter_sheet.Services;

namespace Charakter_sheet.Models
{
    class Charakter
    {
        public string Name;
        //public Race race = new Race();
        //public Class class = new Class();
        
        public string Background;
        public int Prof;
        public int Ac;
        public int Hp;
        public int Int;
        public int Str;
        public int Wis;
        public int Con;
        public int Dex;
        public int Cha;
        public int Lvl;
        public int Speed;
        public int Gold;
        public Dice dice = new Dice();

        // konstruktor dla podania parametrów
        public Charakter(string Name, int Int,int Str, int Wis, int Con, int Dex, int Cha, int lvl, int hitdice, int speed)
        {
            this.Name = Name;
            this.Int = Int;
            this.Str = Str;
            this.Wis = Wis;
            this.Con = Con;
            this.Dex = Dex;
            this.Cha = Cha;
            this.Lvl = lvl;
            this.Prof = 2 + lvl / 4;
            this.Ac = 14 + Dex;
            this.Hp = (dice.roll(hitdice)) * (lvl - 1) + lvl * Con + hitdice;
            this.Speed = speed;
        }
        // konstruktor bez parametrów to więcej roboty niestety no bo całe wybieranie gdzie jaką statę trzeba obsłużyć więc to raczej będzie na froncie

    }
}