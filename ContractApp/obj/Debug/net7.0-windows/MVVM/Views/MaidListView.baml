   M S B A M L   `   `   `  ����F  BContractApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ContractApp.MVVM.ViewsContractApp.MVVM.Views  5      I)clr-namespace:ContractApp.MVVM.ViewModelsContractApp.MVVM.ViewModels  5      )    #ContractApp.MVVM.Views.MaidListView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ContractApp.MVVM.Views     5      @
viewModels)clr-namespace:ContractApp.MVVM.ViewModels     5        � DataContext  5
      3   -ContractApp.MVVM.ViewModels.MaidListViewModel  5   
   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��5      $��24(�5      $��Center=�5      $��Maids��5      $
��Bold"�5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�5       $��2��5!      $��1��5"      $��	0,33,0,27q�5#      .+�5&      �� $��1��6   $��0��5'      $	��550��5(      $��24(�5)      $��5q�5*      $��Center=�5+      ��5,      �� *
SearchMaid+�� 5.      $��1��6   $��1��5/      $��Search��50         ButtonTheme#��[  51      ��52      �� *SearchCommand+54      �� 55   
   $��10q�6   $��2��6#   $��2��60   .��56      �� ��6   �� *
MaidData+��57      �� 58      .R�59      ��  �� Padding$ 10q�6!   $��10q�5:      ���#000���#fff$��1q�5=       �� CornerRadius$ 10��5>      ._�5?      9� $��12(�6'   $
��Bold"�65   ��6G   �� *
Item1.Name+.��5@   "   �� $ 
Horizontal=�6-   .+�5A   &   �� $��10q�6-   #��[  6:   $��Edit Maid Details��5B   %   ��5C   %   �� *Item1.EditMaid+�� 5E   &   $��10q�6-   #��[  69   $��	Edit Fees��5F   )   ��5G   )   �� *Item2.EditFees+5H   #   5I      5J      5K      5M      5N      5O      5P      