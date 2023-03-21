using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject11_ColorImageSmoothing
{
    public partial class Form1 : Form
    {
        // Khai báo biến toàn cục để sử dụng cho các hàm khác dạng Bitmap
        Bitmap HinhGoc;

        public Form1()
        {
            InitializeComponent();

            // Load hình .jpg từ file
            HinhGoc = new Bitmap(@"D:\Machine Vision\Visual Studio 2017 C#\lenna.png");

            // Cho hiển thị trên pictureBox
            picBox_HinhGoc.Image = HinhGoc;
    
        }

        public Bitmap ColorImageSmoothing3x3(Bitmap hinhgoc)
        {
            Bitmap SmoothedImage3x3 = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    int Rs =0, Gs = 0, Bs = 0;
                    for (int i=x-1; i<=x+1; i++)
                        for (int j=y-1; j<=y+1; j++)
                        {
                            Color color = hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 3 * 3;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage3x3.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage3x3; 
        }

        public Bitmap ColorImageSmoothing5x5(Bitmap hinhgoc)
        {
            Bitmap SmoothedImage5x5 = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 2; x < hinhgoc.Width - 2; x++)
                for (int y = 2; y < hinhgoc.Height - 2; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    for (int i = x - 2; i <= x + 2; i++)
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            Color color = hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 5 * 5;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage5x5.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage5x5;
        }

        public Bitmap ColorImageSmoothing7x7(Bitmap hinhgoc)
        {
            Bitmap SmoothedImage7x7 = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 3; x < hinhgoc.Width - 3; x++)
                for (int y = 3; y < hinhgoc.Height - 3; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    for (int i = x - 3; i <= x + 3; i++)
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            Color color = hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 7 * 7;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage7x7.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage7x7;
        }

        public Bitmap ColorImageSmoothing9x9(Bitmap hinhgoc)
        {
            Bitmap SmoothedImage9x9 = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 4; x < hinhgoc.Width - 4; x++)
                for (int y = 4; y < hinhgoc.Height - 4; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    for (int i = x - 4; i <= x + 4; i++)
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            Color color = hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 9 * 9;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage9x9.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage9x9;
        }

        private void SmoothedImage3x3_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage3x3 = ColorImageSmoothing3x3(HinhGoc);
            picBox_Smooth3x3Image.Image = SmoothedImage3x3;
        }

        private void SmoothedImage5x5_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage5x5 = ColorImageSmoothing5x5(HinhGoc);
            picBox_Smooth5x5Image.Image = SmoothedImage5x5;
        }

        private void SmoothedImage7x7_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage7x7 = ColorImageSmoothing7x7(HinhGoc);
            picBox_Smooth7x7Image.Image = SmoothedImage7x7;
        }

        private void SmoothedImage9x9_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage9x9 = ColorImageSmoothing9x9(HinhGoc);
            picBox_Smooth9x9Image.Image = SmoothedImage9x9;
        }
    }
}
