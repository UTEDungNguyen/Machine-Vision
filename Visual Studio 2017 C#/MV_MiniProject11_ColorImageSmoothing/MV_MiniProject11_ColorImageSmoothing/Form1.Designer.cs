namespace MV_MiniProject11_ColorImageSmoothing
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
            this.picBox_Smooth3x3Image = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_Smooth5x5Image = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox_Smooth7x7Image = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBox_Smooth9x9Image = new System.Windows.Forms.PictureBox();
            this.SmoothedImage3x3 = new System.Windows.Forms.Button();
            this.SmoothedImage5x5 = new System.Windows.Forms.Button();
            this.SmoothedImage7x7 = new System.Windows.Forms.Button();
            this.SmoothedImage9x9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth3x3Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth5x5Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth7x7Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth9x9Image)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(45, 57);
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
            this.label1.Location = new System.Drawing.Point(42, 20);
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
            this.label2.Location = new System.Drawing.Point(42, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hình làm mượt (Mask 3x3)";
            // 
            // picBox_Smooth3x3Image
            // 
            this.picBox_Smooth3x3Image.Location = new System.Drawing.Point(45, 415);
            this.picBox_Smooth3x3Image.Name = "picBox_Smooth3x3Image";
            this.picBox_Smooth3x3Image.Size = new System.Drawing.Size(260, 260);
            this.picBox_Smooth3x3Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Smooth3x3Image.TabIndex = 2;
            this.picBox_Smooth3x3Image.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hình làm mượt (Mask 5x5)";
            // 
            // picBox_Smooth5x5Image
            // 
            this.picBox_Smooth5x5Image.Location = new System.Drawing.Point(368, 415);
            this.picBox_Smooth5x5Image.Name = "picBox_Smooth5x5Image";
            this.picBox_Smooth5x5Image.Size = new System.Drawing.Size(260, 260);
            this.picBox_Smooth5x5Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Smooth5x5Image.TabIndex = 4;
            this.picBox_Smooth5x5Image.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hình làm mượt (Mask 7x7)";
            // 
            // picBox_Smooth7x7Image
            // 
            this.picBox_Smooth7x7Image.Location = new System.Drawing.Point(694, 415);
            this.picBox_Smooth7x7Image.Name = "picBox_Smooth7x7Image";
            this.picBox_Smooth7x7Image.Size = new System.Drawing.Size(260, 260);
            this.picBox_Smooth7x7Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Smooth7x7Image.TabIndex = 6;
            this.picBox_Smooth7x7Image.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1016, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hình làm mượt (Mask 9x9)";
            // 
            // picBox_Smooth9x9Image
            // 
            this.picBox_Smooth9x9Image.Location = new System.Drawing.Point(1019, 415);
            this.picBox_Smooth9x9Image.Name = "picBox_Smooth9x9Image";
            this.picBox_Smooth9x9Image.Size = new System.Drawing.Size(260, 260);
            this.picBox_Smooth9x9Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Smooth9x9Image.TabIndex = 8;
            this.picBox_Smooth9x9Image.TabStop = false;
            // 
            // SmoothedImage3x3
            // 
            this.SmoothedImage3x3.Location = new System.Drawing.Point(389, 164);
            this.SmoothedImage3x3.Name = "SmoothedImage3x3";
            this.SmoothedImage3x3.Size = new System.Drawing.Size(144, 80);
            this.SmoothedImage3x3.TabIndex = 10;
            this.SmoothedImage3x3.Text = "Smoothed Image 3x3";
            this.SmoothedImage3x3.UseVisualStyleBackColor = true;
            this.SmoothedImage3x3.Click += new System.EventHandler(this.SmoothedImage3x3_Click);
            // 
            // SmoothedImage5x5
            // 
            this.SmoothedImage5x5.Location = new System.Drawing.Point(609, 164);
            this.SmoothedImage5x5.Name = "SmoothedImage5x5";
            this.SmoothedImage5x5.Size = new System.Drawing.Size(144, 80);
            this.SmoothedImage5x5.TabIndex = 11;
            this.SmoothedImage5x5.Text = "Smoothed Image 5x5";
            this.SmoothedImage5x5.UseVisualStyleBackColor = true;
            this.SmoothedImage5x5.Click += new System.EventHandler(this.SmoothedImage5x5_Click);
            // 
            // SmoothedImage7x7
            // 
            this.SmoothedImage7x7.Location = new System.Drawing.Point(841, 164);
            this.SmoothedImage7x7.Name = "SmoothedImage7x7";
            this.SmoothedImage7x7.Size = new System.Drawing.Size(144, 80);
            this.SmoothedImage7x7.TabIndex = 12;
            this.SmoothedImage7x7.Text = "Smoothed Image 7x7";
            this.SmoothedImage7x7.UseVisualStyleBackColor = true;
            this.SmoothedImage7x7.Click += new System.EventHandler(this.SmoothedImage7x7_Click);
            // 
            // SmoothedImage9x9
            // 
            this.SmoothedImage9x9.Location = new System.Drawing.Point(1063, 164);
            this.SmoothedImage9x9.Name = "SmoothedImage9x9";
            this.SmoothedImage9x9.Size = new System.Drawing.Size(144, 80);
            this.SmoothedImage9x9.TabIndex = 13;
            this.SmoothedImage9x9.Text = "Smoothed Image 9x9";
            this.SmoothedImage9x9.UseVisualStyleBackColor = true;
            this.SmoothedImage9x9.Click += new System.EventHandler(this.SmoothedImage9x9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.SmoothedImage9x9);
            this.Controls.Add(this.SmoothedImage7x7);
            this.Controls.Add(this.SmoothedImage5x5);
            this.Controls.Add(this.SmoothedImage3x3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBox_Smooth9x9Image);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBox_Smooth7x7Image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox_Smooth5x5Image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_Smooth3x3Image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Color Image Smoothing - Làm mượt ảnh màu RGB";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth3x3Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth5x5Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth7x7Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Smooth9x9Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_Smooth3x3Image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Smooth5x5Image;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBox_Smooth7x7Image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBox_Smooth9x9Image;
        private System.Windows.Forms.Button SmoothedImage3x3;
        private System.Windows.Forms.Button SmoothedImage5x5;
        private System.Windows.Forms.Button SmoothedImage7x7;
        private System.Windows.Forms.Button SmoothedImage9x9;
    }
}

