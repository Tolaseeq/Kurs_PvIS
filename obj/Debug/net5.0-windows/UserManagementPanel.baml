   M S B A M L   `   `   `  ����G  CKURS_SERGEEV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KURS_SERGEEVKURS_SERGEEV  5   	   &     KURS_SERGEEV.UserManagementPanel   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KURS_SERGEEV     5   	     � Title$  ControlPanel��5   	   
����=H�$	��450��69   $	��425��6F   .��5	      � $y�Visible=�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
table_grid��5
      $��	33,10,0,0q�6'   $��Bahnschrift SemiBold)�6:   $
��Bold"�6\   $��14(�6n   $
��Left=�6|   $	��Top=�6�   $	��260��6�      AutoGenerateColumns$ False��6�   $	��367��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
 ���@�63   �� 5       � ��$ SemiBold"�63   �� 5       � ��$ 0,0,1,2q�68   �� 5       � ��
 �   �64   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$      ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6M   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *id+6M     5      $           User Name��6%   $		 230 6`   
 6B   �� *	user_name+6`     5      $  Role��6%   $	 * 6W   
 64   �� *user_role_name+6W   5      �� 5   
   -   5         ��Name$ change_role��5   '   $��Change Role��6   $
��Left=�6<   $��260,286,0,0q�6W   $	��Top=�6l   $��50��6�   $	��140��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   6�   �� 5   
   -   5        $��	Film List��5      $
��Left=�6%   $��120,371,0,0q�6@   $	��Top=�6U   $��42��6m   $	��109��6y   6�   �� 5   
   -   5         ��Name$ id_panel��5      $y�Visible=�6'   .+�5      � .+�5      �� $��ID��6   $
��Left=�6%   $��
33,279,0,0q�6@   $	��Top=�6T   $��78��6l   $��38��6w   $��14(�6�   $
��Bold"�6�   
�������6�   �� 5      -   5         ��Name$ id_box��5   5   $
��Left=�6   $��
33,322,0,0q�6E   $�� ��6Y    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $��78��6�   $��25��6�   �� 5      $
��Role��6   $
��Left=�6'   $��134,279,0,0q�6B   $	��Top=�6W   $��78��6o   $��38��6z   $��14(�6�   $
��Bold"�6�   
�������6�   �� 5       -   5        $ role_box��5    5   $
��Left=�6   $��134,322,0,0q�6G   $�� ��6\   $
 Wrap=�6d   $	��Top=�6x   $��78��6�   $��25��6�   5!      5"      5#      5$      