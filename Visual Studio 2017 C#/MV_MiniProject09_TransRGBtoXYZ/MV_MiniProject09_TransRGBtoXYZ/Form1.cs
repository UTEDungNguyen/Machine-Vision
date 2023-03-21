using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject09_TransRGBtoXYZ
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

            List<Bitmap> XYZ = TransRGBtoXYZ(HinhGoc);

            picBox_X.Image = XYZ[0];
            picBox_Y.Image = XYZ[1];
            picBox_Z.Image = XYZ[2];
            picBox_XYZ.Image = XYZ[3];
        }

        /// <summary>
        /// Khai báo hàm tính toán chuyển đổi RGB sang XYZ
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public List<Bitmap> TransRGBtoXYZ(Bitmap hinhgoc)
        {
            // Điểm tọa độ (0,0) gốc trên hình là điểm trên cùng góc trái của hình
            // Chiều X sẽ từ gốc tính về phải, Chiều Y từ gốc tính xuống 

            // Khai báo biến Bitmap để lưu hình gốc vào 
            List<Bitmap> XYZ = new List<Bitmap>();

            Bitmap X_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Y_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Z_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap XYZ_picture = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);

                    double R = pixel.R;   // Giá trị kênh Red
                    double G = pixel.G;   // Giá trị kênh Green
                    double B = pixel.B;   // Giá trị kênh Blue

                    double X = (0.4124564 * R + 0.3575761 * G + 0.1804375 * B);
                    double Y = (0.2126729 * R + 0.7151522 * G + 0.0721750 * B);
                    double Z = (0.0193339 * R + 0.1191920 * G + 0.9503041 * B);

                    X_picture.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    Y_picture.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    Z_picture.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));
                    XYZ_picture.SetPixel(x, y, Color.FromArgb((byte)X, (byte)Y, (byte)Z));

                }
            XYZ.Add(X_picture);
            XYZ.Add(Y_picture);
            XYZ.Add(Z_picture);
            XYZ.Add(XYZ_picture);
            return XYZ;
        }
    }
}
