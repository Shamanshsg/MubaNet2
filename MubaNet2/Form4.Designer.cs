namespace MubaNet2
{
    partial class Form4
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
            this.compText = new System.Windows.Forms.RichTextBox();
            this.Lentext = new System.Windows.Forms.Label();
            this.Lencode = new System.Windows.Forms.Label();
            this.Lendict = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hafmrext = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.half_unfoldedtext = new System.Windows.Forms.RichTextBox();
            this.decipherButton = new System.Windows.Forms.Button();
            this.finaltext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // compText
            // 
            this.compText.Location = new System.Drawing.Point(12, 12);
            this.compText.Name = "compText";
            this.compText.Size = new System.Drawing.Size(290, 215);
            this.compText.TabIndex = 0;
            this.compText.Text = "";
            // 
            // Lentext
            // 
            this.Lentext.AutoSize = true;
            this.Lentext.Location = new System.Drawing.Point(308, 21);
            this.Lentext.Name = "Lentext";
            this.Lentext.Size = new System.Drawing.Size(44, 16);
            this.Lentext.TabIndex = 1;
            this.Lentext.Text = "label1";
            // 
            // Lencode
            // 
            this.Lencode.AutoSize = true;
            this.Lencode.Location = new System.Drawing.Point(308, 51);
            this.Lencode.Name = "Lencode";
            this.Lencode.Size = new System.Drawing.Size(44, 16);
            this.Lencode.TabIndex = 2;
            this.Lencode.Text = "label1";
            // 
            // Lendict
            // 
            this.Lendict.AutoSize = true;
            this.Lendict.Location = new System.Drawing.Point(308, 79);
            this.Lendict.Name = "Lendict";
            this.Lendict.Size = new System.Drawing.Size(44, 16);
            this.Lendict.TabIndex = 3;
            this.Lendict.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // hafmrext
            // 
            this.hafmrext.Location = new System.Drawing.Point(12, 246);
            this.hafmrext.Name = "hafmrext";
            this.hafmrext.Size = new System.Drawing.Size(290, 215);
            this.hafmrext.TabIndex = 6;
            this.hafmrext.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(311, 246);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(144, 215);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // half_unfoldedtext
            // 
            this.half_unfoldedtext.Location = new System.Drawing.Point(670, 12);
            this.half_unfoldedtext.Name = "half_unfoldedtext";
            this.half_unfoldedtext.Size = new System.Drawing.Size(290, 215);
            this.half_unfoldedtext.TabIndex = 8;
            this.half_unfoldedtext.Text = "";
            // 
            // decipherButton
            // 
            this.decipherButton.Location = new System.Drawing.Point(311, 217);
            this.decipherButton.Name = "decipherButton";
            this.decipherButton.Size = new System.Drawing.Size(144, 23);
            this.decipherButton.TabIndex = 9;
            this.decipherButton.Text = "разархивировать";
            this.decipherButton.UseVisualStyleBackColor = true;
            this.decipherButton.Click += new System.EventHandler(this.decipherButton_Click);
            // 
            // finaltext
            // 
            this.finaltext.Location = new System.Drawing.Point(670, 246);
            this.finaltext.Name = "finaltext";
            this.finaltext.Size = new System.Drawing.Size(290, 215);
            this.finaltext.TabIndex = 10;
            this.finaltext.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 473);
            this.Controls.Add(this.finaltext);
            this.Controls.Add(this.decipherButton);
            this.Controls.Add(this.half_unfoldedtext);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.hafmrext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lendict);
            this.Controls.Add(this.Lencode);
            this.Controls.Add(this.Lentext);
            this.Controls.Add(this.compText);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox compText;
        private System.Windows.Forms.Label Lentext;
        private System.Windows.Forms.Label Lencode;
        private System.Windows.Forms.Label Lendict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox hafmrext;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox half_unfoldedtext;
        private System.Windows.Forms.Button decipherButton;
        private System.Windows.Forms.RichTextBox finaltext;
    }
}