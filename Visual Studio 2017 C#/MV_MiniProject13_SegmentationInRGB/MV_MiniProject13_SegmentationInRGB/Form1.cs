using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject13_SegmentationInRGB
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

        public Bitmap Segmented_img(Bitmap hinhgoc)
        {         
            int x1 = Convert.ToInt16(tB_X1.Text);
            int x2 = Convert.ToInt16(tB_X2.Text);
            int y1 = Convert.ToInt16(tB_Y1.Text);
            int y2 = Convert.ToInt16(tB_Y2.Text);
            int thresh = Convert.ToInt16(tB_Thresh.Text);

            double[] A = new double[3];
            A[0] = A[1] = A[2] = 0;    // A[0] là AR, A[1] là AG, A[2] là AB 
            for (int x = x1; x <= x2; x++)
                for (int y = y1; y <= y2; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    A[0] += pixel.R;
                    A[1] += pixel.G;
                    A[2] += pixel.B;
                }

            double size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            double Rs = A[0] /= size;
            double Gs = A[1] /= size;
            double Bs = A[2] /= size;

            Bitmap Segmenteation_img_dis = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color color = hinhgoc.GetPixel(x, y);
                    double R = color.R;
                    double G = color.G;
                    double B = color.B;

                    double D = Math.Sqrt(Math.Pow((R - Rs), 2) + Math.Pow((G - Gs), 2) + Math.Pow((B - Bs), 2));

                    if ((int)D <=  thresh)
                        Segmenteation_img_dis.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        Segmenteation_img_dis.SetPixel(x, y, Color.FromArgb((byte)R, (byte)G, (byte)B));
                }
            
            return Segmenteation_img_dis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picBox_Segmented.Image = Segmented_img(HinhGoc);
        }
    }
}
