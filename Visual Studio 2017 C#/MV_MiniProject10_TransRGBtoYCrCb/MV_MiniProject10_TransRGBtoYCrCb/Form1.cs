using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject10_TransRGBtoYCrCb
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

            List<Bitmap> YCbCr = TransRGBtoYCbCr(HinhGoc);

            picBox_Y.Image = YCbCr[0];
            picBox_Cr.Image = YCbCr[1];
            picBox_Cb.Image = YCbCr[2];
            picBox_YCbCr.Image = YCbCr[3];
        }

        /// <summary>
        /// Khai báo hàm tính toán chuyển đổi RGB sang YCbCr
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public List<Bitmap> TransRGBtoYCbCr(Bitmap hinhgoc)
        {
            // Điểm tọa độ (0,0) gốc trên hình là điểm trên cùng góc trái của hình
            // Chiều X sẽ từ gốc tính về phải, Chiều Y từ gốc tính xuống 

            // Khai báo biến Bitmap để lưu hình gốc vào 
            List<Bitmap> YCbCr = new List<Bitmap>();

            Bitmap Y_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Cr_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Cb_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap YCbCr_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);

                    double R = pixel.R;   // Giá trị kênh Red
                    double G = pixel.G;   // Giá trị kênh Green
                    double B = pixel.B;   // Giá trị kênh Blue

                    double Y = (16 + (65.738 * R / 256) + (129.057 * G / 256) + (25.064 * B / 256));
                    double Cb = (128 - (37.945 * R / 256) - (74.494 * G / 256) + (112.439 * B / 256));
                    double Cr = (128 + (112.439 * R / 256) - (94.154 * G / 256) - (18.285 * B / 256));

                    Y_picture.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    Cr_picture.SetPixel(x, y, Color.FromArgb((byte)Cr, (byte)Cr, (byte)Cr));
                    Cb_picture.SetPixel(x, y, Color.FromArgb((byte)Cb, (byte)Cb, (byte)Cb));
                    YCbCr_picture.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Cb, (byte)Cr));

                }
            YCbCr.Add(Y_picture);
            YCbCr.Add(Cr_picture);
            YCbCr.Add(Cb_picture);
            YCbCr.Add(YCbCr_picture);
            return YCbCr;
        }
    }
}
