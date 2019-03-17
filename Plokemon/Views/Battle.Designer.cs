namespace Plokemon
{
    partial class Battle
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
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.plokemonButton = new System.Windows.Forms.Button();
            this.fightButton = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel2.ForeColor = System.Drawing.SystemColors.Info;
            this.nameLabel2.Location = new System.Drawing.Point(12, 22);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(35, 13);
            this.nameLabel2.TabIndex = 72;
            this.nameLabel2.Text = "label3";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(5, 38);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(174, 23);
            this.progressBar2.TabIndex = 71;
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.Info;
            this.nameLabel1.Location = new System.Drawing.Point(591, 215);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(35, 13);
            this.nameLabel1.TabIndex = 70;
            this.nameLabel1.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(584, 231);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 23);
            this.progressBar1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "--Battle Log--";
            // 
            // plokemonButton
            // 
            this.plokemonButton.Location = new System.Drawing.Point(478, 300);
            this.plokemonButton.Name = "plokemonButton";
            this.plokemonButton.Size = new System.Drawing.Size(178, 79);
            this.plokemonButton.TabIndex = 67;
            this.plokemonButton.Text = "Plokemon";
            this.plokemonButton.UseVisualStyleBackColor = true;
            this.plokemonButton.Click += new System.EventHandler(this.plokemonButton_Click);
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(115, 300);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(178, 79);
            this.fightButton.TabIndex = 66;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // battleLog
            // 
            this.battleLog.AutoEllipsis = true;
            this.battleLog.AutoSize = true;
            this.battleLog.BackColor = System.Drawing.Color.Transparent;
            this.battleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLog.ForeColor = System.Drawing.SystemColors.Info;
            this.battleLog.Location = new System.Drawing.Point(251, 38);
            this.battleLog.MaximumSize = new System.Drawing.Size(280, 600);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(16, 17);
            this.battleLog.TabIndex = 65;
            this.battleLog.Text = "  ";
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.returnButton.Location = new System.Drawing.Point(290, 294);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(194, 85);
            this.returnButton.TabIndex = 73;
            this.returnButton.Text = "return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plokemon.Properties.Resources.battle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plokemonButton);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.battleLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Battle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plokemonButton;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Label battleLog;
        private System.Windows.Forms.Button returnButton;
    }
}