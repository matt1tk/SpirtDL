using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Spirthack
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer;

        public MainWindow() //this is just the main window
        {
            InitializeComponent();
            foreach (var process in Process.GetProcessesByName("Steam")) //closes steam!
            {
                process.Kill();
            }
            File.Delete(@"C:\SpirtDL\myfile.exe"); //delete any old versions of the loader 
            Directory.CreateDirectory("c:\\SpirtDL");
            string url = "song.mp3";  //set music path
            if (!File.Exists(url))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://files.catbox.moe/mj3tab.flac", "song.mp3");   //download song to folder
                webClient.Dispose();
            }


            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri(url, UriKind.Relative)); //open the music player with the url

            string localversion = "1.5";          //sets local version first
            WebClient client = new WebClient(); //new web client
            string onlineversion = client.DownloadString("http://matt1.tk/np/spirtdlver.html"); //checks my site for the current version

            int stringcheck = string.Compare(localversion, onlineversion);
            if (stringcheck != 0) //If there is a newer version, open github to the releases tab
            {
                Process.Start("https://github.com/matt1tk/SpirtDL/releases");
            }
        }


        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) //lets you move window
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
            //allows for moving window
        }

        private void Button_Click(object sender, RoutedEventArgs e) //copy discord id button
        {
            Clipboard.SetText("2772#7903");
            //adds my discord tag to clipboard when you click this button
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //this is the download and run button. read through this if you want to see if it's safe (hint: it is)
        {

            downloadLoader();
        }
        private void downloadLoader()
        {
            string url = "https://spirthack.me/api/getinj";
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    pBar1.Value = e.ProgressPercentage;
                });

                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler
                    (delegate (object sender, AsyncCompletedEventArgs e)
                    {
                        if (e.Error == null && !e.Cancelled)
                        {
                            Process.Start("myfile");
                        }
                    });
                webClient.DownloadFileAsync(new Uri(url), "myfile.exe");
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e) // this is the open my site button
        {
            Process.Start("http://matt1.tk"); //open my site when the button is clicked
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //this is the exit button
        {
            mediaPlayer.Stop(); //stops music if playing (clean up)
            Environment.Exit(0); //close program
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // this is the play button
        {

            mediaPlayer.Play(); //play (duh)
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //check for updates button
        {
            Process.Start("https://github.com/matt1tk/SpirtDL"); //this just opens my website to the SpirtDL page, in the future I may add a built in update function
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //pause button (these are all out of order i know)
        {


            mediaPlayer.Pause(); //pause
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start("steam://rungameid/730"); //launch CS:GO
            mediaPlayer.Stop(); //stop music (cleanup)
            Environment.Exit(0);  //end process

        }
    }
}
