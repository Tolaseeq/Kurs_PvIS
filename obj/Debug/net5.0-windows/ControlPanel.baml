   M S B A M L   `   `   `  ����G  CKURS_SERGEEV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KURS_SERGEEVKURS_SERGEEV  5   	       KURS_SERGEEV.ControlPanel   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KURS_SERGEEV     5   	     � Title$  ControlPanel��5   	   
����=H�$	��450��69   $	��809��6F   .��5	      � $y�Visible=�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $
��399* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
table_grid��5      $��0,10,0,0q�6'   $��Bahnschrift SemiBold)�69   $
��Bold"�6[   $��14(�6m   $��Center=�6{   $	��Top=�6�   $	��260��6�      AutoGenerateColumns$ False��6�   $��1��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
 ���@�63   �� 5       � ��$ SemiBold"�63   �� 5       � ��$ 0,0,1,2q�68   �� 5       � ��
 �   �64   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	      ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 50 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ��  �� Path$ id�6T     5      $	           Film Name��6%   $	
 150 6b    6B   �� $
 name�6b     5      $	 
     Genre��6%   $
 80 6Z    69   �� $ genre�6Z     5      $9	 3                                        Description��6%   $	
 425 6�    6b   �� $ description�6�     5      $	     Critic Rate��6%   $
 * 6e    6>   �� $ critic_rate�6e   5      �� 5   
   -   5         ��Name$ 
new_record��5   &   $��
New Record��6   $
��Left=�6:   $��173,371,0,0q�6U   $	��Top=�6j   $��40��6�   $	��100��6�   $��1��6�   �� 5    
   -   5        $ change_record��5    )   $��Change Record��6   $
��Left=�6@   $��
28,371,0,0q�6[   $	��Top=�6o   $��40��6�   $	��100��6�    J� RenderTransformOrigin$ 0.497,0.544&�6�   $��1��6�   �� 5!   
   -   5        $ delete_record��5!   )   $��Delete Record��6   $
��Left=�6@   $��328,371,0,0q�6[   $	��Top=�6p   $��40��6�   $	��100��6�   $��1��6�   �� 5"   
   -   5        $��	User List��5"      $
��Left=�6%   $��668,371,0,0q�6@   $	��Top=�6U   $��42��6m   $	��109��6y   $��1��6�   �� 5#   
   -   5         ��Name$ change_rec_panel��5#      $y�	Collapsed=�6/   $��2��6F   .+�5$      � .+�5%      �� $
��Name��6   $
��Left=�6'   $��
91,289,0,0q�6B   $	��Top=�6V   $	��123��6n   $��38��6z   $��14(�6�   $
��Bold"�6�   
�������6�   �� 5&      $��Genre��6   $
��Left=�6(   $��218,289,0,0q�6C   $	��Top=�6X   $��77��6p   $��38��6{   $��14(�6�   $
��Bold"�6�   
�������6�   �� 5'      $��Description��6   $
��Left=�6.   $��300,289,0,0q�6I   $	��Top=�6^   $	��379��6v   $��38��6�   $��14(�6�   $
��Bold"�6�   
�������6�   �� 5(      $��Critic Rate��6   $
��Left=�6.   $��684,289,0,0q�6I   $	��Top=�6^   $��96��6v   $��38��6�   $��14(�6�   $
��Bold"�6�   
�������6�   �� 5)      -   5         ��Name$ name_in��5)   5   $
��Left=�6   $��
91,331,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��123��6�   $��25��6�   �� 5*      -   5        $ genre_in��5*   5   $
��Left=�6   $��218,332,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $��77��6�   $��25��6�   �� 5+      -	   5        $ desc_in��5+   5   $
��Left=�6   $��300,332,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��379��6�   $��25��6�   �� 5,      -
   5        $ rate_in��5,   5   $
��Left=�6   $��684,331,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $��96��6�   $��25��6�   5-      5.      �� 5/   
   -   5        $ id_panel��5/      $y�	Collapsed=�6'   $��2��6>   .+�50      � .+�51      �� $��ID��6   $
��Left=�6%   $��	8,289,0,0q�6@   $	��Top=�6S   $��78��6k   $��38��6v   $��14(�6�   $
��Bold"�6�   
�������6�   �� 52      -   5        $ id_in��52   5   $
��Left=�6   $��	8,332,0,0q�6D   $�� ��6W   $
 Wrap=�6_   $	��Top=�6s   $��78��6�   $��25��6�   53      54      55      56      