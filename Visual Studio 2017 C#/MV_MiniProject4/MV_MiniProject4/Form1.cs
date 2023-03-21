using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_MiniProject4
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
            picBox_Hinhgoc.Image = HinhGoc;

            // Tính hình mức xám theo phương pháp Lightness và hiển thị
            picBox_Lightness.Image = TransRGBtoGrayLightness(HinhGoc);

            // Tính hình nhị phân (binary) và hiển thị
            // Giả sử ngưỡng là 150
            picBox_Binary.Image = TransRGBtoBinary(HinhGoc, 150);
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

        /// <summary>
        /// Khai báo hàm tính toán ảnh nhị phân 
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public Bitmap TransRGBtoBinary(Bitmap hinhgoc, byte nguong)
        {
            // Điểm tọa độ (0,0) gốc trên hình là điểm trên cùng góc trái của hình
            // Chiều X sẽ từ gốc tính về phải, Chiều Y từ gốc tính xuống 

            // Khai báo biến Bitmap để lưu hình gốc vào 
            Bitmap Binarypicture = new Bitmap(hinhgoc.Width, hinhgoc.Height);
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
                    byte binary = (byte)((max + min) / 2);

                    // Phân loại điểm ảnh sang nhị phân dựa vào giá trị ngưỡng
                    if (binary < nguong)
                        binary = 0;
                    else
                        binary = 255;

                    // Gán giá trị nhị phân vừa tính vào Hình nhị phân 
                    Binarypicture.SetPixel(x, y, Color.FromArgb(binary, binary, binary));
                }
            return Binarypicture;
        }

        private void vScrollBar_Binarypicture_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị ngưỡng từ giá trị của thanh cuộn
            // Do Value trả về của thanh cuộn là kiểu int, trong khi ngưỡng là kiểu byte
            // Cho nên cần phải ép kiểu byte cho giá trị của thanh cuộn
            byte nguong = (byte)vScrollBar_Binarypicture.Value;

            // Cho hiển thị giá trị ngưỡng lên label 
            // (Chuyển giá trị ngưỡng thành dạng chuỗi rồi đưa lên label theo dạng Text)
            lblThreshold.Text = nguong.ToString();

            // Gọi hàm tính ảnh nhị phân và cho hiển thị
            picBox_Binary.Image = TransRGBtoBinary(HinhGoc, nguong);
        }
    }
}
