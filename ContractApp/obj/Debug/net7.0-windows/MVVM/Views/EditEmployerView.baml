   M S B A M L   `   `   `  ����F  BContractApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ContractApp.MVVM.ViewsContractApp.MVVM.Views  5   	   I)clr-namespace:ContractApp.MVVM.ViewModelsContractApp.MVVM.ViewModels  5   	   -    'ContractApp.MVVM.Views.EditEmployerView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ContractApp.MVVM.Views     5   	   @
viewModels)clr-namespace:ContractApp.MVVM.ViewModels     5   	     � Title$  EditEmployerView��5	   	   $	��450��6"   $	��800��6/    � DataContext 5
      7   1ContractApp.MVVM.ViewModels.EditEmployerViewModel  5   
   .��5      �� .��5   
   � -   5         �Name$ MainGrid��5      $��10q�6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   $��0��5      $��2��5      $��24(�5      $��Center=�5      $��Employer Contract��5      $
��Bold"�5      �� 5       $��Center=�6   $��1��5!      $��10q�5"      .+�5%      �� $��	Fullname:��6   $��15(�6,   �� 5&      -   5         ��Name$ Fullname��5&      $	��500��5'      $
��Left=�5(      ��5&   ,   �� *EmpData.EmpName+5(      �� 5+      $��Reference No:��6   $��15(�60   �� 5,      $	��500��69   $
��Left=�6E   ��6   �� *EmpData.RefNo+6E   �� 5/      $��Profession:��6   $��15(�6.   �� 50      $	��500��6>   $
��Left=�6J   ��6   �� *EmpData.Profession+6J   �� 53      $��CompanyName:��6   $��15(�6/   �� 54      $	��500��6?   $
��Left=�6K   ��6   �� *EmpData.CompanyName+6K   �� 57      $��Address:��6   $��15(�6+   �� 58      $	��500��6;   $
��Left=�6G   ��6   �� *EmpData.Address+6G   �� 5;      $��Email Address:��6   $��15(�61   �� 5<      $	��500��69   $
��Left=�6E   ��6   �� *EmpData.Email+6E   � 5>       5?      �� 5@      $
��auto �6+   �� 5A      $
��auto �6+    5C      �� 5D      $
��auto �6(   �� 5E      $
��auto �6(   �� 5F      $
��auto �6(   �� 5G      $
��auto �6(   �� 5H      $
��auto �6(   �� 5I      $
��auto �6(   �� 5J      $
��auto �6(   �� 5K      $
��auto �6(   �� 5L      $
��auto �6(   �� 5M      $
��auto �6(   �� 5N      $
��auto �6(   .+�5R      �� $��0��6   $��NRIC:��6)   $��15(�69   �� 5S      $��1��6>   $	��240��6K   $��	 0 0 10 0q�6W   $
��Left=�6j   ��6   �� *EmpData.CardNo+6j   �� 5V      $��0��6   $��1��6)   $��Passport No.:��69   $��15(�6Q   �� 5W      $��1��6B   $��1��6O   $	��250��6_   $
��Left=�6k   ��6   �� *EmpData.PassportNo+6k   �� 5Z      $��2��6   $��Date of Birth��6)   $��15(�6A   (  "System.Windows.Controls.DatePicker  5[      $��3��6o   $	��240��6|   $��0 0 10 0q�6�      SelectedDate 6!   �� *EmpData.DateOfBirth+ �� StringFormat$ {0:dd.MM.yyyy}��6�   �� 5^      $��2��6   $��1��6)   $��Status:��69   $��15(�6K   �� 5_      $��3��6?   $��1��6L    �� Text 6   �� *EmpData.Status+.@�5`      �� $��Married��6$   �� 5a      $��Single��6$   �� 5b      $��Divorced��6$   �� 5c      $��Widowed��6$   5d      �� 5g      $��4��6   $��Office Phone: ��6)   $��15(�6B   �� 5h      $��5��6   $	��240��6M   $��0 0 10 0q�6Y   $
��Left=�6k   ��6+   �� *EmpData.OfficeNo+6k   �� 5k      $��4��6   $��2��6)   $��HandPhone No.: ��69   $��15(�6S   �� 5l      $��5��6   $��2��6K   $	��250��6[   $
��Left=�6g   ��6+   �� *EmpData.HandNo+6g   �� 5o      $��6��6   $��Telphone No.: ��6)   $��15(�6B   �� 5p      $��7��6   $	��240��6J   $
��Left=�6V   ��6+   �� *EmpData.TelNo+6V   5r      �� 5t      $	��230��6   $
��0 30q�5u      $��Save Details��5v         ButtonTheme#��[  5x      ��5w      �� *
UpdateData+5x      5z      5{      5|      5}      