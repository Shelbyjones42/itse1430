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

<<<<<<< HEAD
        private void OnHelpAbout ( object sender, EventArgs e )
=======
        private void AboutToolStripMenuItem_Click ( object sender, EventArgs e )
>>>>>>> 68cf341013862ab2bb00b6ceee97f1db28444cf4
        {
            var form = new OnAboutBox ();
            form.ShowDialog (this); 
        }
    }
}
