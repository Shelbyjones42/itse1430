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
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
            Character character = new Character ();
            character.Name = "";
            character.Description = character.Name;
        }


        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new OnAboutBox ();
            form.ShowDialog (this); 
        }
    }
}
