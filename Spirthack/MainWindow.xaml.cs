using System;
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
            File.Delete(@"C:\SpirtDL\myfile.exe"); //delete any old versions of the loader 
            Directory.CreateDirectory("c:\\SpirtDL");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://files.catbox.moe/68eig5.mp3", @"c:\SpirtDL\thesearch.mp3");   //download song (NF - The Search (edit)) to folder
            webClient.Dispose();
            string url = @"c:\SpirtDL\thesearch.mp3";  //set music path

            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri(url, UriKind.Relative)); //open the music player with the url

            string localversion = "1";          //sets local version first
            WebClient client = new WebClient(); //new web client
            string onlineversion = client.DownloadString("http://matt1.tk/spirtdlver.html"); //checks my site for the current version
            

            int stringcheck = 0;

            stringcheck = string.Compare(localversion, onlineversion);
            

            if (stringcheck != 0) //If there is a newer version, open github to the releases tab
            {
                System.Diagnostics.Process.Start("https://github.com/matt1tk/SpirtDL/releases");
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

            //ok lets break this down
            WebClient webClient = new WebClient();                                                  //new web client

            webClient.DownloadFile("https://spirthack.me/api/getinj", @"c:\SpirtDL\myfile.exe");   //download the injector (from the site), put it in c folder as myfile.exe
            System.Diagnostics.Process.Start(@"c:\SpirtDL\myfile.exe");                            //run the exe
            webClient.Dispose();                                                                   //delete the web client
            mediaPlayer.Stop();                                                                    //stop the music if it is running (clean up)

            System.Environment.Exit(0);                                                            //close program 


        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // this is the open my site button
        {
            System.Diagnostics.Process.Start("http://matt1.tk"); //open my site when the button is clicked
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //this is the exit button
        {
            mediaPlayer.Stop(); //stops music if playing (clean up)
            System.Environment.Exit(0); //close program
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // this is the play button
        {

            mediaPlayer.Play(); //play (duh)
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //check for updates button
        {
            System.Diagnostics.Process.Start("https://github.com/matt1tk/SpirtDL"); //this just opens my website to the SpirtDL page, in the future I may add a built in update function
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //pause button (these are all out of order i know)
        {


            mediaPlayer.Pause(); //pause
        }
    }
}

