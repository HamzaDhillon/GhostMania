using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace Desktop_Game
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
        }

        List<PictureBox> vendor_fire = new List<PictureBox>();
        int count = 0;
        public int score_count;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score_count = 0;
        }
        bool up=false,down=false,right=false,left=false;

        void vendor_move()
        {
            if (up == true)
            {
                if (pictureBox1.Top > 0)
                {
                    pictureBox1.Top -= 5;
                }
            }
            if (down == true)
            {
                if (pictureBox1.Top < 570)
                {
                    pictureBox1.Top += 5;
                }
            }
            if (left == true)
            {
                if (pictureBox1.Left > 0)
                {
                    pictureBox1.Left -= 5;
                }
            }
            if (right == true)
            {
                if (pictureBox1.Left < 1280)
                {
                    pictureBox1.Left += 5;
                }
            }



        }
     
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                Application.Exit();
            }


            //Maintaining the vendor at bottom
            if (pictureBox1.Top < 530)
            {
                pictureBox1.Top += 2;
            }

            vendor_move();

            if (count == 15)
            {
                Score.Text = score_count.ToString();
                count = 0;
                score_count++;
                END.Instance.scoree = score_count;

            }
            count++;

            setGhostOne();
            setGhostTwo();
            setGhostThree();
            set_bat();
            setBatTwo();
            set_Spider();


            //Fire
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                create_fire();

            }
            move_fire();
            remove_fire();
            kill_GhostOne();
            kill_GhostTwo();
            kill_GhostThree();
            if (GameEnding() == true)
            {
                
                timer1.Stop();
                this.Hide();
                END Form = new END();
                Form.Show();
            }
        }
        private void set_bat()
        {
            //Conditions For Bat
            Bat.Left -= 2;
            if (Bat.Left <= -20)
            {
                Bat.Left = 1280;
            }
        }
        private void setBatTwo()
        {
            //Conditions For Ghost

            Bat2.Left -= 1;
            Bat2.Top += 1;
            if (Bat2.Top >= 700)
            {
                Bat2.Top = -100;
            }
        }
        private void set_Spider()
        {

            //Conditions For Spider
            pictureBox2.Top += 2;
            if (pictureBox2.Top >= 700)
            {
                pictureBox2.Top = -80;
            }
        }
       
        private void kill_GhostOne()
        {
            //In Case ghost is fired two bullets
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "B")
                {
                    if (Ghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        Ghost.Location = new System.Drawing.Point(2083, 184);
                    }
                }
            }
        }
        private void kill_GhostTwo()
        {

            foreach (Control y in this.Controls)
            {
                if ((string)y.Tag == "B")
                {
                    if (Ghost2.Bounds.IntersectsWith(y.Bounds))
                    {
                        Ghost2.Location = new System.Drawing.Point(707, -100);
                    }
                }
            }
        }
        private void kill_GhostThree()
        {

            foreach (Control y in this.Controls)
            {
                if ((string)y.Tag == "B")
                {
                    if (Ghost3.Bounds.IntersectsWith(y.Bounds))
                    {
                        Ghost3.Location = new System.Drawing.Point(72, -100);
                    }
                }
            }
        }
        private void setGhostThree()
        {
            //Conditions For Ghost

            Ghost3.Left += 1;
            Ghost3.Top += 1;
        }
        private void setGhostOne()
        {
            //Conditions For Ghost

            if (Ghost.Left > pictureBox1.Left)
            {
                Ghost.Left -= 2;
            }
            if (Ghost.Left < pictureBox1.Left)
            {
                Ghost.Left += 2;

            }

            if (Ghost.Top > pictureBox1.Top)
            {
                Ghost.Top -= 2;
            }
            if (Ghost.Top < pictureBox1.Top)
            {
                Ghost.Top += 2;

            }
        }
        private void setGhostTwo()
        {
            //Conditions For Ghost

            if (Ghost2.Left > pictureBox1.Left)
            {
                Ghost2.Left -= 1;
            }
            if (Ghost2.Left < pictureBox1.Left)
            {
                Ghost2.Left += 1;

            }

            if (Ghost2.Top > pictureBox1.Top)
            {
                Ghost2.Top -= 1;
            }
            if (Ghost2.Top < pictureBox1.Top)
            {
                Ghost2.Top += 1;

            }
        }
        private bool GameEnding()
        {
            //In Case ghost is fired two bullets
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "C")
                {
                    if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        private void create_fire()
        {
            PictureBox fire = new PictureBox();
            fire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            fire.BackColor = System.Drawing.Color.Transparent;
            fire.BackgroundImage = global::Desktop_Game.Properties.Resources.istockphoto_1090969260_;
            fire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            fire.Location = new System.Drawing.Point(139, 472);
            fire.Margin = new System.Windows.Forms.Padding(4);
            fire.Name = "fire";
            fire.Size = new System.Drawing.Size(34, 10);
            fire.TabIndex = 7;
            fire.TabStop = false;
            fire.Tag = "B";

            fire.Left = pictureBox1.Left + 140;
            fire.Top = pictureBox1.Top + 80;

            vendor_fire.Add(fire);
            this.Controls.Add(fire);
        }
        private void move_fire()
        {
            foreach(PictureBox fire in vendor_fire)
            {
                fire.Left += 10;
            }
        }
        private void remove_fire()
        {
            for(int i = 0; i < vendor_fire.Count; i++)
            {
                if (vendor_fire[i].Left <= 0)
                {
                    vendor_fire.Remove(vendor_fire[i]);
                }
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int rand()
        {

            Random random;
            random = new Random();
            int x = random.Next(0,50);
            return x;

        }
       
    }
}
