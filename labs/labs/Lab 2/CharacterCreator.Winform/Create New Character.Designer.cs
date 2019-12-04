namespace CharacterCreator.Winform
{
    partial class Create_New_Character
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._nudStrength = new System.Windows.Forms.NumericUpDown();
            this._nudCharisma = new System.Windows.Forms.NumericUpDown();
            this._nudIntelligence = new System.Windows.Forms.NumericUpDown();
            this._nudAgility = new System.Windows.Forms.NumericUpDown();
            this._nudConstitution = new System.Windows.Forms.NumericUpDown();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudConstitution)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attributes";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(70, 13);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(454, 20);
            this._txtName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Intelligence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Agility";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Constitution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Charisma";
            // 
            // _nudStrength
            // 
            this._nudStrength.Location = new System.Drawing.Point(121, 137);
            this._nudStrength.Name = "_nudStrength";
            this._nudStrength.Size = new System.Drawing.Size(35, 20);
            this._nudStrength.TabIndex = 10;
            this._nudStrength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudCharisma
            // 
            this._nudCharisma.Location = new System.Drawing.Point(121, 249);
            this._nudCharisma.Name = "_nudCharisma";
            this._nudCharisma.Size = new System.Drawing.Size(35, 20);
            this._nudCharisma.TabIndex = 11;
            this._nudCharisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudIntelligence
            // 
            this._nudIntelligence.Location = new System.Drawing.Point(121, 165);
            this._nudIntelligence.Name = "_nudIntelligence";
            this._nudIntelligence.Size = new System.Drawing.Size(35, 20);
            this._nudIntelligence.TabIndex = 12;
            this._nudIntelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudAgility
            // 
            this._nudAgility.Location = new System.Drawing.Point(121, 193);
            this._nudAgility.Name = "_nudAgility";
            this._nudAgility.Size = new System.Drawing.Size(35, 20);
            this._nudAgility.TabIndex = 13;
            this._nudAgility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudConstitution
            // 
            this._nudConstitution.Location = new System.Drawing.Point(121, 219);
            this._nudConstitution.Name = "_nudConstitution";
            this._nudConstitution.Size = new System.Drawing.Size(35, 20);
            this._nudConstitution.TabIndex = 14;
            this._nudConstitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _cbProfession
            // 
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._cbProfession.Location = new System.Drawing.Point(70, 44);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(121, 21);
            this._cbProfession.TabIndex = 15;
            // 
            // _cbRace
            // 
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._cbRace.Location = new System.Drawing.Point(70, 75);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(121, 21);
            this._cbRace.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(246, 64);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(278, 171);
            this._txtDescription.TabIndex = 18;
            this._txtDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(359, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(449, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
=======
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
>>>>>>> 68cf341013862ab2bb00b6ceee97f1db28444cf4
            // 
            // Create_New_Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this._nudConstitution);
            this.Controls.Add(this._nudAgility);
            this.Controls.Add(this._nudIntelligence);
            this.Controls.Add(this._nudCharisma);
            this.Controls.Add(this._nudStrength);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create_New_Character";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create_New_Character";
            ((System.ComponentModel.ISupportInitialize)(this._nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudConstitution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown _nudStrength;
        private System.Windows.Forms.NumericUpDown _nudCharisma;
        private System.Windows.Forms.NumericUpDown _nudIntelligence;
        private System.Windows.Forms.NumericUpDown _nudAgility;
        private System.Windows.Forms.NumericUpDown _nudConstitution;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox _txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}