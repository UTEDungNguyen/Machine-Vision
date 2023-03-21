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
Y_picture = Image.new(imgPIL.mode, imgPIL.size)   # Copy các chế độ(mode) và kích thước của ảnh
Cb_picture = Image.new(imgPIL.mode, imgPIL.size)
Cr_picture = Image.new(imgPIL.mode, imgPIL.size)
YCbCr_picture = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước của ảnh từ imgPIL
width = Y_picture.size[0]         # chiều ngang
height = Y_picture.size[1]        #chiều cao

# Mỗi ảnh là 1 ma trận 2 chiều nên sử dụng 2 vòng for để quét hết tất cả các điểm ảnh(pixel) có trong ảnh đang xét
for x in range(width):
    for y in range(height):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        R, G, B = imgPIL.getpixel((x, y))  # R, G, B là 1 vecto 3 giá trị (3 phần tử) trả về từ hàm getpixel của ảnh đang xét 

        Y = np.uint8((16 + (65.738 * R / 256) + (129.057 * G / 256) + (25.064 * B / 256)))
        Cb = np.uint8((128 - (37.945 * R / 256) - (74.494 * G / 256) + (112.439 * B / 256)))
        Cr = np.uint8((128 + (112.439 * R / 256) - (94.154 * G / 256) - (18.285 * B / 256)))

        Y_picture.putpixel((x, y), (Y, Y, Y))      
        Cb_picture.putpixel((x, y), (Cb, Cb, Cb)) 
        Cr_picture.putpixel((x, y), (Cr, Cr, Cr)) 
        YCbCr_picture.putpixel((x, y), (Cr, Cb, Y))

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng opencv
# Dùng array trong thư viện numpy để chuyển đổi từ ảnh PIL thanf ma trận mà openCV có thể hiển thị được
Y_picture_display = np.array(Y_picture) 
Cb_picture_display = np.array(Cb_picture)
Cr_picture_display = np.array(Cr_picture)
YCbCr_picture_display = np.array(YCbCr_picture)

# Resize ảnh cho vừa kích thước màn hình lap
resize = (400,400)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
Y_picture_display_res = cv2.resize(Y_picture_display, resize, interpolation = cv2.INTER_AREA)
Cb_picture_display_res = cv2.resize(Cb_picture_display, resize, interpolation = cv2.INTER_AREA)
Cr_picture_display_res = cv2.resize(Cr_picture_display, resize, interpolation = cv2.INTER_AREA)
YCbCr_picture_display_res = cv2.resize(YCbCr_picture_display, resize, interpolation = cv2.INTER_AREA)

# Hiển thị ảnh dùng thư viện OpenCV
cv2.imshow('Anh mau goc RGB co gai Lena',img_res)
cv2.imshow('Co gai Lena kenh Y', Y_picture_display_res)
cv2.imshow('Co gai Lena kenh Cb', Cb_picture_display_res)
cv2.imshow('Co gai Lena kenh Cr', Cr_picture_display_res)
cv2.imshow('Co gai Lena kenh YCbCr', YCbCr_picture_display_res)


# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()



