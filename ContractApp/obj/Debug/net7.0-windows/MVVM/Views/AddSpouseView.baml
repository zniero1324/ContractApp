   M S B A M L   `   `   `  ����F  BContractApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ContractApp.MVVM.ViewsContractApp.MVVM.Views  5   	   I)clr-namespace:ContractApp.MVVM.ViewModelsContractApp.MVVM.ViewModels  5   	   *    $ContractApp.MVVM.Views.AddSpouseView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ContractApp.MVVM.Views     5   	   @
viewModels)clr-namespace:ContractApp.MVVM.ViewModels     5   	     � Title$  AddSpouseView��5	   	   $	��450��6   $	��800��6,    � DataContext 5
      4   .ContractApp.MVVM.ViewModels.AddSpouseViewModel  5   
   .��5      �� .��5   
   � -   5         �Name$ MainGrid��5      $��10q�6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   $��0��5      $��2��5      $��24(�5      $��Center=�5      $��
Add Spouse��5      $
��Bold"�5      �� 5       $��Center=�6   $��1��5!      $��10q�5"      .+�5%      �� $��	Fullname:��6   $��15(�6,   �� 5&      $	��500��5(      $
��Left=�5)      ��5&      �� *
SpouseName+5)      �� 5,      $��Profession:��6   $��15(�6.   �� 5-      $	��500��6<   $
��Left=�6H   ��6   �� *SpouseProfession+6H   �� 50      $��CompanyName:��6   $��15(�6/   �� 51      $	��500��69   $
��Left=�6E   ��6   �� *SpouseCompany+6E   �� 54      $��Address:��6   $��15(�6+   �� 55      $	��500��69   $
��Left=�6E   ��6   �� *SpouseAddress+6E   � 57       58      �� 59      $
��auto �6+   �� 5:      $
��auto �6+    5<      �� 5=      $
��auto �6(   �� 5>      $
��auto �6(   �� 5?      $
��auto �6(   �� 5@      $
��auto �6(   �� 5A      $
��auto �6(   �� 5B      $
��auto �6(   �� 5C      $
��auto �6(   �� 5D      $
��auto �6(   �� 5E      $
��auto �6(   �� 5F      $
��auto �6(   �� 5G      $
��auto �6(   .+�5K      �� $��0��6   $��NRIC:��6)   $��15(�69   �� 5L      $��1��6<   $	��240��6I   $��	 0 0 10 0q�6U   $
��Left=�6h   ��6   �� *SpouseCardNo+6h   �� 5O      $��0��6   $��1��6)   $��Passport No.:��69   $��15(�6Q   �� 5P      $��1��6>   $��1��6K   $	��250��6[   $
��Left=�6g   ��6   �� *SpousePassport+6g   �� 5S      $��2��6   $��Date of Birth��6)   $��15(�6A   (  "System.Windows.Controls.DatePicker  5T      $��3��6m   $	��240��6z   $��0 0 10 0q�6�      SelectedDate 6!   �� *SpouseDateOfBirth+ �� StringFormat$ {0:dd.MM.yyyy}��6�   �� 5W      $��2��6   $��1��6)   $��Status:��69   $��15(�6K   �� 5X      $��3��6=   $��1��6J    �� Text 6   �� *SpouseStatus+.@�5Y      �� $��Married��6$   �� 5Z      $��Single��6$   �� 5[      $��Divorced��6$   �� 5\      $��Widowed��6$   5]      �� 5`      $��4��6   $��Office Phone: ��6)   $��15(�6B   �� 5a      $��5��6   $	��240��6K   $��0 0 10 0q�6W   $
��Left=�6i   ��6+   �� *SpouseOfficeNo+6i   �� 5d      $��4��6   $��2��6)   $��HandPhone : ��69   $��15(�6P   �� 5e      $��5��6   $��2��6+   $	��250��6Y   $
��Left=�6e   ��6;   �� *SpouseHandNo+6e   �� 5h      $��6��6   $��Telephone No: ��6)   $��15(�6B   �� 5i      $��7��6   $	��240��6+   $
��Left=�6T   ��67   �� *SpouseTelNo+6T   5j      �� 5l      $	��230��6   $
��0 30q�5m      $��Save Details��5n         ButtonTheme#��[  5p      ��5o      �� *AddSpouseCommand+5p      5r      5s      5t      5u      