   M S B A M L   `   `   `  ����C  ?HelloApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HelloAppHelloApp  5   	   3clr-namespace:HelloApp.ClassesHelloApp.Classes  5   	       HelloApp.WindowCommand   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:HelloApp     5   	   -ccclr-namespace:HelloApp.Classes     5   	     � Title$  WindowCommand��5	   	   $	��650��6   $
��1000��6,    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cc:WindowCommands.Exit��5      6:   .��5      � .+�5   
   ]� .+�5      o� $	��Top=�5      .@�5      m� $
��File��6   .@�5      m� $��Close��5      5      m� 5      $
��Edit��6   .@�5      m� $
��Copy��5       m� Command$
 Copy��5       m� CommandTarget 5      ��  �� ElementName$ 	myTextBox��5      m� 5      $��Paste��5      $ Paste��5       5      �� $ 	myTextBox��5      5      5      �� 5       $��70��5!      $	��Top=�5"      ��5#      !� 5$       j� Viewbox$ 0.4,0,0.7,1�5&       !� Visual 5%      �� $
 but1��5&      5(      �� 5)      -   5         ��Name$ 
ButtonExit��5*      $��Bottom=�5+      $��30��5,      $��
Выход��5-      $��cc:WindowCommands.Exit��5.      �� 5/      $��Bottom=�50      $	��100��51      ��52      �� 53      $
��Roll��54      $��20(�55      $��Black"�56      
����  �57      ��5:      �� 5;      	 �� ImageSource$	 /Images/right-arrow.png��5<      
 j� Stretch$
 Uniform=�5=       j� Viewport$ 0,0,0.5,0.5�5>       j� TileMode$ FlipXY=�5?      5A      �� 5B      -   5        $
 but1��5C      $��Bottom=�5D      $	��100��5E      ��5F      �� 5G      $
��Roll��5H      $��20(�5I      $��Black"�5J      
����  �$��RightToLeft=�5L      $	��200��5M      ��5O      �� 5P      $	 /Images/рулон.png��5Q      $
 Uniform=�5R      $ 0,0.44,1,0.17�5S      5U      �� 5V      -   5         ��Name$ TextBoxLeft��5W      $��25(�5X      $��	ExtraBold"�5Y      $��AbCdiFgKlMnOp��5Z      $
��Left=�5[      $	��300��5\      .��6   ��5]      �� 5^       �� 
StartPoint$ 0.5,1&�5_       �� EndPoint$ 0.5,0&�5`      .��5a      �  � Color$
 Aqua��6'    � Offset$ 1Q�64   � 5b      $ Bisque��6'   $ 0Q�66   5c      .��5d   &   ��5e      �� 5f      .��5g      � $
 Blue��6'   $ 1Q�64   � 5h      $	 Red��6'   $	 0.5Q�63   � 5i      $ Yellow��6'   $ 0Q�66   5j      .��5k   &   5l      A� 5n      $��60��5o      $��60��5p      $��3q�5q      ��5r      
� 5s       
� RadiusX$	 0.6Q�6*    
� RadiusY$	 0.8Q�68    
� GradientOrigin$ 0.3,0.3&�6F   .��5t      � $	 Red��6'   $ 1Q�63   � 5u      $ White��6'   $ 0Q�65   5v      5x      �� 5y      -   5        $ TextBoxRight��5z      $��50(�5{      $��	ExtraBold"�5|      $��AbCdiFgKlMnO��5}      $��Right=�5~      .��6(   ��5      
� 5�      $	 0.6Q�5�      $	 0.6Q�5�      $ 0.5,0.5&�5�      .��5�      � $
 Aqua��6'   $ 1Q�64   � 5�      $ Bisque��6'   $ 0Q�66   5�      .��5�   &   ��5�      
� 5�       
� Center$ 0.4,0.4&�6*    � SpreadMethod$ Reflect=�6<   .��5�      � $
 Blue��6'   $ 1Q�64   � 5�      $	 Red��6'   $	 0.5Q�63   � 5�      $ Yellow��6'   $ 0Q�66   5�      .��5�   &   5�      5�      5�      5�      