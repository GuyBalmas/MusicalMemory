using GameLogic;
using System;
using System.Windows.Forms;

namespace MusicalMemory
{
    partial class GameForm : Form
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
            this.Lable_MusicalMemory = new System.Windows.Forms.Label();
            this.CardsPanel1 = new System.Windows.Forms.Panel();
            this.CardsPanel2 = new System.Windows.Forms.Panel();
            this.Lable_Player1 = new System.Windows.Forms.Label();
            this.Lable_Player2 = new System.Windows.Forms.Label();
            this.Lable_Player1Score = new System.Windows.Forms.Label();
            this.Lable_Player2Score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lable_MusicalMemory
            // 
            this.Lable_MusicalMemory.AutoSize = true;
            this.Lable_MusicalMemory.Font = new System.Drawing.Font("Suez One", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_MusicalMemory.Location = new System.Drawing.Point(287, 20);
            this.Lable_MusicalMemory.Name = "Lable_MusicalMemory";
            this.Lable_MusicalMemory.Size = new System.Drawing.Size(356, 52);
            this.Lable_MusicalMemory.TabIndex = 0;
            this.Lable_MusicalMemory.Text = "Musical Memory";
            // 
            // CardsPanel1
            // 
            this.CardsPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CardsPanel1.Location = new System.Drawing.Point(11, 111);
            this.CardsPanel1.Name = "CardsPanel1";
            this.CardsPanel1.Size = new System.Drawing.Size(447, 411);
            this.CardsPanel1.TabIndex = 1;
            // 
            // CardsPanel2
            // 
            this.CardsPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CardsPanel2.Location = new System.Drawing.Point(464, 111);
            this.CardsPanel2.Name = "CardsPanel2";
            this.CardsPanel2.Size = new System.Drawing.Size(453, 411);
            this.CardsPanel2.TabIndex = 2;
            // 
            // Lable_Player1
            // 
            this.Lable_Player1.AutoSize = true;
            this.Lable_Player1.Font = new System.Drawing.Font("Secular One", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Player1.Location = new System.Drawing.Point(13, 525);
            this.Lable_Player1.Name = "Lable_Player1";
            this.Lable_Player1.Size = new System.Drawing.Size(120, 35);
            this.Lable_Player1.TabIndex = 3;
            this.Lable_Player1.Text = "Player 1:";
            this.Lable_Player1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lable_Player2
            // 
            this.Lable_Player2.AutoSize = true;
            this.Lable_Player2.Font = new System.Drawing.Font("Secular One", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Player2.Location = new System.Drawing.Point(464, 525);
            this.Lable_Player2.Name = "Lable_Player2";
            this.Lable_Player2.Size = new System.Drawing.Size(121, 35);
            this.Lable_Player2.TabIndex = 4;
            this.Lable_Player2.Text = "Player 2:";
            // 
            // Lable_Player1Score
            // 
            this.Lable_Player1Score.AutoSize = true;
            this.Lable_Player1Score.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Player1Score.Location = new System.Drawing.Point(14, 559);
            this.Lable_Player1Score.Name = "Lable_Player1Score";
            this.Lable_Player1Score.Size = new System.Drawing.Size(79, 29);
            this.Lable_Player1Score.TabIndex = 5;
            this.Lable_Player1Score.Text = "Score:";
            // 
            // Lable_Player2Score
            // 
            this.Lable_Player2Score.AutoSize = true;
            this.Lable_Player2Score.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Player2Score.Location = new System.Drawing.Point(465, 559);
            this.Lable_Player2Score.Name = "Lable_Player2Score";
            this.Lable_Player2Score.Size = new System.Drawing.Size(79, 29);
            this.Lable_Player2Score.TabIndex = 6;
            this.Lable_Player2Score.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Secular One", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Songs";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Secular One", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Artists";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardsPanel1);
            this.Controls.Add(this.Lable_Player2Score);
            this.Controls.Add(this.Lable_Player1Score);
            this.Controls.Add(this.Lable_Player2);
            this.Controls.Add(this.Lable_Player1);
            this.Controls.Add(this.CardsPanel2);
            this.Controls.Add(this.Lable_MusicalMemory);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Musical Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lable_MusicalMemory;
        private System.Windows.Forms.Panel CardsPanel1;
        private System.Windows.Forms.Panel CardsPanel2;
        private System.Windows.Forms.Label Lable_Player1;
        private System.Windows.Forms.Label Lable_Player2;
        private System.Windows.Forms.Label Lable_Player1Score;
        private System.Windows.Forms.Label Lable_Player2Score;
        private Label label1;
        private Label label2;
    }
}

