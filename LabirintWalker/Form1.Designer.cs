namespace LabirintWalker
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uploadButton = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.SystemColors.Control;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uploadButton.Location = new System.Drawing.Point(12, 12);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Загрузить";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.Control;
            this.sign.Location = new System.Drawing.Point(12, 524);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(141, 13);
            this.sign.TabIndex = 2;
            this.sign.Text = "Выберете картинку";
            this.sign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "Контраст.png";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.Enabled = false;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Location = new System.Drawing.Point(395, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Начать поиск пути";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // brushButton
            // 
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brushButton.Location = new System.Drawing.Point(93, 12);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(23, 23);
            this.brushButton.TabIndex = 5;
            this.brushButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 543);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Поиск пути в лабиринте";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button brushButton;
    }
}

