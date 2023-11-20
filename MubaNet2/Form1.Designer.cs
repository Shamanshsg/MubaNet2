namespace MubaNet2
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.textent = new System.Windows.Forms.Button();
            this.picent = new System.Windows.Forms.Button();
            this.filebutton = new System.Windows.Forms.Button();
            this.entsim = new System.Windows.Forms.Label();
            this.textentl = new System.Windows.Forms.Label();
            this.pictent = new System.Windows.Forms.Label();
            this.pixelent = new System.Windows.Forms.Label();
            this.gaba = new System.Windows.Forms.RadioButton();
            this.bookbutton = new System.Windows.Forms.RadioButton();
            this.compress_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(372, 413);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(545, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(506, 207);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(33, 31);
            this.L.TabIndex = 4;
            this.L.Text = "←";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(868, 207);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(33, 31);
            this.R.TabIndex = 5;
            this.R.Text = "→";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // textent
            // 
            this.textent.AutoSize = true;
            this.textent.Location = new System.Drawing.Point(105, 431);
            this.textent.Name = "textent";
            this.textent.Size = new System.Drawing.Size(160, 26);
            this.textent.TabIndex = 6;
            this.textent.Text = "Вычислить энтропию";
            this.textent.UseVisualStyleBackColor = true;
            this.textent.Click += new System.EventHandler(this.textent_Click);
            // 
            // picent
            // 
            this.picent.AutoSize = true;
            this.picent.Location = new System.Drawing.Point(626, 431);
            this.picent.Name = "picent";
            this.picent.Size = new System.Drawing.Size(160, 26);
            this.picent.TabIndex = 7;
            this.picent.Text = "Вычислить энтропию";
            this.picent.UseVisualStyleBackColor = true;
            this.picent.Click += new System.EventHandler(this.picent_Click);
            // 
            // filebutton
            // 
            this.filebutton.AutoSize = true;
            this.filebutton.Location = new System.Drawing.Point(401, 261);
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(118, 38);
            this.filebutton.TabIndex = 8;
            this.filebutton.Text = "Путь до файла";
            this.filebutton.UseVisualStyleBackColor = true;
            this.filebutton.Click += new System.EventHandler(this.filebutton_Click);
            // 
            // entsim
            // 
            this.entsim.AutoSize = true;
            this.entsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entsim.Location = new System.Drawing.Point(31, 473);
            this.entsim.Name = "entsim";
            this.entsim.Size = new System.Drawing.Size(64, 25);
            this.entsim.TabIndex = 9;
            this.entsim.Text = "label1";
            this.entsim.Click += new System.EventHandler(this.entsim_Click);
            // 
            // textentl
            // 
            this.textentl.AutoSize = true;
            this.textentl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textentl.Location = new System.Drawing.Point(29, 516);
            this.textentl.Name = "textentl";
            this.textentl.Size = new System.Drawing.Size(64, 25);
            this.textentl.TabIndex = 10;
            this.textentl.Text = "label1";
            // 
            // pictent
            // 
            this.pictent.AutoSize = true;
            this.pictent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictent.Location = new System.Drawing.Point(510, 516);
            this.pictent.Name = "pictent";
            this.pictent.Size = new System.Drawing.Size(64, 25);
            this.pictent.TabIndex = 12;
            this.pictent.Text = "label1";
            // 
            // pixelent
            // 
            this.pixelent.AutoSize = true;
            this.pixelent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pixelent.Location = new System.Drawing.Point(510, 473);
            this.pixelent.Name = "pixelent";
            this.pixelent.Size = new System.Drawing.Size(64, 25);
            this.pixelent.TabIndex = 11;
            this.pixelent.Text = "label1";
            this.pixelent.Click += new System.EventHandler(this.pixelent_Click);
            // 
            // gaba
            // 
            this.gaba.AutoSize = true;
            this.gaba.Location = new System.Drawing.Point(401, 314);
            this.gaba.Name = "gaba";
            this.gaba.Size = new System.Drawing.Size(113, 20);
            this.gaba.TabIndex = 13;
            this.gaba.TabStop = true;
            this.gaba.Text = "режим жабки";
            this.gaba.UseVisualStyleBackColor = true;
            this.gaba.CheckedChanged += new System.EventHandler(this.gaba_CheckedChanged);
            // 
            // bookbutton
            // 
            this.bookbutton.AutoSize = true;
            this.bookbutton.Location = new System.Drawing.Point(401, 340);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(110, 20);
            this.bookbutton.TabIndex = 14;
            this.bookbutton.TabStop = true;
            this.bookbutton.Text = "режим книги";
            this.bookbutton.UseVisualStyleBackColor = true;
            this.bookbutton.CheckedChanged += new System.EventHandler(this.bookbutton_CheckedChanged);
            // 
            // compress_button
            // 
            this.compress_button.Location = new System.Drawing.Point(271, 433);
            this.compress_button.Name = "compress_button";
            this.compress_button.Size = new System.Drawing.Size(75, 23);
            this.compress_button.TabIndex = 15;
            this.compress_button.Text = "сжать";
            this.compress_button.UseVisualStyleBackColor = true;
            this.compress_button.Click += new System.EventHandler(this.compress_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 572);
            this.Controls.Add(this.compress_button);
            this.Controls.Add(this.bookbutton);
            this.Controls.Add(this.gaba);
            this.Controls.Add(this.pictent);
            this.Controls.Add(this.pixelent);
            this.Controls.Add(this.textentl);
            this.Controls.Add(this.entsim);
            this.Controls.Add(this.filebutton);
            this.Controls.Add(this.picent);
            this.Controls.Add(this.textent);
            this.Controls.Add(this.R);
            this.Controls.Add(this.L);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button textent;
        private System.Windows.Forms.Button picent;
        private System.Windows.Forms.Button filebutton;
        private System.Windows.Forms.Label entsim;
        private System.Windows.Forms.Label textentl;
        private System.Windows.Forms.Label pictent;
        private System.Windows.Forms.Label pixelent;
        private System.Windows.Forms.RadioButton gaba;
        private System.Windows.Forms.RadioButton bookbutton;
        private System.Windows.Forms.Button compress_button;
    }
}

