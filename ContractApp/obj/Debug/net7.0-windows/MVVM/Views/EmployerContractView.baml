   M S B A M L   `   `   `  ����F  BContractApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ContractApp.MVVM.ViewModelsContractApp.MVVM.ViewModels  5   	   ?$clr-namespace:ContractApp.MVVM.ViewsContractApp.MVVM.Views  5   	   1    +ContractApp.MVVM.Views.EmployerContractView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @
viewModels)clr-namespace:ContractApp.MVVM.ViewModels     5   	   6local$clr-namespace:ContractApp.MVVM.Views     5   	     � Title$  EmployerContractView��5	   	   $	��450��6&   $	��800��63    � DataContext 5
      ;   5ContractApp.MVVM.ViewModels.EmployerContractViewModel  5   
   .��5      �� .��5   
   � -   5         �Name$ MainGrid��5      $��10q�6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   $��0��5      $��2��5      $��24(�5      $��Center=�5      $��Employer Contract��5      $
��Bold"�5       �� 5"      $��Center=�6   $��1��5#      $��10q�5$      .+�5'      �� $��	Fullname:��6   $��15(�6,   �� 5(      -   5         ��Name$ Fullname��5(      $	��500��5)      $
��Left=�5+      ��5(   ,   �� *	EmpName+ �� 
IsReadOnly 5*      �� *IsTextBoxReadOnly+5+      �� 5.      $��Reference No:��6   $��15(�60   �� 5/      $	��500��61   $
��Left=�6=   ��6   �� *RefNo+6=   �� 52      $��Profession:��6   $��15(�6.   �� 53      $	��500��66   $
��Left=�6B   ��6   �� *
Profession+6B   �� 56      $��CompanyName:��6   $��15(�6/   �� 57      $	��500��67   $
��Left=�6C   ��6   �� *CompanyName+6C   �� 5:      $��Address:��6   $��15(�6+   �� 5;      $	��500��63   $
��Left=�6?   ��6   �� *	Address+6?   �� 5>      $��Email Address:��6   $��15(�61   �� 5?      $	��500��61   $
��Left=�6=   ��6   �� *Email+6=   � 5A       5B      �� 5C      $
��auto �6+   �� 5D      $
��auto �6+    5F      �� 5G      $
��auto �6(   �� 5H      $
��auto �6(   �� 5I      $
��auto �6(   �� 5J      $
��auto �6(   �� 5K      $
��auto �6(   �� 5L      $
��auto �6(   �� 5M      $
��auto �6(   �� 5N      $
��auto �6(   �� 5O      $
��auto �6(   �� 5P      $
��auto �6(   �� 5Q      $
��auto �6(   .+�5U      �� $��0��6   $��NRIC:��6)   $��15(�69   �� 5V      $��1��66   $	��240��6C   $��	 0 0 10 0q�6O   $
��Left=�6b   ��6   �� *CardNo+6b   �� 5Y      $��0��6   $��1��6)   $��Passport No.:��69   $��15(�6Q   �� 5Z      $��1��6:   $��1��6G   $	��250��6W   $
��Left=�6c   ��6   �� *
PassportNo+6c   �� 5]      $��2��6   $��Date of Birth��6)   $��15(�6A   (  "System.Windows.Controls.DatePicker  5^      $��3��6g   $	��240��6t   $��0 0 10 0q�6�      SelectedDate 6!   �� *DateOfBirth+ �� StringFormat$ {0:dd.MM.yyyy}��6�   �� 5a      $��2��6   $��1��6)   $��Status:��69   $��15(�6K   �� 5b      $��3��67   $��1��6D   	 �� Text	 6   �� *Status+.@�5c      �� $��Married��6$   �� 5d      $��Single��6$   �� 5e      $��Divorced��6$   �� 5f      $��Widowed��6$   5g      �� 5j      $��4��6   $��Office Phone: ��6)   $��15(�6B   �� 5k      $��5��6   $	��240��6E   $��0 0 10 0q�6Q   $
��Left=�6c   ��6+   �� *
OfficeNo+6c   �� 5n      $��4��6   $��2��6)   $��Mobile Phone: ��69   $��15(�6R   �� 5o      $��5��6   $��2��6B   $	��250��6R   $
��Left=�6^   ��6+   �� *TelNo+6^   �� 5r      $��6��6   $��Home Phone: ��6)   $��15(�6@   �� 5s      $��7��6   $	��240��6C   $
��Left=�6O   ��6+   �� *HandNo+6O   5u      �� 5w      $	��230��6   $
��0 30q�5x      $��Save Details��5y         ButtonTheme#��[  5{      ��5z      �� *SavedEmployerCommand+5{      5}      5~      5      5�      