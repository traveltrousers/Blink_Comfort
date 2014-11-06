Blink_Comfort
=============

This is a simple test to add 'blink comfort' turning in the Oculus Tuscany Demo.

Using two 'eye lids' we have a simple animation to bring them together when the user turns with Q and E.

If you wish to edit their speed select TopLid or BottomLid under OVRPlayerController and press CTRL-6 to bring up the animation window. 

A lower 'sample' number will make the lids close slower, high is faster. 

A figure of 67 gives a speed of around 300ms.

If you change this figure then you need to alter to the delay at the bottom of the OVRPlayerController script...

The compiled code is also in the directory or just download the code and play around with it. There are only 6 extra files, 2 animations, 2 animators and 2 scripts to play the animations when Q or E are pressed, otherwise the code is vanilla 0.4.3 Tuscany.

Using Unity 4.6 B 21 and 0.4.3 from Oculus.
