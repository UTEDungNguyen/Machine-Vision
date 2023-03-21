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
Hue_picture = Image.new(imgPIL.mode, imgPIL.size)   # Copy các chế độ(mode) và kích thước của ảnh
Saturation_picture = Image.new(imgPIL.mode, imgPIL.size)
Value_picture = Image.new(imgPIL.mode, imgPIL.size)
HSV_picture = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước của ảnh từ imgPIL
width = Hue_picture.size[0]         # chiều ngang
height = Hue_picture.size[1]        #chiều cao

# Mỗi ảnh là 1 ma trận 2 chiều nên sử dụng 2 vòng for để quét hết tất cả các điểm ảnh(pixel) có trong ảnh đang xét
for x in range(width):
    for y in range(height):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        R, G, B = imgPIL.getpixel((x, y))  # R, G, B là 1 vecto 3 giá trị (3 phần tử) trả về từ hàm getpixel của ảnh đang xét 

        t1 = ((R - G) + (R - B)) / 2
        t2 = math.sqrt((R - G) * (R - G) + ((R - B) * (G - B)))
        theta = math.acos(t1 / t2)
        H = 0
        if B <= G :
            H = theta
        else :
            H = 2 * math.pi- theta
        H = np.uint8((H * 180 / math.pi))

        S = np.uint8((1 - (3 * min(R,G,B) / (R + G + B)))*255)

        V = np.uint8(max(R, G, B))

        Hue_picture.putpixel((x, y), (H, H, H))      
        Saturation_picture.putpixel((x, y), (S, S, S)) 
        Value_picture.putpixel((x, y), (V, V, V)) 
        HSV_picture.putpixel((x, y), (V, S, H))

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng opencv
# Dùng array trong thư viện numpy để chuyển đổi từ ảnh PIL thanf ma trận mà openCV có thể hiển thị được
Hue_picture_display = np.array(Hue_picture) 
Saturation_picture_display = np.array(Saturation_picture)
Value_picture_display = np.array(Value_picture)
HSV_picture_display = np.array(HSV_picture)

# Resize ảnh cho vừa kích thước màn hình lap
resize = (400,400)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
Hue_picture_display_res = cv2.resize(Hue_picture_display, resize, interpolation = cv2.INTER_AREA)
Saturation_picture_display_res = cv2.resize(Saturation_picture_display, resize, interpolation = cv2.INTER_AREA)
Value_picture_display_res = cv2.resize(Value_picture_display, resize, interpolation = cv2.INTER_AREA)
HSV_picture_display_res = cv2.resize(HSV_picture_display, resize, interpolation = cv2.INTER_AREA)

# Hiển thị ảnh dùng thư viện OpenCV
cv2.imshow('Anh mau goc RGB co gai Lena',img_res)
cv2.imshow('Co gai Lena kenh Hue', Hue_picture_display_res)
cv2.imshow('Co gai Lena kenh Saturation', Saturation_picture_display_res)
cv2.imshow('Co gai Lena kenh Value', Value_picture_display_res)
cv2.imshow('Co gai Lena kenh HSV', HSV_picture_display_res)


# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()



