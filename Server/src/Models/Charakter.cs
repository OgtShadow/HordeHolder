using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Charakter_sheet.Services;
using HordeHolder.Server.Models;

namespace Charakter_sheet.Models
{
    class Charakter
    {
        public bool autoroll;
        public string Name;
        //public Race race = new Race();
        //public Class class = new Class();
        
        public string Background;
        public int Prof;
        public int Ac;
        public int Hp;
        public int tempHp;
        public int Int;
        public int Str;
        public int Wis;
        public int Con;
        public int Dex;
        public int Cha;
        public int Lvl;
        public int Speed;
        public int Gold;
        public Dice dice = new();
        public Proficiencies proficiencies = new();
        public int passivePerception;
        public Charakter(Proficiencies proficiencies, string Background, string Name, int Int,int Str, int Wis, int Con, int Dex, int Cha, int lvl, int hitdice, int speed, bool autoroll)
        {
            this.Gold = 0;
            this.dice = new Dice();
           this.proficiencies = proficiencies;
            this.Background = Background;
            this.autoroll = autoroll;
            this.passivePerception = 10 + (proficiencies != null && proficiencies.Perception ? StatUtils.Mod(Dex) : 0);
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
            this.tempHp = 0;
            this.Speed = speed;


        }
        // konstruktor bez parametrów to więcej roboty niestety no bo całe wybieranie gdzie jaką statę trzeba obsłużyć więc to raczej będzie na froncie
        public static int initiative(int dex, bool autoroll)
        {
            int value = StatUtils.Mod(dex);
            if (autoroll)
            {
                Dice rand = new Dice();
                value = rand.roll(20) + value;
            }
            return value;
        }

    }
}