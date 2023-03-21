import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import math

# Định nghĩa hàm Haar Wavelet
def haar_wavelet(data):
    length = len(data)
    output = np.zeros(length)
    even_index = np.arange(0, length, 2)
    odd_index = np.arange(1, length, 2)
    output[even_index] = (data[even_index] + data[odd_index]) / np.sqrt(2)
    output[odd_index] = (data[even_index] - data[odd_index]) / np.sqrt(2)
    return output

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

# Đọc ảnh đầu vào
img = cv2.imread('lenna.png', cv2.IMREAD_GRAYSCALE)
# print(img)

picture = r'D:\Machine Vision\MVPython\lenna.png'
img_fake = cv2.imread(picture, cv2.IMREAD_COLOR)
# print(img_fake)
imgPIL = Image.open(picture)
GrayPicture = TransRGBtoGrayusingAverage(imgPIL)
GrayPicture_CV = np.array(GrayPicture)
cv2.imshow('Anh muc xam OpenCV', GrayPicture_CV)

# Áp dụng phép biến đổi Wavelet cho từng dòng của ảnh
coefficients = np.zeros_like(img, dtype=np.float32)
for i in range(img.shape[0]):
    coefficients[i, :] = haar_wavelet(img[i, :])
    print(coefficients)

# Áp dụng phép biến đổi Wavelet cho từng cột của ảnh
for j in range(coefficients.shape[1]):
    coefficients[:, j] = haar_wavelet(coefficients[:, j])

# Giữ lại một số coefficients để nén ảnh
threshold = 50
coefficients[abs(coefficients) < threshold] = 0

# Áp dụng phép nghịch biến đổi Wavelet để tái tạo ảnh ban đầu
for j in range(coefficients.shape[1]):
    coefficients[:, j] = haar_wavelet(coefficients[:, j])
for i in range(coefficients.shape[0]):
    coefficients[i, :] = haar_wavelet(coefficients[i, :])

# Chuyển đổi các coefficients thành kiểu dữ liệu 8-bit unsigned integer
compressed_img = np.uint8(coefficients)

# Hiển thị ảnh gốc và ảnh nén
# cv2.imshow('Original Image', img)
cv2.imshow('Haar Wavelet Image', compressed_img)
cv2.waitKey(0)
cv2.destroyAllWindows()
