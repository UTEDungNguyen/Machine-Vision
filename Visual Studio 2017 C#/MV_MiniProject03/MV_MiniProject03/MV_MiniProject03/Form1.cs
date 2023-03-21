using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load hình .jpg từ file
            Bitmap HinhGoc = new Bitmap(@"D:\Machine Vision\Visual Studio 2017 C#\Lena.jpg");

            // Cho hiển thị trên pictureBox
            picBox_Hinhgoc.Image = HinhGoc;

            // Tính hình mức xám theo phương pháp Lightness và hiển thị
            picBox_Lightness.Image = TransRGBtoGrayLightness(HinhGoc);

            // Tính hình mức xám theo phương pháp Average và hiển thị
            picBox_Average.Image = TransRGBtoGrayAverage(HinhGoc);

            // Tính hình mức xám theo phương pháp Luminance và hiển thị
            picBox_Luminance.Image = TransRGBtoGrayLuminance(HinhGoc);
        }

        /// <summary>
        /// Khai báo hàm tính toán mức xám theo phương pháp Lightness 
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public Bitmap TransRGBtoGrayLightness(Bitmap hinhgoc)
        {
            // Điểm tọa độ (0,0) gốc trên hình là điểm trên cùng góc trái của hình
            // Chiều X sẽ từ gốc tính về phải, Chiều Y từ gốc tính xuống 

            // Khai báo biến Bitmap để lưu hình gốc vào 
            Bitmap Graypicture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);

                    byte R = pixel.R;   // Giá trị kênh Red
                    byte G = pixel.G;   // Giá trị kênh Green
                    byte B = pixel.B;   // Giá trị kênh Blue

                    // Tính giá trị mức xám cho điểm ảnh tại vị trí (x, y)
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    // Vì khi tính thì ((max + min)/2) là kiểu số thực nên phải ép kiểu byte 8 bit
                    byte gray = (byte)((max + min) / 2);

                    // Gán giá trị mức xám vừa tính vào Hình mức xám 
                    Graypicture.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return Graypicture;
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

        public Bitmap TransRGBtoGrayLuminance(Bitmap hinhgoc)
        {
            Bitmap Graypicture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);

                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)(0.2126*R + 0.7152*G + 0.0722*B);

                    Graypicture.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return Graypicture;
        }
    }
}
