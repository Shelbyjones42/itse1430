using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;

namespace CharacterCreatorMain
{
    public partial class CreateNewCharacter : Form
    {
        public CreateNewCharacter ()
        {
            InitializeComponent ();
        }

        public CreateNewCharacter ( string name ) : this()
        {
            Text = name;
        }

        public Character Character { get; set; }

        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            
            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _cbProfession.Text = Character.Profession;
                _cbRace.Text = Character.Race;
                _txtStrength.Text = Character.Strength.ToString ();
                _txtIntelligence.Text = Character.Intelligence.ToString ();
                _txtAgility.Text = Character.Agility.ToString ();
                _txtConstitution.Text = Character.Constitution.ToString ();
                _txtCharisma.Text = Character.Charisma.ToString ();
            };

            ValidateChildren ();
        }
        
        private int GetAsInt32 ( TextBox control)
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;

            return 0;
        }
        private void BtnCancel_Click ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }

        private void BtnSave_Click ( object sender, EventArgs e )
        {
            var character = new Character () {
                Name = _txtName.Text,
                Profession = _cbProfession.Text,
                Race = _cbRace.Text,
                Strength = GetAsInt32 (_txtStrength),
                Intelligence = GetAsInt32 (_txtIntelligence),
                Agility = GetAsInt32 (_txtAgility),
                Constitution = GetAsInt32 (_txtConstitution),
                Charisma = GetAsInt32 (_txtConstitution)
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close ();
        }

      
        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Name is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Profession is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Race is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingStrength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 0 && value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Strength must be greater than 0 and less than 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingIntelligence ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 0 && value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Intelligence must be greater than 0 and less than 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingAgility ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 0 && value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Agility must be greater than 0 and less than 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingConstitution ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 0 && value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Constitution must be greater than 0 and less than 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingCharisma ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 0 && value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Charisma must be greater than 0 and less than 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }
    }
}
