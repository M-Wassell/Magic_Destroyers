//using Enumerations;
//using System;

//namespace Common
//{
//    public class Fields
//    {
//        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;

//        private Faction faction;
//        private HitPoints health;
//        private string name;
//        private int level, abilityPoints;


//        public string Name 
//        {
//            get
//            {
//                return this.name;
//            }
//            set
//            {
//                this.name = value;
//            } 
//        }
//        public Faction Faction
//        {
//            get
//            {
//                return this.faction;
//            }
//            set
//            {
//                this.faction = value;
//            }
//        }
//        public HitPoints Health
//        {
//            get
//            {
//                return this.health;
//            }
//            set
//            {
//                this.health = value;
//            }
//        }
//        public int Level
//        {
//            get
//            {
//                return this.level;
//            }
//            set
//            {
//                this.level = value;
//            }
//        }
//        public int AbilityPoints
//        {
//            get
//            {
//                return this.abilityPoints;
//            }
//            set
//            {
//                this.abilityPoints = value;
//            }
//        }


//        public Fields()
//            :this("Megan", Faction.Default){}

//        public Fields(string name, Faction faction)
//            : this("Michael", Faction.Default, HitPoints.Health, 10, 20){}
//        public Fields(string name, Faction faction, HitPoints hitPoints, int level, int abilityPoints) 
//        {
//            this.Name = name;
//            this.Faction = Faction;
//            this.Health = DEFAULT_HIT_POINTS;
//            this.Level = level;
//            this.AbilityPoints = abilityPoints;
//        }

//        public void Character()
//        {
//            Console.WriteLine(
//                $"--------Character------\n" +
//                $"Character Name: {this.Name}\n" +
//                $"Character Faction: {Faction.Default}\n" +
//                $"Character Health: {HitPoints.Health}\n" +
//                $"Character Level: {this.Level}\n" +
//                $"Character Ability Points {this.AbilityPoints}\n"+
//                $"--------Character------\n");
//        }
//    }
//}
