   M S B A M L   `   `   `  ����F  BContractApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ContractApp.MVVM.ViewsContractApp.MVVM.Views  5   	   I)clr-namespace:ContractApp.MVVM.ViewModelsContractApp.MVVM.ViewModels  5   	   +    %ContractApp.MVVM.Views.EditSpouseView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ContractApp.MVVM.Views     5   	   @
viewModels)clr-namespace:ContractApp.MVVM.ViewModels     5   	     � Title$  EditSpouseView��5	   	   $	��450��6    $	��800��6-    � DataContext 5
      5   /ContractApp.MVVM.ViewModels.EditSpouseViewModel  5   
   .��5      �� .��5   
   � -   5         �Name$ MainGrid��5      $��10q�6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   $��0��5      $��2��5      $��24(�5      $��Center=�5      $��Edit Spouse Details��5      $
��Bold"�5      �� 5       $��Center=�6   $��1��5!      $��10q�5"      .+�5%      �� $��	Fullname:��6   $��15(�6,   �� 5&      $	��500��5'      $
��Left=�5(      ��5&      �� *SpouseData.EmpName+5(      �� 5+      $��Profession:��6   $��15(�6.   �� 5,      $	��500��6A   $
��Left=�6M   ��6   �� *SpouseData.Profession+6M   �� 5/      $��CompanyName:��6   $��15(�6/   �� 50      $	��500��6B   $
��Left=�6N   ��6   �� *SpouseData.CompanyName+6N   �� 53      $��Address:��6   $��15(�6+   �� 54      $	��500��6>   $
��Left=�6J   ��6   �� *SpouseData.Address+6J   � 56       57      �� 58      $
��auto �6+   �� 59      $
��auto �6+    5;      �� 5<      $
��auto �6(   �� 5=      $
��auto �6(   �� 5>      $
��auto �6(   �� 5?      $
��auto �6(   �� 5@      $
��auto �6(   �� 5A      $
��auto �6(   �� 5B      $
��auto �6(   �� 5C      $
��auto �6(   �� 5D      $
��auto �6(   �� 5E      $
��auto �6(   �� 5F      $
��auto �6(   .+�5J      �� $��0��6   $��NRIC:��6)   $��15(�69   �� 5K      $��1��6A   $	��240��6N   $��	 0 0 10 0q�6Z   $
��Left=�6m   ��6   �� *SpouseData.CardNo+6m   �� 5N      $��0��6   $��1��6)   $��Passport No.:��69   $��15(�6Q   �� 5O      $��1��6E   $��1��6R   $	��250��6b   $
��Left=�6n   ��6   �� *SpouseData.PassportNo+6n   �� 5R      $��2��6   $��Date of Birth��6)   $��15(�6A   (  "System.Windows.Controls.DatePicker  5S      $��3��6r   $	��240��6   $��0 0 10 0q�6�      SelectedDate 6!   �� *SpouseData.DateOfBirth+ �� StringFormat$ {0:dd.MM.yyyy}��6�   �� 5V      $��2��6   $��1��6)   $��Status:��69   $��15(�6K   �� 5W      $��3��6B   $��1��6O    �� Text 6   �� *SpouseData.Status+.@�5X      �� $��Married��6$   �� 5Y      $��Single��6$   �� 5Z      $��Divorced��6$   �� 5[      $��Widowed��6$   5\      �� 5_      $��4��6   $��Office Phone: ��6)   $��15(�6B   �� 5`      $��5��6   $	��240��6P   $��0 0 10 0q�6\   $
��Left=�6n   ��6+   �� *SpouseData.OfficeNo+6n   �� 5c      $��4��6   $��2��6)   $��HandPhone : ��69   $��15(�6P   �� 5d      $��5��6   $��2��6+   $	��250��6^   $
��Left=�6j   ��6;   �� *SpouseData.HandNo+6j   �� 5g      $��6��6   $��Telephone No: ��6)   $��15(�6B   �� 5h      $��7��6   $	��240��6+   $
��Left=�6Y   ��67   �� *SpouseData.TelNo+6Y   5i      �� 5k      $	��230��6   $
��0 30q�5l      $��Save Details��5m         ButtonTheme#��[  5o      ��5n      �� *AddSpouseCommand+5o      5q      5r      5s      5t      