namespace ConsoleApp2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(200, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.Text = "Welcome to QuizApp";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.Location = new System.Drawing.Point(200, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 30);
            this.lblSubtitle.Text = "Pertamina Quiz";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            //this.pictureBox.Image = System.Drawing.Image.FromFile("quiz.png"); // Letakkan file quiz.png di /bin/Debug/
            //this.pictureBox.Location = new System.Drawing.Point(310, 120);
            //this.pictureBox.Name = "pictureBox";
            //this.pictureBox.Size = new System.Drawing.Size(180, 120);
            //this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            //this.pictureBox.TabStop = false;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(220, 270);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(150, 45);
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnAdmin
            //
            this.btnAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(430, 270);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(150, 45);
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);

            // btnScores
            //
            this.btnScores.BackColor = System.Drawing.Color.DarkOrange;
            this.btnScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScores.ForeColor = System.Drawing.Color.White;
            this.btnScores.Location = new System.Drawing.Point(220, 330);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(150, 45);
            this.btnScores.Text = "Score List";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizApp Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnScores;
    }
}
