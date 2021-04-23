# SFX-100-Timerfix
Fixes Windows 10 high performance timer issues. Works as SimFeedback extenstion. 

### Download and install this extension now for best performance using SimFeedback with SFX-100

**Update 23.04.2021:**  
**Function of the fix confirmed by measurement and many reports from users. "You can really feel it!"**  
**See and download full report by Topy190675: [SFX-SFB_measurement_for_timer-fix.pdf](https://github.com/ashupp/SFX-100-Timerfix/files/6363569/SFX-SFB_measurement_for_timer-fix.pdf)** 

# Description
Many current Windows installations are suffering a slower high performance timer. This could be due to an energy-saving setting but currently there is many speculation and no one is really sure about why this is actually happening and how to solve it by configuration. 

The slower timer can lead to different issues. 
On SFX-100 system it can result in stuttering movements.
The update rate of the Leonardo controller should be 100 times per second (10ms). 
Because of the issue the update rate is only 60-70 times per second (14-15ms) on affected systems.

This is a fire-and-forget fix for SimFeedback to enforce best possible timer performance. 
It automatically detects if a fix for the timer is needed and applies it at runtime.
At start-up, a period of 50 timer events is examined. If the average of the results are higher than 12 milliseconds, the fix is applied.


# Installation  
Do not click on the green Download button on this page. This would download the sources only.  
Download the files from the releases page instead or download latest version below. 
https://github.com/ashupp/SFX-100-Timerfix/releases

[Click here to download latest SFX-100-Timerfix installer](https://github.com/ashupp/SFX-100-Timerfix/releases/latest/download/SFX-100-Timerfix-Setup.exe)


- Launch the installer
- Select SimFeedback base directory (not extension directory)
- Enable the plugin and enable autorun of the extension in SimFeedback
- Restart SimFeedback

![image](https://user-images.githubusercontent.com/1867828/115565650-d6b88b00-a2b9-11eb-9a04-24d6a345d4df.png)

## Proof that this fix works (Part from the report of Topy190675)
![image](https://user-images.githubusercontent.com/1867828/115837385-cff45a00-a418-11eb-863d-ec8184b85565.png)

## How can i be sure and test if this fix works?


**This is how it looks like when the extension detects that no timer fix is needed**
![image](https://user-images.githubusercontent.com/1867828/115901164-21283c00-a461-11eb-8d7f-008d45f77398.png)

**And this is how it looks like when the extension detects the timer fix is needed**
![image](https://user-images.githubusercontent.com/1867828/115901077-06ee5e00-a461-11eb-9e36-03606fa7c71a.png)



This fix is based on the research and proof of concept by SimFeedBack community member Dsl71, Topy190675, Saxxon and many others.
The issue in combination with SFX-100 was detected by Pimpi84 - thank you.

**Please support this great project.**
https://opensfx.com
