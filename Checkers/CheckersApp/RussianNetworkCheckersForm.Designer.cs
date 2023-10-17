namespace CheckersApp
{
    partial class RussianNetworkCheckersForm
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
            this.askToDrawLabel = new System.Windows.Forms.Label();
            this.refuseButton = new System.Windows.Forms.Button();
            this.agreeButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.moveLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // askToDrawLabel
            // 
            this.askToDrawLabel.AutoSize = true;
            this.askToDrawLabel.Location = new System.Drawing.Point(415, 296);
            this.askToDrawLabel.Name = "askToDrawLabel";
            this.askToDrawLabel.Size = new System.Drawing.Size(151, 13);
            this.askToDrawLabel.TabIndex = 9;
            this.askToDrawLabel.Text = "Соперник предлагает ничью";
            this.askToDrawLabel.Visible = false;
            // 
            // refuseButton
            // 
            this.refuseButton.Location = new System.Drawing.Point(441, 341);
            this.refuseButton.Name = "refuseButton";
            this.refuseButton.Size = new System.Drawing.Size(95, 23);
            this.refuseButton.TabIndex = 8;
            this.refuseButton.Text = "Отказать";
            this.refuseButton.UseVisualStyleBackColor = true;
            this.refuseButton.Visible = false;
            this.refuseButton.Click += new System.EventHandler(this.refuseButton_Click);
            // 
            // agreeButton
            // 
            this.agreeButton.Location = new System.Drawing.Point(441, 312);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(95, 23);
            this.agreeButton.TabIndex = 7;
            this.agreeButton.Text = "Согласиться";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Visible = false;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(441, 236);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(95, 23);
            this.drawButton.TabIndex = 6;
            this.drawButton.Text = "Ничья";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(441, 81);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(95, 23);
            this.ConnectButton.TabIndex = 10;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Location = new System.Drawing.Point(464, 45);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(60, 13);
            this.moveLabel.TabIndex = 5;
            this.moveLabel.Text = "Ход белых";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(441, 111);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(95, 23);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Создать игру";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RussianNetworkCheckersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.askToDrawLabel);
            this.Controls.Add(this.refuseButton);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.moveLabel);
            this.Name = "RussianNetworkCheckersForm";
            this.Text = "Шашки";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label askToDrawLabel;
        private System.Windows.Forms.Button refuseButton;
        private System.Windows.Forms.Button agreeButton;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Button CreateButton;
    }
}