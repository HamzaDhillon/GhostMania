using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Game
{
    public partial class END : Form
    {
        public int scoree;
        private static END _instance;
        public static END Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new END();
                }
                return _instance;
            }
        }
        public END()
        {
            InitializeComponent();
            //label2.Text=scoree.ToString();
            label2.Text = Form1.Instance.score_count.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void END_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
