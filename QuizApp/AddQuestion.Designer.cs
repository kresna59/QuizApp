namespace ConsoleApp2
{
    partial class AddQuestion
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblOpt1 = new System.Windows.Forms.Label();
            this.txtOpt1 = new System.Windows.Forms.TextBox();
            this.lblOpt2 = new System.Windows.Forms.Label();
            this.txtOpt2 = new System.Windows.Forms.TextBox();
            this.lblOpt3 = new System.Windows.Forms.Label();
            this.txtOpt3 = new System.Windows.Forms.TextBox();
            this.lblOpt4 = new System.Windows.Forms.Label();
            this.txtOpt4 = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(0, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(686, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tambahkah Soal Baru";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(43, 69);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(86, 17);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Pertanyaan:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(137, 69);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(472, 44);
            this.txtQuestion.TabIndex = 2;
            // 
            // lblOpt1
            // 
            this.lblOpt1.Location = new System.Drawing.Point(43, 130);
            this.lblOpt1.Name = "lblOpt1";
            this.lblOpt1.Size = new System.Drawing.Size(86, 17);
            this.lblOpt1.TabIndex = 3;
            this.lblOpt1.Text = "Opsi 1:";
            // 
            // txtOpt1
            // 
            this.txtOpt1.Location = new System.Drawing.Point(137, 130);
            this.txtOpt1.Name = "txtOpt1";
            this.txtOpt1.Size = new System.Drawing.Size(343, 20);
            this.txtOpt1.TabIndex = 4;
            // 
            // lblOpt2
            // 
            this.lblOpt2.Location = new System.Drawing.Point(43, 165);
            this.lblOpt2.Name = "lblOpt2";
            this.lblOpt2.Size = new System.Drawing.Size(86, 17);
            this.lblOpt2.TabIndex = 5;
            this.lblOpt2.Text = "Opsi 2:";
            // 
            // txtOpt2
            // 
            this.txtOpt2.Location = new System.Drawing.Point(137, 165);
            this.txtOpt2.Name = "txtOpt2";
            this.txtOpt2.Size = new System.Drawing.Size(343, 20);
            this.txtOpt2.TabIndex = 6;
            // 
            // lblOpt3
            // 
            this.lblOpt3.Location = new System.Drawing.Point(43, 199);
            this.lblOpt3.Name = "lblOpt3";
            this.lblOpt3.Size = new System.Drawing.Size(86, 17);
            this.lblOpt3.TabIndex = 7;
            this.lblOpt3.Text = "Opsi 3:";
            // 
            // txtOpt3
            // 
            this.txtOpt3.Location = new System.Drawing.Point(137, 199);
            this.txtOpt3.Name = "txtOpt3";
            this.txtOpt3.Size = new System.Drawing.Size(343, 20);
            this.txtOpt3.TabIndex = 8;
            // 
            // lblOpt4
            // 
            this.lblOpt4.Location = new System.Drawing.Point(43, 234);
            this.lblOpt4.Name = "lblOpt4";
            this.lblOpt4.Size = new System.Drawing.Size(86, 17);
            this.lblOpt4.TabIndex = 9;
            this.lblOpt4.Text = "Opsi 4:";
            // 
            // txtOpt4
            // 
            this.txtOpt4.Location = new System.Drawing.Point(137, 234);
            this.txtOpt4.Name = "txtOpt4";
            this.txtOpt4.Size = new System.Drawing.Size(343, 20);
            this.txtOpt4.TabIndex = 10;
            // 
            // lblCorrect
            // 
            this.lblCorrect.Location = new System.Drawing.Point(43, 269);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(103, 20);
            this.lblCorrect.TabIndex = 11;
            this.lblCorrect.Text = "Jawaban Benar (1-4):";
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(154, 269);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(43, 20);
            this.txtCorrect.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(46, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 35);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Kembali ke Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(497, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Tambah Soal";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblOpt1);
            this.Controls.Add(this.txtOpt1);
            this.Controls.Add(this.lblOpt2);
            this.Controls.Add(this.txtOpt2);
            this.Controls.Add(this.lblOpt3);
            this.Controls.Add(this.txtOpt3);
            this.Controls.Add(this.lblOpt4);
            this.Controls.Add(this.txtOpt4);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblOpt1;
        private System.Windows.Forms.Label lblOpt2;
        private System.Windows.Forms.Label lblOpt3;
        private System.Windows.Forms.Label lblOpt4;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtOpt1;
        private System.Windows.Forms.TextBox txtOpt2;
        private System.Windows.Forms.TextBox txtOpt3;
        private System.Windows.Forms.TextBox txtOpt4;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Button btnBack;

    }
}