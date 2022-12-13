namespace TestOCR
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
            this.rtxresult = new System.Windows.Forms.RichTextBox();
            this.Btnload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnprocess = new System.Windows.Forms.Button();
            this.Btnrr = new System.Windows.Forms.Button();
            this.Btnrl = new System.Windows.Forms.Button();
            this.pbimg = new System.Windows.Forms.PictureBox();
            this.openimagedia = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxresult
            // 
            this.rtxresult.Location = new System.Drawing.Point(341, 33);
            this.rtxresult.Name = "rtxresult";
            this.rtxresult.Size = new System.Drawing.Size(319, 271);
            this.rtxresult.TabIndex = 2;
            this.rtxresult.Text = "";
            // 
            // Btnload
            // 
            this.Btnload.Location = new System.Drawing.Point(161, 274);
            this.Btnload.Name = "Btnload";
            this.Btnload.Size = new System.Drawing.Size(75, 30);
            this.Btnload.TabIndex = 3;
            this.Btnload.Text = "Load Image";
            this.Btnload.UseVisualStyleBackColor = true;
            this.Btnload.Click += new System.EventHandler(this.Btnload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OCR Result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btnprocess
            // 
            this.Btnprocess.Location = new System.Drawing.Point(242, 274);
            this.Btnprocess.Name = "Btnprocess";
            this.Btnprocess.Size = new System.Drawing.Size(75, 30);
            this.Btnprocess.TabIndex = 5;
            this.Btnprocess.Text = "Process";
            this.Btnprocess.UseVisualStyleBackColor = true;
            this.Btnprocess.Click += new System.EventHandler(this.Btnprocess_Click);
            // 
            // Btnrr
            // 
            this.Btnrr.Image = global::TestOCR.Properties.Resources.RR;
            this.Btnrr.Location = new System.Drawing.Point(48, 274);
            this.Btnrr.Name = "Btnrr";
            this.Btnrr.Size = new System.Drawing.Size(30, 30);
            this.Btnrr.TabIndex = 7;
            this.Btnrr.UseVisualStyleBackColor = true;
            this.Btnrr.Click += new System.EventHandler(this.Btnrr_Click);
            // 
            // Btnrl
            // 
            this.Btnrl.Image = global::TestOCR.Properties.Resources.RL;
            this.Btnrl.Location = new System.Drawing.Point(12, 274);
            this.Btnrl.Name = "Btnrl";
            this.Btnrl.Size = new System.Drawing.Size(30, 30);
            this.Btnrl.TabIndex = 6;
            this.Btnrl.UseVisualStyleBackColor = true;
            this.Btnrl.Click += new System.EventHandler(this.Btnrl_Click);
            // 
            // pbimg
            // 
            this.pbimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbimg.Location = new System.Drawing.Point(12, 12);
            this.pbimg.Name = "pbimg";
            this.pbimg.Size = new System.Drawing.Size(315, 256);
            this.pbimg.TabIndex = 0;
            this.pbimg.TabStop = false;
            this.pbimg.Click += new System.EventHandler(this.pbimg_Click);
            // 
            // openimagedia
            // 
            this.openimagedia.FileName = "openimage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 316);
            this.Controls.Add(this.Btnrr);
            this.Controls.Add(this.Btnrl);
            this.Controls.Add(this.Btnprocess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnload);
            this.Controls.Add(this.rtxresult);
            this.Controls.Add(this.pbimg);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbimg;
        private System.Windows.Forms.RichTextBox rtxresult;
        private System.Windows.Forms.Button Btnload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnprocess;
        private System.Windows.Forms.Button Btnrl;
        private System.Windows.Forms.Button Btnrr;
        private System.Windows.Forms.OpenFileDialog openimagedia;
    }
}

