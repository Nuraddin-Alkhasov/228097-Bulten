   M S B A M L   `   `   `  ����  228097-Bulten4    .HMI.MainRegion.Recipes.Views.Recipe_Article_BT   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   5   	   $��Center=�60   $��Center=�6K   $
��1200��6h     J� Opacity$  0Q�6u   .��5        VisiWin.Controls.GroupBox  -   5           GB_Group#���   5      
 � Tag$ 50��65      LocalizableHeaderText$ @RecipeSystem.Text22��6S   .��5      � $��0q�6    � RowDefinitions 5	      �� 5
      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5        #���   6   $��0,0,0,0q�6=   $ 50��6N   $ @RecipeSystem.Text12��6X   .��5      �� $��5,10,5,5q�6   .+�5      #  VisiWin.Controls.NumericVarIn    NVI_Main#���  6&   $
��Bold"�6I   $��45��6[   *  $VisiWin.Controls.VariableBaseControl   LocalizableLabelText$ @RecipeSystem.Text41��6g      LocalizableUnitText$ @Units.grad��6�      RawLimitMax$	 180Q�6�      RawLimitMin$ 0Q�6�   	   FormatString$	 0��6�   
   VariableName$S
 MCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Angle��6�      AuthorizationRight$ RecipeA��6H  5      5        5      $��1��6   $��0��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text42��6n   .��5      �� $��5,10,5,5q�6   .+�5        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[0].Angle��6�   $ RecipeA��6O    5      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 60Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[0].Speed��6�   $ RecipeA��6d    5      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $		 0.0��6�   $Z
 TCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[0].Wait��6�   $ RecipeA��6]    VisiWin.Controls.Switch  5        S_Status#���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������#  VisiWin.Controls.ToggleButton   LocalizableLabelText$ @RecipeSystem.Text82��6�      VariableName$^ XCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[0].Rotation��6�      AuthorizationRight$ RecipeA��6  5      5        5       $��2��6   $��0��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text43��6n   .��5!      �� $��5,10,5,5q�6   .+�5"        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[1].Angle��6�   $ RecipeA��6O    5#      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 60Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[1].Speed��6�   $ RecipeA��6d    5$      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $		 0.0��6�   $Z
 TCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[1].Wait��6�   $ RecipeA��6]    5%      #���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������$ @RecipeSystem.Text82��6�   $^ XCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[1].Rotation��6�   $ RecipeA��6  5&      5'        5(      $��1��6   $��2��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text44��6n   .��5)      �� $��5,10,5,5q�6   .+�5*        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[2].Angle��6�   $ RecipeA��6O    5+      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 60Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[2].Speed��6�   $ RecipeA��6d    5,      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $		 0.0��6�   $Z
 TCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[2].Wait��6�   $ RecipeA��6]    5-      #���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������$ @RecipeSystem.Text82��6�   $^ XCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[2].Rotation��6�   $ RecipeA��6  5.      5/        50      $��2��6   $��2��6*   #���   67   $ 50��6Z   $��0q�6c   $ @RecipeSystem.Text45��6n   .��51      �� $��5,10,5,5q�6   .+�52        #���  6&   $
��Bold"�6I   $��45��6[   $ @Units.grad��6g   $ @RecipeSystem.Text46��6�   $	 180Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[3].Angle��6�   $ RecipeA��6O    53      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.grad_sec��6y   $ @RecipeSystem.Text47��6�   $ 60Q�6�   $ 0Q�6�   $	 0��6�   $[
 UCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[3].Speed��6�   $ RecipeA��6d    54      #���  6&   $
��Bold"�6I   $��45��6[   $��0,5,0,0q�6g   $ @Units.s��6x   $ @RecipeSystem.Text32��6�   $ 59Q�6�   $ 0Q�6�   $		 0.0��6�   $Z
 TCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[3].Wait��6�   $ RecipeA��6]    55      #���  6    $
��Bold"�6C   $��45��6U   $��0,5,0,0q�6a   
�������$ @RecipeSystem.Text82��6�   $^ XCPU1.PLC.Blocks.01 Basket feeding.01 LD.00 Main.DB LD HMI.PC.Station.BT.Step[3].Rotation��6�   $ RecipeA��6  56      57      58      59      5;      