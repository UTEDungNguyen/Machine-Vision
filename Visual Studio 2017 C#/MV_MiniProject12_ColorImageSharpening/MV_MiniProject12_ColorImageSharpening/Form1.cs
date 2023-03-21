using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject12_ColorImageSharpening
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

        public Bitmap ColorImageSharpening(Bitmap hinhgoc)
        {
            Bitmap SharpImage = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            int[,] matrix = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };

            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    int SharpR = 0, SharpG = 0, SharpB = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = hinhgoc.GetPixel(i, j);
                            int R_sharp = color.R;
                            int G_sharp = color.G;
                            int B_sharp = color.B;

                            Rs += R_sharp * matrix[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Gs += G_sharp * matrix[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Bs += B_sharp * matrix[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                        }

                    Color pixel = hinhgoc.GetPixel(x, y);
                    int R = pixel.R;
                    int G = pixel.G;
                    int B = pixel.B;

                    SharpR = (int)(R + Rs);
                    SharpG = (int)(G + Gs);
                    SharpB = (int)(B + Bs);

                    if (SharpR < 0)
                        SharpR = 0;
                    else if (SharpR > 255)
                        SharpR = 255;
                    if (SharpG < 0)
                        SharpG = 0;
                    else if (SharpG > 255)
                        SharpG = 255;
                    if (SharpB < 0)
                        SharpB = 0;
                    else if (SharpB > 255)
                        SharpB = 255;

                    SharpImage.SetPixel(x, y, Color.FromArgb(SharpR, SharpG, SharpB));
                }
            return SharpImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap SharpImage = ColorImageSharpening(HinhGoc);
            picBox_Sharp.Image = SharpImage;
        }
    }
}
