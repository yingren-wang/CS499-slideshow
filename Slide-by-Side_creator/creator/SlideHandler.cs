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
            private string path { get; set; }
            private int duration { get; set; }
            private int transitionTime { get; set; }
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

        // getSlideTransitionType
        // retrieves the transition time for the slide
        public string getSlideTransistionType(Slide slide)
        {
            return "Type";
        }


        //--------------------------
        // all the change functions
        //--------------------------

        // changeSlideTransition
        // changes the transition of the slide
        private void changeSlideTransition(Slide slide)
        {

        }

        


    }
}
