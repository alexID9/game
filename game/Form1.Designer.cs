namespace game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            villain1 = new PictureBox();
            villain2 = new PictureBox();
            villain3 = new PictureBox();
            hero = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)villain1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)villain2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)villain3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hero).BeginInit();
            SuspendLayout();
            // 
            // villain1
            // 
            villain1.Image = Properties.Resources.v1;
            villain1.Location = new Point(8, 7);
            villain1.Margin = new Padding(2, 2, 2, 2);
            villain1.Name = "villain1";
            villain1.Size = new Size(70, 60);
            villain1.TabIndex = 0;
            villain1.TabStop = false;
            // 
            // villain2
            // 
            villain2.Image = Properties.Resources.v2;
            villain2.Location = new Point(8, 105);
            villain2.Margin = new Padding(2, 2, 2, 2);
            villain2.Name = "villain2";
            villain2.Size = new Size(70, 60);
            villain2.TabIndex = 1;
            villain2.TabStop = false;
            // 
            // villain3
            // 
            villain3.Image = Properties.Resources.v3;
            villain3.Location = new Point(8, 203);
            villain3.Margin = new Padding(2, 2, 2, 2);
            villain3.Name = "villain3";
            villain3.Size = new Size(70, 60);
            villain3.TabIndex = 2;
            villain3.TabStop = false;
            // 
            // hero
            // 
            hero.Image = Properties.Resources.h1;
            hero.Location = new Point(288, 92);
            hero.Margin = new Padding(2, 2, 2, 2);
            hero.Name = "hero";
            hero.Size = new Size(70, 60);
            hero.TabIndex = 3;
            hero.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 326);
            Controls.Add(hero);
            Controls.Add(villain3);
            Controls.Add(villain2);
            Controls.Add(villain1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            this.MouseMove += this.MouseMove;
            ((System.ComponentModel.ISupportInitialize)villain1).EndInit();
            ((System.ComponentModel.ISupportInitialize)villain2).EndInit();
            ((System.ComponentModel.ISupportInitialize)villain3).EndInit();
            ((System.ComponentModel.ISupportInitialize)hero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox villain1;
        private PictureBox villain2;
        private PictureBox villain3;
        private PictureBox hero;
        private System.Windows.Forms.Timer timer;
    }
}