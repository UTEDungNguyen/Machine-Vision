import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image  # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import matplotlib.pyplot as plt  

def CalculateHistogram(HinhXamPIL) :
    hisR = np.zeros(256)
    hisG = np.zeros(256)
    hisB = np.zeros(256)
    w = HinhXamPIL.size[0]
    h = HinhXamPIL.size[1] 
    for x in range(w):
        for y in range(h):
            gR, gG, gB = HinhXamPIL.getpixel((x,y))
            hisR[gR] += 1
            hisG[gG] += 1
            hisB[gB] += 1
    return hisR,hisG,hisB

def DrawHistogram(hisR,hisG,hisB) :
    w = 6
    h = 4
    plt.figure('Biểu đồ Histogram RGB', figsize = (w,h), dpi =100)
    trucX = np.zeros(256)
    trucX = np.linspace(0, 256, 256)
    plt.plot(trucX, hisR, color = 'red')
    plt.plot(trucX, hisG, color = 'Green')
    plt.plot(trucX, hisB, color = 'blue')
    plt.title('Biểu đồ Histogram')
    plt.xlabel('Giá trị RGB')
    plt.ylabel('Số điểm cùng giá trị RGB')
    plt.show()

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\Visual Studio 2017 C#\bird_small.jpg'
RGBPicture = cv2.imread(picture, cv2.IMREAD_COLOR)
imgPIL = Image.open(picture)  


# Vì là đọc ảnh RGB để Vẽ Histogram RGB nên phải bỏ ảnh nguyên gốc vào hàm tính Histogram
hiscalR, hiscalG, hiscalB = CalculateHistogram(imgPIL)  
cv2.imshow('Anh RGB OpenCV', RGBPicture)
DrawHistogram(hiscalR, hiscalG, hiscalB)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()



