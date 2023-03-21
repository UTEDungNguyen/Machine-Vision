namespace MV_MiniProject08_TransRGBtoHSV
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
            this.picBox_HinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_Hue = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_Saturation = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox_Value = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBox_HSV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HSV)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(44, 64);
            this.picBox_HinhGoc.Name = "picBox_HinhGoc";
            this.picBox_HinhGoc.Size = new System.Drawing.Size(260, 260);
            this.picBox_HinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HinhGoc.TabIndex = 0;
            this.picBox_HinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình RGB Gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kênh HUE";
            // 
            // picBox_Hue
            // 
            this.picBox_Hue.Location = new System.Drawing.Point(44, 412);
            this.picBox_Hue.Name = "picBox_Hue";
            this.picBox_Hue.Size = new System.Drawing.Size(260, 260);
            this.picBox_Hue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Hue.TabIndex = 2;
            this.picBox_Hue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kênh Saturation";
            // 
            // picBox_Saturation
            // 
            this.picBox_Saturation.Location = new System.Drawing.Point(388, 412);
            this.picBox_Saturation.Name = "picBox_Saturation";
            this.picBox_Saturation.Size = new System.Drawing.Size(260, 260);
            this.picBox_Saturation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Saturation.TabIndex = 4;
            this.picBox_Saturation.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(725, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kênh Value";
            // 
            // picBox_Value
            // 
            this.picBox_Value.Location = new System.Drawing.Point(718, 412);
            this.picBox_Value.Name = "picBox_Value";
            this.picBox_Value.Size = new System.Drawing.Size(260, 260);
            this.picBox_Value.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Value.TabIndex = 6;
            this.picBox_Value.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1073, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kênh HSV";
            // 
            // picBox_HSV
            // 
            this.picBox_HSV.Location = new System.Drawing.Point(1066, 412);
            this.picBox_HSV.Name = "picBox_HSV";
            this.picBox_HSV.Size = new System.Drawing.Size(260, 260);
            this.picBox_HSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HSV.TabIndex = 8;
            this.picBox_HSV.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBox_HSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBox_Value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox_Saturation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_Hue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Chuyển đổi không gian màu RGb sang HSV";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_Hue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Saturation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBox_Value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBox_HSV;
    }
}

