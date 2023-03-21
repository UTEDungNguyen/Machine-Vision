using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject06_TransRGBtoCMYK
{
    public partial class Form1 : Form
    {
        // Khai báo biến toàn cục để sử dụng cho các hàm khác dạng Bitmap
        Bitmap HinhGoc;

        public Form1()
        {
            InitializeComponent();

            // Load hình .jpg từ file
            HinhGoc = new Bitmap(@"D:\Machine Vision\Visual Studio 2017 C#\Lena.jpg");

            // Cho hiển thị trên pictureBox
            picBox_HinhGoc.Image = HinhGoc;

            List<Bitmap> CMYK = TransRGBtoCMYK(HinhGoc);

            picBox_Cyan.Image = CMYK[0];
            picBox_Magenta.Image = CMYK[1];
            picBox_Yellow.Image = CMYK[2];
            picBox_Black.Image = CMYK[3];

        }

        /// <summary>
        /// Khai báo hàm tính toán chuyển đổi RGB sang CMYK
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public List<Bitmap> TransRGBtoCMYK(Bitmap hinhgoc)
        {
            // Điểm tọa độ (0,0) gốc trên hình là điểm trên cùng góc trái của hình
            // Chiều X sẽ từ gốc tính về phải, Chiều Y từ gốc tính xuống 

            // Khai báo biến Bitmap để lưu hình gốc vào 
            List<Bitmap> CMYK = new List<Bitmap>();

            Bitmap Cyan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Magenta = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Yellow = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Black = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);

                    byte R = pixel.R;   // Giá trị kênh Red
                    byte G = pixel.G;   // Giá trị kênh Green
                    byte B = pixel.B;   // Giá trị kênh Blue

                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));

                    byte K = Math.Min(R, Math.Min(G, B));
                    Black.SetPixel(x, y, Color.FromArgb(K, K, K));
                }
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);
            return CMYK;
        }
    }
}
