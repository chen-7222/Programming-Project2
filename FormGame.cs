using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // ✅ 引入 Stopwatch 所需命名空間
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1131759
{
    public partial class FormGame : Form
    {
        private string playerName;          // 玩家姓名
        private string difficulty;          // 難度（簡單或困難）
        private List<int> numbers = new List<int>(); // 顯示的數字列表
        private int currentIndex;           // 目前顯示的數字索引
        private int totalSum;               // 數字加總結果
        private int timeLeft;               // 答題剩餘時間（秒）
        private List<string> ranking = new List<string>();  // 排行榜資料
        private readonly string rankingFile = "ranking.txt"; // 排行榜檔案名稱
        private Stopwatch stopwatch = new Stopwatch();       // ✅ 用於精準記錄實際作答時間

        public FormGame(string playerName, string difficulty)
        {
            InitializeComponent();
            this.playerName = playerName;
            this.difficulty = difficulty;

            LoadRankingFromFile();     // 讀取排行榜
            InitializeGameUI();        // 初始化畫面

            // 綁定事件
            timerShowNumbers.Tick += timerShowNumbers_Tick;
            timerCountdown.Tick += timerCountdown_Tick;
            btnSubmit.Click += btnSubmit_Click;
            btnStart.Click += btnStart_Click;
        }

        // 初始化畫面
        private void InitializeGameUI()
        {
            lblNumber.Text = "";
            lblCountdown.Text = "請按「開始」開始遊戲";
            txtAnswer.Text = "";
            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;
            btnStart.Enabled = true;
        }

        // 產生 10 個隨機不重複數字
        private void GenerateNumbers(int maxNumber)
        {
            Random rnd = new Random();
            numbers = new List<int>();

            if (maxNumber < 10)
            {
                MessageBox.Show("數字上限必須大於等於 10。");
                return;
            }

            List<int> pool = Enumerable.Range(1, maxNumber)
                                       .OrderBy(x => rnd.Next())
                                       .Take(10)
                                       .ToList();
            numbers.AddRange(pool);
        }

        // 每次顯示一個數字
        private void timerShowNumbers_Tick(object? sender, EventArgs e)
        {
            if (currentIndex < numbers.Count)
            {
                int num = numbers[currentIndex];
                lblNumber.Text = num.ToString();
                totalSum += num;
                currentIndex++;
            }
            else
            {
                // 顯示完畢，轉為答題模式
                timerShowNumbers.Stop();
                lblNumber.Text = "請輸入答案";
                txtAnswer.Enabled = true;
                btnSubmit.Enabled = true;
                txtAnswer.Focus();

                timeLeft = 20;
                lblCountdown.Text = $"剩餘時間: {timeLeft} 秒";
                stopwatch.Restart();            // ✅ 現在才開始記錄「作答時間」
                timerCountdown.Start();
            }
        }

        // 倒數計時器（每秒）
        private void timerCountdown_Tick(object? sender, EventArgs e)
        {
            timeLeft--;
            lblCountdown.Text = $"剩餘時間: {timeLeft} 秒";

            if (timeLeft <= 0)
            {
                timerCountdown.Stop();
                txtAnswer.Enabled = false;
                btnSubmit.Enabled = false;
                CheckAnswer(); // 超時仍會自動驗證
            }
        }

        // 使用者按下送出答案
        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("請輸入答案！");
                return;
            }

            timerCountdown.Stop();       // 停止倒數
            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;

            CheckAnswer();               // 驗證答案
        }

        // 核對答案、顯示訊息、紀錄排行榜
        private void CheckAnswer()
        {
            stopwatch.Stop(); // ✅ 停止記錄使用時間

            // 計算實際使用秒數與剩餘時間
            double usedSeconds = stopwatch.Elapsed.TotalSeconds;
            double remainingSeconds = 20 - usedSeconds;
            if (remainingSeconds < 0) remainingSeconds = 0;

            // 判斷正確性
            bool isCorrect = int.TryParse(txtAnswer.Text.Trim(), out int userAnswer)
                             && userAnswer == totalSum;

            string message;
            if (isCorrect)
            {
                message = $"答對了！花費時間：{usedSeconds:F1} 秒";
                SaveRankingEntry(remainingSeconds); // ✅ 傳入剩餘時間記錄
            }
            else
            {
                message = $"答錯了，正確答案是 {totalSum}";
            }

            MessageBox.Show(message, "遊戲結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // 關閉回首頁
        }

        // 點下「開始遊戲」按鈕
        private void btnStart_Click(object? sender, EventArgs e)
        {
            btnStart.Enabled = false;
            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;

            int maxNumber;
            if (difficulty == "簡單")
            {
                maxNumber = 20;
                timerShowNumbers.Interval = 1000;
            }
            else
            {
                maxNumber = 30;
                timerShowNumbers.Interval = 800;
            }

            GenerateNumbers(maxNumber); // 產生題目

            currentIndex = 0;
            totalSum = 0;
            timeLeft = 20;

            timerCountdown.Interval = 1000;
            stopwatch.Restart(); // ✅ 開始精準計時
            timerShowNumbers.Start();

            lblCountdown.Text = $"剩餘時間: {timeLeft} 秒";
            lblNumber.Text = "";
        }

        // 讀取排行榜資料
        private void LoadRankingFromFile()
        {
            if (File.Exists(rankingFile))
                ranking = new List<string>(File.ReadAllLines(rankingFile));
            else
                ranking = new List<string>();
        }

        // 儲存排行榜（依剩餘秒數排序）
        private void SaveRankingEntry(double remainingSeconds)
        {
            string entry = $"{playerName} - {remainingSeconds:F1} 秒 - {difficulty}";
            ranking.Add(entry);

            ranking = ranking
                .OrderByDescending(e => GetRemainingTimeFromEntry(e))
                .Take(10)
                .ToList();

            SaveRankingToFile();
        }

        // 從文字取出剩餘秒數
        private double GetRemainingTimeFromEntry(string entry)
        {
            try
            {
                var parts = entry.Split(new string[] { " - " }, StringSplitOptions.None);
                if (parts.Length >= 3)
                {
                    string timeStr = parts[1].Replace(" 秒", "");
                    if (double.TryParse(timeStr, out double remainingSeconds))
                        return remainingSeconds;
                }
            }
            catch { }

            return double.MinValue; // 若失敗，排序在最後
        }

        // 將排行榜寫入文字檔
        private void SaveRankingToFile()
        {
            try
            {
                File.WriteAllLines(rankingFile, ranking);
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存排行榜時發生錯誤：" + ex.Message);
            }
        }

        
    }
}
