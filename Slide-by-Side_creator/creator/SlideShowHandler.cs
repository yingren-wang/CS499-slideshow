using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Threading;

namespace formNamespace
{
    public class Slide
    {
        private string path;
        public string Path { get; set; }

        private int duration;
        public int Duration { get; set; }

        private int transitionTime;
        public int TransitionTime { get; set; }
        //Integer that stores the value of the transistion type, cause strings enums are not used in C#
        public int transitionType { get; set; } 
        public enum transitionTypes
        {
            none,
            wipeLeft,
            wipeRight,
            wipeUp,
            wipeDown,
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

    public class SlideShowHandler
	{
        //------------------
        // member variables
        //------------------




        //-------------------
        // members for slide
        //-------------------

        // list for available slides
        public List<Slide> ImportedSlideList = new List<Slide>();

        // list for slides added to the timeline
        public List<Slide> SlideshowSlideList = new List<Slide>();

        // list for slides
        public List<Slide> slideList;

        public SlideShowHandler()
        {
            soundTrackPlayer.MediaOpened += (sender, path) =>
            {

            };
        }


        //------------------------
        // members for soundtrack
        //------------------------

        public MediaPlayer soundTrackPlayer = new MediaPlayer();

        private readonly object _lock = new object();

        //List to hold all imported(available) sound tracks
        public List<SoundTrack> ImportedSoundTrackList = new List<SoundTrack>();

        //List to hold organized sound tracks placed in slideshow
        public List<SoundTrack> SlideshowSoundTrackList = new List<SoundTrack>();

        // list for soundtracks
        public List<SoundTrack> soundtrackList;



        //-----------
        // methods
        //-----------


        //----------------------
        // all the slide stuff
        //----------------------


        //--------------------
        // name: createSlide
        // purpose: creates a struct slide with the information passed to it
        //--------------------
        public void createSlide(string path)
        {
            Slide slide = new Slide();
            slide.Path = path;
            slide.Duration = 5;
            slide.TransitionTime = 3;
            ImportedSlideList.Add(slide);
        }
        

        //---------------------------
        // name: addSlideToSlideshow
        // purpose: adds the selected slide to the list of slides that are included in the shlideshow timeline
        //---------------------------
        public void addSlideToSlideshow(Slide slide)
        {
            SlideshowSlideList.Add(slide);
        }


        //--------------------------------
        // name: removeSlideFromSlideshow
        // purpose: removes the selected slide from the list of slides that are included in teh slideshow timeline
        //--------------------------------
        public void removeSlideFromSlideshow(Slide slide)
        {
            SlideshowSlideList.Remove(slide);
        }


        // getSlideTransitionType
        // retrieves the transition time for the slide
        public string getSlideTransistionType(Slide slide)
        {
            string type = "";
            //type = slide.transitionType;
            return type;
        }

        // changeSlideTransition
        // changes the transition of the slide
        public void changeSlideTransition(Slide slide, string selectedType)
        {
            switch (selectedType)
            {
                case "None":
                    slide.transitionType = (int)Slide.transitionTypes.none;
                    break;
                case "Cross Fade":
                    slide.transitionType = (int)Slide.transitionTypes.crossFade;
                    break;
                case "Wipe Up":
                    slide.transitionType = (int)Slide.transitionTypes.wipeUp;
                    break;
                case "Wipe Down":
                    slide.transitionType = (int)Slide.transitionTypes.wipeDown;
                    break;
                case "Wipe Left":
                    slide.transitionType = (int)Slide.transitionTypes.wipeLeft;
                    break;
                case "Wipe Right":
                    slide.transitionType = (int)Slide.transitionTypes.wipeRight;
                    break;
                default:
                    slide.transitionType = (int)Slide.transitionTypes.none;
                    break;
            }
        }



        //------------------
        // soundtrack stuff
        //------------------

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
                soundTrack.Duration = (int)(soundTrackPlayer.NaturalDuration.TimeSpan.TotalSeconds); //get duration in seconds
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
            //Re-open track and ensure correct duration before adding to timeline

            SoundTrack newShowTrack = track;
            //set its path name

            newShowTrack.Path = track.Path;

            //open sound file to get duration
            soundTrackPlayer.Open(new Uri(track.Path, UriKind.Relative)); //use path to get duration

            int counter = 0;
            //NOTE: This wait is to ensure successful opening of sound file
            //time out if it took more than 2 seconds
            while ((soundTrackPlayer.NaturalDuration.HasTimeSpan) == false && (counter < 20))
            {
                Thread.Sleep(100);
                counter++;
            }

            //Set the duration of the track object
            if (soundTrackPlayer.NaturalDuration.HasTimeSpan == true)
            {
                newShowTrack.Duration = (int)(soundTrackPlayer.NaturalDuration.TimeSpan.TotalSeconds); //get duration in seconds
                soundTrackPlayer.Close();
            }
            else
            {
                Console.WriteLine("SOUNDTRACK ERROR: COULD NOT SET DURATION ON ADD TO SHOW\n\n");
            }

            //add to organized slideshow list
            SlideshowSoundTrackList.Add(newShowTrack);
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


        // ----- end of methods ----- //
	}
}
