namespace Verman
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.tboxEncrypt = new System.Windows.Forms.RichTextBox();
            this.tboxKey = new System.Windows.Forms.RichTextBox();
            this.tboxOut = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(188, 106);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(33, 7);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(102, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Enter text to encrypt";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(33, 168);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(100, 13);
            this.lblKey.TabIndex = 5;
            this.lblKey.Text = "Encryption keyword";
            // 
            // tboxEncrypt
            // 
            this.tboxEncrypt.Location = new System.Drawing.Point(11, 23);
            this.tboxEncrypt.Name = "tboxEncrypt";
            this.tboxEncrypt.Size = new System.Drawing.Size(145, 142);
            this.tboxEncrypt.TabIndex = 6;
            this.tboxEncrypt.Text = "";
            // 
            // tboxKey
            // 
            this.tboxKey.Location = new System.Drawing.Point(11, 184);
            this.tboxKey.Name = "tboxKey";
            this.tboxKey.Size = new System.Drawing.Size(145, 129);
            this.tboxKey.TabIndex = 7;
            this.tboxKey.Text = "";
            // 
            // tboxOut
            // 
            this.tboxOut.Location = new System.Drawing.Point(285, 69);
            this.tboxOut.Name = "tboxOut";
            this.tboxOut.Size = new System.Drawing.Size(214, 183);
            this.tboxOut.TabIndex = 8;
            this.tboxOut.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(374, 53);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(188, 147);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 342);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tboxOut);
            this.Controls.Add(this.tboxKey);
            this.Controls.Add(this.tboxEncrypt);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "Vernam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.RichTextBox tboxEncrypt;
        private System.Windows.Forms.RichTextBox tboxKey;
        private System.Windows.Forms.RichTextBox tboxOut;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

