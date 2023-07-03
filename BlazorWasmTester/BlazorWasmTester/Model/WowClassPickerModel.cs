namespace BlazorWasmTester.Model
{
    public class WowClassPickerModel
    {
        public class  Class
        {
            public ClassNames? Name { get; set; }
        }
        public class Race
        {
            public RaceNames? Name { get; set; }
        }

        public enum RaceNames
        {
            Orc,Tauren,Troll,Undead,Human,Dwarf,Gnome,NightElf
        };

        public enum ClassNames
        {
            Warrior, Paladin, Shaman, Hunter, Rogue, Druid, Mage, Warlock, Priest
        };

        public static List<Race> Races { get; set; } = new List<Race>()  
        {
            new Race() { Name = RaceNames.Orc},
            new Race() { Name = RaceNames.Tauren},
            new Race() { Name = RaceNames.Troll},
            new Race() { Name = RaceNames.Undead},
        };
        public static List<Class> Classes { get; set; } = new List<Class>
        {
            new Class() { Name = ClassNames.Warrior},
            new Class() { Name = ClassNames.Paladin},
            new Class() { Name = ClassNames.Shaman},
            new Class() { Name = ClassNames.Hunter},
            new Class() { Name = ClassNames.Rogue},
            new Class() { Name = ClassNames.Druid},
            new Class() { Name = ClassNames.Mage},
            new Class() { Name = ClassNames.Warlock},
            new Class() { Name = ClassNames.Priest},
        };




    }
}
