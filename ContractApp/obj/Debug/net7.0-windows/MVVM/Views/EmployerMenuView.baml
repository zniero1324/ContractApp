   M S B A M L   `   `   `  ����F  BContractApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ContractApp.MVVM.ViewsContractApp.MVVM.Views  5   	   I)clr-namespace:ContractApp.MVVM.ViewModelsContractApp.MVVM.ViewModels  5   	   -    'ContractApp.MVVM.Views.EmployerMenuView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ContractApp.MVVM.Views     5   	   @
viewModels)clr-namespace:ContractApp.MVVM.ViewModels     5   	     � Title$  EmployerMenuView��5	   	   $	��350��6"   $	��350��6/    � DataContext 5      7   1ContractApp.MVVM.ViewModels.EmployerMenuViewModel  5   
   .��5      �� $��10q�6   .+�5   
   �� $��Center=�5      $��24(�5      $
��Bold"�5      ��5      �� *EmployerData.EmpName+5      �� 5   
   $��Employer's Name��6   $��Center=�5      $��Italic$�5      
�������$��18(�5      �� 5   
   $��30q�6   $��Add Family Member��5         ButtonTheme#��[  5      ��5      �� *OpenAddFamilyWindow+�� 5   
   $
��30 0q�6   $��
Add Spouse��5      #��[  5      ��5      �� *OpenAddSpouseWindow+�� 5    
   $��30q�6   $��Add Maid��5!      #��[  5#      ��5"      �� *OpenAddMaidWindow+5#      5$      5%      