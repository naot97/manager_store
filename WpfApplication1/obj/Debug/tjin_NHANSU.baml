   M S B A M L   `   `   `  ����  WpfApplication1!    WpfApplication1.tjin_NHANSU   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  tjin_NHANSU��5       N� FontSize$ 18(�6    N� 
Foreground
 �����.��5
      � -   5         �Name$ 
pageNhanSu��5
      .+�5   
   (� -   5         (�Name$ vbLable��5      $��113,62,725,223q�6#    (� Stretch$
 Fill=�6;   .��5      � $	��315��6   $	��162��6    .+�5      �� -   5         ��Name$ lblName��5      $��Họ và Tên :��6)   $
��Left=�6?   $��35��6Z   $	��Top=�6f   $	��162��6~   �� 5      -   5        $ lblMaSo��5      $��
Mã số :��6)   $
��Left=�6;   $��35��6V   $��0,40,0,0q�6b   $	��Top=�6t   $	��162��6�   �� 5      -   5        $ lblSDT��5      $��Số điện thoại:��6(   $
��Left=�6A   $��35��6\   $��0,80,0,0q�6h   $	��Top=�6z   $	��162��6�   �� 5      -   5        $ lblNgaySinh��5      $��Năm sinh :��6-   $
��Left=�6B   $��35��6]   $��	0,120,0,0q�6i   $	��Top=�6|   $	��162��6�   �� 5      -   5        $ lblDonViTien��5      $��Đơn vị tiền :��6.   $
��Left=�6F   $��35��6a   $��	0,160,0,0q�6m   $	��Top=�6�   $	��162��6�   �� 5      -   5        $ lblUser��5      $��
Username :��6)   $
��Left=�6>   $��35��6Y   $��	0,200,0,0q�6e   $	��Top=�6x   $	��162��6�   �� 5      -	   5        $ lblPass1��5      $��
Password :��6*   $
��Left=�6?   $��35��6Z   $��	0,240,0,0q�6f   $	��Top=�6y   $	��162��6�   �� 5      -
   5        $ lblPass2��5      $��Re-Type Password :��6*   $
��Left=�6G   $��35��6b   $��	0,280,0,0q�6n   $	��Top=�6�   $	��162��6�   5      5      (� 5   
   -   5        $ vbTXT��5      $��361,62,308,228q�6!   $
 Fill=�69   .��5      � $	��310��6   $	��331��6    .+�5      �� -   5         ��Name$ txtName��5      $
��Left=�6+   $��30��6F    �� TextWrapping$ NoWrap=�6R   $�� ��6h   $	��Top=�6p   $	��331��6�   �� 5      -   5        $ txtMaSo��5      $
��Left=�6+   $��30��6F   $��0,40,0,0q�6R   $ NoWrap=�6d   $�� ��6z   $	��Top=�6�   $	��331��6�   �� 5      -   5        $ txtSDT��5      $
��Left=�6*   $��30��6E   $��0,80,0,0q�6Q   $ NoWrap=�6c   $�� ��6z   $	��Top=�6�   $	��331��6�   �� 5       -   5        $ 
txtNamSinh��5       $
��Left=�6.   $��30��6I   $��	0,120,0,0q�6U   $ NoWrap=�6h   $�� ��6~   $	��Top=�6�   $	��331��6�   �� 5!      -   5        $ txtDonViTien��5!      $
��Left=�60   $��30��6K   $��	0,160,0,0q�6W   $ NoWrap=�6j   $�� ��6�   $	��Top=�6�   $	��331��6�   �� 5$      -   5        $ txtUser��5$      $
��Left=�6+   $��30��6F   $��	0,200,0,0q�6R   $ NoWrap=�6e   $�� ��6{   $	��Top=�6�   $	��331��6�   G� 5%      -   5        	 G�Name$	 txtPass1��5%      $
��Left=�60   $��30��6K   $��	0,240,0,0q�6W   
 G� Password$
  ��6j   $	��Top=�6v   $	��331��6�   G� 5&      -   5        $	 txtPass2��5&      $
��Left=�60   $��30��6K   $��	0,280,0,0q�6W   $
  ��6j   $	��Top=�6v   $	��331��6�   5(      5)      �� 5+   
   -   5         ��Name$ btnSave��5+      $
��Save��6"   $
��Left=�61   $��40��6L   $��134,436,0,0q�6X   $	��Top=�6m   $	��120��6�   $��25(�6�   6�   �� 5,   
   -   5        $ 	btnDelete��5,      $��Delete��6$   $
��Left=�65   $��40��6P   $��334,436,0,0q�6\   $	��Top=�6q   $	��120��6�   $��25(�6�   6�   �� 5-   
   -   5        $ 
btnThemMoi��5-      $��Thêm mới��6%   $
��Left=�68   $��40��6S   $��534,436,0,0q�6_   $	��Top=�6t   $	��120��6�   $��25(�6�   6�   �� 5/   
   -   5        $ 	btnSearch��5/      $��Search��6$   $
��Left=�65   $��40��6P   $��
746,97,0,0q�6\   $	��Top=�6p   $	��120��6�   $��25(�6�   6�   �� 50   
   -   5        $ 	txtSearch��50      $
��Left=�6%   $��30��6@   $��
746,62,0,0q�6L   $ NoWrap=�6`   $(��"Nhập tên hoặc mã tại đây��6v   $	��Top=�6�   $	��223��6�   $��Italic$�6�    J� Opacity$	 0.5Q�6�   51      52      