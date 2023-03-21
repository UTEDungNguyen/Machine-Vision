import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image  # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import matplotlib.pyplot as plt  

def TransRGBtoGrayusingAverage(imgPIL) :
    grayscale_average = Image.new(imgPIL.mode, imgPIL.size)   # Copy các chế độ(mode) và kích thước của ảnh
    # Lấy kích thước của ảnh từ imgPIL
    width = grayscale_average.size[0]         # chiều ngang
    height = grayscale_average.size[1]        #chiều cao
    # Mỗi ảnh là 1 ma trận 2 chiều nên sử dụng 2 vòng for để quét hết tất cả các điểm ảnh(pixel) có trong ảnh đang xét
    for x in range(width):
        for y in range(height):
            # Lấy giá trị điểm ảnh tại vị trí (x, y)
            R, G, B = imgPIL.getpixel((x, y))  
            gray_trans_average = np.uint8((R + G + B) / 3)   # Average
            grayscale_average.putpixel((x, y), (gray_trans_average, gray_trans_average, gray_trans_average))  
            print(gray_trans_average)
    return grayscale_average

def CalculateHistogram(HinhXamPIL) :
    his = np.zeros(256)
    w = HinhXamPIL.size[0]
    h = HinhXamPIL.size[1] 
    for x in range(w):
        for y in range(h):
            gR, gG, gB = HinhXamPIL.getpixel((x,y))
            his[gR] += 1
    return his

def DrawHistogram(his) :
    w = 6
    h = 4
    plt.figure('Biểu đồ Histogram Xám', figsize = (w,h), dpi =100)
    trucX = np.zeros(256)
    trucX = np.linspace(0, 256, 256)
    plt.plot(trucX, his, color = 'red')
    plt.title('Biểu đồ Histogram')
    plt.xlabel('Giá trị mức xám')
    plt.ylabel('Số điểm cùng giá trị mức xám')
    plt.show()

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\Visual Studio 2017 C#\bird_small.jpg'
imgPIL = Image.open(picture)  

GrayPicture = TransRGBtoGrayusingAverage(imgPIL)
hiscal = CalculateHistogram(GrayPicture)
GrayPicture_CV = np.array(GrayPicture)
cv2.imshow('Anh muc xam OpenCV', GrayPicture_CV)
DrawHistogram(hiscal)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()



