namespace MusicalMemory
{
    partial class GameSettingsForm
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
            this.TextBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.Label_Player1 = new System.Windows.Forms.Label();
            this.Label_Player2 = new System.Windows.Forms.Label();
            this.TextBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxPlayer1Name
            // 
            this.TextBoxPlayer1Name.Font = new System.Drawing.Font("Suez One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxPlayer1Name.Location = new System.Drawing.Point(185, 43);
            this.TextBoxPlayer1Name.Name = "TextBoxPlayer1Name";
            this.TextBoxPlayer1Name.Size = new System.Drawing.Size(130, 30);
            this.TextBoxPlayer1Name.TabIndex = 0;
            this.TextBoxPlayer1Name.TabStop = false;
            this.TextBoxPlayer1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Player1
            // 
            this.Label_Player1.AutoSize = true;
            this.Label_Player1.Font = new System.Drawing.Font("Suez One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Player1.Location = new System.Drawing.Point(20, 43);
            this.Label_Player1.Name = "Label_Player1";
            this.Label_Player1.Size = new System.Drawing.Size(137, 26);
            this.Label_Player1.TabIndex = 1;
            this.Label_Player1.Text = "Player name:";
            // 
            // Label_Player2
            // 
            this.Label_Player2.AutoSize = true;
            this.Label_Player2.Font = new System.Drawing.Font("Suez One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Player2.Location = new System.Drawing.Point(20, 89);
            this.Label_Player2.Name = "Label_Player2";
            this.Label_Player2.Size = new System.Drawing.Size(137, 26);
            this.Label_Player2.TabIndex = 3;
            this.Label_Player2.Text = "Player name:";
            // 
            // TextBoxPlayer2Name
            // 
            this.TextBoxPlayer2Name.Font = new System.Drawing.Font("Suez One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxPlayer2Name.Location = new System.Drawing.Point(185, 89);
            this.TextBoxPlayer2Name.Name = "TextBoxPlayer2Name";
            this.TextBoxPlayer2Name.Size = new System.Drawing.Size(130, 30);
            this.TextBoxPlayer2Name.TabIndex = 2;
            this.TextBoxPlayer2Name.TabStop = false;
            this.TextBoxPlayer2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Font = new System.Drawing.Font("Suez One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonSubmit.Location = new System.Drawing.Point(114, 151);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(99, 42);
            this.ButtonSubmit.TabIndex = 4;
            this.ButtonSubmit.Text = "New Game";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 227);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.Label_Player2);
            this.Controls.Add(this.TextBoxPlayer2Name);
            this.Controls.Add(this.Label_Player1);
            this.Controls.Add(this.TextBoxPlayer1Name);
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPlayer1Name;
        private System.Windows.Forms.Label Label_Player1;
        private System.Windows.Forms.Label Label_Player2;
        private System.Windows.Forms.TextBox TextBoxPlayer2Name;
        private System.Windows.Forms.Button ButtonSubmit;
    }
}