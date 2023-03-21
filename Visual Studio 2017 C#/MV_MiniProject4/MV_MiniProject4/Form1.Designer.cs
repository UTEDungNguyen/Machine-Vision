namespace MV_MiniProject4
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
            this.picBox_Hinhgoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_Lightness = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_Binary = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar_Binarypicture = new System.Windows.Forms.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Binary)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Hinhgoc
            // 
            this.picBox_Hinhgoc.Location = new System.Drawing.Point(45, 47);
            this.picBox_Hinhgoc.Name = "picBox_Hinhgoc";
            this.picBox_Hinhgoc.Size = new System.Drawing.Size(260, 260);
            this.picBox_Hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Hinhgoc.TabIndex = 0;
            this.picBox_Hinhgoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình màu RGB gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh mức xám dùng Lightness";
            // 
            // picBox_Lightness
            // 
            this.picBox_Lightness.Location = new System.Drawing.Point(491, 47);
            this.picBox_Lightness.Name = "picBox_Lightness";
            this.picBox_Lightness.Size = new System.Drawing.Size(260, 260);
            this.picBox_Lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Lightness.TabIndex = 2;
            this.picBox_Lightness.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hình nhị phân (Binary)";
            // 
            // picBox_Binary
            // 
            this.picBox_Binary.Location = new System.Drawing.Point(45, 367);
            this.picBox_Binary.Name = "picBox_Binary";
            this.picBox_Binary.Size = new System.Drawing.Size(260, 260);
            this.picBox_Binary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Binary.TabIndex = 4;
            this.picBox_Binary.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 6;
            // 
            // vScrollBar_Binarypicture
            // 
            this.vScrollBar_Binarypicture.Location = new System.Drawing.Point(366, 367);
            this.vScrollBar_Binarypicture.Maximum = 255;
            this.vScrollBar_Binarypicture.Name = "vScrollBar_Binarypicture";
            this.vScrollBar_Binarypicture.Size = new System.Drawing.Size(27, 260);
            this.vScrollBar_Binarypicture.TabIndex = 7;
            this.vScrollBar_Binarypicture.ValueChanged += new System.EventHandler(this.vScrollBar_Binarypicture_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Threshold :";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(450, 472);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(0, 25);
            this.lblThreshold.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vScrollBar_Binarypicture);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox_Binary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_Lightness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_Hinhgoc);
            this.Name = "Form1";
            this.Text = "Chuyển ảnh màu RGB sang ảnh nhị phân (Binary)";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Binary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Hinhgoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_Lightness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Binary;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar_Binarypicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThreshold;
    }
}

