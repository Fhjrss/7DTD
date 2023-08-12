﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Cheat.Helpers
{
    class ColourHelper
    {
        public static void AddColours()
        {


            AddColour("Zombie Colour", Color.blue);
            AddColour("Player Colour", Color.white);
            AddColour("Animal Colour", Color.cyan);
            AddColour("Menu Primary Colour", Color.red);
            AddColour("Menu Secondary Colour", Color.white);
            AddColour("Player Box Colour", Color.red);
            AddColour("Player Chams Visible Colour", Color.white);
            AddColour("Player Chams Invisible Colour", Color.red);
            AddColour("Zombie Box Colour", Color.red);
            AddColour("Aimbot Fov Colour", Color.white);
            AddColour("Aimbot Target Line Colour", Color.red);
            AddColour("Tile Item Colour", Color.green);
        }
        public static Color32 GetColour(string identifier)
        {
            if (Globals.Config.Colours.GlobalColors.TryGetValue(identifier, out var toret))
                return toret;
            return Color.magenta;
        }

        public static void AddColour(string id, Color32 c)
        {
            // add to the colour list
            if (!Globals.Config.Colours.GlobalColors.ContainsKey(id))
                Globals.Config.Colours.GlobalColors.Add(id, c);
        }

        public static void SetColour(string id, Color32 c) 
        {
            Globals.Config.Colours.GlobalColors[id] = c;

        }
    }
}
