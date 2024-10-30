using System;
using System.Windows.Forms;

namespace game2048
{
    public partial class Endgame : Form
    {

        public static bool gameRefresh = false;
        Menu m = new Menu();
        PlayGround pg;

        public Endgame(Menu form1, PlayGround form2)
        {
            InitializeComponent();
            pg = new PlayGround(m);
            pg = form2;
            m = form1;
        }

        // Thoát về menu
        private void button2_Click(object sender, EventArgs e)
        {
            gameRefresh = true;
            Close();
            pg.Close();
        }

        // Bắt đầu lại
        private void button1_Click(object sender, EventArgs e)
        {
            gameRefresh = true;
            Close();
            pg.Close();
            m.Hide();
            pg = new PlayGround(m);
            pg.Show();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }

        private void Endgame_Load(object sender, EventArgs e)
        {

        }
    }
}