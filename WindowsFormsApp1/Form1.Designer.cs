
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
            this.components = new System.ComponentModel.Container();
            this.btnFindSenseForNewDPI = new System.Windows.Forms.Button();
            this.btnFindEquivalentSense_KeepingYourDPI = new System.Windows.Forms.Button();
            this.txt1CurrDPI = new System.Windows.Forms.TextBox();
            this.txt1CurrSens = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1NewDPI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1RESULT_SenseFound = new System.Windows.Forms.TextBox();
            this.tip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt2CurrDPI = new System.Windows.Forms.TextBox();
            this.txt2TheirDPI = new System.Windows.Forms.TextBox();
            this.txt2TheirSens = new System.Windows.Forms.TextBox();
            this.txt2RESULT_YourSenseForTheirEquivalent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl1ResultInfo = new System.Windows.Forms.Label();
            this.lbl1Example = new System.Windows.Forms.Label();
            this.lbl2ResultInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoAmIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindSenseForNewDPI
            // 
            this.btnFindSenseForNewDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSenseForNewDPI.Location = new System.Drawing.Point(32, 272);
            this.btnFindSenseForNewDPI.Name = "btnFindSenseForNewDPI";
            this.btnFindSenseForNewDPI.Size = new System.Drawing.Size(301, 56);
            this.btnFindSenseForNewDPI.TabIndex = 3;
            this.btnFindSenseForNewDPI.Text = "Find new XIM Sensitivity\r\n(Transfer to new DPI mouse)";
            this.btnFindSenseForNewDPI.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tip1.SetToolTip(this.btnFindSenseForNewDPI, "For a new DPI, find equivalnt Sensitivity to maintain same feel\r\n\r\nUseful for low" +
        "ering mouse DPI / moving mice.");
            this.btnFindSenseForNewDPI.UseVisualStyleBackColor = true;
            this.btnFindSenseForNewDPI.Click += new System.EventHandler(this.btnFindSenseForNewDPI_Click);
            // 
            // btnFindEquivalentSense_KeepingYourDPI
            // 
            this.btnFindEquivalentSense_KeepingYourDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindEquivalentSense_KeepingYourDPI.Location = new System.Drawing.Point(509, 292);
            this.btnFindEquivalentSense_KeepingYourDPI.Name = "btnFindEquivalentSense_KeepingYourDPI";
            this.btnFindEquivalentSense_KeepingYourDPI.Size = new System.Drawing.Size(326, 56);
            this.btnFindEquivalentSense_KeepingYourDPI.TabIndex = 7;
            this.btnFindEquivalentSense_KeepingYourDPI.Text = "Find equivalent XIM sensitivity for your DPI\r\n(given someone elses)";
            this.btnFindEquivalentSense_KeepingYourDPI.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tip1.SetToolTip(this.btnFindEquivalentSense_KeepingYourDPI, "Given another user\'s DPI : Sense ratio, obtain that same feel-ratio for my desire" +
        "d DPI\r\n\r\nUseful to equate what another persons XIM Sens + Their DPI is for your " +
        "DPI (finding that equivalent XIM sense)");
            this.btnFindEquivalentSense_KeepingYourDPI.UseVisualStyleBackColor = true;
            this.btnFindEquivalentSense_KeepingYourDPI.Click += new System.EventHandler(this.btnFindEquivalentSense_KeepingYourDPI_Click);
            // 
            // txt1CurrDPI
            // 
            this.txt1CurrDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1CurrDPI.Location = new System.Drawing.Point(227, 79);
            this.txt1CurrDPI.Name = "txt1CurrDPI";
            this.txt1CurrDPI.Size = new System.Drawing.Size(122, 22);
            this.txt1CurrDPI.TabIndex = 0;
            this.txt1CurrDPI.Text = "12,000";
            this.tip1.SetToolTip(this.txt1CurrDPI, "Last mouse DPI");
            this.txt1CurrDPI.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txt1CurrSens
            // 
            this.txt1CurrSens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1CurrSens.Location = new System.Drawing.Point(227, 106);
            this.txt1CurrSens.Name = "txt1CurrSens";
            this.txt1CurrSens.Size = new System.Drawing.Size(122, 22);
            this.txt1CurrSens.TabIndex = 1;
            this.txt1CurrSens.Text = "3.75";
            this.tip1.SetToolTip(this.txt1CurrSens, "XIM Sensitivity using with Last mouse");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. Current/Prev DPI (for changing):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "2. Current XIM Aim Sensitivity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "3. New DPI Setting Change To:";
            // 
            // txt1NewDPI
            // 
            this.txt1NewDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1NewDPI.Location = new System.Drawing.Point(227, 148);
            this.txt1NewDPI.Name = "txt1NewDPI";
            this.txt1NewDPI.Size = new System.Drawing.Size(122, 22);
            this.txt1NewDPI.TabIndex = 2;
            this.txt1NewDPI.Text = "25,000";
            this.tip1.SetToolTip(this.txt1NewDPI, "Current mouse DPI");
            this.txt1NewDPI.Leave += new System.EventHandler(this.txt1NewDPI_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "New XIM Sensitivity found:";
            // 
            // txt1RESULT_SenseFound
            // 
            this.txt1RESULT_SenseFound.BackColor = System.Drawing.SystemColors.Control;
            this.txt1RESULT_SenseFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1RESULT_SenseFound.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt1RESULT_SenseFound.Location = new System.Drawing.Point(227, 176);
            this.txt1RESULT_SenseFound.Name = "txt1RESULT_SenseFound";
            this.txt1RESULT_SenseFound.Size = new System.Drawing.Size(122, 24);
            this.txt1RESULT_SenseFound.TabIndex = 10;
            this.tip1.SetToolTip(this.txt1RESULT_SenseFound, "Result: New sensitivity for this new DPI");
            // 
            // txt2CurrDPI
            // 
            this.txt2CurrDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2CurrDPI.Location = new System.Drawing.Point(673, 76);
            this.txt2CurrDPI.Name = "txt2CurrDPI";
            this.txt2CurrDPI.Size = new System.Drawing.Size(122, 22);
            this.txt2CurrDPI.TabIndex = 4;
            this.txt2CurrDPI.Text = "12,000";
            this.tip1.SetToolTip(this.txt2CurrDPI, "Your current DPI, which will remain constant");
            this.txt2CurrDPI.Leave += new System.EventHandler(this.txt2CurrDPI_Leave);
            // 
            // txt2TheirDPI
            // 
            this.txt2TheirDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2TheirDPI.Location = new System.Drawing.Point(673, 126);
            this.txt2TheirDPI.Name = "txt2TheirDPI";
            this.txt2TheirDPI.Size = new System.Drawing.Size(122, 22);
            this.txt2TheirDPI.TabIndex = 5;
            this.txt2TheirDPI.Text = "800";
            this.tip1.SetToolTip(this.txt2TheirDPI, "Their DPI");
            this.txt2TheirDPI.Leave += new System.EventHandler(this.txt2TheirDPI_Leave);
            // 
            // txt2TheirSens
            // 
            this.txt2TheirSens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2TheirSens.Location = new System.Drawing.Point(673, 154);
            this.txt2TheirSens.Name = "txt2TheirSens";
            this.txt2TheirSens.Size = new System.Drawing.Size(122, 22);
            this.txt2TheirSens.TabIndex = 6;
            this.txt2TheirSens.Text = "500";
            this.tip1.SetToolTip(this.txt2TheirSens, "Their XIM Aim Sensitivity");
            // 
            // txt2RESULT_YourSenseForTheirEquivalent
            // 
            this.txt2RESULT_YourSenseForTheirEquivalent.BackColor = System.Drawing.SystemColors.Control;
            this.txt2RESULT_YourSenseForTheirEquivalent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2RESULT_YourSenseForTheirEquivalent.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt2RESULT_YourSenseForTheirEquivalent.Location = new System.Drawing.Point(673, 206);
            this.txt2RESULT_YourSenseForTheirEquivalent.Name = "txt2RESULT_YourSenseForTheirEquivalent";
            this.txt2RESULT_YourSenseForTheirEquivalent.Size = new System.Drawing.Size(122, 24);
            this.txt2RESULT_YourSenseForTheirEquivalent.TabIndex = 18;
            this.tip1.SetToolTip(this.txt2RESULT_YourSenseForTheirEquivalent, "Result: Your sensitivity, given your DPI, to obtain the same feel");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(328, 30);
            this.label12.TabIndex = 26;
            this.label12.Text = "I. Translate to a new mouse DPI:";
            this.tip1.SetToolTip(this.label12, "This is not really required, as you could simply set your new mouse to use our ol" +
        "d mouse\'s DPI, but perhaps if you wanted to increase to the max (unsure if even " +
        "beneficial)");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(471, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(426, 30);
            this.label13.TabIndex = 27;
            this.label13.Text = "II. Find the \"feel\" of someone else\'s setup:";
            this.tip1.SetToolTip(this.label13, "Obtain someone else\'s identical-ish feel for their DPI : Sens. \r\nThis finds what " +
        "XIM Aim Sensitivity you need given you DPI.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "1. Current DPI (to keep):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "2. Other persons DPI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(507, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "3. Other persons Sensititvy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Your equivalent Sensitivity, keeping existing DPI";
            // 
            // lbl1ResultInfo
            // 
            this.lbl1ResultInfo.AutoSize = true;
            this.lbl1ResultInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1ResultInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl1ResultInfo.Location = new System.Drawing.Point(29, 205);
            this.lbl1ResultInfo.Name = "lbl1ResultInfo";
            this.lbl1ResultInfo.Size = new System.Drawing.Size(16, 15);
            this.lbl1ResultInfo.TabIndex = 19;
            this.lbl1ResultInfo.Text = "...";
            // 
            // lbl1Example
            // 
            this.lbl1Example.AutoSize = true;
            this.lbl1Example.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl1Example.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Example.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl1Example.Location = new System.Drawing.Point(277, 333);
            this.lbl1Example.Name = "lbl1Example";
            this.lbl1Example.Size = new System.Drawing.Size(56, 15);
            this.lbl1Example.TabIndex = 20;
            this.lbl1Example.Text = "Example";
            this.lbl1Example.Click += new System.EventHandler(this.lbl1Example_Click);
            // 
            // lbl2ResultInfo
            // 
            this.lbl2ResultInfo.AutoSize = true;
            this.lbl2ResultInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ResultInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl2ResultInfo.Location = new System.Drawing.Point(506, 253);
            this.lbl2ResultInfo.Name = "lbl2ResultInfo";
            this.lbl2ResultInfo.Size = new System.Drawing.Size(16, 15);
            this.lbl2ResultInfo.TabIndex = 21;
            this.lbl2ResultInfo.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(779, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Example";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(490, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(408, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "This assumes your Aim \'Synchronize\' matches theirs (ex: Off or Common).";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(490, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Thus, ensure all their settings are copied over as intended.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoAmIToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // whoAmIToolStripMenuItem
            // 
            this.whoAmIToolStripMenuItem.Name = "whoAmIToolStripMenuItem";
            this.whoAmIToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.whoAmIToolStripMenuItem.Text = "WhoAmI";
            this.whoAmIToolStripMenuItem.Click += new System.EventHandler(this.whoAmIToolStripMenuItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(386, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 30);
            this.label14.TabIndex = 28;
            this.label14.Text = "[OR]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 423);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl2ResultInfo);
            this.Controls.Add(this.lbl1Example);
            this.Controls.Add(this.lbl1ResultInfo);
            this.Controls.Add(this.txt2RESULT_YourSenseForTheirEquivalent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt2TheirSens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt2TheirDPI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2CurrDPI);
            this.Controls.Add(this.txt1RESULT_SenseFound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt1NewDPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1CurrSens);
            this.Controls.Add(this.txt1CurrDPI);
            this.Controls.Add(this.btnFindEquivalentSense_KeepingYourDPI);
            this.Controls.Add(this.btnFindSenseForNewDPI);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XIM Sensitivity + DPI Converter          -- By AltF4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindSenseForNewDPI;
        private System.Windows.Forms.Button btnFindEquivalentSense_KeepingYourDPI;
        private System.Windows.Forms.TextBox txt1CurrDPI;
        private System.Windows.Forms.TextBox txt1CurrSens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1NewDPI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1RESULT_SenseFound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2CurrDPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt2TheirDPI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt2TheirSens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt2RESULT_YourSenseForTheirEquivalent;
        private System.Windows.Forms.Label lbl1ResultInfo;
        private System.Windows.Forms.Label lbl1Example;
        private System.Windows.Forms.Label lbl2ResultInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoAmIToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

