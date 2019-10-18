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
                _txtStrength.Text = Character.Strength.ToString ();
                _txtIntelligence.Text = Character.Intelligence.ToString ();
                _txtAgility.Text = Character.Agility.ToString ();
                _txtConstitution.Text = Character.Constitution.ToString ();
                _txtCharisma.Text = Character.Charisma.ToString ();
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
            character.Strength = GetAsInt32 (_txtStrength);
            character.Intelligence = GetAsInt32 (_txtIntelligence);
            character.Agility = GetAsInt32 (_txtAgility);
            character.Constitution = GetAsInt32 (_txtConstitution);
            character.Charisma = GetAsInt32 (_txtCharisma);

            var message = character.Validate ();
            if (!String.IsNullOrEmpty (message))
            {

                MessageBox.Show (this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close ();
            }


        }
    private int GetAsInt32 ( TextBox control )
    {
        if (Int32.TryParse (control.Text, out var result))
            return result;

        return 0;
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



        


       
    }
}
