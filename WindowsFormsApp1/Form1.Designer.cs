namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dexterity = new System.Windows.Forms.TextBox();
            this.txt_intelligence = new System.Windows.Forms.TextBox();
            this.txt_strength = new System.Windows.Forms.TextBox();
            this.txt_race = new System.Windows.Forms.TextBox();
            this.txt_characterName = new System.Windows.Forms.TextBox();
            this.txt_playerName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_fightOutput = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 447);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_test);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_dexterity);
            this.tabPage1.Controls.Add(this.txt_intelligence);
            this.tabPage1.Controls.Add(this.txt_strength);
            this.tabPage1.Controls.Add(this.txt_race);
            this.tabPage1.Controls.Add(this.txt_characterName);
            this.tabPage1.Controls.Add(this.txt_playerName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character Creation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_test
            // 
            this.txt_test.Location = new System.Drawing.Point(499, 18);
            this.txt_test.Multiline = true;
            this.txt_test.Name = "txt_test";
            this.txt_test.ReadOnly = true;
            this.txt_test.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_test.Size = new System.Drawing.Size(275, 348);
            this.txt_test.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dexterity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Intelligence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Strength";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Race";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Character Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player Name";
            // 
            // txt_dexterity
            // 
            this.txt_dexterity.Location = new System.Drawing.Point(92, 141);
            this.txt_dexterity.Name = "txt_dexterity";
            this.txt_dexterity.Size = new System.Drawing.Size(201, 20);
            this.txt_dexterity.TabIndex = 10;
            // 
            // txt_intelligence
            // 
            this.txt_intelligence.Location = new System.Drawing.Point(92, 115);
            this.txt_intelligence.Name = "txt_intelligence";
            this.txt_intelligence.Size = new System.Drawing.Size(201, 20);
            this.txt_intelligence.TabIndex = 9;
            // 
            // txt_strength
            // 
            this.txt_strength.Location = new System.Drawing.Point(92, 89);
            this.txt_strength.Name = "txt_strength";
            this.txt_strength.Size = new System.Drawing.Size(201, 20);
            this.txt_strength.TabIndex = 8;
            // 
            // txt_race
            // 
            this.txt_race.Location = new System.Drawing.Point(92, 63);
            this.txt_race.Name = "txt_race";
            this.txt_race.Size = new System.Drawing.Size(201, 20);
            this.txt_race.TabIndex = 7;
            // 
            // txt_characterName
            // 
            this.txt_characterName.Location = new System.Drawing.Point(92, 37);
            this.txt_characterName.Name = "txt_characterName";
            this.txt_characterName.Size = new System.Drawing.Size(201, 20);
            this.txt_characterName.TabIndex = 6;
            // 
            // txt_playerName
            // 
            this.txt_playerName.Location = new System.Drawing.Point(92, 11);
            this.txt_playerName.Name = "txt_playerName";
            this.txt_playerName.ShortcutsEnabled = false;
            this.txt_playerName.Size = new System.Drawing.Size(201, 20);
            this.txt_playerName.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txt_fightOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fight";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fight!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_fightOutput
            // 
            this.txt_fightOutput.Location = new System.Drawing.Point(510, 6);
            this.txt_fightOutput.Multiline = true;
            this.txt_fightOutput.Name = "txt_fightOutput";
            this.txt_fightOutput.Size = new System.Drawing.Size(274, 328);
            this.txt_fightOutput.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dexterity;
        private System.Windows.Forms.TextBox txt_intelligence;
        private System.Windows.Forms.TextBox txt_strength;
        private System.Windows.Forms.TextBox txt_race;
        private System.Windows.Forms.TextBox txt_characterName;
        private System.Windows.Forms.TextBox txt_playerName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_test;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_fightOutput;
    }
}

