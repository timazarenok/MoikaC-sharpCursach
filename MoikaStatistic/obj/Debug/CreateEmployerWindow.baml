   M S B A M L   `   `   `  ����I  EMoikaStatistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MoikaStatisticMoikaStatistic  5   	   )    #MoikaStatistic.CreateEmployerWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MoikaStatistic     5   	     � Title$  CreateEmployerWindow��5   	   $	��350��6&   $	��800��63   .��5	      � .+�5
   
   �� 
�������$
��Bold"�6#   $��24(�65   $��Center=�6C   $	��Top=�6`   .��6x   42Создание нового сотрудника6�   �� 5   
   $8��2Введите фамилию сотрудника��6   $
��Left=�66   $��Center=�6Q   $��
50,0,0,150q�6l   �� 5   
   -   5         ��Name$ Surname��5      $
��Left=�6#   $��
50,0,0,100q�6>   $��Center=�6R   $	��200��6m   $��25��6y   �� 5   
   $)��#Выберите должность��6   $
��Left=�6.   $��Center=�6I   $��50,0,0,0q�6d   �� 5   
   -   5         ��Name$ Professions��5      $	��200��6(   $��25��64   $	��Top=�6@   $
��Left=�6X   $��
50,170,0,0q�6s   �� 5   
   $E��?Введите номер телефона сотрудника��6   $
��Left=�6=   $��Center=�6X   $��400,0,0,150q�6s   �� 5   
   -   5        $ 	Telephone��5      $
��Left=�6P   $��400,0,0,100q�6k   $��Center=�6�   $	��200��6�   $��25��6�   �� 5   
   $I��CВведите уникальный номер сотрудника��6   $
��Left=�6?   $��Center=�6Z   $��400,140,0,150q�6u   �� 5   
   -   5        $ UniquNumber��5      $
��Left=�6R   $��400,140,0,100q�6m   $��Center=�6�   $	��200��6�   $��25��6�   �� 5   
   -   5         ��Name$	 Add��5      $	��200��6   $��25��6*   $��Right=�66   $��Center=�6R   $��0,150,190,0q�6m   .��6�   %#Создать сотрудника6�   5      5      