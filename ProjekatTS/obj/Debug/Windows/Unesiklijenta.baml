   M S B A M L   `   `   `  ����E  AProjekatTS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjekatTS.WindowsProjekatTS.Windows  5   	   &     ProjekatTS.Windows.Unesiklijenta   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjekatTS.Windows     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$   ��5   	   $	��420��6   $	��700��6    � WindowStartupLocation$ CenterScreen=�5	       � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � -   5        .+�5   
   �� ���	#FFAEAEAE J� OpacityMask �	#FFBCBCBC$��1q�6A   �� 5   
   $��40��6   $	��Top=�6"   .+�5      �� $��40��6   $	��Top=�6%   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   	 �� RelativeTransform	 5      V� 5      .~�5   "   �� 
 �� CenterY$	
 0.5Q�61    �� CenterX$	 0.5Q�6?   �� 5   "    �� CenterY$	 0.5Q�60    �� CenterX$	 0.5Q�6>   �� 5   "    �� Angle$ 60Q�62    �� CenterY$	 0.5Q�6=    �� CenterX$	 0.5Q�6K   T� 5    "   5!      .��5#      �  � Color$ 	#FF3A3E69��6'    � Offset$ 0.559Q�69   � 5$      $ Black��6'   5%      5(      �� 5)      $��/Help/logo.png��6   $��70��6,   $
��Left=�67   $��	7,-54,0,0q�6R   $��74��6e   5,      �� 5-   
   $	��300��6   .+�5/      ��  �� Orientation$ 
Horizontal=�6   $��
60,50,60,0q�62   .+�50      �� $��Ime klijenta:��6   $��50,0,0,0q�61   �� 51      -   5         ��Name$ fullName��51      $��10,0,0,0q�6-   $	��390��6?    �� 
CaretBrush �	#FFBABABA���	#FC282828���	#89FFFFFF6y   52      �� 53      $ 
Horizontal=�6   $��
60,20,60,0q�62   .+�54      �� $
��PIB:��6   $��50,0,0,0q�6(   �� 55      -   5        $	 pib��55      $��	58,-5,0,0q�6(   $	��390��6;    �	#FFBABABA���	#FC282828���	#89FFFFFF6u   56      �� 57      $ 
Horizontal=�6   $��
60,20,60,0q�62   .+�58      �� $��Adresa:��6   $��50,0,0,0q�6+   �� 59      -   5        $ adresa��59      $��
37,-10,0,0q�6*   $	��390��6>    �	#FFBABABA���	#FC282828���	#89FFFFFF6�   5:      �� 5;      $ 
Horizontal=�6   $��
60,20,60,0q�62   .+�5<      �� $��Kontakt:��6   $��50,0,0,0q�6,   �� 5=      -   5        $ kontakt��5=      $��
37,-10,0,0q�6+   $	��390��6?    �	#FFBABABA���	#FC282828���	#89FFFFFF6�   5>      5B      �� 5D   
   $ 
Horizontal=�6   $	��700��6.   $	��100��6:   $��	0,240,0,0q�6G   .+�5E      �� -   5        $��Sačuvaj��5E      $��	180,0,0,0q�6(   $��50��6;   $	��130��6G   ���	#FF97A0AD��6S   Z� 6�   �� 5F      -   5         �� IsCancel . $��Otkaži��5F   :   $��80,0,0,0q�6K   $��50��6]   $	��130��6i   ���	#FF97A0AD��6u   Z� 6�   5H      5I      5J      