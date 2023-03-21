from turtle import width
import cv2              # Sử dụng thư viện xử lý ảnh openCV
from PIL import Image
from cv2 import threshold   # Sử dụng thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh khác nhau
import numpy as np      # Sử dụng thư viện toán học, đặc biệt là các tính toán ma trận 

# Khai báo đường dẫn file hình
picture = r'D:\Machine Vision\MVPython\MV_MiniProject03\Lena.jpg'

def donothing(x):
    pass

cv2.namedWindow('image')

cv2.createTrackbar('Threshold','image',130,255, donothing)

while True :
    k = cv2.waitKey(1) 
    if k == ord('q'):
        break
    b = cv2.getTrackbarPos('Threshold','image')
    print(b)