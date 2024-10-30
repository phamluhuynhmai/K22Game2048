using System;
using System.Windows.Forms;

namespace game2048
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();

            textSpec.Text = "1. Mục tiêu là kết hợp các ô phù hợp để đạt được ô 2048.\n\n" +
                            "2. Vuốt sang trái, phải, lên hoặc xuống để di chuyển\n" +
                            "    tất cả các ô theo hướng đó. Mỗi lần di chuyển, một ô mới\n" +
                            "    (2 hoặc 4) sẽ xuất hiện ở một chỗ trống.\n\n" +
                            "3. Các ô có cùng giá trị được kết hợp bằng cách\n" +
                            "    di chuyển chúng vào nhau.\n\n" +
                            "4. Khi hai ô có cùng giá trị kết hợp với nhau, chúng sẽ\n" +
                            "    hợp nhất thành một ô có giá trị bằng tổng của chúng.";
            textSpec.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        // Nhấn nút "Bắt đầu"
        private void button1_Click_1(object sender, EventArgs e)
        {
            game2048.Endgame.gameRefresh = false;
            PlayGround pg = new PlayGround(this);
            Endgame eg = new Endgame(this, pg);
            pg.Show();
            Hide();
        }

        // Nhấn nút "Quy tắc"
        private void specButton_Click(object sender, EventArgs e)
        {
            Specification.BringToFront();
        }

        // Nhấn nút "Quay lại"
        private void backButton_Click(object sender, EventArgs e)
        {
            mainMenu.BringToFront();
        }
    }
}
