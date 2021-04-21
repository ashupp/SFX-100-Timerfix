# SFX-100-Timerfix
Fixes Windows 10 high performance timer issues

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


## How can i be sure and test if this fix works?
- Launch Simfeedback with debug logging enabled (SimFeedbackStart.exe -d 2)
- Check SimFeedbackLog.log in /log subdirectory 
- Look for entries containing "SFX-100-Timerfix"

**This is how it looks like when the extension detects that no timer fix is needed**
```
2021-04-21 14:32:24.4039 Info SFX-100 Timerfix: Extension loaded  
2021-04-21 14:32:24.9294 Info SFX-100 Timerfix: Average timer value: 10,36  
2021-04-21 14:32:27.0154 Info SFX-100-Timerfix: not necessary  
```

**And this is how it looks like when the extension detects the timer fix is needed**
```
2021-04-21 15:43:48.0924 Debug AutoStart Extension SFX-100 Timerfix 1.0.2.0
2021-04-21 15:43:48.0934 Info SFX-100 Timerfix: Extension loaded
2021-04-21 15:43:48.8653 Info SFX-100 Timerfix: Average timer value: 15
2021-04-21 15:43:48.8653 Info SFX-100 Timerfix: slow timer detected - loading fix
2021-04-21 15:43:48.8653 Info SFX-100 Timerfix: fix loaded
```


This fix is based on the research and proof of concept by SimFeedBack community member Dsl71, Saxxon and many others.

**Please support this great project. **
https://opensfx.com
