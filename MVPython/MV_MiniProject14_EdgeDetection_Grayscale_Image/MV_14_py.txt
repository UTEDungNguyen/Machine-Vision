from tkinter import *
import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image
from cv2 import sqrt   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import math

root = Tk()
root.geometry('400x200+500+500')
root.title('Giao diện Nhận dạng đường biên (Edge Detection Grayscale Image)')
root.resizable(False,False)

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\MVPython\lenna.png'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(picture, cv2.IMREAD_COLOR)

imgPIL = Image.open(picture)

matrix_x = [[-1, -2, -1],[0, 0, 0 ],[1, 2, 1]]
matrix_y = [[-1, 0, 1],[-2, 0, 2],[-1, 0, 1]]

L1 = Label(root, text='Giao diện Nhận Dạng Biên (Edge Detected Image)', font=('Arial',13), fg='White', bg='blue')
L1.place(x=0 , y=0, width=400)
L2 = Label(root, text='Ngưỡng:', font=('Arial',10), fg='black')
L2.place(x=20 , y=130)

E1 = Entry(root, font=('Arial',10), width=10, justify='left')
E1.place(x=80, y=130)

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
    return grayscale_average

def Edge_Detected_Image_func(Graypicture):

    Nguong = int(E1.get())

    Edge_Detected_picture = Image.new(Graypicture.mode, Graypicture.size)  

    # Lấy kích thước của ảnh từ imgPIL
    width = Edge_Detected_picture.size[0]         # chiều ngang
    height = Edge_Detected_picture.size[1]        #chiều cao

    for x in range(1, width-1):
        for y in range(1, height-1):
            R_edge_x = 0
            R_edge_y = 0
            for i in range(x-1,x+2):
                for j in range(y-1,y+2):
                    R_sharp, G_sharp, B_Sharp = Graypicture.getpixel((i, j))   
                    R_edge_x += R_sharp * matrix_x[abs(x-i-1)][abs(y-j-1)]
                    R_edge_y += R_sharp * matrix_y[abs(x-i-1)][abs(y-j-1)]
            M_red = int((abs(R_edge_x)) + abs(R_edge_y))
            if M_red <= Nguong :
                Edge_Detected_picture.putpixel((x, y), (0, 0, 0))
            else :
                Edge_Detected_picture.putpixel((x, y), (255, 255, 255))
    return Edge_Detected_picture


def B1_Click():
    Edge_Detected_picture = Edge_Detected_Image_func(GrayPicture)
    Edge_Detected_picture_display = np.array(Edge_Detected_picture) 
    Segment_picture_display_res = cv2.resize(Edge_Detected_picture_display, resize, interpolation = cv2.INTER_AREA)
    cv2.imshow('Nhan dang duong bien - Edge Detection Image',Segment_picture_display_res)

    # Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
    cv2.waitKey(0)

    # Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
    cv2.destroyAllWindows()

resize = (350,350)
GrayPicture = TransRGBtoGrayusingAverage(imgPIL)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
cv2.imshow('Anh mau goc RGB co gai Lena',img_res)

B1 = Button(root,text='Nhận dạng biên',font=('Arial',10), width=15, fg='white',bg='green', command=B1_Click)
B1.place(x=225, y=130)

root.mainloop()