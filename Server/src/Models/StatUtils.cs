namespace Charakter_sheet.Models
{
    public static class StatUtils
    {
        public static int Mod(int stat)
        {
            return (stat - 10) / 2;
        }
    }
}