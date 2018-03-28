using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Character
    {
        public string plyrName;
        public string charName;
        public string race;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int level = 1;
        public int xp = 0;

        public Character(string playerName, string characterName, string rce, int Str, int Int, int Dex, int lvl, int exp)
        {
            plyrName = playerName;
            charName = characterName;
            race = rce;
            strength = Str;
            intelligence = Int;
            dexterity = Dex;
            level = lvl;
            xp = exp;
        }

        public Character(string playerName, string characterName, string rce, int Str, int Int, int Dex)
        {
            plyrName = playerName;
            charName = characterName;
            race = rce;
            strength = Str;
            intelligence = Int;
            dexterity = Dex;
        }
    }
}
