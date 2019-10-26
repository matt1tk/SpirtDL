# Spirthack
SpirtDL - the open source C# spirthack loader... loader 



SpirtDL is a very simple loader for Spirthack that gets around having to go to the site every time (since the loader deletes itself out of safety). 

Instructions: 
1. Download latest version from releases.
2. Place on your desktop (or wherever)
3. CLOSE STEAM (only way to be 100% sure that *this program* won't cause a VAC ban. If you do, it's because a cheat you used got detected. probably not spirthack since they have been undetected for a while)
4. Double click to open

In the interest of openness, I made this program open source. 

These are the things the program will do without having to click anything. It will create the C:/SpirtDL folder. It will delete the myfile.exe file in the folder if it exists (to ensure it uses the newest loader every time) Then it will download a song (one of my favorites) to C:/SpirtDL. It gets the media player ready by setting a string value to the path. It has a local value for version, it will check against my site (https://matt1.tk/spirtdlver.html) and if the local value and the number my webpage returs are *different*, it will OPEN THIS GITHUB PAGE*.

The rest of the code requires a button press and does these things:

Allows you to move the window (since I removed the default window)
Opens my site (if you click that button)
Copies discord ID (if you click that button) 
Open github project page (if you click that button)
Plays the song (NF- The Search) (if you click the play button)
Pauses the song
Close 

Main function is to download and run the spirthack loader, this is the code I will copy and paste here. 

WebClient webClient = new WebClient();                                                  //new web client

            webClient.DownloadFile("https://spirthack.me/api/getinj", @"c:\SpirtDL\myfile.exe");   //download the injector (from the site), put it in c folder as myfile.exe
            System.Diagnostics.Process.Start(@"c:\SpirtDL\myfile.exe");                            //run the exe
            webClient.Dispose();                                                                   //delete the web client
            mediaPlayer.Stop();                                                                    //stop the music if it is running (clean up)

            System.Environment.Exit(0);                                                            //close program 

As you can see, it downloads the injector from the spirthack site, saves it as myfile.exe in C:/SpirtDL, and runs it. Then it disposes of the web client used to download the loader, stops the music (general coding clean up), and commits suicide and closes itself. The program NEVER touches any log ins to spirthack, or touches the loader in any way.


"It has a local value for version, it will check against my site (https://matt1.tk/spirtdlver.html) and if the local value and the number my webpage returs are *different*, it will OPEN THIS GITHUB PAGE*."

*This is very important. It cannot and will not ***EVER*** update itself, which both means you need to do it yourself, and that I cannot push out a malicious update that doesn't come from the github. (Or even from the github!)

Open a github issue if you have any issues using it. 

Contact me: admin@matt1.tk or 2772#7903 on discord or u/throwaway27727394927 on reddit!
