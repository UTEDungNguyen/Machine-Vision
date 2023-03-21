import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import math

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\MVPython\lenna.png'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(picture, cv2.IMREAD_COLOR)

imgPIL = Image.open(picture)

Sharp_picture = Image.new(imgPIL.mode, imgPIL.size)   # Copy các chế độ(mode) và kích thước của ảnh

# Lấy kích thước của ảnh từ imgPIL
width = Sharp_picture.size[0]         # chiều ngang
height = Sharp_picture.size[1]        #chiều cao

matrix = [[0,-1,0],[-1,4,-1],[0,-1,0]]

def Sharp_img() :
    for x in range(1, width-1):
        for y in range(1, height-1):
            Rs = 0
            Gs = 0
            Bs = 0
            SharpR = 0
            SharpG = 0
            SharpB = 0
            for i in range(x-1,x+2):
                for j in range(y-1,y+2):
                    # Lấy giá trị điểm ảnh tại vị trí (i, j)
                    R_sharp, G_sharp, B_sharp = imgPIL.getpixel((i, j))   
                    Rs += R_sharp * matrix[abs(x-i-1)][abs(y-j-1)]
                    Gs += G_sharp * matrix[abs(x-i-1)][abs(y-j-1)]
                    Bs += B_sharp * matrix[abs(x-i-1)][abs(y-j-1)]    

            R, G, B = imgPIL.getpixel((x, y))                 
            SharpR = int(R + Rs)
            SharpG = int(G + Gs)
            SharpB = int(B + Bs)

            if SharpR < 0 :
                SharpR = 0
            elif SharpR > 255 :
                SharpR = 255
            if SharpG < 0 :
                SharpG = 0
            elif SharpG > 255 :
                SharpG =255
            if SharpB < 0 :
                SharpB = 0
            elif SharpB > 255 :
                SharpB = 255

            Sharp_picture.putpixel((x, y), (SharpB, SharpG, SharpR))  

Sharp_img()

Sharp_picture_display = np.array(Sharp_picture) 

resize = (350,350)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
Sharp_picture_display_res = cv2.resize(Sharp_picture_display, resize, interpolation = cv2.INTER_AREA)

cv2.imshow('Anh mau goc RGB co gai Lena',img_res)
cv2.imshow('Hinh lam sac net (Sharpening)',Sharp_picture_display_res)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()
