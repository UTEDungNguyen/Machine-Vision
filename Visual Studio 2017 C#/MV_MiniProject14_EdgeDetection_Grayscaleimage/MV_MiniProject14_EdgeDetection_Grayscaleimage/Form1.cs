using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject14_EdgeDetection_Grayscaleimage
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

        public Bitmap TransRGBtoGrayAverage(Bitmap hinhgoc)
        {
            Bitmap Graypicture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);

                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)((R + G + B) / 3);

                    Graypicture.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return Graypicture;
        }

        public Bitmap Edge_Detection_Grayscale_Image(Bitmap hinhgoc)
        {
            Bitmap Edge_Detection_Grayscale_Image = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            int thresh = Convert.ToInt16(tB_Thresh.Text);

            int[,] matrix_x = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] matrix_y = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    int R_edge_x = 0, G_edge_x = 0, B_edge_x = 0;
                    int R_edge_y = 0, G_edge_y = 0, B_edge_y = 0;
                    //int R_get = 0, G_get = 0, B_get = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = hinhgoc.GetPixel(i, j);
                            int R_get = color.R;

                            R_edge_x += R_get * matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];

                            R_edge_y += R_get * matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                        }

                    int M_red = (int)(Math.Abs(R_edge_x) + Math.Abs(R_edge_y));

                    if (M_red <= thresh)
                        Edge_Detection_Grayscale_Image.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        Edge_Detection_Grayscale_Image.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return Edge_Detection_Grayscale_Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap Graypicture_dis = TransRGBtoGrayAverage(HinhGoc);
            Bitmap Edge_Detection_picture_dis = Edge_Detection_Grayscale_Image(Graypicture_dis);
            picBox_GreySobel.Image = Edge_Detection_picture_dis;
        }
    }
}
