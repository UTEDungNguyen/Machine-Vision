namespace MV_MiniProject03
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
            this.picBox_Lightness = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_Average = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox_Luminance = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Hinhgoc
            // 
            this.picBox_Hinhgoc.Location = new System.Drawing.Point(62, 57);
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
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình màu RGB gốc ";
            // 
            // picBox_Lightness
            // 
            this.picBox_Lightness.Location = new System.Drawing.Point(462, 57);
            this.picBox_Lightness.Name = "picBox_Lightness";
            this.picBox_Lightness.Size = new System.Drawing.Size(260, 260);
            this.picBox_Lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Lightness.TabIndex = 2;
            this.picBox_Lightness.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh mức xám Lightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ảnh mức xám Average";
            // 
            // picBox_Average
            // 
            this.picBox_Average.Location = new System.Drawing.Point(62, 369);
            this.picBox_Average.Name = "picBox_Average";
            this.picBox_Average.Size = new System.Drawing.Size(260, 260);
            this.picBox_Average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Average.TabIndex = 4;
            this.picBox_Average.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ảnh mức xám Luminance";
            // 
            // picBox_Luminance
            // 
            this.picBox_Luminance.Location = new System.Drawing.Point(462, 369);
            this.picBox_Luminance.Name = "picBox_Luminance";
            this.picBox_Luminance.Size = new System.Drawing.Size(260, 260);
            this.picBox_Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Luminance.TabIndex = 6;
            this.picBox_Luminance.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBox_Luminance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox_Average);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_Lightness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_Hinhgoc);
            this.Name = "Form1";
            this.Text = "Chuyển ảnh màu RGB sang ảnh mức xám Grayscale";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Hinhgoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_Lightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Average;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBox_Luminance;
    }
}

