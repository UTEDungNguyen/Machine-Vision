namespace MV_MiniProject01
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
            this.components = new System.ComponentModel.Container();
            this.imgBox_HinhGoc = new Emgu.CV.UI.ImageBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imgBox_Green = new Emgu.CV.UI.ImageBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imgBox_Blue = new Emgu.CV.UI.ImageBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imgBox_red = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_red)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox_HinhGoc
            // 
            this.imgBox_HinhGoc.Location = new System.Drawing.Point(71, 37);
            this.imgBox_HinhGoc.Name = "imgBox_HinhGoc";
            this.imgBox_HinhGoc.Size = new System.Drawing.Size(262, 254);
            this.imgBox_HinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox_HinhGoc.TabIndex = 2;
            this.imgBox_HinhGoc.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hình màu RGB gốc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kênh màu xanh lá cây (GREEN) :";
            // 
            // imgBox_Green
            // 
            this.imgBox_Green.Location = new System.Drawing.Point(71, 336);
            this.imgBox_Green.Name = "imgBox_Green";
            this.imgBox_Green.Size = new System.Drawing.Size(262, 254);
            this.imgBox_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox_Green.TabIndex = 4;
            this.imgBox_Green.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kênh màu xanh nước biển (BLUE) :";
            // 
            // imgBox_Blue
            // 
            this.imgBox_Blue.Location = new System.Drawing.Point(539, 336);
            this.imgBox_Blue.Name = "imgBox_Blue";
            this.imgBox_Blue.Size = new System.Drawing.Size(262, 254);
            this.imgBox_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox_Blue.TabIndex = 8;
            this.imgBox_Blue.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kênh màu đỏ (RED) :";
            // 
            // imgBox_red
            // 
            this.imgBox_red.Location = new System.Drawing.Point(539, 37);
            this.imgBox_red.Name = "imgBox_red";
            this.imgBox_red.Size = new System.Drawing.Size(262, 254);
            this.imgBox_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox_red.TabIndex = 6;
            this.imgBox_red.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 602);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imgBox_Blue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imgBox_red);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imgBox_Green);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Tách ảnh màu RGB cho từng kênh RED-GREEN-BLUE";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox_HinhGoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.ImageBox imgBox_Green;
        private System.Windows.Forms.Label label6;
        private Emgu.CV.UI.ImageBox imgBox_Blue;
        private System.Windows.Forms.Label label7;
        private Emgu.CV.UI.ImageBox imgBox_red;
    }
}

