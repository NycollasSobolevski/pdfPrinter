# pip install pywin32

import win32print
import win32api
import os

#chose the printer 
printers_list = win32print.EnumPrinters(2)

search = "EPSON L3210 Series"
selected_printer = None
for printer in printers_list:
    if(printer[2] == search):
        selected_printer = printer
        break

win32print.SetDefaultPrinter(selected_printer[2])

print_files_path = r"C:\Users\Nycollas\Desktop\Projects\PdfPrinter\Imprimir"
file_lsit = os.listdir(print_files_path)

for file in file_lsit:
    win32api.ShellExecute(0, "print", file, None, print_files_path, 0)