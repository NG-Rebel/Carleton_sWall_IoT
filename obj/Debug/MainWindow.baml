   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	       Test.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Test     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��850��5	   	   $	��700��6   
�������  � WindowStartupLocation$  CenterScreen=�66    � WindowStyle$
 None=�6[    � WindowState$ Normal=�6n    � 	Resources 5
         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.5��6'   $	 230Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 230Q�63     5      $ 0:0:0.5��6'   $ 70Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5       � ���	#FFDEDEDE.+�5!   
    � -   5          �Name$
 Main��5!   0     � NavigationUIVisibility$ Hidden=�6   $��
0,100,0,45q�6>   � 5"   
   -   5         �Name$ GridMain��5"      $��Right=�6!   $��Bottom=�6=   $	��540��6X   � 5#   
   $	��100��6   $	��Top=�6   ���	#FFA90000 J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%         
BlurRadius$ 25Q�6$      Color$ 	#FFC8C8C8��64      RenderingBias$ Quality=�6F      ShadowDepth$ 2Q�6^   .+�5(      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5)      �� $	��Top=�6   $��5q�65   $��1��6@   $��Center=�6P   .+�5*      �� $��Carleton��6    $��Center=�60   $��Center=�6M   $��Berthold Walbaum Book)�6h   ���	#FF030322$��50(�6�   �� 5+      $��U N I V E R S I T Y��6    $��Center=�6;   $��Center=�6X   $��Uniman ExtraBold)�6s   ���	#FF030322$��20(�6�   5,      5-      5.      � 50   
   -   5        $ GridMenu��50      $��65��6!   $��Bottom=�6,   $
��Left=�6G   $��0,0,0,45q�6c    51        52      $ 30Q�6$   $ Black��64      Opacity$ 10Q�6B   $ Quality=�6O   $ 10Q�6g   .+�54      �� ���	#FF7E3131$��2q�6,    �� CornerRadius$ 4��6@   ._�55      �� ���	#FFA90000.+�56      � $	��100��6    J� RenderTransformOrigin$ 0.5,0.5&�6(   $��5q�6H   ��57      �� 58       �� ImageSource$L FC:\Users\PC\Desktop\Github Projects\Carleton_sWall_IoT\images\Logo.png��6)    j� Stretch$ Uniform=�6~   z�5:      V� 5;      .~�5<   "   �� �� 5=   "   �� 5>   "   T� 5?   "   5@      .+�5B      �� -   5         ��Name$ ButtonOpenMenu��5B   !   $	��100��69   $��50��6F   
���������6Q   Z� ��6g   Z� 6�   � 5C      -   5        $ 	HandClick��5C      $��Right=�62   $��Bottom=�6N   ��6j   Z� .+�5D      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ HandDoubleTap=�66   $��50��6K   $��40��6V   5E      �� 5F      -   5        $ ButtonCloseMenu��5F   !   $y�	Collapsed=�6:   $��60��6Q   $��60��6]   $��5q�6h   $��Right=�6s   $	��Top=�6�   
���������6�   Z� ��6�   Z� .��5G        $ 	ArrowLeft=�66   $��25��6G   $��25��6R   5H      �� 5J      $��80��6    $��Bottom=�6,   5K      �� 5L      -   5         ��Name$ ListViewMenu��5L      
�������$��Disabled=�6O   .@�5M      �� -   5         ��Name$ ItemLibrary��5M   '   $��60��6<   
������.��5O   "   �� $ 
Horizontal=�6-   .+�5P   &     $
 Book=�6>   $��30��6J   $��40��6V   $��4q�6a   6n   �� 5Q   "   $��Library��6,   $��Center=�6;   $��20 10q�6V   5R      5T      �� 5V      -	   5        $ ItemAzrieli��5V   '   $��60��6<   
���� K�.��5X      �� $ 
Horizontal=�6)   .+�5Y   "     $ Pencil=�6:   $��25��6H   $��25��6T   $��10q�6_   �� 5Z   "   $��Azrieli��6,   $��Center=�6;   $��20 10q�6V   5[      5]      �� 5_      -
   5        $ ItemComputer��5_   '   $��60��6=   
�����_�.��5a      �� $ 
Horizontal=�6)   .+�5b   "     $ Computer=�6:   $��25��6J   $��25��6V   $��10q�6a   �� 5c   "   $��IoT Lab��6,   $��Center=�6;   $��20 10q�6W   5d      5f      �� 5g      -   5        $ ItemTree��5g   '   $��60��69   
���"�"�.��5h      �� $ 
Horizontal=�6)   .+�5i   "     $
 Tree=�6:   $��25��6F   $��25��6R   $��10q�6]   �� 5j   "   $��The Quad��6,   $��Center=�6<   $��20 10q�6X   5k      5l      5n      5p      5q      5s      � 5u   
   -   5        $ GridBarTitle��5u      $��1��6%   $��2��62   ���	#FF02020F$��Bottom=�6^    5v        5w      $ 25Q�6$   $ 	#FFC8C8C8��64   $ Quality=�6F   $ 40Q�6^   .+�5y      �� $ 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5z      �� -   5        $ 
ButtonHelp��5z       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6-   $��0,0,0,5q�6t   
���������6�   Z� ��6�   Z� .��5{        $
 Bell=�6.   $��40��6:   $��40��6F   5|      �� 5}      -   5        $ ButtonClose��5}      #��[ 6.   $��0,0,0,5q�6u   
���������6�   Z� ��6�   Z� .��5~        $ 	ExitToApp=�6.   $��40��6?   $��40��6K   5      5�      5�      5�      5�      