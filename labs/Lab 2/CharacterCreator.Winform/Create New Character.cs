using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winform
{
    public partial class Create_New_Character : Form
    {
        public Create_New_Character ()
        {
            InitializeComponent ();
        }

        public Create_New_Character(string name) :this()
        {
            Text = name;
        }

        public Character Character { get; set; }
        
        protected override void Onload( EventArgs e )
        {
            base.OnLoad (e);
            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _cbProfession.Text = Character.Profession;
                _cbRace.Text = Character.Race;
                _txtDescription.Text = Character.Description;
                _nudStrength.Text = Character.Strength.ToString ();
                _nudIntelligence.Text = Character.Intelligence.ToString ();
                _nudAgility.Text = Character.Agility.ToString ();
                _nudConstitution.Text = Character.Constitution.ToString ();
                _nudCharisma.Text = Character.Charisma.ToString ();
            };

            ValidateChildren ();
        }
         private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren ())
                return;

            var character = new Character ();
            character.Name = _txtName.Text;
            character.Profession = _cbProfession.Text;
            character.Race = _cbRace.Text;
            character.Description = _txtDescription.Text;
            character.Strength = GetAsDecimal (_nudStrength);
            character.Intelligence = GetAsDecimal (_nudIntelligence);
            character.Agility = GetAsDecimal (_nudAgility);
            character.Constitution = GetAsDecimal (_nudConstitution);
            character.Charisma = GetAsDecimal (_nudCharisma);

            var message = character.Validate ();
            if (!String.IsNullOrEmpty (message))
            {
                MessageBox.Show (this, message, "Error", )
            }

        }

        private decimal GetAsDecimal (NumericUpDown control)
        {
            if (Decimal.TryParse (control.Text, out var result))
                return result;

            return 0;
        }
        private void btnCancel_Click ( object sender, EventArgs e )
        {
            Close ();
        }

       
    }
}
