using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class SlideHandler
    {
        //------------------
        // member variables
        //------------------

        public struct Slide {
            private string path;
            private int duration;
            private int transitionTime;
            private enum transitionType {
                wipeLeft,
                wipeRight,
                wipeUp,
                wipdeDown,
                crossFade
            }
        }

        private Slide[] slideList;




        //-----------------------
        // all the get functions
        //-----------------------

        // getSlideDuration
        // retrieves the duration of the slide
        public int getSlideDuration(Slide slide)
        {
            return 0;
        }

        // getSlidePath
        // retrieves the Path of the slide
        public string getSlidePath(Slide slide)
        {
            return "a";
        }

        // getSlideTransitoinTime
        // retrieves the transition time for the slide
        public int getSlideTransistionTime(Slide slide)
        {
            return 0;
        }

        
        //--------------------------
        // all the change functions
        //--------------------------

        // changeSlidePath
        // Changes the directory path of the slide
        private void changeSlidePath(Slide slide)
        {

        }

        // changeSlideDuration
        // changes the duration of the slide
        private void changSlideDuration(Slide slide)
        {

        }

        // changeSlideTransition
        // changes the transition of the slide
        private void changeSlideTransition(Slide slide)
        {

        }

        // changeSlideTransitionTime
        // changes the transition time of the slide
        private void changeSlideTransitionTime(Slide slide)
        {

        }
    }
}
