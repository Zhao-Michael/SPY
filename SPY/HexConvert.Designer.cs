namespace SPY
{
    partial class HexConvert
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelHex = new System.Windows.Forms.Label();
            this.pictureBoxHex = new System.Windows.Forms.PictureBox();
            this.pictureBoxText = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxText)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(57, 25);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(426, 21);
            this.textBoxText.TabIndex = 0;
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(59, 76);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(426, 21);
            this.textBoxHex.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelText.Font = new System.Drawing.Font("宋体", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(10, 27);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(39, 14);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Text";
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHex.Font = new System.Drawing.Font("宋体", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHex.Location = new System.Drawing.Point(11, 80);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(31, 14);
            this.labelHex.TabIndex = 1;
            this.labelHex.Text = "Hex";
            this.labelHex.Click += new System.EventHandler(this.labelHex_Click);
            // 
            // pictureBoxHex
            // 
            this.pictureBoxHex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHex.Image = global::SPY.My.Resources.Resources.copy;
            this.pictureBoxHex.Location = new System.Drawing.Point(501, 76);
            this.pictureBoxHex.Name = "pictureBoxHex";
            this.pictureBoxHex.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxHex.TabIndex = 2;
            this.pictureBoxHex.TabStop = false;
            this.pictureBoxHex.Click += new System.EventHandler(this.pictureBoxHex_Click);
            // 
            // pictureBoxText
            // 
            this.pictureBoxText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxText.Image = global::SPY.My.Resources.Resources.copy;
            this.pictureBoxText.Location = new System.Drawing.Point(501, 25);
            this.pictureBoxText.Name = "pictureBoxText";
            this.pictureBoxText.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxText.TabIndex = 2;
            this.pictureBoxText.TabStop = false;
            this.pictureBoxText.Click += new System.EventHandler(this.pictureBoxText_Click);
            // 
            // HexConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 124);
            this.Controls.Add(this.pictureBoxHex);
            this.Controls.Add(this.pictureBoxText);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxHex);
            this.Controls.Add(this.textBoxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "HexConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HexConvert";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.PictureBox pictureBoxText;
        private System.Windows.Forms.PictureBox pictureBoxHex;
    }
}