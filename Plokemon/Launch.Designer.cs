namespace Plokemon
{
    partial class Launch
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
            this.battleLog = new System.Windows.Forms.Label();
            this.fightButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battleLog
            // 
            this.battleLog.AutoEllipsis = true;
            this.battleLog.AutoSize = true;
            this.battleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLog.Location = new System.Drawing.Point(259, 9);
            this.battleLog.MaximumSize = new System.Drawing.Size(280, 600);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(138, 17);
            this.battleLog.TabIndex = 57;
            this.battleLog.Text = "---Battle Log---         ";
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(122, 300);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(178, 79);
            this.fightButton.TabIndex = 58;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 79);
            this.button2.TabIndex = 59;
            this.button2.Text = "Plokemon";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.battleLog);
            this.Name = "Launch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label battleLog;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button button2;
    }
}

