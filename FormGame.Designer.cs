namespace s1131759
{
    partial class FormGame
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
            components = new System.ComponentModel.Container();
            lblNumber = new Label();
            lblCountdown = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            timerShowNumbers = new System.Windows.Forms.Timer(components);
            timerCountdown = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Microsoft JhengHei UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblNumber.Location = new Point(252, 152);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(260, 60);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "請確認答案";
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Location = new Point(12, 9);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(51, 19);
            lblCountdown.TabIndex = 1;
            lblCountdown.Text = "label1";
            // 
            // txtAnswer
            // 
            txtAnswer.Enabled = false;
            txtAnswer.Location = new Point(320, 311);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(125, 27);
            txtAnswer.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(601, 311);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "確認答案";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(601, 276);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "開始";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.背景1;
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 455);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblCountdown);
            Controls.Add(lblNumber);
            Controls.Add(pictureBox1);
            Name = "FormGame";
            Text = "FormGame";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber;
        private Label lblCountdown;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private System.Windows.Forms.Timer timerShowNumbers;
        private System.Windows.Forms.Timer timerCountdown;
        private Button btnStart;
        private PictureBox pictureBox1;
    }
}