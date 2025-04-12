using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Catalog
    {
        public List<MediaItem> MediaItems { get; set; }
        public Catalog()
        {
            MediaItems = new List<MediaItem>();
        }
        public void AddMediaItem(MediaItem mediaItem)
        {
            MediaItems.Add(mediaItem);
            this.SaveToFile();
        }
        public void RemoveMediaItem(MediaItem mediaItem)
        {
            MediaItems.Remove(mediaItem);
        }
        public static void DisplayAllMediaItems() //metoda klasowa
        {
            foreach (var mediaItem in MediaItem.AllMediaItems)
            {
                Console.WriteLine(mediaItem);
            }
        }
    }
}
