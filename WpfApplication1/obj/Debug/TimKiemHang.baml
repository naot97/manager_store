   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5      !    WpfApplication1.TimKiemHang   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication1     5        N� Title$  TimKiemHang��5	      $	��800��5
       N� FontSize$ 20(�5      $
��1000��5      .��5      �� .+�5   
   �� $��0,10,0,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5         ��Name$ 	SearchBox��5      $	��300��5      $"��Nhập mã hoặc tên hàng��5      .��5   8   ��5      �� 5       �� Color# � ��6*   .��5   *   5      �� 5      -   5         ��Name$ SearchButton��5      $	��100��6/   $��Tìm kiếm��6;   6O   5      �� 5      -   5         ��Name$ listHang��5      $��Visible=�5      $��0,10,0,0q�5       �� SelectionMode$ Single=�5      $	��250��5       $��12(�5!      ��5      �� ��5#      �� 5$      .R�5%      �� $ 
Horizontal=�6%   .+�5&      �� $	��300��6)   .+�5'   "   �� ��6,   ��  �� Path$	 ten��� 5(   "   ��6,   �� $ maHang��� 5)   "   ��6,   �� $
 loai��� 5*   "   ��6,   �� $ soLuong��� 5+   "   ��6,   �� $ donGia�5,      �� 5-      $	��150��6F   $��10,0,0,0q�6R   ��6$   �� $ 	sourceAnh�6R   5.      5/      51      �� 52      .+�53      �� $ 
Horizontal=�6   .+�54      �� -   5        	 ��Name$	 Result��54       $	��100��60   $
��Wrap=�6=   $��14(�6Q   $��0,10,0,0q�6_   
����  �6q   �� 55      -   5        
 ��Name$

 imgR��55      $��20,0,0,0q�6*   $	��200��6<   $	��120��6H   56      �� 57      -   5        $ 
SoLuongBox��57      $	��200��62   $$��Nhập số lượng cần mua��6>   $��14(�6z   $
��Left=�6�   $��	20,20,0,0q�6�   .��6�   ��58      �� 59      # � ��6.   .��5:   .   5;      5<      �� 5=      -   5        $ OkButton��5=      $��OK��6'   $	��100��64   $��Right=�6@   $��
0,-60,20,0q�6\   6p   5>      5?      5@      