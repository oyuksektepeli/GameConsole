﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if(player.DaysSinceLastLogin == -1)
            {
                Console.WriteLine("No Value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if(player.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}
