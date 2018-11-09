namespace Mini_puzzle
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonH);
            this.panel1.Controls.Add(this.buttonG);
            this.panel1.Controls.Add(this.buttonF);
            this.panel1.Controls.Add(this.buttonE);
            this.panel1.Controls.Add(this.buttonD);
            this.panel1.Controls.Add(this.buttonB);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.buttonA);
            this.panel1.Location = new System.Drawing.Point(11, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonH
            // 
            this.buttonH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonH.Location = new System.Drawing.Point(120, 225);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(100, 100);
            this.buttonH.TabIndex = 7;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = false;
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonG.Location = new System.Drawing.Point(14, 225);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(100, 100);
            this.buttonG.TabIndex = 6;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = false;
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonF.Location = new System.Drawing.Point(226, 120);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(100, 100);
            this.buttonF.TabIndex = 5;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = false;
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonE.Location = new System.Drawing.Point(120, 120);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(100, 100);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonD.Location = new System.Drawing.Point(14, 119);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(100, 100);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonB.Location = new System.Drawing.Point(120, 13);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(100, 100);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonC.Location = new System.Drawing.Point(226, 13);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(100, 100);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonA.Location = new System.Drawing.Point(14, 13);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(100, 100);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuxToolStripMenuItem
            // 
            this.jeuxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonOffToolStripMenuItem,
            this.relancerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.jeuxToolStripMenuItem.Name = "jeuxToolStripMenuItem";
            this.jeuxToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.jeuxToolStripMenuItem.Text = "Jeux";
            // 
            // sonOffToolStripMenuItem
            // 
            this.sonOffToolStripMenuItem.Name = "sonOffToolStripMenuItem";
            this.sonOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sonOffToolStripMenuItem.Text = "Son Off";
            // 
            // relancerToolStripMenuItem
            // 
            this.relancerToolStripMenuItem.Name = "relancerToolStripMenuItem";
            this.relancerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.relancerToolStripMenuItem.Text = "Relancer";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mini puzzle";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

