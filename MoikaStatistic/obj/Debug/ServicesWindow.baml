   M S B A M L   `   `   `  ����I  EMoikaStatistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MoikaStatisticMoikaStatistic  5   	   #    MoikaStatistic.ServicesWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MoikaStatistic     5   	     � Title$  Услуги��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� 
�������$
��Bold"�6#   $��24(�65   $��Center=�6C   $	��Top=�6`   .��6x   *(Создание новой услуги6�   �� 5   
   $2��,Введите название услуги��6   $
��Left=�63   $��Center=�6N   $��
50,0,0,300q�6i   �� 5   
   -   5         ��Name$
 Name��5      $
��Left=�6    $��
50,0,0,250q�6;   $��Center=�6O   $	��200��6j   $��25��6v   �� 5   
   $*��$Введите цену услуги��6   $
��Left=�6/   $��Center=�6J   $��300,0,0,300q�6e   �� 5   
   -   5        $ Price��5      $
��Left=�6L   $��300,0,0,250q�6g   $��Center=�6|   $	��200��6�   $��25��6�   �� 5   
   -   5         ��Name$	 Add��5      $��25��6   $��Right=�6*   $	��150��6F   $	��Top=�6R   $��
0,70,100,0q�6j   .��6�   Создать услугу6�   �� 5   
   -   5        $ Delete��5      $��25��6!   $��Right=�6-   $	��150��6I   $	��Top=�6U   $��0,100,100,0q�6m   .��6�   Удалить услугу6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Table��5      $	��500��6"   $	��280��6.   $��0,120,200,0q�6;      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� 	 �� Path$
	 Name�  5      $ Цена��6%   $	 250 63    6?   �� $	 Price�5      5      5      