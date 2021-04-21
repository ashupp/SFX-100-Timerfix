# SFX-100-Timerfix
Fixes Windows 10 high performance timer issues

Please support this great project.  
https://opensfx.com

# Installation  
Do not click on the green Download button on this page. This would download the sources only.  
Download the files from the releases page instead or download latest version below. 
https://github.com/ashupp/SFX-100-Timerfix/releases

[Click here to download latest SFX-100-Timerfix installer](https://github.com/ashupp/SFX-100-Streamdeck/releases/latest/download/SFX-100-Timerfix-Setup.exe)


- Launch the installer
- Select SimFeedback base directory (not extension directory)
- Enable the plugin and enable autorun of the extension in SimFeedback
- Restart SimFeedback

## How can i be sure this thing works?
- Launch Simfeedback with debug logging enabled (SimFeedbackStart.exe -d 2)
- Check SimFeedbackLog.log in /log subdirectory 
- Look for entries containing "SFX-100-Timerfix"

This is how it looks like when the extension detects that no timer fix is needed
```
2021-04-21 14:32:24.4039 Info SFX-100 Timerfix: Extension loaded  
2021-04-21 14:32:24.9294 Info SFX-100 Timerfix: Average timer value: 10,36  
2021-04-21 14:32:27.0154 Info SFX-100-Timerfix: not necessary  
```

This fix is based on the research and proof of concept by SimFeedBack community member Dsl71, Saxxon and many others.
