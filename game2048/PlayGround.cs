using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Media;

namespace game2048
{
    // Thêm chú thích vì sự thoải mái của người đọc
    public partial class PlayGround : Form
    {
        Random rand = new Random();                                                 // Biến tạo số ngẫu nhiên
        Menu m = new Menu();                                                        // Con trỏ lưu cửa sổ màn hình chính
        PictureBox[,] pic = new PictureBox[4, 4];                                   // Ma trận lưu đồ họa của ô
        int[,] cube = new int[4, 4];                                                // Ma trận lưu giá trị của ô
        bool[,] merged = new bool[4, 4];                                            // Ma trận đánh dấu các ô đã hợp nhất trong lần di chuyển
        int currentScore = 0;                                                       // Biến lưu điểm hiện tại

        string fileHighScore = "bestscore_data\\BestScore.txt";                     // Tệp lưu điểm kỷ lục

        SoundPlayer soundGameOver = new SoundPlayer(@"game_sounds\gameover.wav");   // Âm thanh trò chơi kết thúc
        SoundPlayer soundYouWin = new SoundPlayer(@"game_sounds\youwin.wav");       // Âm thanh trò chơi hoàn thành

        public PlayGround(Menu form1)
        {
            InitializeComponent();

            // Biến lưu phím được bấm
            KeyDown += new KeyEventHandler(KeyBoardPress);

            // Ẩn màn hình chính
            m = form1;
            m.Hide();

            // Hiển thị điểm kỷ lục
            bestScore.Text = "Kỷ lục: ";
            if (File.Exists(fileHighScore))
                using (StreamReader sr = new StreamReader(fileHighScore))
                    bestScore.Text += sr.ReadToEnd();
            else
                bestScore.Text += "0";

            // Gán giá trị mặc định trống cho các ô
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    cube[i, j] = -1;

            // Khởi tạo 2 ô có giá trị và vị trí ngẫu nhiên
            int x1, y1, x2, y2;

            do
            {
                x1 = rand.Next(4);
                y1 = rand.Next(4);
                x2 = rand.Next(4);
                y2 = rand.Next(4);
            } while (x1 == x2 && y1 == y2);

            CreateCube(x1, y1, ScoreGenerate());
            CreateCube(x2, y2, ScoreGenerate());
        }

        // Hàm trả về giá trị ngẫu nhiên 2/4
        int ScoreGenerate()
        {
            if (rand.Next(0, 100) % 4 > 0) // 75% ra số 2
                return 2;
            return 4;
        }

        // Hàm tạo ô với vị trí và giá trị truyền vào
        void CreateCube(int row, int collumn, int score)
        {
            pic[row, collumn] = new PictureBox();
            pic[row, collumn].Location = new Point(30 + 120 * collumn, 200 + 120 * row);
            Controls.Add(pic[row, collumn]);
            pic[row, collumn].BringToFront();
            pic[row, collumn].Size = new Size(100, 100);
            cube[row, collumn] = score;
            switch (score)
            {
                case 2:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_2.png");
                    break;
                case 4:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_4.png");
                    break;
                case 8:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_8.png");
                    break;
                case 16:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_16.png");
                    break;
                case 32:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_32.png");
                    break;
                case 64:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_64.png");
                    break;
                case 128:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_128.png");
                    break;
                case 256:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_256.png");
                    break;
                case 512:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_512.png");
                    break;
                case 1024:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_1024.png");
                    break;
                case 2048:
                    pic[row, collumn].BackgroundImage = Image.FromFile(@"score_pics\score_2048.png");
                    break;
                // Phòng tránh ô có giá trị không hợp lệ
                default:
                    cube[row, collumn] = -1;
                    pic[row, collumn].Dispose();
                    break;
            }
        }

        void KeyBoardPress(object sender, KeyEventArgs e)
        {
            bool changed = false;
            bool final = false;

            if ((new string[] { "Up", "Down", "Left", "Right" }).Contains(e.KeyCode.ToString()))
            {
                // Di chuyển các ô trong ma trận theo phím được bấm
                switch (e.KeyCode.ToString())
                {
                    case "Up":
                        for (int k = 0; k < 3; k++)
                            for (int i = 1; i <= 3; i++)
                                for (int j = 0; j <= 3; j++)
                                    MoveTiles(i, j, ref cube[i - 1, j], ref merged[i - 1, j], ref changed);
                        break;
                    case "Down":
                        for (int k = 0; k < 3; k++)
                            for (int i = 2; i >= 0; i--)
                                for (int j = 0; j <= 3; j++)
                                    MoveTiles(i, j, ref cube[i + 1, j], ref merged[i + 1, j], ref changed);
                        break;
                    case "Left":
                        for (int k = 0; k < 3; k++)
                            for (int i = 0; i < 4; i++)
                                for (int j = 1; j <= 3; j++)
                                    MoveTiles(i, j, ref cube[i, j - 1], ref merged[i, j - 1], ref changed);
                        break;
                    case "Right":
                        for (int k = 0; k < 3; k++)
                            for (int i = 0; i < 4; i++)
                                for (int j = 2; j >= 0; j--)
                                    MoveTiles(i, j, ref cube[i, j + 1], ref merged[i, j + 1], ref changed);
                        break;
                    default:
                        break;
                }

                // Làm mới ma trận sau khi di chuyển
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                    {
                        if (pic[i, j] != null)
                            pic[i, j].Dispose();
                        Controls.Remove(pic[i, j]);
                        if (cube[i, j] > 0)
                            CreateCube(i, j, cube[i, j]);
                        if (cube[i, j] == 2048)
                            final = true;
                    }

                // Hiển thị và quản lý điểm
                string highScore;

                if (File.Exists(fileHighScore))
                    using (StreamReader sw = new StreamReader(fileHighScore))
                        highScore = sw.ReadToEnd();
                else
                    highScore = "0";

                textScore.Text = "Điểm: \t" + Convert.ToString(currentScore);

                if (currentScore > Int32.Parse(highScore))
                {
                    using (StreamWriter sw = new StreamWriter(fileHighScore, false))
                        sw.WriteLine(currentScore);
                    bestScore.Text = "Kỷ lục: \t" + Convert.ToString(currentScore);
                }

                // Làm mới ma trận đánh dấu
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        merged[i, j] = false;
                
                // Kiểm tra ma trận đầy hay chưa
                bool filled = true;
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (cube[i, j] < 0)
                            filled = false;

                // Nếu ma trận chưa đầy, thêm ô
                if (!filled && changed)
                {
                    int x, y;

                    do
                    {
                        x = rand.Next(0, 4);
                        y = rand.Next(0, 4);
                    } while (cube[x, y] > 0);

                    CreateCube(x, y, ScoreGenerate());

                    filled = true;
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                            if (cube[i, j] < 0)
                                filled = false;
                }

                // Nếu ma trận đầy, kiểm tra nước đi hợp lệ
                bool endGame = false;
                if (filled)
                {
                    bool moveable = false;
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 4; j++)
                            if (cube[i, j] == cube[i + 1, j])
                                moveable = true;
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 3; j++)
                            if (cube[i, j] == cube[i, j + 1])
                                moveable = true;
                    // Đánh dấu trò chơi kết thúc
                    if (!moveable)
                        endGame = true;
                }

                // Trò chơi kết thúc (endGame = thua, final = thắng)
                if (endGame || final)
                {
                    Endgame eg = new Endgame(m, this);
                    if (final)
                    {
                        soundYouWin.Play();
                        eg.labelMenu.Location = new Point(128, 23);
                        eg.labelMenu.ForeColor = Color.Green;
                        eg.labelMenu.Text = "Chiến thắng";
                    }
                    else
                    {
                        soundGameOver.Play();
                        eg.labelMenu.Location = new Point(88, 23);
                        eg.labelMenu.ForeColor = Color.Red;
                        eg.labelMenu.Text = "Trò chơi kết thúc";
                    }
                    while (!game2048.Endgame.gameRefresh)
                        eg.ShowDialog();
                    game2048.Endgame.gameRefresh = false;
                }
            }
        }

        // Hàm di chuyển giá trị ô
        // row, collumn là vị trí của ô cần di chuyển
        // cubeValue, cubeMerge là giá trị và đánh dấu ô đích đến có hợp nhất chưa
        // changed đánh dấu ma trận đã có sự di chuyển chưa
        void MoveTiles(int row, int collumn, ref int cubeValue, ref bool cubeMerged, ref bool changed)
        {
            // Di chuyển đến ô trống
            if (cube[row, collumn] > 0 && cubeValue < 0)
            {
                cubeValue = cube[row, collumn];
                cube[row, collumn] = -1;
                changed = true;
            }
            // Hợp nhất với ô khác nếu có cùng giá trị
            else if (!cubeMerged && !merged[row, collumn] && cube[row, collumn] > 0 && cube[row, collumn] == cubeValue)
            {
                cubeValue *= 2;
                currentScore += cubeValue;
                cube[row, collumn] = -1;
                cubeMerged = true;
                changed = true;
            }
        }

        // Quay về màn hình chính khi thoát
        void PlayGround_FormClosing(object sender, FormClosingEventArgs e)
        {
            m.Show();
        }
    }
}
