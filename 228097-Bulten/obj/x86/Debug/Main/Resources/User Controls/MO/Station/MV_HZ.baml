   M S B A M L   `   `   `  ����  228097-Bulten)    #HMI.Resources.UserControls.MO.MV_HZ   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   5   	   -   5          J� Opacity$  0Q�5   L   .��5      � .+�5   
   �� -   5         ��Name$ A��5       �� Orientation$ 
Horizontal=�6!   .+�5      � -   5         �Name$	 HZ1��5      .+�5      !  VisiWin.Controls.PictureBox     SymbolResourceKey$ MV_HZ��6    $	��165��6:   $	��299��6F   $��3q�6S   $��Right=�6^   $	��Top=�6z    J� Effect 5	      3  -System.Windows.Media.Effects.DropShadowEffect  5
         Color$	 Red��6+      
BlurRadius$ 20Q�67      	Direction$ 90Q�6H   	   Opacity$		 0.5Q�6X   5        VisiWin.Controls.Button  5      -   5        
  Name$

 hzNL��5      $��80��6*   $	��100��66      	B_Blue_ns#���   6B   $y�Hidden=�6f      LocalizableText$ @MachineOverview.Text55��6z   {�.  $��0,-80,150,0q�6�   $	��Top=�6�   $��Right=�6�   �� 5      $	��100��6    �� CornerRadius$ 4��6&   $	��Top=�67   $��Right=�6O   $��
0,-70,45,0q�6k   $��2q�6   
�������  FP_Blue_Gradient#���  6�   ._�5      �� .+�5         VisiWin.Controls.TextBlock     LocalizableText$ @MachineOverview.Text56��6'   $	��Top=�6Q   $��Center=�6i   $��SemiBold"�6�   $��13(�6�   $��20��6�   
�������$��0,4,0,0q�6�   $  VisiWin.Controls.NumericVarOut  5      -   5          Name$
 HZ1F��5   +   $��0,0,3,0q�69     NVO_Main#���  6K   $��30��6n      LocalizableUnitText$ 
@Units.rpm��6z      Value$
 2500Q�6�   *  $VisiWin.Controls.VariableBaseControl   TextAlignment$ Center=�6�   $��Bottom=�6�      FormatString$ 0��6�   5      5      �� 5      $	��100��6   $ 4��6%   $	��Top=�66   $��Right=�6N   $��0,-70,-60,0q�6j   
�������$��2q�6�     FP_Green_Gradient#���  6�   ._�5      �� .+�5        $ @MachineOverview.Text22��6'   $	��Top=�6Q   $��Center=�6i   $��SemiBold"�6�   $��20��6�   $��0,4,0,0q�6�   $��13(�6�   
�������6�     5      -   5        $
 HZ1T��5   +   $��0,0,3,0q�69   #���  6K   $��30��6n   $ @Units.C��6z   $	 500Q�6�   $ Center=�6�   $��Bottom=�6�   $ 0��6�   5      5      5      5        5   
   -   5        $��75,-5,-5,-5q�5   +     	B_Station#���  6A   5      5!      