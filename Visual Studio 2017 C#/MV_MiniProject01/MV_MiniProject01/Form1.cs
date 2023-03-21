using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace MV_MiniProject01
{
    public partial class Form1 : Form
    {
        //Image<Bgr, byte> hinhhienthi = new Image<Bgr, byte>(@"D:\Machine Vision\Visual Studio 2017 C#\Lena.jpg");
        
        public Form1()
        {
            InitializeComponent();

            //Tạo một biến chứa đường dẫn nơi lưu hình màu RGB gốc cần xử lý 
            // Lưu ý : Cần phải có ký tự @ phía trước để C#.NET biết chuỗi là Unicode để không bị báo lỗi 
            string Filehinh = @"D:\Machine Vision\Visual Studio 2017 C#\Lena.jpg";

            //Tạo một biến chứa hình Bitmap được load từ file hình
            Bitmap hinhgoc = new Bitmap(Filehinh);

            //Khai báo biến và kiểu dữ liệu load ảnh từ file hình Bitmap vừa khai báo ở trên bằng Image
            Image<Bgr, byte> hinhhienthi = new Image<Bgr, byte>(hinhgoc);

            // Hiển thị hình gốc trong ImageBox đã tạo  
            imgBox_HinhGoc.Image = hinhhienthi;

            //Khai báo 3 hình Bitmap để chứa 3 hình kênh R,G,B
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //Mỗi hình là một ma trận 2 chiều nên sẽ dùng 2 vòng For 
            //để đọc hết các điểm ảnh (Pixel) có trong hình 
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Đọc giá trị pixel tại điểm ảnh có vị trí (x, y)
                    Color pixel = hinhgoc.GetPixel(x, y);

                    //Mỗi pixel chứa 4 thông tin bao gồm giá trị màu
                    //R,G,B và thông tin giá trị độ trong suốt A
                    byte R = pixel.R;  // Giá trị kênh RED
                    byte G = pixel.G;  // Giá trị kênh GREEN
                    byte B = pixel.B;  // Giá trị kênh BLUE
                    byte A = pixel.A;  // Độ trong suốt

                    //Set giá trị pixel đọc được cho các hình chứa 
                    //các kênh màu tương ứng R,G,B
                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));
                        
                }
            // Hiển thị 3 kênh màu R,G,B tại các imageBox đã tạo
            Image<Bgr, byte> kenhred = new Image<Bgr, byte>(red);
            Image<Bgr, byte> kenhgreen = new Image<Bgr, byte>(green);
            Image<Bgr, byte> kenhblue = new Image<Bgr, byte>(blue);
            imgBox_red.Image = kenhred;
            imgBox_Green.Image = kenhgreen;
            imgBox_Blue.Image = kenhblue;
        }
    }
}
