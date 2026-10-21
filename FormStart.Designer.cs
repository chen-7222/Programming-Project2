namespace s1131759
{
    partial class FormStart
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
            lblName = new Label();
            txtPlayerName = new TextBox();
            grpDifficulty = new GroupBox();
            rdoHard = new RadioButton();
            rdoEasy = new RadioButton();
            btnStart = new Button();
            lstRanking = new ListBox();
            lblRanking = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            pictureBox1 = new PictureBox();
            grpDifficulty.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblName.Location = new Point(303, 248);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 25);
            lblName.TabIndex = 0;
            lblName.Text = "姓名:";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(366, 248);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(125, 27);
            txtPlayerName.TabIndex = 1;
            // 
            // grpDifficulty
            // 
            grpDifficulty.Controls.Add(rdoHard);
            grpDifficulty.Controls.Add(rdoEasy);
            grpDifficulty.Location = new Point(267, 285);
            grpDifficulty.Name = "grpDifficulty";
            grpDifficulty.Size = new Size(250, 125);
            grpDifficulty.TabIndex = 2;
            grpDifficulty.TabStop = false;
            grpDifficulty.Text = "難度選擇";
            grpDifficulty.Enter += grpDifficulty_Enter;
            // 
            // rdoHard
            // 
            rdoHard.AutoSize = true;
            rdoHard.Location = new Point(122, 23);
            rdoHard.Name = "rdoHard";
            rdoHard.Size = new Size(90, 23);
            rdoHard.TabIndex = 1;
            rdoHard.TabStop = true;
            rdoHard.Text = "困難模式";
            rdoHard.UseVisualStyleBackColor = true;
            // 
            // rdoEasy
            // 
            rdoEasy.AutoSize = true;
            rdoEasy.Location = new Point(3, 23);
            rdoEasy.Name = "rdoEasy";
            rdoEasy.Size = new Size(90, 23);
            rdoEasy.TabIndex = 0;
            rdoEasy.TabStop = true;
            rdoEasy.Text = "簡單模式";
            rdoEasy.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(606, 320);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "開始";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lstRanking
            // 
            lstRanking.FormattingEnabled = true;
            lstRanking.ItemHeight = 19;
            lstRanking.Location = new Point(574, 78);
            lstRanking.Name = "lstRanking";
            lstRanking.Size = new Size(214, 175);
            lstRanking.TabIndex = 3;
            // 
            // lblRanking
            // 
            lblRanking.AutoSize = true;
            lblRanking.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblRanking.Location = new Point(574, 50);
            lblRanking.Name = "lblRanking";
            lblRanking.Size = new Size(72, 25);
            lblRanking.TabIndex = 4;
            lblRanking.Text = "排行榜";
            lblRanking.Click += lblRanking_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(250, 173);
            label1.Name = "label1";
            label1.Size = new Size(267, 36);
            label1.TabIndex = 5;
            label1.Text = "數字瞬時記憶力挑戰";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuSave });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(53, 24);
            menuFile.Text = "檔案";
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(167, 26);
            menuSave.Text = "儲存排行榜";
            menuSave.Click += menuSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.背景1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblRanking);
            Controls.Add(lstRanking);
            Controls.Add(btnStart);
            Controls.Add(grpDifficulty);
            Controls.Add(txtPlayerName);
            Controls.Add(lblName);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "FormStart";
            Text = "s1131759";
            grpDifficulty.ResumeLayout(false);
            grpDifficulty.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtPlayerName;
        private GroupBox grpDifficulty;
        private RadioButton rdoHard;
        private RadioButton rdoEasy;
        private Button btnStart;
        private ListBox lstRanking;
        private Label lblRanking;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuSave;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
    }
}
