   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5          WpfApplication1.TinhLuong   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication1     5        N� Title$  	TinhLuong��5	       N� FontSize$ 20(�6    N� 
Foreground
 �����.��5      �� $��0,50,0,0q�6   $��Center=�6#   .+�5   
   �� $��Tính lương��6   $��48(�6&   $��Center=�64   �� 5   
   $��0,20,0,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0,20,0,0q�6O   .+�5      �� -   5         ��Name$ 	searchBox��5      $(��"Nhập mã hoặc tên nhân viên��6-   $	��300��6O   .��6w   ��5      �� 5       �� Color# � ��6*   .��5   *   5      �� 5      -   5         ��Name$ SearchButton��5      $��Tìm kiếm��6/   $	��150��6B   6N   5      �� 5      -   5         ��Name$
 Bang��5      $	��500��6'   $��0,20,0,0q�64   $��Center=�6F   $y�	Collapsed=�6c   .+�5      �� -   5        $ ThongTin��5       J� IsHitTestVisible .  .+�5      �� $ 
Horizontal=�6!   .+�5      �� $��Họ và tên��6$   $	��120��65   �� 5      -   5        $ HoTenBox��5   "   $	��200��64   $��5,0,0,0q�6@   5      �� 5      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5      �� $��	Mã số ��6$   $	��120��62   �� 5      -   5        $ MaSoBox��5   "   $	��200��63   $��5,0,0,0q�6?   5      �� 5       $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5!      �� $��
Năm sinh ��6$   $	��120��66   �� 5"      -   5        $ 
NamSinhBox��5"   "   $	��200��66   $��5,0,0,0q�6B   5#      �� 5$      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5%      �� $��
Ngày làm��6$   $	��120��64   �� 5&      -   5        $ 
NgayLamBox��5&   "   $	��200��66   $��5,0,0,0q�6B   5'      �� 5(      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5)      �� $��Đơn vị lương ��6$   $	��120��69   �� 5*      -	   5        $ DVLBox��5*   "   $	��200��62   $��5,0,0,0q�6>   5+      5,      �� 5-      -
   5        	 ��Name$	 Luong��5-      $��	Lương :��6+   
�������$��30��6L   $��0,10,0,0q�6X   �� 5.      -   5        $ 	LapHoaDon��5.      $��Reset và in hóa đơn��6,   $	��200��6J   $��0,20,0,0q�6V   6h   5/      50      51      52      