   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   B >Planner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PlannerPlanner 5   	      Planner.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Planner  5   	     � Title$  
MainWindow��5
   	   $	��600��6   $
��1200��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $��0��6#    �� HeaderStringFormat$ Monday | {0}��6O   $��5q�6q    � UseLayoutRounding .  J� SnapsToDevicePixels . ��60   �� *MondayTitle+.��5      �� $��12(�66   ��6   �� *Monday+ � ContextMenu 5      �� 5      .@�5      m� $��Delete��6#    m� Icon 5      '  !MaterialDesignThemes.Wpf.PackIcon  5   "   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Delete=�6:   5      5      	 �� View	 5!      �� 5"      .P�5#      �� $��Title��6P   
 �� DisplayMemberBinding
 6)   �� *Title+6P   �� 5$      $��Description��6V   
 6)   �� *Description+6V   �� 5%      $
��Time��6O   
 6)   �� *Time+6O   5&      5(      5)      �� 5*   
   $��1��6   $ Tuesday | {0}��6C      MaterialDesignGroupBox#���   6f   $��5q�6�    .  . ��6#   �� *TuesdayTitle+.��5+      �� $��12(�67   ��6   �� *	Tuesday+ 5,      �� 5-      .@�5.      m� $��Delete��6#    5/        50   "   $ Delete=�6:   52      53      	 55      �� 56      .P�57      �� $��Title��6P   
 6)   �� *Title+6P   �� 58      $��Description��6V   
 6)   �� *Description+6V   �� 59      $
��Time��6O   
 6)   �� *Time+6O   5:      5<      5=      �� 5>   
   $��2��6   $ Wednesday | {0}��6E   #���   6j   $��5q�6�    .  . ��6#   �� *WednesdayTitle+.��5?      �� $��12(�69   ��6   �� *	Wednesday+ 5@      �� 5A      .@�5B      m� $��Delete��6#    5C        5D   "   $ Delete=�6:   5F      5G      	 5I      �� 5J      .P�5K      �� $��Title��6P   
 6)   �� *Title+6P   �� 5L      $��Description��6V   
 6)   �� *Description+6V   �� 5M      $
��Time��6O   
 6)   �� *Time+6O   5N      5P      5Q      �� 5R   
   $��0��6   $��1��6#   $ Thursday | {0}��6Q   #���   6u   $��5q�6�    .  . ��60   �� *ThursdayTitle+.��5S      �� $��12(�68   ��6   �� *
Thursday+ 5T      �� 5U      .@�5V      m� $��Delete��6#    5W        5X   "   $ Delete=�6:   5Z      5[      	 5]      �� 5^      .P�5_      �� $��Title��6P   
 6)   �� *Title+6P   �� 5`      $��Description��6V   
 6)   �� *Description+6V   �� 5a      $
��Time��6O   
 6)   �� *Time+6O   5b      5d      5e      �� 5f   
   $��1��6   $��1��6#   $ Friday | {0}��6O   #���   6q   $��5q�6�    .  . ��60   �� *FridayTitle+.��5g      �� $��12(�66   ��6   �� *Friday+ 5h      �� 5i      .@�5j      m� $��Delete��6#    5k        5l   "   $ Delete=�6:   5n      5o      	 5q      �� 5r      .P�5s      �� $��Title��6P   
 6)   �� *Title+6P   �� 5t      $��Description��6V   
 6)   �� *Description+6V   �� 5u      $
��Time��6O   
 6)   �� *Time+6O   5v      5x      5y      �� 5z   
   $��1��6   $��2��6    $��Stretch=�60   $ Saturday | {0}��6o   #���   6�   $��5q�6�    .  . ��6N   �� *SaturdayTitle+.��5{      �� $��12(�68   ��6   �� *
Saturday+ 5|      �� 5}      .@�5~      m� $��Delete��6#    5        5�   "   $ Delete=�6:   5�      5�      	 5�      �� 5�      .P�5�      �� $��Title��6P   
 6)   �� *Title+6P   �� 5�      $��Description��6V   
 6)   �� *Description+6V   �� 5�      $
��Time��6O   
 6)   �� *Time+6O   5�      5�      5�      )  #MaterialDesignThemes.Wpf.DialogHost  5�   
   -   5        $��1��5�   M   $��2��6]   $��Center=�6j   $��Center=�6�      DialogContent 5�      �� 5�      $��16q�6   .+�5�      �� Title:6(   �� 5�      -   5         ��Name$ 	TaskTitle��5�   M   $��0 8 0 0q�6   $��Stretch=�6/   6M   �� 5�      Description:6.   �� 5�      -   5        $ TaskDescription��5�   M   $��0 8 0 0q�6   $��Stretch=�6/   6M   �� 5�      Select a day:6/   �� 5�      -   5         ��Name$ 
DialogDays��5�   G   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Monday��6   .@�5�      �� .��6'   Monday6/   �� 5�      .��6'   	Tuesday60   �� 5�      .��6'   	Wednesday62   �� 5�      .��6'   
Thursday61   �� 5�      .��6'   Friday6/   �� 5�      .��6'   
Saturday61   �� 5�      .��6'   Sunday6/   5�      )  #MaterialDesignThemes.Wpf.TimePicker  5�      -   5          Name$ 
DialogTime��5�   0   6F   �� 5�       �� Orientation$ 
Horizontal=�6!   $��Right=�6:   .+�5�      ��   MaterialDesignFlatButton#��[ 6!    �� 	IsDefault . $��0 8 8 0q�5�   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   )   ��5�      ��5�   "   True��67   .��5�   7   ACCEPT5�      �� 5�      #��[ 6!    �� IsCancel . $��0 8 8 0q�5�   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   )   ��5�      ��5�   "   	False��68   .��5�   7   CANCEL5�      5�      5�      .��5�      �� -   5         ��Name$ 
ShowDialog��5�      $��0��6)   $��2��69      OpenDialogCommand#��Z 6F   .��6�   
Add Item6�   5�      �� 5�   
   $��2��62   $��2��6?   $��Center=�6O   $��Center=�6l   $��32��6�   $	��150��6�   $��50��6�   $	��234��6�   ��6   �� *GoToNextWeek+.��5�        $ 
ArrowRight=�6*   5�      �� 5�   
   $��2��66   $��0��6C   $��Center=�6S   $��Center=�6p   $��32��6�   $	��150��6�   $��50��6�   $	��234��6�   ��6   �� *GoToPreviousWeek+.��5�        $ 	ArrowLeft=�6&   5�      5�      5�      