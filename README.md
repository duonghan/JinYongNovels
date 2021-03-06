﻿# Phần mềm đọc truyện Kim Dung  

## ***Bài tập lớn học phần "Lập trình .NET"***  
---

#### **Yêu cầu**  
- > Làm chương trình (Winform hoặc ASP .NET) hiển thị nội dung của bộ truyện Kim Dung. Và sinh viên phải làm chức năng(bên cạnh đọc truyện) kiểm tra xem từ nào sai chính tả tiếng việt. Chương trình phải có thêm chức năng tìm kiếm.
Ví dụ câu: "con mèo đi ra ngoài đường" thì người dùng tìm kiếm với từ khóa "mèo ngoài" phải ra được câu trên và sắp xếp theo thứ tự ưu tiên.  

- > Nếu CSDL trên desktop thì bắt buộc phải là SQL Server. Trên di động cho phép dùng SQLite  

- > Trước 12h đêm ngày 27/1 thì nhóm trưởng comment trên group về danh sách nhóm.  
---
#### **Quy ước**  
1. ### *Đặt tên biến*  
  
    |    Control           |    Tiền tố     |
    | -------------------- |:--------------:|
    |    Label             |      lbl       |
    |    TextBox           |      txt       |
    |    DataGrid          |      dtg       |
    |    Button            |      btn       |
    |    ImageButton       |      hlk       |
    |    Hyperlink         |      lbl       |
    |    DropDownList      |      ddl       |
    |    DataList          |      dtl       |
    |    Repeater          |      rep       |
    |    Checkbox          |      chk       |
    |    CheckBoxList      |      cbl       |
    |    RadioButton       |      rdo       |
    |    RadioButtonList   |      rbl       |
    |    Image             |      img       |
    |    Panel             |      pnl       |
    |    PlaceHolder       |      phd       |
    |    Table             |      tbl       |
    |    Validators        |      val       |  

2. ### *Kiểm tra chính tả*  

    |    Mục                                   |       Ví dụ                      |
    | ---------------------------------------- |:--------------------------------:|
    |    Bảng chữ cái tiếng việt               |      Không chứa: z,j,w,f         |
    |    Cặp phụ âm đầu                        |      8:nh,th,ph,tr,ch,gh,kh,ng   |
    |    Phụ âm cuối                           |      5:c,m,n,p,t                 |
    |    Cặp phụ âm cuối                       |      3: nh, ng, ch               |
    |    Tối đa 7 chữ cái                      |      "nghiêng"                   |
    |    Tối đa 5 phụ âm                       |      "ngh + ng"                  |
    |    Tối đa 3 nguyên âm                    |      "uye"                       |
    |    Trùng kí tự                           |      "chuung"                    |
    |    Dấu không đúng chỗ                    |      "qũy" -> "quỹ"              |
    |    Sai dấu                               |      "nien" -> "niên"            |
    |    Kí tự thiếu                           |      "kông" -> "không"           |
    |    Chính tả: ch/tr, s/x, d/gi/r, l/n     |      "chăn chối, xuất xắc..."    |
    |    Hỏi/ngã                               |      "vui vẽ" -> "vui vẻ"        |  
3. 
---
#### **Thành viên**  
1. [Hàn Văn Dương](https://www.facebook.com/duonngbk)  
2. [Đỗ Minh Quang](https://www.facebook.com/quang.do.963871)  
3. [Tô Tiến Đạt](https://www.facebook.com/dat.tien.1656)  

![Cover - JinYong](cover.png)  