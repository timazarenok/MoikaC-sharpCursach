   M S B A M L   `   `   `  ����I  EMoikaStatistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MoikaStatisticMoikaStatistic  5   	       MoikaStatistic.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MoikaStatistic     5   	     � Title$  Главная��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   �� 
�������$��24(�6'   $
��Bold"�65   $��Center=�6G   $	��Top=�6d   75Отправьте отзыв нащей работы6�   �� 5   
   $:��4Выберите фамилию сотрудника��6   $��18(�67   $
��Left=�6E   $��Center=�6`   $��
50,0,0,300q�6{   �� 5   
   -   5         ��Name$ 	Employers��5      $
��Left=�6&   $��
50,0,0,200q�6A   $��Center=�6U   $	��250��6p   $��30��6|   �� 5   
   $#��Выберите оценку��6   $��18(�6+   $
��Left=�69   $��Center=�6T   $��
50,0,0,140q�6o   �� 5   
   -   5        $ Scores��5      $	��250��6#   $��30��6/   $	��Top=�6;   $
��Left=�6S   $��
50,160,0,0q�6n   �� 5   
   $#��Выберите услугу��6   $��18(�6+   $
��Left=�69   $��Center=�6T   $��50,0,0,0q�6o   �� 5   
   -   5        $ Service��5      $	��250��6$   $��30��60   $	��Top=�6<   $
��Left=�6T   $��
50,230,0,0q�6o   �� 5   
   $4��.Опишите оказанную услугу��6   $��18(�64   $
��Left=�6B   $��Center=�6]   $��400,0,0,150q�6x   �� 5   
   $2��,Выберите дату обращения��6   $��18(�63   $
��Left=�6A   $��Center=�6\   $��
50,150,0,0q�6w   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 Date��5      $	��100��6#   $��25��6/   $
��Left=�6;   $��Center=�6V   $��
50,210,0,0q�6q   �� 5   
   -   5         ��Name$
 Text��5       �� TextWrapping$
 Wrap=�6     �� AcceptsReturn . $
��Left=�6I   $��400,150,0,100q�6d   $��Center=�6{   $	��350��6�   $	��150��6�   �� 5   
   -   5         ��Name$	 Add��5      $	��200��6   $��30��6*   $��18(�66   $��Right=�6D   $��Center=�6`   $��0,350,300,0q�6{   .��6�   Отправить6�   �� 5   
   -   5        $
 Exit��5      $	��120��6   $��30��6+   $��18(�67   $��Right=�6E   $��Center=�6a   $��0,350,600,0q�6|   .��6�   
Выход6�   5      5      