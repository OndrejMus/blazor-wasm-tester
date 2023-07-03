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
            new Race() { Name = RaceNames.Human},
            new Race() { Name = RaceNames.Dwarf},
            new Race() { Name = RaceNames.Gnome},
            new Race() { Name = RaceNames.NightElf},
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


        public static List<(ClassNames ClassName, RaceNames RaceName)> xx = new List<(ClassNames ClassName, RaceNames RaceName)>
        {
            (ClassNames.Warrior, RaceNames.Orc),
            (ClassNames.Warrior, RaceNames.Troll),
            (ClassNames.Warrior, RaceNames.Undead),
            (ClassNames.Warrior, RaceNames.Tauren),
            (ClassNames.Warrior, RaceNames.Human),
            (ClassNames.Warrior, RaceNames.Dwarf),
            (ClassNames.Warrior, RaceNames.Gnome),
            (ClassNames.Warrior, RaceNames.NightElf),

            (ClassNames.Paladin, RaceNames.Human),
            (ClassNames.Paladin, RaceNames.Dwarf),

            (ClassNames.Hunter, RaceNames.Orc),
            (ClassNames.Hunter, RaceNames.Troll),
            (ClassNames.Hunter, RaceNames.Tauren),
            (ClassNames.Hunter, RaceNames.Dwarf),
            (ClassNames.Hunter, RaceNames.NightElf),
                    
            (ClassNames.Shaman, RaceNames.Orc),
            (ClassNames.Shaman, RaceNames.Troll),
            (ClassNames.Shaman, RaceNames.Tauren),

            (ClassNames.Druid, RaceNames.Tauren),
            (ClassNames.Druid, RaceNames.NightElf),

            (ClassNames.Rogue, RaceNames.Orc),
            (ClassNames.Rogue, RaceNames.Troll),
            (ClassNames.Rogue, RaceNames.Undead),
            (ClassNames.Rogue, RaceNames.Human),
            (ClassNames.Rogue, RaceNames.Dwarf),
            (ClassNames.Rogue, RaceNames.Gnome),
            (ClassNames.Rogue, RaceNames.NightElf),

            (ClassNames.Mage, RaceNames.Troll),
            (ClassNames.Mage, RaceNames.Undead),
            (ClassNames.Mage, RaceNames.Human),
            (ClassNames.Mage, RaceNames.Gnome),

            (ClassNames.Warlock, RaceNames.Orc),
            (ClassNames.Warlock, RaceNames.Undead),
            (ClassNames.Warlock, RaceNames.Human),
            (ClassNames.Warlock, RaceNames.Gnome),

            (ClassNames.Priest, RaceNames.Troll),
            (ClassNames.Priest, RaceNames.Undead),
            (ClassNames.Priest, RaceNames.Human),
            (ClassNames.Priest, RaceNames.Dwarf),
            (ClassNames.Priest, RaceNames.NightElf),
        };
        //public static Dictionary<ClassNames, RaceNames> ClassRaceCombinations { get; set; } =
        //    new Dictionary<ClassNames, RaceNames>
        //    {
        //        { ClassNames.Warrior,RaceNames.Orc },
        //        { ClassNames.Warrior,RaceNames.Troll },
        //        { ClassNames.Warrior,RaceNames.Undead },
        //        { ClassNames.Warrior,RaceNames.Tauren },
        //        { ClassNames.Warrior,RaceNames.Human },
        //        { ClassNames.Warrior,RaceNames.Dwarf },
        //        { ClassNames.Warrior,RaceNames.Gnome },
        //        { ClassNames.Warrior,RaceNames.NightElf },

        //        { ClassNames.Paladin,RaceNames.Human },
        //        { ClassNames.Paladin,RaceNames.Dwarf },

        //        { ClassNames.Hunter,RaceNames.Orc },
        //        { ClassNames.Hunter,RaceNames.Troll },
        //        { ClassNames.Hunter,RaceNames.Tauren },
        //        { ClassNames.Hunter,RaceNames.Dwarf },
        //        { ClassNames.Hunter,RaceNames.NightElf },

        //        { ClassNames.Shaman,RaceNames.Orc },
        //        { ClassNames.Shaman,RaceNames.Troll },
        //        { ClassNames.Shaman,RaceNames.Tauren },

        //        { ClassNames.Druid,RaceNames.Tauren },
        //        { ClassNames.Druid,RaceNames.NightElf },

        //        { ClassNames.Rogue,RaceNames.Orc },
        //        { ClassNames.Rogue,RaceNames.Troll},
        //        { ClassNames.Rogue,RaceNames.Undead },
        //        { ClassNames.Rogue,RaceNames.Human },
        //        { ClassNames.Rogue,RaceNames.Dwarf },
        //        { ClassNames.Rogue,RaceNames.Gnome},
        //        { ClassNames.Rogue,RaceNames.NightElf },

        //        { ClassNames.Mage,RaceNames.Troll },
        //        { ClassNames.Mage,RaceNames.Undead },
        //        { ClassNames.Mage,RaceNames.Human },
        //        { ClassNames.Mage,RaceNames.Gnome },

        //        { ClassNames.Warlock,RaceNames.Orc },
        //        { ClassNames.Warlock,RaceNames.Undead },
        //        { ClassNames.Warlock,RaceNames.Human },
        //        { ClassNames.Warlock,RaceNames.Gnome },

        //        { ClassNames.Priest,RaceNames.Troll },
        //        { ClassNames.Priest,RaceNames.Undead },
        //        { ClassNames.Priest,RaceNames.Human },
        //        { ClassNames.Priest,RaceNames.Dwarf },
        //        { ClassNames.Priest,RaceNames.NightElf },
        //    };


    }
}
