using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace MV_MiniProject05_RGB
{
    public partial class Form1 : Form
    {
        // Khai báo biến toàn cục để sử dụng cho các hàm khác dạng Bitmap
        Bitmap HinhGoc;
        public Form1()
        {
            InitializeComponent();
            // Load hình .jpg từ file
            HinhGoc = new Bitmap(@"D:\Machine Vision\Visual Studio 2017 C#\bird_small.jpg");

            // Cho hiển thị trên pictureBox
            picBox_Hinhgoc.Image = HinhGoc;

            double[,] histogram = CalculateHistogram(HinhGoc);
            List<PointPairList> points = TranstoHistogram(histogram);
            zGHistogram.GraphPane = DrawHistogram(points);
            zGHistogram.Refresh();

        }

        public double[,] CalculateHistogram(Bitmap RGBPicture)
        {
            // Mảng 2 chiều để chứa thông tin Histogram các kênh R,G,B
            //3 : số kênh màu cần lưu
            // 256 : là cần 256 vị trí tương ứng giá trị màu từ 0-255
            double[,] histogram = new double[3,256];
            for (int x = 0; x < RGBPicture.Width; x++)
                for (int y = 0; y < RGBPicture.Height; y++)
                {
                    Color color = RGBPicture.GetPixel(x, y);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    histogram[0, R]++;
                    histogram[1, G]++;
                    histogram[2, B]++;
                }
            return histogram; // trả mảng 2 chiều chứa tt histogram của 3 kênh R,G,B
        }

        List<PointPairList> TranstoHistogram(double[,] histogram)
        {
            // PointPairList là kiểu dữ liệu của ZedGraph để vẽ biểu đồ
            List<PointPairList> points = new List<PointPairList>();
            PointPairList redpoints = new PointPairList();
            PointPairList greenpoints = new PointPairList();
            PointPairList bluepoints = new PointPairList();

            for (int i = 0; i < 256; i++)
            {
                redpoints.Add(i, histogram[0, i]);
                greenpoints.Add(i, histogram[1, i]);
                bluepoints.Add(i, histogram[2, i]);
            }

            points.Add(redpoints);
            points.Add(greenpoints);
            points.Add(bluepoints);

            return points;
        }

        public GraphPane DrawHistogram(List<PointPairList> histogram)
        {
            // GraphPane là đối tượng biểu đồ trong ZedGraph
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Biểu đồ Histogram";
            gp.Rect = new Rectangle(0, 0, 886, 693);

            gp.XAxis.Title.Text = @"Giá trị mức xám của các điểm ảnh";
            gp.XAxis.Scale.Min = 0;
            gp.XAxis.Scale.Max = 255;
            gp.XAxis.Scale.MajorStep = 5;  // Mỗi bước chính là 5
            gp.XAxis.Scale.MinorStep = 1;  // Mỗi bước trong 1 bước chính là 1

            gp.YAxis.Title.Text = @"Giá trị mức xám của các điểm ảnh";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000;    // Số này phải lớn hơn kích thước ảnh (w*h)
            gp.YAxis.Scale.MajorStep = 5;  // Mỗi bước chính là 5
            gp.YAxis.Scale.MinorStep = 1;  // Mỗi bước trong 1 bước chính là 1

            gp.AddBar("Histogram kênh Red", histogram[0], Color.Red);
            gp.AddBar("Histogram kênh Green", histogram[1], Color.Green);
            gp.AddBar("Histogram kênh Blue", histogram[2], Color.Blue);

            return gp;

        }
    }
}
