from tkinter import *
from tkinter.tix import ButtonBox
from attr import define
import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image
from cv2 import RNG_NORMAL
from cv2 import sqrt   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 
import math

root = Tk()
root.geometry('400x200+500+500')
root.title('Giao diện Phân Đoạn Ảnh (Segmentation in RGB)')
root.resizable(False,False)

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\MVPython\lenna.png'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(picture, cv2.IMREAD_COLOR)

imgPIL = Image.open(picture)

resize = (350,350)

img_res = cv2.resize(img, resize, interpolation = cv2.INTER_AREA)
cv2.imshow('Anh mau goc RGB co gai Lena',img_res)

Segmented_picture = Image.new(imgPIL.mode, imgPIL.size)   # Copy các chế độ(mode) và kích thước của ảnh

# Lấy kích thước của ảnh từ imgPIL
width = Segmented_picture.size[0]         # chiều ngang
height = Segmented_picture.size[1]        #chiều cao

L1 = Label(root, text='Giao diện Phân Đoạn Ảnh (Segmentation in RGB)', font=('Arial',13), fg='White', bg='blue')
L1.place(x=0 , y=0, width=400)
L2 = Label(root, text='x1:', font=('Arial',10), fg='black')
L2.place(x=20 , y=30)
L3 = Label(root, text='x2:', font=('Arial',10), fg='black')
L3.place(x=230 , y=30)
L4 = Label(root, text='y1:', font=('Arial',10), fg='black')
L4.place(x=20 , y=80)
L5 = Label(root, text='y2:', font=('Arial',10), fg='black')
L5.place(x=230 , y=80)
L6 = Label(root, text='Ngưỡng:', font=('Arial',10), fg='black')
L6.place(x=20 , y=130)

E1 = Entry(root, font=('Arial',10), width=10, justify='left')
E1.place(x=45, y=30)
E2 = Entry(root, font=('Arial',10), width=10, justify='left')
E2.place(x=255, y=30)
E3 = Entry(root, font=('Arial',10), width=10, justify='left')
E3.place(x=45, y=80)
E4 = Entry(root, font=('Arial',10), width=10, justify='left')
E4.place(x=255, y=80)
E5 = Entry(root, font=('Arial',10), width=10, justify='left')
E5.place(x=80, y=130)

def Segmented_img() :
    x1 = int(E1.get())
    x2 = int(E2.get())
    y1 = int(E3.get())
    y2 = int(E4.get())
    Nguong = int(E5.get())

    Rs = 0
    Gs = 0
    Bs = 0 

    for x in range (x1, x2+1) :
        for y in range (y1, y2+1):
            R_seg, G_seg, B_seg = imgPIL.getpixel((x, y))
            Rs += R_seg
            Gs += G_seg
            Bs += B_seg
    size = abs(x2-x1)*abs(y2-y1)
    Rs /= size
    Gs /= size
    Bs /= size

    for x in range (width) :
        for y in range (height):
            R,G,B = imgPIL.getpixel((x, y))
            D = math.sqrt(math.pow((R-Rs),2) + pow((G-Gs),2) + pow((B-Bs),2))
            if int(D) <= Nguong :
                Segmented_picture.putpixel((x, y), (255, 255, 255)) 
            else :
                Segmented_picture.putpixel((x, y), (B, G, R)) 

def B1_Click():
    Segmented_img()
    Segmented_picture_display = np.array(Segmented_picture) 
    Segment_picture_display_res = cv2.resize(Segmented_picture_display, resize, interpolation = cv2.INTER_AREA)
    cv2.imshow('Phan doan anh - Segmented Image',Segment_picture_display_res)

    # Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
    cv2.waitKey(0)

    # Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
    cv2.destroyAllWindows()

B1 = Button(root,text='Phân đoạn ảnh',font=('Arial',10), width=15, fg='white',bg='green', command=B1_Click)
B1.place(x=225, y=130)

root.mainloop()