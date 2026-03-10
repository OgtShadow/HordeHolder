namespace HordeHolder.Server.Models
{
    public class Proficiencies
    {
        // Armor Proficiencies
        public bool LightArmor { get; set; }
        public bool MediumArmor { get; set; }
        public bool HeavyArmor { get; set; }
        public bool Shields { get; set; }

        // Weapon Proficiencies
        public bool SimpleWeapons { get; set; }
        public bool MartialWeapons { get; set; }

        // Saving Throws
        public bool StrengthSave { get; set; }
        public bool DexteritySave { get; set; }
        public bool ConstitutionSave { get; set; }
        public bool IntelligenceSave { get; set; }
        public bool WisdomSave { get; set; }
        public bool CharismaSave { get; set; }

        // Skills
        public bool Acrobatics { get; set; }
        public bool AnimalHandling { get; set; }
        public bool Arcana { get; set; }
        public bool Athletics { get; set; }
        public bool Deception { get; set; }
        public bool History { get; set; }
        public bool Insight { get; set; }
        public bool Intimidation { get; set; }
        public bool Investigation { get; set; }
        public bool Medicine { get; set; }
        public bool Nature { get; set; }
        public bool Perception { get; set; }
        public bool Performance { get; set; }
        public bool Persuasion { get; set; }
        public bool Religion { get; set; }
        public bool SleightOfHand { get; set; }
        public bool Stealth { get; set; }
        public bool Survival { get; set; }
    }
}