
namespace Desktop_Game
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Ghost2 = new System.Windows.Forms.PictureBox();
            this.Ghost3 = new System.Windows.Forms.PictureBox();
            this.Bat2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Desktop_Game.Properties.Resources.ch;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 451);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Block";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ghost
            // 
            this.Ghost.BackColor = System.Drawing.Color.Transparent;
            this.Ghost.BackgroundImage = global::Desktop_Game.Properties.Resources.Ghost3;
            this.Ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ghost.Location = new System.Drawing.Point(2083, 184);
            this.Ghost.Margin = new System.Windows.Forms.Padding(4);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(109, 77);
            this.Ghost.TabIndex = 1;
            this.Ghost.TabStop = false;
            this.Ghost.Tag = "C";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Gray;
            this.Score.Location = new System.Drawing.Point(1209, -1);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(59, 20);
            this.Score.TabIndex = 2;
            this.Score.Text = "label1";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1417, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1160, -1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Desktop_Game.Properties.Resources.Spider2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(587, -70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 61);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "C";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Bat
            // 
            this.Bat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.BackgroundImage = global::Desktop_Game.Properties.Resources.Bat11;
            this.Bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bat.Location = new System.Drawing.Point(1271, 137);
            this.Bat.Margin = new System.Windows.Forms.Padding(4);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(103, 42);
            this.Bat.TabIndex = 6;
            this.Bat.TabStop = false;
            this.Bat.Tag = "C";
            // 
            // Ghost2
            // 
            this.Ghost2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ghost2.BackColor = System.Drawing.Color.Transparent;
            this.Ghost2.BackgroundImage = global::Desktop_Game.Properties.Resources.Ghost5;
            this.Ghost2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ghost2.Location = new System.Drawing.Point(707, -100);
            this.Ghost2.Margin = new System.Windows.Forms.Padding(4);
            this.Ghost2.Name = "Ghost2";
            this.Ghost2.Size = new System.Drawing.Size(77, 84);
            this.Ghost2.TabIndex = 7;
            this.Ghost2.TabStop = false;
            this.Ghost2.Tag = "C";
            // 
            // Ghost3
            // 
            this.Ghost3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ghost3.BackColor = System.Drawing.Color.Transparent;
            this.Ghost3.BackgroundImage = global::Desktop_Game.Properties.Resources.Ghost1;
            this.Ghost3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ghost3.Location = new System.Drawing.Point(72, -100);
            this.Ghost3.Margin = new System.Windows.Forms.Padding(4);
            this.Ghost3.Name = "Ghost3";
            this.Ghost3.Size = new System.Drawing.Size(73, 88);
            this.Ghost3.TabIndex = 8;
            this.Ghost3.TabStop = false;
            this.Ghost3.Tag = "C";
            // 
            // Bat2
            // 
            this.Bat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bat2.BackColor = System.Drawing.Color.Transparent;
            this.Bat2.BackgroundImage = global::Desktop_Game.Properties.Resources.Bat11;
            this.Bat2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bat2.Location = new System.Drawing.Point(832, -100);
            this.Bat2.Margin = new System.Windows.Forms.Padding(4);
            this.Bat2.Name = "Bat2";
            this.Bat2.Size = new System.Drawing.Size(107, 50);
            this.Bat2.TabIndex = 9;
            this.Bat2.TabStop = false;
            this.Bat2.Tag = "C";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::Desktop_Game.Properties.Resources.My_project_1__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 692);
            this.Controls.Add(this.Bat2);
            this.Controls.Add(this.Ghost3);
            this.Controls.Add(this.Ghost2);
            this.Controls.Add(this.Bat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Ghost;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Ghost2;
        private System.Windows.Forms.PictureBox Ghost3;
        private System.Windows.Forms.PictureBox Bat2;
    }
}

