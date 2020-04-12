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
	public class Decoder
	{
		public Decoder()
		{

		}

		public List<SoundTrack> ImportSoundTracksFromFile()
		{
			//make a new temp list
			List<SoundTrack> SoundTrackListFromFile = new List<SoundTrack>();

			//generate file name
			string appDirectory = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			string SoundTrackPath = appDirectory + "\\soundtracklist.json";

			//read json file in parsing objects out as new soundtrack objects and placing them in new list
			try
			{
				using (StreamReader r = new StreamReader(SoundTrackPath))
				{
					string json = r.ReadToEnd();
					SoundTrackListFromFile = JsonConvert.DeserializeObject<List<SoundTrack>>(json);
				}
			}
			catch(Exception e)
			{
				Console.WriteLine("ERROR: Json tracks file cannot be opened\n\n");
			}

			return SoundTrackListFromFile;
		}

		public List<Slide> ImportSlidesFromFile()
		{
			//make a new temp list
			List<Slide> SlideListFromFile = new List<Slide>();

			//generate file name
			string appDirectory = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			string SlidePath = appDirectory + "\\slidelist.json";

			//read json file in parsing objects out as new soundtrack objects and placing them in new list
			try
			{
				using (StreamReader r = new StreamReader(SlidePath))
				{
					string json = r.ReadToEnd();
					SlideListFromFile = JsonConvert.DeserializeObject<List<Slide>>(json);
				}
			}
			catch(Exception e)
			{
				Console.WriteLine("ERROR: Json slides file cannot be opened\n\n");
			}

			return SlideListFromFile;
		}

	}
}
