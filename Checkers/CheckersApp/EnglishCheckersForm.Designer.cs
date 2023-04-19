namespace CheckersApp
{
    partial class EnglishCheckersForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.moveLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.agreeButton = new System.Windows.Forms.Button();
            this.refuseButton = new System.Windows.Forms.Button();
            this.askToDrawLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Location = new System.Drawing.Point(464, 45);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(60, 13);
            this.moveLabel.TabIndex = 0;
            this.moveLabel.Text = "Ход белых";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(441, 236);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(95, 23);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Ничья";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // agreeButton
            // 
            this.agreeButton.Location = new System.Drawing.Point(441, 312);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(95, 23);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Согласиться";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Visible = false;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // refuseButton
            // 
            this.refuseButton.Location = new System.Drawing.Point(441, 341);
            this.refuseButton.Name = "refuseButton";
            this.refuseButton.Size = new System.Drawing.Size(95, 23);
            this.refuseButton.TabIndex = 3;
            this.refuseButton.Text = "Отказать";
            this.refuseButton.UseVisualStyleBackColor = true;
            this.refuseButton.Visible = false;
            this.refuseButton.Click += new System.EventHandler(this.refuseButton_Click);
            // 
            // askToDrawLabel
            // 
            this.askToDrawLabel.AutoSize = true;
            this.askToDrawLabel.Location = new System.Drawing.Point(415, 296);
            this.askToDrawLabel.Name = "askToDrawLabel";
            this.askToDrawLabel.Size = new System.Drawing.Size(151, 13);
            this.askToDrawLabel.TabIndex = 4;
            this.askToDrawLabel.Text = "Соперник предлагает ничью";
            this.askToDrawLabel.Visible = false;
            // 
            // EnglishCheckersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.askToDrawLabel);
            this.Controls.Add(this.refuseButton);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.moveLabel);
            this.Name = "EnglishCheckersForm";
            this.Text = "Шашки";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button agreeButton;
        private System.Windows.Forms.Button refuseButton;
        private System.Windows.Forms.Label askToDrawLabel;
    }
}

