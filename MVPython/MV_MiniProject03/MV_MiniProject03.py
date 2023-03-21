from turtle import width
import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\MVPython\MV_MiniProject03\Lena.jpg'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(picture, cv2.IMREAD_COLOR)

# Đọc ảnh màu dùng thư viện PIL. Ảnh PIL này chúng ta sẽ dùng để thực hiện 
# các tác vụ xử lý và tính toán thay vì dùng OpenCV q
# còn ảnh OpenCV chỉ dùng để hiện thị (PIL dùng để tính toán)
imgPIL = Image.open(picture)

# Tạo một ảnh có cùng kích thước và mode với ảnh imgPIL ở trên
# Mục đích dùng để chứa các kết quả trả về sau khi thực hiện chuyển đổi từ ảnh RGB --> Grayscale
grayscale_average = Image.new(imgPIL.mode, imgPIL.size)   # Copy các chế độ(mode) và kích thước của ảnh
grayscale_Lightness = Image.new(imgPIL.mode, imgPIL.size)
grayscale_Luminance = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước của ảnh từ imgPIL
width = grayscale_average.size[0]         # chiều ngang
height = grayscale_average.size[1]        #chiều cao

# Mỗi ảnh là 1 ma trận 2 chiều nên sử dụng 2 vòng for để quét hết tất cả các điểm ảnh(pixel) có trong ảnh đang xét
for x in range(width):
    for y in range(height):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        R, G, B = imgPIL.getpixel((x, y))  # R, G, B là 1 vecto 3 giá trị (3 phần tử) trả về từ hàm getpixel của ảnh đang xét 

        # Công thức chuyển đổi điểm ảnh màu RGB thành điểm ảnh màu mức xám dùng phương pháp Average, Lightness, Luminance 
        # Ép kiểu trả về là 8 bit (từ 0-255) --> Bởi vì giá trị Gray hiển thị là 1 giá trị từ 0-255 nên phải ép kiểu 8 bit
        gray_trans_average = np.uint8((R + G + B) / 3)   # Average
        gray_trans_Luminance = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)  # Luminance
        # Lightness
        Min = min(R, G, B)
        Max = max(R, G, B)
        gray_trans_Lightness = np.uint8((Min + Max) / 2)  

        # Gán giá trị mức xám vừa tính cho ảnh xám 
        # Tại vì ảnh 3 kênh RGB nên cho cùng giá trị gray thay vì là RGB
        grayscale_average.putpixel((x, y), (gray_trans_average, gray_trans_average, gray_trans_average))       # Average
        grayscale_Luminance.putpixel((x, y), (gray_trans_Luminance, gray_trans_Luminance, gray_trans_Luminance)) # Luminance
        grayscale_Lightness.putpixel((x, y), (gray_trans_Lightness, gray_trans_Lightness, gray_trans_Lightness)) # Lightness

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng opencv
# Dùng array trong thư viện numpy để chuyển đổi từ ảnh PIL thanf ma trận mà openCV có thể hiển thị được
graypicture_average = np.array(grayscale_average) 
graypicture_Luminance = np.array(grayscale_Luminance)
graypicture_Lightness = np.array(grayscale_Lightness)

# Resize ảnh cho vừa kích thước màn hình lap
resize = (400,400)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
gray_res_avr = cv2.resize(graypicture_average, resize, interpolation = cv2.INTER_AREA)
gray_res_Luminance = cv2.resize(graypicture_Luminance, resize, interpolation = cv2.INTER_AREA)
gray_res_Lightness = cv2.resize(graypicture_Lightness, resize, interpolation = cv2.INTER_AREA)

# Hiển thị ảnh dùng thư viện OpenCV
cv2.imshow('Anh mau goc RGB co gai Lena',img_res)
cv2.imshow('Co gai Lena dung Average', gray_res_avr)
cv2.imshow('Co gai Lena dung Luminance', gray_res_Luminance)
cv2.imshow('Co gai Lena dung Lightness', gray_res_Lightness)


# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()



