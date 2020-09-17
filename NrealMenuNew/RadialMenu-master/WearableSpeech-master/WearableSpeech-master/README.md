If you click play on the project, you will be able to 
scroll through the main scroller, the only button that 
does anything is the Food & Beverages button that changes 
the title of the secondary scroller. 
There is an older version of the middle radial with 
some functionality but I've hidden it as it had the wrong
UI / UX design... 

I am currently working on passing the Food & Beverages list
of buttons to the secondary scroller on click and the rest of the options
that will be done by refactoring the ScrollerView / ScrollerButton to a 
Master - Slave Design pattern.


TODO: For Centennial developers
Ideally you guys could work on making the scrollers loop around, 
such that after the last button labelled "chipotle" it goes back to Food & Beverages,
and you can keep wrapping through it, such that the scroller has "infinite looping". 
In terms of asthetics, if it could look similar to how Iphone and Android does on their current clock alarm, 
where the current number in the middle of the scroller gets highlighted, and the other buttons look like they're in the background, so it uses depth. 