   M S B A M L   `   `   `  ����  228097-Bulten*    $HMI.Resources.UserControls.MO.CZTray   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   5   	   $��Center=�60   $��Center=�6K   .��5      � .+�5   
   � -   5          �Name$  A��5       J� Opacity$ 0Q�6   .+�5      !  VisiWin.Controls.PictureBox  -   5          Name$
 tray��5         SymbolResourceKey$ CZTray��6*   $	��135��6F   $	��246��6R   $��3,3,3,43q�6_    J� Effect 5	      3  -System.Windows.Media.Effects.DropShadowEffect  5
         Color$ Black��6'      
BlurRadius$ 15Q�65      	Direction$	 270Q�6F      Opacity$ 1Q�6W   5      � 5      -   5        $  
ismaterial��5      $ 0Q�6'   .+�5      $  VisiWin.Controls.NumericVarOut  -   5        	  Name$		 sCL��5   #   *  $VisiWin.Controls.VariableBaseControl
   TextAlignment$
 Center=�60      CornerRadius$ 0��6H   
���   �
�������$	��120��6�   $��84��6�   $��	10,27,0,0q�6�   $
��Left=�6�   $	��Top=�6�     5      -   5        $		 aCL��5   #   $
 Center=�60   $ 0��6H   
���   �
�������$	��120��6�   $��84��6�   $��	10,0,0,73q�6�   $
��Left=�6�   $��Bottom=�6�   5      �� 5      $��Bottom=�6   $��Center=�64   $��0,0,0,45q�6Q    �� Orientation$ 
Horizontal=�6c   .+�5      �� -   5         ��Name$ 	discharge��5      $y�	Collapsed=�6,      FP_Yellow_Gradient#���   6C   $��0,0,1,0q�6u   $��1q�6�   
���   � �� CornerRadius$ 3��6�   $��20��6�   $��20��6�   ._�5         VisiWin.Controls.TextBlock  $��Center=�6$   $��Center=�6?   $��13(�6]   $
��Bold"�6k    
 FP_Red#���  6}      LocalizableText$ @Status.Text33��6�   5      �� 5      -   5        $ watch��5      $y�	Collapsed=�6(   #���   6?   $��0,0,1,0q�6q   $��1q�6�   
���   �$ 3��6�   $��20��6�   $��20��6�   ._�5        $��Center=�6$   $��Center=�6?   $��13(�6]   $
��Bold"�6k   #���  6}   $ @Status.Text34��6�   5      5      5        5   
   -   5          Name$ Vplace��5       �� TextAlignment$ Center=�6'   $��SemiBold"�6>   $��16(�6T   
�������$��Center=�6u   $��Bottom=�6�     VisiWin.Controls.Button  5   
   -	   5          
B_Material#���  5   )   $��0,0,0,40q�6N   $	��139��6`   $	��250��6l   5      5       