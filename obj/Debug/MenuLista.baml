   M S B A M L   `   `   `  ����G  CEjercicioWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EjercicioWPFEjercicioWPF  5          EjercicioWPF.MenuLista   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:EjercicioWPF     5        N� Title$  	MenuLista��5      $	��500��6   $	��800��6&    N� 
Background
 ���� .��5      ��  �� CornerRadius$ 10��6   
�������._�5   
   � 
������ .+�5      � -   5        $��Header��5      $��40��6!   $	��Top=�6-   
������ .+�5      �� $ 	10,10,0,0��6   
����ح�5      5      �� 5   
   $��45q�6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   $	��Top=�6V   .+�5      �� $��14(�6   $��3q�6"   $��Center=�6-   $��50��6H   .��6T   Nombre6\   �� 5      -   5         ��Name$ 	txtNombre��5      $��14(�6-    �� TextWrapping$
 Wrap=�6;   $��3q�6O   $��Center=�6Z   $	��170��6u   $��40��6�   5       �� 5"   
   $��45q�6   $ 
Horizontal=�6!   $��Center=�6:   $	��Top=�6W   .+�5#      �� $��14(�6   $��3q�6&   $��Center=�61   $��50��6L   .��6X   Edad6^   �� 5$      -   5        $ txtEdad��5$      $��14(�6+   $
 Wrap=�69   $��3q�6M   $��Center=�6X   $	��150��6s   $��40��6   5%      �� 5'   
   $��45q�6   $ 
Horizontal=�6!   $��Right=�6:   $	��Top=�6V   .+�5(      �� $��14(�6   $��3q�6&   $��Center=�61   $��50��6L   .��6X   Email6_   �� 5)      -   5        $ txtEmail��5)      $��14(�6,   $
 Wrap=�6:   $��3q�6N   $��Center=�6Y   $	��170��6t   $��40��6�   5*      �� 5,   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   .+�5-      �� -   5         ��Name$ 
btnAgregar��5-      $��14(�6-   
����ح�$��30q�6R   $��40��6^   $��90��6j   $	��Top=�6u   .��6�   	Agregar6�   �� 5.      -   5        $ btnEliminar��5.      $��14(�6.   
����ح�$��30q�6S   $��40��6_   $��90��6k   $��Center=�6v   .��6�   
Eliminar6�   �� 5/      -   5        $ 	btnVaciar��5/      $��14(�6,   
����ح�$��30q�6Q   $��40��6]   $��95��6i   $��Bottom=�6t   .��6�   Vaciar campos6�   50      &   System.Windows.Controls.DataGrid  52      -   5        $��DG��52   8   $��14(�6   
�������   
IsReadOnly . $��Center=�6T   $��Center=�6o   ��6�   �� 5F      5G      5H      5I      