using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Threading;

namespace formNamespace
{
    public struct Slide
    {
        private string path;
        public string Path { get; set; }

        private int duration;
        public int Duration { get; set; }

        private int transitionTime;
        public int TransitionTime { get; set; }

        public enum transitionType
        {
            wipeLeft,
            wipeRight,
            wipeUp,
            wipdeDown,
            crossFade
        }


    }

    //struct to hold soundtrack information
    public struct SoundTrack
    {

        private string path;

        public string Path { get; set; }

        private int duration;

        public int Duration { get; set; }
    }


    public class SlideHandler
    {
        //------------------
        // member variables
        //------------------

        public MediaPlayer soundTrackPlayer = new MediaPlayer();

        private readonly object _lock = new object();
        //List to hold all slides
        private Slide[] slideList;

        //List to hold all imported(available) sound tracks
        public List<SoundTrack> ImportedSoundTrackList = new List<SoundTrack>();

        //List to hold organized sound tracks placed in slideshow
        public List<SoundTrack> SlideshowSoundTrackList = new List<SoundTrack>();

        public SlideHandler()
        {


            soundTrackPlayer.MediaOpened += (sender, path) =>
            {

            };
        }


        //-----------------------
        // all the get functions
        //-----------------------

        // getSlideTransitionType
        // retrieves the transition time for the slide
        public string getSlideTransistionType(Slide slide)
        {
            string type = "";
            //type = slide.transitionType;
            return type;
        }


        //--------------------------
        // all the change functions
        //--------------------------

        // changeSlideTransition
        // changes the transition of the slide
        private void changeSlideTransition(Slide slide)
        {

        }


        // createSlide
        // creates a slide
        public void createSlide(string path)
        {
            Slide slide = new Slide();
            slide.Path = path;
            slide.Duration = 5;
        }

        // create new imported soundtrack entry
        public void createSoundTrack(string path)
        {   //make new track
            SoundTrack soundTrack = new SoundTrack();
            //set its path name
            soundTrack.Path = path;

            //open sound file to get duration
            soundTrackPlayer.Open(new Uri(path, UriKind.Relative)); //use path to get duration

            int counter = 0;
            //NOTE: This wait is to ensure successful opening of sound file
            //time out if it took more than 2 seconds
            while((soundTrackPlayer.NaturalDuration.HasTimeSpan) == false && (counter < 20))
            {
                Thread.Sleep(100);
                counter++;
            }

            //Set the duration of the track object
            if (soundTrackPlayer.NaturalDuration.HasTimeSpan == true)
            {
                soundTrack.Duration = soundTrackPlayer.NaturalDuration.TimeSpan.Seconds; //get duration in seconds
                soundTrackPlayer.Close();
            }
            else
            {
                Console.WriteLine("SOUNDTRACK ERROR: COULD NOT SET DURATION\n\n");
            }

            //add to list
            ImportedSoundTrackList.Add(soundTrack);
        }


        // Add soundtrack to show
        public void addSoundTrackToSlideshow(SoundTrack track)
        {
            //add to organized slideshow list
            SlideshowSoundTrackList.Add(track);
        }

        public void removeSoundTrackFromSlideshow(SoundTrack track)
        {
            //remove from organized list
            SlideshowSoundTrackList.Remove(track);
        }

        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

    }
}
