   M S B A M L   `   `   `  ����  228097-Bulten(    "HMI.DialogRegion.MO.Views.MO_PZ_EF   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   5      -   5        $
��1920��5      $
��1080��6      DialogSurroundBrush#���   6      J� Opacity$  0Q�6S   .��5      � .+�5   
     VisiWin.Controls.Button  
������ $��0q�6-   ��6A   �� *Close+� 5
   
   -   5         �Name$ border��5
       J� RenderTransformOrigin$ 1, 0.5&�6    $��Center=�6?   $��Center=�6\   z�5      �� 5       �� ScaleX$	 0.3Q�6!    �� ScaleY$	 0.3Q�6.   .+�5        VisiWin.Controls.Border  
�������$	  0.7Q�6,    �� CornerRadius$ 5��6:    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 10Q�6!   5      �� 5      
�������$	��500��6+   $��5q�67   $��0q�6B     BackgroundBrush#���  6V   $ 5��6�   ._�5      � $��	10,0,10,0q�6    � RowDefinitions 5      �� 5      $��70 �6(   �� 5      $��12 �6(   �� 5      $��* �6(   �� 5      $��12 �6(   �� 5      $��70 �6(   .+�5         VisiWin.Controls.TextBlock  -   5        	  Name$	 
HeaderText��5   #   $
��Left=�67   $��Center=�6R   
�������$��18(�6�   $
��Bold"�6�   
   LocalizableText$
 @MachineOverview.Text91��6�   $	��400��6�     5      -   5          Name$ CancelButton��5       $��Right=�66   $	��Top=�6R     B_Close#���  6j   $��80��6�   $��40��6�      Text$ X��6�   $��0,0,0,0q�6�   6�   �� 5      $��1��6   $	��Top=�6*    
 FP_Red#���  6B   $��2��6i   $ 2��6t   � 5       -   5        $	 grd��5       $��2��6(   $��	10,0,10,0q�65    5!      �� 5"      $��* �6,   �� 5#      $��* �6,   �� 5$      $��* �6,   �� 5%      $��* �6,   .+�5'        VisiWin.Controls.GroupBox     LocalizableHeaderText$ @MachineOverview.Text87��6&     GB_Group#���  6V   $��1��6y   .��5(      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   $��5,10,5,5q�6_   .+�5)   "   $  VisiWin.Controls.NumericVarOut  -   5          Name$ 
NSTime_Min��5)   3     NVO_Main#���  6H   $	��220��6l   $��45��6x      LocalizableUnitText$ @Units.m��6�   *  $VisiWin.Controls.VariableBaseControl   VariableName$i cCPU1.PLC.Blocks.04 Tray handling.02 PZ.01 Air.DB PZ Air HMI.Actual.Exhaust fan.State.Restart.Minute��6�     5*   "   -   5        $ 
NSTime_Sec��5*   3   #���  6G   $	��220��6j   $��45��6v   $��5,0,0,0q�6�   $ @Units.s��6�      FormatString$ 0��6�   $i cCPU1.PLC.Blocks.04 Tray handling.02 PZ.01 Air.DB PZ Air HMI.Actual.Exhaust fan.State.Restart.Second��6�   5+      5,        5-      -   5          Name$ Purge��5-   &   $y�	Collapsed=�65   $ @MachineOverview.Text88��6L   #���  6|     FP_Yellow_Gradient#���  6�   $��1��6�   .��5.      �� $ 
Horizontal=�6)   $��Center=�6B   $��5,10,5,5q�6_   .+�5/   "     -	   5        $ 	PTime_Min��5/   3   #���  6F   $	��220��6j   $��45��6v   $ @Units.m��6�   $ 0��6�   $g aCPU1.PLC.Blocks.04 Tray handling.02 PZ.01 Air.DB PZ Air HMI.Actual.Exhaust fan.State.Purge.Minute��6�     50   "   -
   5        $ 	PTime_Sec��50   3   #���  6F   $	��220��6j   $��45��6v   $��5,0,0,0q�6�   $ @Units.s��6�   $ 0��6�   $g aCPU1.PLC.Blocks.04 Tray handling.02 PZ.01 Air.DB PZ Air HMI.Actual.Exhaust fan.State.Purge.Second��6�   51      52      !  VisiWin.Controls.TextVarOut  54      -   5          Name$	 PS1��54   (     FP_Gray_Gradient   
BlinkBrush# �  65   
�������  FP_Blue_Gradient#���  6x   $��2q�6�   $��2��6�   $��60��6�   $��60��6�      CornerRadius$ 30��6�   $��Right=�6�   $��Center=�6  $��
0,20,50,10q�6*     LocalizableLabelText$ @MachineOverview.Text89��6>  $ __UNLINKED_BSTR��6m    55      -   5        $	 PS2��55   (   # �  65   
�������#���  6x   $��2q�6�   $��3��6�   $��60��6�   $��60��6�   $ 30��6�   $��Right=�6�   $��Center=�6  $��	0,0,50,10q�6*  $ @MachineOverview.Text90��6=  $ __UNLINKED_BSTR��6l  57      �� 5?      $��3��6   $��Bottom=�6*   #���  6E   $��2��6l   $ 2��6w   � 5A      $��4��6    � ColumnDefinitions 5B      �� 5C      $��* �6/   �� 5D      $��* �6/   .+�5F      	  VisiWin.Controls.Key	  -   5         	 Name$
 V_On��5F   !      LocalizableText$ @Buttons.Text19��6/    
	 B_Gray#��� 	 6Q   $��50��6r   $	��200��6~    	  KeyMode$ KeyMode=�6�    	  VariableName$S MCPU1.PLC.Blocks.04 Tray handling.02 PZ.01 Air.DB PZ Air HMI.PC.Exhaust fan.On��6�      AuthorizationRight$ Exhaust��6�   	  5G      -   5        $ V_Off��5G   !   $ @Buttons.Text17��61   $��1��6S    	
 B_Red#��� 
 6c   $��50��6�   $	��200��6�   $ KeyMode=�6�   $T NCPU1.PLC.Blocks.04 Tray handling.02 PZ.01 Air.DB PZ Air HMI.PC.Exhaust fan.Off��6�   $ Exhaust��6  5H      5I      5J      5K      5L      5M      