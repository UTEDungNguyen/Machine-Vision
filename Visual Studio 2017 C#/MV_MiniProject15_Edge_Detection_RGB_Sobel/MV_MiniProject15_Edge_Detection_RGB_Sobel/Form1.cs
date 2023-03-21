using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject15_Edge_Detection_RGB_Sobel
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
        public Bitmap Edge_Detection_RGB_Image(Bitmap hinhgoc)
        {
            Bitmap Edge_Detection_RGB_Image = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            int thresh = Convert.ToInt16(tB_Nguong.Text);

            int[,] matrix_x = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] matrix_y = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    int R_edge_x = 0, G_edge_x = 0, B_edge_x = 0;
                    int R_edge_y = 0, G_edge_y = 0, B_edge_y = 0;
                    int gxx = 0, gyy = 0, gxy = 0;

                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = hinhgoc.GetPixel(i, j);
                            int R_get = color.R;
                            int G_get = color.G;
                            int B_get = color.B;

                            R_edge_x += R_get * matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            G_edge_x += G_get * matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            B_edge_x += B_get * matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];

                            R_edge_y += R_get * matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            G_edge_y += G_get * matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            B_edge_y += B_get * matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                        }

                    gxx = (int)(Math.Pow(Math.Abs(R_edge_x), 2) + Math.Pow(Math.Abs(G_edge_x), 2) + Math.Pow(Math.Abs(B_edge_x), 2));
                    gyy = (int)(Math.Pow(Math.Abs(R_edge_y), 2) + Math.Pow(Math.Abs(G_edge_y), 2) + Math.Pow(Math.Abs(B_edge_y), 2));
                    gxy = (int)((R_edge_x * R_edge_y) + (G_edge_x * G_edge_y) + (B_edge_x * B_edge_y));
                    int theta = (int)(Math.Atan2((2 * gxy) , (gxx - gyy)) / 2);  // dùng hàm Atan2 để tránh trường hợp mẫu bằng 0 sẽ bị lỗi
                    int F0 = (int)Math.Sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)));


                    if (F0 <= thresh)
                        Edge_Detection_RGB_Image.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        Edge_Detection_RGB_Image.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return Edge_Detection_RGB_Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap Edge_Detection_RGB_picture_dis = Edge_Detection_RGB_Image(HinhGoc);
            picBox_RGBSobel.Image = Edge_Detection_RGB_picture_dis;
        }
    }
}
