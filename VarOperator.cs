using Charakter_sheet;
using System;

class Charakter
{
    public int Int;
    public int Str;
    public int Wis;
    public int Con;
    public int Dex;
    public int Cha;
    public int lvl;
    public int Speed;
    public int Gold;
    

    // konstruktor dla podania parametrów
    public Charakter(int Int,int Str, int Wis, int Con, int Dex, int Cha, int lvl, int hitdice, int speed)
    {
        Random dice = new Random();
        this.Int = Int;
        this.Str = Str;
        this.Wis = Wis;
        this.Con = Con;
        this.Dex = Dex;
        this.Cha = Cha;
        this.lvl = lvl;
        int prof = 2 + lvl / 4;
        int Ac = 14 + Dex;
        int Hp = (dice.Next(1, hitdice)) * (lvl - 1) + lvl * Con + hitdice;
        this.Speed = speed;
    }

    //konstruktor bez parametrowy

}