using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject08_TransRGBtoHSV
{
    public partial class Form1 : Form
    {
        // Khai báo biến toàn cục để sử dụng cho các hàm khác dạng Bitmap
        Bitmap HinhGoc;

        public Form1()
        {
            InitializeComponent();
            // Load hình .jpg từ file
            HinhGoc = new Bitmap(@"D:\Machine Vision\Visual Studio 2017 C#\lena_color.gif");

            // Cho hiển thị trên pictureBox
            picBox_HinhGoc.Image = HinhGoc;

            List<Bitmap> HSV = TransRGBtoHSV(HinhGoc);

            picBox_Hue.Image = HSV[0];
            picBox_Saturation.Image = HSV[1];
            picBox_Value.Image = HSV[2];
            picBox_HSV.Image = HSV[3];
        }

        /// <summary>
        /// Khai báo hàm tính toán chuyển đổi RGB sang HSV
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public List<Bitmap> TransRGBtoHSV(Bitmap hinhgoc)
        {
            // Điểm tọa độ (0,0) gốc trên hình là điểm trên cùng góc trái của hình
            // Chiều X sẽ từ gốc tính về phải, Chiều Y từ gốc tính xuống 

            // Khai báo biến Bitmap để lưu hình gốc vào 
            List<Bitmap> HSV = new List<Bitmap>();

            Bitmap Hue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Saturation = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Value = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap HSVimg = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);

                    double R = pixel.R;   // Giá trị kênh Red
                    double G = pixel.G;   // Giá trị kênh Green
                    double B = pixel.B;   // Giá trị kênh Blue

                    double t1 = ((R - G) + (R - B)) / 2;
                    // t2 là phần mẫu số của công thức tính góc theta 
                    double t2 = Math.Sqrt((R - G) * (R - G) + ((R - B) * (G - B)));
                    // Kết quả theta trả về là kiểu radian nên phải chuyển sang độ 
                    double theta = Math.Acos(t1 / t2);
                    // Công thức tính giá trị Hue 
                    double H = 0;
                    // Nếu B<=G thì Hue = theta 
                    if (B <= G)
                        H = theta;
                    else
                        H = 2 * Math.PI - theta;
                    // Chuyển đổi giá trị từ radian sang độ 
                    H = (H * 180 / Math.PI);

                    double S = 1 - (3 * Math.Min(R, Math.Min(G, B)) / (R + G + B));

                    double V = Math.Max(R, Math.Max(G, B));

                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)(S * 255), (byte)(S * 255), (byte)(S * 255)));
                    Value.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (byte)V));
                    HSVimg.SetPixel(x, y, Color.FromArgb((byte)H, (byte)(S * 255), (byte)V));

                }
            HSV.Add(Hue);
            HSV.Add(Saturation);
            HSV.Add(Value);
            HSV.Add(HSVimg);
            return HSV;
        }
    }
}
