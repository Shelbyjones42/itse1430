using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character : IValidatableObject
    {
        public int Id { get; set; }
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

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set;
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
