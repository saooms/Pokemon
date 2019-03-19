namespace Plokemon
{
    partial class World
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
            this.fightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shopButton = new System.Windows.Forms.Button();
            this.basicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.BackColor = System.Drawing.SystemColors.Control;
            this.fightButton.Location = new System.Drawing.Point(266, 133);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(203, 112);
            this.fightButton.TabIndex = 0;
            this.fightButton.Text = "fight!";
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "heaths:";
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(266, 265);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(203, 69);
            this.shopButton.TabIndex = 4;
            this.shopButton.Text = "shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // basicButton
            // 
            this.basicButton.Location = new System.Drawing.Point(12, 45);
            this.basicButton.Name = "basicButton";
            this.basicButton.Size = new System.Drawing.Size(52, 28);
            this.basicButton.TabIndex = 5;
            this.basicButton.Text = "demo";
            this.basicButton.UseVisualStyleBackColor = true;
            this.basicButton.Click += new System.EventHandler(this.basicButton_Click);
            // 
            // World
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plokemon.Properties.Resources.grass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basicButton);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fightButton);
            this.Name = "World";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button basicButton;
    }
}