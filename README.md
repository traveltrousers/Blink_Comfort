Blink_Comfort 0.2 + Flash Comfort
=============

This is a simple test to add 'blink comfort' turning in the Oculus Tuscany Demo.

Using two 'eye lids' we have a simple animation to bring them together when the user turns with Q and E.

I added another set of blinks for forward and backwards motion. You also blink when you stop moving too... These are triggered by W and S... if you just want to move forward without 'blinking' then the up and down arrows are working as normal.

If you wish to edit their speed select TopLid or BottomLid under OVRPlayerController and press CTRL-6 to bring up the animation window. 

A lower 'sample' number will make the lids close slower, high is faster. 

A figure of 67 gives a speed of around 300ms.

If you change this figure then you need to alter to the two delay at the bottom of the OVRPlayerController script, currently set at 0.15 (half of the 300ms delay)...

The compiled code is also in the directory or just download the code and play around with it. There are only 6 extra files, 2 animations, 2 animators and 2 scripts to play the animations when Q or E are pressed, otherwise the code is vanilla 0.4.3 Tuscany.

Using Unity 4.6 B 21 and 0.4.3 from Oculus.

If you just want the exe download it here :  http://www.feelthree.com/downloads/Blink_Comfort.rar

A few blog posts about the phenonmenon are on my website : http://www.feelthree.com/category/motion-sickness/

TO DO/TRY

Grey eye lids instead of black

Allow on the fly change of speed for turning by 50ms increments

Blink on camera reset with variable speed

Acceleration curves on the 'eyelids' for a more natural effect.

Different coloured eyelids.

Semi - Transparent eyelids.

Desaturating the colour in each scene on movement.

Desaturating certain colours on movement.

Blinking down quickly but snapping the eye open.

Blurred eyelid edges.

If you want to copy this idea from scratch I suggest you watch this video first :
https://www.youtube.com/watch?v=WXKzeZmB9Zc

=============

I also found some interesting research conducted by the US Army Aeromedical Research Laboratory in 2007 which tested subjects susceptibility to motion sickness by using LCD shutter glasses closing at a rate of 4 or 8hz for 10ms while people tried to read a map in a moving helicopter. 19 out of 20 people reported less nausea...

I created another simple demo to re-create this simulation and would be interested in hearing if anyone finds it useful... http://www.feelthree.com/downloads/flash_test.rar

You can change the frequency with Z (quicker) and X. Initially it flashes about once every 19 updates... I figured that's about 4 times a second around 75hz but I'm not sure that assumption is really correct....

The papers (including the scanned original report) are here :
http://www.dtic.mil/dtic/tr/fulltext/u2/a467760.pdf
http://www-ieem.ust.hk/dfaculty/so/pdf/Pages51-58-VIMS2007.pdf
