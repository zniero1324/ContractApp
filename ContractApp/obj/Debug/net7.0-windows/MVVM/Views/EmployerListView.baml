   M S B A M L   `   `   `  ����F  BContractApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ContractApp.MVVM.ViewsContractApp.MVVM.Views  5      I)clr-namespace:ContractApp.MVVM.ViewModelsContractApp.MVVM.ViewModels  5      -    'ContractApp.MVVM.Views.EmployerListView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ContractApp.MVVM.Views     5      @
viewModels)clr-namespace:ContractApp.MVVM.ViewModels     5        � DataContext  5      7   1ContractApp.MVVM.ViewModels.EmployerListViewModel  5   
   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��5      $��24(�5      $��Center=�5      $��	Employers��5      $
��Bold"�5       �� 5#   
    �� Orientation$ 
Horizontal=�6   $��Center=�5$      $��2��5%      $��1��5&      $��	0,33,0,27q�5'      .+�5)      �� $��1��6   $��0��5*      $	��550��5,      $��5q�5-      $��24(�5.      $��Center=�5/      ��5+      �� *SearchPattern+5/      �� 53      $��1��6   $��1��54      $��Search��55         ButtonTheme#��[  56      ��57      �� *	SearchEmp+59      �� 5:   
   $��2��6   $��1��5;      $��Add Employer��5<      #��[  5>      ��5=      �� *AddEmployer+5>      �� 5?   
   $��10q�6   $��4��6#   $��2��60   .��5@      �� ��6   �� *EmployerListViewModels+��5A      �� 5B      .R�5C      ��  �� Padding$ 10q�6!   $��10q�5D   !   ���#000���#fff$��1q�5G   !    �� CornerRadius$ 10��5H   !   ._�5I      9� $��12(�6'   $
��Bold"�65   ��6G   �� *Item1.EmpName+.��5J   "   �� $��10q�6-   .+�5K   &   �  5L   *   �� 5M   .   �� 5N   .    5P   *   �� 5Q   .   �� 5R   .   �� 5S   .   $
��auto �6<   .+�5U   *   �� $��0��60   $��Date of Birth:��6@   �� 5V   *   $
��Left=�64   $��0��6O   $��1��6\   ��6l   �� *Item1.DateOfBirth+�� 5W   *   $��1��60   $��0��6=   $��NRIC No:��6M   �� 5X   *   $
��Left=�64   $��1��6O   $��1��6\   ��6l   �� *Item1.CardNo+5Y   '   �� 5Z   &   $��10q�60   $��Employer's Spouse: ��6<   �� 5[   &   ��63   �� *Item2+��5\   *   �� 5]   .   .R�5^   2   �� $��10q�69   
���   �$��1q�6Y   $ 5q�6m   ._�5_   6   9�  9�Name$ 
myExpander��6?   ��6S   �� *	EmpName+.��5`   :   �� .+�5a   >   �� $��Edit Spouse��6E   ��6[   �� *
EditSpouse+�� 5b   >   $��Delete Spouse��6E   ��6]   �� *DeleteSpouse+5c   ;   5d   7   5e   3   5f   /   5h   '   �� 5i   &   $��10q�60   $��Family Members: ��6<   �� 5j   &   ��63   �� *Item3+��5k   *   �� 5l   .   .R�5m   2   �� $��10q�6:   
���   �$��1q�6Z   $ 5q�6n   ._�5n   6   9� ��6?   �� *Name+.��5o   :   �� .+�5p   >   �� $��10q�6H   $��Family Member's: ��6T   �� 5q   >   $��Edit Family Member��6E   ��6b   �� *
EditFamily+�� 5r   >   $��Delete Family��6E   ��6]   �� *DeleteFamily+5s   ;   5t   7   5u   3   5v   /   5x   '   �� 5y   &   #��[  6-   $	��0 5q�6R   $��	Add Menus��6_   ��6s   �� *Item1.AddAssoc+�� 5z   &   #��[  6-   $	��0 5q�6R   $��Edit Employer��6_   ��6w   �� *Item1.EditEmployer+�� 5{   &   #��[  6-   $	��0 5q�6R   $��Delete Employer��6_   ��6y   �� *Item1.DeleteAssoc+5|   #   5}      5~      5      5�      5�      5�      5�      