import cv2
from cv2 import INTER_AREA           # Sử dụng thư viện xử lý ảnh của opencv cho Python
import numpy as np   # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 

# Đọc ảnh màu dùng thư viện opencv
img = cv2.imread('D:\Machine Vision\MVPython\MV_MiniProject02\Lena.jpg', cv2.IMREAD_COLOR)  

# Lấy kích thước của ảnh 
height = img.shape[1]   # Lấy số cột của mảng
width = img.shape[0]    # Lấy số cột của mảng

# Khai báo 3 biến để chứa hình 3 kênh R-G-B
cyan = np.zeros((width, height, 3), np.uint8)   # Số 3 là ba kênh R-G-B, mỗi kênh 8bit
magenta = np.zeros((width, height, 3), np.uint8)
yellow = np.zeros((width, height, 3), np.uint8)
black = np.zeros((width, height, 3), np.uint8)

#Ban đầu set zero cho tất cả các điểm ảnh có trong cả 3 kênh trong mỗi hình
cyan[:] = [0,0,0]
magenta[:] = [0,0,0]
yellow[:] = [0,0,0]
black[:] = [0,0,0]

# Mỗi hình là một ma trận 2 chiều nên sẽ dùng 2 vòng for
# để đọc hết các điểm ảnh (pixel) có trong hình
for x in range(width):
    for y in range(height):

        # Lấy giá trị điểm ảnh tại ví trí (x,y)
        R = img[x, y, 2]
        G = img[x, y, 1]
        B = img[x, y, 0]

        # Thiết lập màu cho các kênh
        cyan[x,y,1] = G
        cyan[x,y,0] = B
        magenta[x,y,2] = R
        magenta[x,y,0] = B
        yellow[x,y,2] = R
        yellow[x,y,1] = G
    
        K = min(R,G,B)
        black[x,y,2]= K
        black[x,y,1]= K
        black[x,y,0]= K

# Resize ảnh cho vừa kích thước màn hình lap
resize = (300,300)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
cyan_res = cv2.resize(cyan, resize, interpolation = cv2.INTER_AREA)
magenta_res = cv2.resize(magenta, resize, interpolation = cv2.INTER_AREA)
yellow_res = cv2.resize(yellow, resize, interpolation = cv2.INTER_AREA)
black_res = cv2.resize(black, resize, interpolation = cv2.INTER_AREA)

# Hiển thị hình dùng thư viện Opencv
cv2.imshow('Hinh Mau RGB Co Gai Lena', img_res)
cv2.imshow('Hinh Kenh Cyan', cyan_res)
cv2.imshow('Hinh Kenh Magenta', magenta_res)
cv2.imshow('Hinh Kenh Yellow',yellow_res)
cv2.imshow('Hinh Kenh Black',black_res)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()


