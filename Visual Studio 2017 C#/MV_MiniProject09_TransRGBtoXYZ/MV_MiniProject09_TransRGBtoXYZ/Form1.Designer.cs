namespace MV_MiniProject09_TransRGBtoXYZ
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
            this.picBox_X = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_Y = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox_Z = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBox_XYZ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_XYZ)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(64, 61);
            this.picBox_HinhGoc.Name = "picBox_HinhGoc";
            this.picBox_HinhGoc.Size = new System.Drawing.Size(260, 260);
            this.picBox_HinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HinhGoc.TabIndex = 1;
            this.picBox_HinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình RGB Gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kênh X";
            // 
            // picBox_X
            // 
            this.picBox_X.Location = new System.Drawing.Point(64, 427);
            this.picBox_X.Name = "picBox_X";
            this.picBox_X.Size = new System.Drawing.Size(260, 260);
            this.picBox_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_X.TabIndex = 3;
            this.picBox_X.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kênh Y";
            // 
            // picBox_Y
            // 
            this.picBox_Y.Location = new System.Drawing.Point(389, 427);
            this.picBox_Y.Name = "picBox_Y";
            this.picBox_Y.Size = new System.Drawing.Size(260, 260);
            this.picBox_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Y.TabIndex = 5;
            this.picBox_Y.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(715, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kênh Z";
            // 
            // picBox_Z
            // 
            this.picBox_Z.Location = new System.Drawing.Point(718, 427);
            this.picBox_Z.Name = "picBox_Z";
            this.picBox_Z.Size = new System.Drawing.Size(260, 260);
            this.picBox_Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Z.TabIndex = 7;
            this.picBox_Z.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1045, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hình XYZ";
            // 
            // picBox_XYZ
            // 
            this.picBox_XYZ.Location = new System.Drawing.Point(1048, 427);
            this.picBox_XYZ.Name = "picBox_XYZ";
            this.picBox_XYZ.Size = new System.Drawing.Size(260, 260);
            this.picBox_XYZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_XYZ.TabIndex = 9;
            this.picBox_XYZ.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBox_XYZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBox_Z);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox_Y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Chuyển đổi không gian màu RGB sang không gian màu XYZ";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_XYZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBox_Z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBox_XYZ;
    }
}

