namespace s1131759
{
    public partial class FormStart : Form
    {
        private List<string> ranking = new List<string>();              // 用來儲存排行榜的記錄
        private readonly string rankingFile = "ranking.txt";  // 排行榜檔案名稱
        public FormStart()
        {
            InitializeComponent();
            LoadRankingFromFile();                  // 載入排行榜資料
            UpdateRankingListBox();                 // 更新排行榜顯示
            rdoEasy.Checked = true;                 // 預設選擇簡單難度
        }

        // 按下開始遊戲按鈕事件
        private void btnStart_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();

            // 檢查玩家姓名是否輸入
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("請輸入玩家姓名。");
                return;
            }

            // 取得玩家選擇的難度
            string difficulty = rdoEasy.Checked ? "簡單" : "困難";

            // 建立遊戲表單，並傳遞玩家姓名與難度
            FormGame gameForm = new FormGame(playerName, difficulty);
            gameForm.FormClosed += GameForm_FormClosed; // 遊戲結束後刷新排行榜
            gameForm.Show();

            this.Hide();   // 隱藏首頁
        }
        // 遊戲結束後顯示首頁並刷新排行榜
        private void GameForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadRankingFromFile();      // 重新讀取排行榜
            UpdateRankingListBox();     // 更新排行榜列表
            SaveRankingToFile();  // 自動存檔
            this.Show();                // 顯示首頁
        }
        // 從檔案讀取排行榜資料
        private void LoadRankingFromFile()
        {
            if (File.Exists(rankingFile))
            {
                ranking = new List<string>(File.ReadAllLines(rankingFile));
            }
            else
            {
                ranking = new List<string>();
            }
        }
        private void SaveRankingToFile()
        {
            try
            {
                File.WriteAllLines(rankingFile, ranking);
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message);
            }
        }
        // 更新排行榜ListBox的顯示內容
        private void UpdateRankingListBox()
        {
            lstRanking.Items.Clear();
            for (int i = 0; i < ranking.Count; i++)
            {
                lstRanking.Items.Add($"第 {i + 1} 名 - {ranking[i]}");
            }
        }

        private void lblRanking_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            saveFileDialog1.Title = "另存排行榜檔案";
            saveFileDialog1.FileName = "ranking_backup.txt"; // 預設檔名

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog1.FileName, ranking);
                    MessageBox.Show("排行榜已成功另存新檔！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存失敗：" + ex.Message);
                }
            }
        }

        private void grpDifficulty_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
