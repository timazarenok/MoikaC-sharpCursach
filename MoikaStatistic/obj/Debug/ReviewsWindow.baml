   M S B A M L   `   `   `  ����I  EMoikaStatistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MoikaStatisticMoikaStatistic  5   	   "    MoikaStatistic.ReviewsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MoikaStatistic     5   	     � Title$)  #Отзывы сотрудников��5   	   $	��450��6$   $	��800��61   .��5	      � .+�5
   
   �� 
�������$��20(�6'   $��Center=�65   $	��Top=�6R   ECВведите уникальный номер сотрудника6�   �� 5   
   -   5         ��Name$ Surname��5      $	��200��6#   $��25��6/   $	��Top=�6;   $��Center=�6S   $��
0,50,100,0q�6p   �� 5   
   -   5         ��Name$ Excel��5      $��Center=�6    $	��Top=�6=   $��25��6U   $	��100��6a   $��
0,50,500,0q�6m   .��6�   Отчет в EXCEL6�   �� 5   
   -   5        $ FindEmploer��5      $��Center=�6&   $	��Top=�6C   $��25��6[   $	��100��6g   $��
250,50,0,0q�6s   .��6�   
Найти6�   �� 5   
   -   5        $ GetAll��5      $��Center=�6!   $	��Top=�6>   $��25��6V   $	��100��6b   $��
500,50,0,0q�6n   .��6�   Показать все6�   �� 5   
   -   5         ��Name$ Reviews��5      $	��600��6#   $	��300��6/   $��
50,120,0,0q�6<   ��5      �� 5      .R�5      � 
������� � RowDefinitions 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $
��Bold"�6=   $��20(�6O   $��11��6]   
�������$��0,0,0,10q�6�   ��6$   �� *	Surname+6�   �� 5      $	��300��6<   $��1��6H   $��1��6U   
���   �$��0,0,0,10q�6x   ��6$   �� *Number+6x   �� 5      $
��Bold"�6;   $��20(�6M   
�������$��0,0,0,10q�6s   ��6$   �� *Score+6s   �� 5      $	��300��6:   $��1��6F   $
��Wrap=�6S   $��0��6g   
���   �$��0,0,0,10q�6�   ��6$   �� *Text+6�   �� 5       $	��300��6:   $��2��6F   $��0��6S   
���   �$��0,0,0,10q�6v   ��6$   �� *Date+6v   �� 5!      $	��300��6:   $��2��6F   $��1��6S   
���   �$��0,0,0,10q�6v   ��6$   �� *Name+6v   5"      5#      5%      �� 5&   
   -   5        $ SortMin��5&      $	��120��6"   $��25��6.   $��400,0,0,220q�6:   .��6e   По убыв.6o   �� 5'   
   -   5        $ SortMax��5'      $	��120��6"   $��25��6.   $��0,0,400,220q�6:   .��6e   По возр.6o   (  "System.Windows.Controls.DatePicker  5(   
   -   5          Name$ FilteredDate��5(      $	��200��6+   $��25��67   $	��Top=�6C   $��Center=�6[   $��0,90,0,0q�6x   6�   �� 5)   
   -	   5        $
 Exit��5)      $	��120��6   $��30��6+   $��18(�67   $��Right=�6E   $��Center=�6a   $��0,350,675,0q�6|   .��6�   
Выход6�   5*      5+      