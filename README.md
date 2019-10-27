# Spirthack
SpirtDL - the open source C# spirthack loader

![SpirtDL menu](https://i.imgur.com/uQe597K.png)

 Want to donate? Buy me a spirthack sub ;)
 
 # Roadmap
 Adding auto run on launch as an option (so you don't have to click run)
 UI 

SpirtDL is a very simple loader for Spirthack that gets around having to go to the site every time (since the loader deletes itself out of safety). 

Instructions: 
1. Download latest version from releases.
2. Place on your desktop (or wherever)
3. CLOSE STEAM (only way to be 100% sure that *this program* won't cause a VAC ban. If you do, it's because a cheat you used got detected. probably not spirthack since they have been undetected for a while)
4. Double click to open
5. Click Download and Run, then inject on the loader. 
6. Click "Run CS:GO" in SpirtDL or just launch CS:GO (if you do this, close spirtDL before opening CS.)

In the interest of openness, I made this program open source. 

Read through the main program code here: https://github.com/matt1tk/SpirtDL/blob/master/Spirthack/MainWindow.xaml.cs

Make an issue if you need an explanation on what something is or if I can do something better. 


On first run, it will create the C:/SpirtDL folder. It will delete the myfile.exe file in the folder if it exists (to ensure it uses the newest loader every time) Then it will download a song (one of my favorites) to C:/SpirtDL. It gets the media player ready by setting a string value to the path. It has a local value for version, it will check against my site (https://matt1.tk/spirtdlver.html) and if the local value and the number my webpage returs are *different*, it will OPEN THIS GITHUB PAGE*.

Here is the code to download the loader: https://github.com/matt1tk/SpirtDL/blob/master/Spirthack/MainWindow.xaml.cs#L67

As you can see, it downloads the injector from the spirthack site, saves it as myfile.exe in C:/SpirtDL, and runs it. Then it disposes of the web client used to download the loader, stops the music (general coding clean up), and ~commits suicide and closes itself~ (It will end itself if you choose "open cs:go", if not, it will not end itself). The program NEVER touches any log ins to spirthack, or touches the loader in any way.


"It has a local value for version, it will check against my site (https://matt1.tk/spirtdlver.html) and if the local value and the number my webpage returs are *different*, it will OPEN THIS GITHUB PAGE*."

*This is very important. It cannot and will not ***EVER*** update itself, which both means you need to do it yourself, and that I cannot push out a malicious update that doesn't come from the github. (Or even from the github!)

Open a github issue if you have any issues using it. 



Contact me: admin@matt1.tk or 2772#7903 on discord or u/throwaway27727394927 on reddit!
