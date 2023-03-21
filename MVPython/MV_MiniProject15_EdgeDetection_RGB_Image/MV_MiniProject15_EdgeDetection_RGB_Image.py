from tkinter import *
import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image
from cv2 import sqrt   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import math

root = Tk()
root.geometry('400x200+500+500')
root.title('Giao diện Nhận dạng đường biên (RGB) (Edge Detection Grayscale Image)')
root.resizable(False,False)

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\MVPython\lenna.png'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(picture, cv2.IMREAD_COLOR)

imgPIL = Image.open(picture)

matrix_x = [[-1, -2, -1],[0, 0, 0 ],[1, 2, 1]]
matrix_y = [[-1, 0, 1],[-2, 0, 2],[-1, 0, 1]]

L1 = Label(root, text='Giao diện Nhận Dạng Biên RGB (Edge Detected Image)', font=('Arial',12), fg='White', bg='blue')
L1.place(x=0 , y=0, width=400)
L2 = Label(root, text='Ngưỡng:', font=('Arial',10), fg='black')
L2.place(x=20 , y=130)

E1 = Entry(root, font=('Arial',10), width=10, justify='left')
E1.place(x=80, y=130)

def Edge_Detected_Image_func(imgPIL):

    Nguong = int(E1.get())

    Edge_Detected_RGB_picture = Image.new(imgPIL.mode, imgPIL.size)  

    # Lấy kích thước của ảnh từ imgPIL
    width = Edge_Detected_RGB_picture.size[0]         # chiều ngang
    height = Edge_Detected_RGB_picture.size[1]        #chiều cao

    for x in range(1, width-1):
        for y in range(1, height-1):
            R_edge_x = 0
            G_edge_x = 0
            B_edge_x = 0

            R_edge_y = 0
            G_edge_y = 0
            B_edge_y = 0

            gxx = 0
            gyy = 0 
            gxy = 0

            for i in range(x-1,x+2):
                for j in range(y-1,y+2):
                    R_sharp, G_sharp, B_sharp = imgPIL.getpixel((i, j))   

                    R_edge_x += R_sharp * matrix_x[abs(x-i-1)][abs(y-j-1)]
                    G_edge_x += G_sharp * matrix_x[abs(x-i-1)][abs(y-j-1)]
                    B_edge_x += B_sharp * matrix_x[abs(x-i-1)][abs(y-j-1)]

                    R_edge_y += R_sharp * matrix_y[abs(x-i-1)][abs(y-j-1)]
                    G_edge_y += G_sharp * matrix_y[abs(x-i-1)][abs(y-j-1)]
                    B_edge_y += B_sharp * matrix_y[abs(x-i-1)][abs(y-j-1)]

            gxx = math.pow(abs(R_edge_x), 2) + math.pow(abs(G_edge_x), 2) + math.pow(abs(B_edge_x), 2)
            gyy = math.pow(abs(R_edge_y), 2) + math.pow(abs(G_edge_y), 2) + math.pow(abs(B_edge_y), 2)
            gxy = (R_edge_x*R_edge_y) + (G_edge_x*G_edge_y) + (B_edge_x*B_edge_y)
            theta = 0.5 * math.atan2((2*gxy), (gxx - gyy))
            F0 = int(math.sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * math.cos(2*theta) + 2*gxy*math.sin(2*theta))))

            # M_red = int((abs(R_edge_x)) + abs(R_edge_y))
            if F0 <= Nguong :
                Edge_Detected_RGB_picture.putpixel((x, y), (0, 0, 0))
            else :
                Edge_Detected_RGB_picture.putpixel((x, y), (255, 255, 255))
    return Edge_Detected_RGB_picture

def B1_Click():
    Edge_Detected_RGB_picture = Edge_Detected_Image_func(imgPIL)
    Edge_Detected_RGB_picture_display = np.array(Edge_Detected_RGB_picture) 
    Edge_Detected_RGB_picture_display_res = cv2.resize(Edge_Detected_RGB_picture_display, resize, interpolation = cv2.INTER_AREA)
    cv2.imshow('Nhan dang duong bien RGB - Edge Detection Image',Edge_Detected_RGB_picture_display_res)

    # Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
    cv2.waitKey(0)

    # Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
    cv2.destroyAllWindows()

resize = (350,350)
img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
cv2.imshow('Anh mau goc RGB co gai Lena',img_res)

B1 = Button(root,text='Nhận dạng biên',font=('Arial',10), width=15, fg='white',bg='green', command=B1_Click)
B1.place(x=225, y=130)

root.mainloop()