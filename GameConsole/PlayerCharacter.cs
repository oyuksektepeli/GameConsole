using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        //public Nullable<int> DaysSinceLastLogin { get; set; }
        //public Nullable<DateTime> DateOfBirth { get; set; }

        //"?"(question mark is shorthand of nullable types
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
            DaysSinceLastLogin = null;
            DateOfBirth = null;
        }
            
    }
}
