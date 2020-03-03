using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formNamespace
{
    class SlideHandler
    {
        //------------------
        // member variables
        //------------------

        public struct Slide {
            private string path;
            public string Path { get; set; }

            private int duration;
            public int Duration { get; set; }

            private int transitionTime;
            public int TransitionTime { get; set; }

            public enum transitionType {
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

    }
}
