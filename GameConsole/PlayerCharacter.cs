﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DaysSinceLastLogin = -1;
            DateOfBirth = DateTime.MinValue;
        }
            
    }
}
