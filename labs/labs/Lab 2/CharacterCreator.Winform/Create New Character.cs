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
<<<<<<< HEAD
                MessageBox.Show (this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close ();
=======
                MessageBox.Show (this, message, "Error", )
            }
>>>>>>> 68cf341013862ab2bb00b6ceee97f1db28444cf4

        }

        private decimal GetAsDecimal (NumericUpDown control)
        {
            if (Decimal.TryParse (control.Text, out var result))
                return result;

            return 0;
        }
<<<<<<< HEAD
        private void BtnCancel_Click ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }

        private void OnValidatingName (object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Name is required");
            }else
            {
                _errors.SetError (control, "");
            }
        }


=======
        private void btnCancel_Click ( object sender, EventArgs e )
        {
            Close ();
        }

>>>>>>> 68cf341013862ab2bb00b6ceee97f1db28444cf4
       
    }
}
