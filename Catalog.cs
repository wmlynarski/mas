using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public class Catalog
    {
        public List<MediaItem> MediaItems { get; set; }
        public Dictionary<int, MediaItem> ById { get; private set; } //asocjacja kwalifikowana
        public Library Library { get; }
        public Catalog(Library library)
        {
            MediaItems = new List<MediaItem>();
            ById = new Dictionary<int, MediaItem>();
            Library = library;
        }
        public void AddMediaItem(MediaItem mediaItem)
        {
            if (mediaItem == null) throw new ArgumentNullException(nameof(mediaItem));
            mediaItem.Catalog = this;
            MediaItems.Add(mediaItem);
            ById[mediaItem.MediaItemID] = mediaItem;
            this.SaveToFile();
        }
        public MediaItem GetById(int id) =>
            ById.TryGetValue(id, out var item) ? item : null;

        public void RemoveMediaItem(MediaItem mediaItem)
        {
            mediaItem.Catalog = null;
            MediaItems.Remove(mediaItem);
            ById.Remove(mediaItem.MediaItemID);
            this.SaveToFile();
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
