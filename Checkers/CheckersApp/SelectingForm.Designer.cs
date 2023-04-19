namespace CheckersApp
{
    partial class SelectingForm
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
            this.englishButton = new System.Windows.Forms.Button();
            this.russianButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // englishButton
            // 
            this.englishButton.Location = new System.Drawing.Point(12, 41);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(199, 23);
            this.englishButton.TabIndex = 0;
            this.englishButton.Text = "Английские шашки";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // russianButton
            // 
            this.russianButton.Location = new System.Drawing.Point(12, 12);
            this.russianButton.Name = "russianButton";
            this.russianButton.Size = new System.Drawing.Size(199, 23);
            this.russianButton.TabIndex = 1;
            this.russianButton.Text = "Русские шашки";
            this.russianButton.UseVisualStyleBackColor = true;
            this.russianButton.Click += new System.EventHandler(this.russianButton_Click);
            // 
            // SelectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 77);
            this.Controls.Add(this.russianButton);
            this.Controls.Add(this.englishButton);
            this.Name = "SelectingForm";
            this.Text = "Шашки";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button russianButton;
    }
}