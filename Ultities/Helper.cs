﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ultities
{
    public class Helper
    {

        public static void ShowDisplay(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum GroupMethods
        {
            CreateGroup = 1,
            UpdateGroup,
            DeleteGroup,
            GetGroupById,
            GetGroupByName,
            GetAll


        }
    }
}
