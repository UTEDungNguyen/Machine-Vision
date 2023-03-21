import cv2
from cv2 import INTER_AREA           # Sử dụng thư viện xử lý ảnh của opencv cho Python
import numpy as np   # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 

# Đọc ảnh màu dùng thư viện opencv
img = cv2.imread('D:\Machine Vision\MVPython\MV_MiniProject02\Lena.jpg', cv2.IMREAD_COLOR)  

# Lấy kích thước của ảnh 
height = img.shape[1]   # Lấy số cột của mảng
width = img.shape[0]    # Lấy số hàng của mảng

# Khai báo 3 biến để chứa hình 3 kênh R-G-B
red = np.zeros((width, height, 3), np.uint8)   # Số 3 là ba kênh R-G-B, mỗi kênh 8bit
green = np.zeros((width, height, 3), np.uint8)
blue = np.zeros((width, height, 3), np.uint8)

#Ban đầu set zero cho tất cả các điểm ảnh có trong cả 3 kênh trong mỗi hình
red[:] = [0,0,0]
green[:] = [0,0,0]
blue[:] = [0,0,0]

# Mỗi hình là một ma trận 2 chiều nên sẽ dùng 2 vòng for
# để đọc hết các điểm ảnh (pixel) có trong hình
for x in range(width):
    for y in range(height):

        # Lấy giá trị điểm ảnh tại ví trí (x,y)
        R = img[x, y, 2]
        G = img[x, y, 1]
        B = img[x, y, 0]

        # Thiết lập màu cho các kênh
        red[x,y,2] = R
        green[x,y,1] = G
        blue[x,y,0] = B

# Resize ảnh cho vừa kích thước màn hình lap
resize = (300,300)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
red_res = cv2.resize(red, resize, interpolation = cv2.INTER_AREA)
green_res = cv2.resize(green, resize, interpolation = cv2.INTER_AREA)
blue_res = cv2.resize(blue, resize, interpolation = cv2.INTER_AREA)

# Hiển thị hình dùng thư viện Opencv
cv2.imshow('Hinh Mau RGB Co Gai Lena', img_res)
cv2.imshow('Hinh Kenh Red', red_res)
cv2.imshow('Hinh Kenh Green', green_res)
cv2.imshow('Hinh Kenh Blue', blue_res)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()


