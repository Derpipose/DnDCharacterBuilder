using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterBuilder
{
    public class Character
    {
        public Character()
        {
            Name = "";
            Race = "";
            Class = "";
        }
        public string Name { get; private set; }
        public string Race { get; private set; }
        public string Class { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }
        
    }
}
