using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Threading;
using System.IO;
using System.Text.Json;
using System.Web;
using Newtonsoft.Json;

namespace formNamespace
{
	// This class is responsible for taking the lists
	// created during the project and writing them to 
	// a json file.
	public class Encoder
	{
		public Encoder()
		{
			
		}

		public void WriteSoundTracksToFile(List<SoundTrack> currentSoundTrackList)
		{
			List<SoundTrack> SoundTrackListToWrite = new List<SoundTrack>();

			//obtain copy of current sound track list if it is not empty
			if(currentSoundTrackList != null)
			{
				SoundTrackListToWrite = new List<SoundTrack>(currentSoundTrackList);

				//generate file name
				string appDirectory = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
				string SoundTrackPath = appDirectory + "\\soundtracklist.json";

				//convert for json writing
				string jsonSoundTracks = JsonConvert.SerializeObject(SoundTrackListToWrite.ToArray());

				System.IO.File.WriteAllText(SoundTrackPath, jsonSoundTracks);


				Console.WriteLine(SoundTrackPath);
				//Console.WriteLine(currentDirectory);
			}
			else
			{
				Console.WriteLine("Sound Track list is empty, cannot write file.");
			}
		}

		public void WriteSlidesToFile(List<Slide> currentSlideList)
		{
			List<Slide> SlideListToWrite = new List<Slide>();

			//obtain copy of current slide list
			if (currentSlideList != null)
			{
				SlideListToWrite = new List<Slide>(currentSlideList);

				//generate file name
				string appDirectory = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
				string SoundTrackPath = appDirectory + "\\slidelist.json";

				//convert for json writing
				string jsonSlides = JsonConvert.SerializeObject(SlideListToWrite.ToArray());

				//write string to file
				System.IO.File.WriteAllText(SoundTrackPath, jsonSlides);
			}
			else
			{
				Console.WriteLine("Slide list is empty, cannot write file.");
			}
		}

	}
}
