   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c   
B_Start_UC  �� 
TargetType   VisiWin.Controls.Key �� Property �� Value  FP_Gray_Gradient �� 
TargetType ��Name �� CornerRadius J� Effect-  'System.Windows.Media.Effects.BlurEffect   Radius �� 
StartPoint	 �� EndPoint
 � Color � Offset �� Triggers P� Property P� Value �� 
TargetName  FP_LightGreen_Gradient ]� 
Conditions �� Property �� Value  VisiWin.Controls.Button N� EnterActions ��Name �� 
TargetName �� TargetProperty	 �� To g� Duration g� AutoReverse g� RepeatBehavior N� ExitActions �� BeginStoryboardName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      &vwhttp://inosoft.com/visiwin7   69   %�  &	        �� 5      "    6   .�5   
   ��  � ��$ 16(�6%   �� 5   
    � ��$ Segoe UI)�6'   �� 5   
    � ��$
 Bold"�6'   �� 5   
    � ��
 �����6'   �� 5	   
    � ��
 �   �6(   �� 5
   
    � ��$ 1q�6,   �� 5   
    � ��# �  6'   �� 5   
    � �� 5      �� 5      "   6"   .R�5      � .+�5      �� $ 	BtnShadow��6!   
�������$��-1q�6G   $ 20��6S    5        5   "   $ 10Q�6-   5      �� 5      $ backgr��6!   $ 20��62   #��z��6E   #��z��6q   ��5      �� 5   "   btnColor��$ 0.5,0&�6H   $	 0.5,1&�6[   .��5   &   � $
 	#FF8F8E8E��63   $ 1Q�6E   � 5   &   $
 	#FF616060��63   $ 0Q�6E   5   #   5      �� 5      $��Center=�6+   $��Center=�6H   5       5      P� 5        �@��	IsDefault . . �5!      �� $ backgr��6%   # �  6O    � ��5"      P� 5#       � {� .  . �5$      ��  �@J�Opacity$	 0.5Q�68   5%      P� 5&       � �� . . �5'      �� $ 	BtnShadow��6%    � y�$ Hidden=�6R   �� 5(       � ��$ 2q�6A   �� 5)      $ backgr��6%   # �  6O    � ���� 5*       � ��
 �����6<   �� 5+       � ��
 �   �6;   5,      ]� 5-       5.      �� 5/   "    �@��	IsDefault .  6A   �� 50   "    � �� . 6A   /�52      �� 53   "   $ backgr��6)   # �  6S    � ��55      ]� 56       57      �� 58   "    �@��	IsDefault . 6A   �� 59   "    � �� . 6A   /�5;      �� 5<   "   $ backgr��6)   # �  6S    � ��5>      P� 5?       �@ IsBlinkEnabled .  5@      �� 5A   "   $ flash��62   .��5B   &   �� .��5C   *   �� $ btnColor��69   $A ;(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�6Z   $ 	#FF12C312X�6�   $ 0:0:0.5D�6�    . $ Forever��6�   �� 5D   *   $ btnColor��69   $A ;(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�6Z   $ 	#FF0DAC0DX�6�   $ 0:0:0.5D�6�    . $ Forever��6�   5E   '   5F   #    5H      �� 5I   "   $ flash��62   5K      5M      5O      5P      5S      