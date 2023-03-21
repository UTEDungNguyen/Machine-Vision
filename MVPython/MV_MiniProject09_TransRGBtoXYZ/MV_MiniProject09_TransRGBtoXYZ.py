import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import math

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\MVPython\lenna.png'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(picture, cv2.IMREAD_COLOR)

# Đọc ảnh màu dùng thư viện PIL. Ảnh PIL này chúng ta sẽ dùng để thực hiện 
# các tác vụ xử lý và tính toán thay vì dùng OpenCV 
# còn ảnh OpenCV chỉ dùng để hiện thị (PIL dùng để tính toán)
imgPIL = Image.open(picture)

# Tạo một ảnh có cùng kích thước và mode với ảnh imgPIL ở trên
# Mục đích dùng để chứa các kết quả trả về sau khi thực hiện chuyển đổi từ ảnh RGB --> Grayscale
X_picture = Image.new(imgPIL.mode, imgPIL.size)   # Copy các chế độ(mode) và kích thước của ảnh
Y_picture = Image.new(imgPIL.mode, imgPIL.size)
Z_picture = Image.new(imgPIL.mode, imgPIL.size)
XYZ_picture = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước của ảnh từ imgPIL
width = X_picture.size[0]         # chiều ngang
height = X_picture.size[1]        #chiều cao

# Mỗi ảnh là 1 ma trận 2 chiều nên sử dụng 2 vòng for để quét hết tất cả các điểm ảnh(pixel) có trong ảnh đang xét
for x in range(width):
    for y in range(height):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        R, G, B = imgPIL.getpixel((x, y))  # R, G, B là 1 vecto 3 giá trị (3 phần tử) trả về từ hàm getpixel của ảnh đang xét 

        X = np.uint8(0.4124564 * R + 0.3575761 * G + 0.1804375 * B)
        Y = np.uint8(0.2126729 * R + 0.7151522 * G + 0.0721750 * B)
        Z = np.uint8(0.0193339 * R + 0.1191920 * G + 0.9503041 * B)

        X_picture.putpixel((x, y), (X, X, X))      
        Y_picture.putpixel((x, y), (Y, Y, Y)) 
        Z_picture.putpixel((x, y), (Z, Z, Z)) 
        XYZ_picture.putpixel((x, y), (Z, Y, X))

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng opencv
# Dùng array trong thư viện numpy để chuyển đổi từ ảnh PIL thanf ma trận mà openCV có thể hiển thị được
X_picture_display = np.array(X_picture) 
Y_picture_display = np.array(Y_picture)
Z_picture_display = np.array(Z_picture)
XYZ_picture_display = np.array(XYZ_picture)

# Resize ảnh cho vừa kích thước màn hình lap
resize = (400,400)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
X_picture_display_res = cv2.resize(X_picture_display, resize, interpolation = cv2.INTER_AREA)
Y_picture_display_res = cv2.resize(Y_picture_display, resize, interpolation = cv2.INTER_AREA)
Z_picture_display_res = cv2.resize(Z_picture_display, resize, interpolation = cv2.INTER_AREA)
XYZ_picture_display_res = cv2.resize(XYZ_picture_display, resize, interpolation = cv2.INTER_AREA)

# Hiển thị ảnh dùng thư viện OpenCV
cv2.imshow('Anh mau goc RGB co gai Lena',img_res)
cv2.imshow('Co gai Lena kenh X', X_picture_display_res)
cv2.imshow('Co gai Lena kenh Y', Y_picture_display_res)
cv2.imshow('Co gai Lena kenh Z', Z_picture_display_res)
cv2.imshow('Co gai Lena kenh XYZ', XYZ_picture_display_res)


# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()



