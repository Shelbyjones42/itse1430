using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        public Create_New_Character ( string name ) : this ()
        {
            Text = name;
        }

        public Character Character { get; set; }
        
        protected override void OnLoad( EventArgs e )
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

            var character = new Character () { 
            Name = _txtName.Text,
            Profession = _cbProfession.Text,
            Race = _cbRace.Text,
            Description = _txtDescription.Text,
            Strength = GetAsInt32 (_txtStrength),
            Intelligence = GetAsInt32 (_txtIntelligence),
            Agility = GetAsInt32 (_txtAgility),
            Constitution = GetAsInt32 (_txtConstitution),
            Charisma = GetAsInt32 (_txtCharisma),
            };

            if(!Validate (character))
                return;

            Character = character;
            DialogResult = DialogResult.OK;
            Close ();
            
        }

        private bool Validate ( Character character ) => throw new NotImplementedException ();

        private int GetAsInt32 ( TextBox control )
    {
        if (Int32.TryParse (control.Text, out var result))
            return result;

        return 0;
    }
    
    private bool Validate(IValidatableObject character)
    {

            var results = ObjectValidator.TryValidateObject (character);
            if (results.Count() > 0)
            {
                foreach (var result in results)
                {
                    MessageBox.Show (this, result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return false;
            }
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

    private void OnValidatingProfession ( object sender , CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Profession is required");
            }else
            {
                _errors.SetError (control, "");
            }
        }

    private void OnValidatingRace (object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Race is required");
            }else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingStrength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Strength is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingIntelligance ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Intelligence is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }
        private void OnValidatingAgility ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Agility is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingConstitution ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Constitution is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingCharisma ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Charisma is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void Create_New_CharacterForm_Load( object sender, EventArgs e)
        {

        }
        

       
    }
}
