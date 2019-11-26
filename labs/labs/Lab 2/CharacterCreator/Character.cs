using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }
        
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        public decimal Strength { get; set; }
        public decimal Intelligence { get; set; }
        public decimal Agility { get; set; }
        public decimal Constitution { get; set; }
        public decimal Charisma { get; set;
        }

        public override string ToString ()
        {
            return $"{Name} ({Profession})";
        }

        private string _name = "";
        private string _profession = "";
        private string _race = "";
        private string _description = "";
        



    }
}
