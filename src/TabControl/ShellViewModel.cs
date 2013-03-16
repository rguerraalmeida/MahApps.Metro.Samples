using System.Linq;
using MahApps.Metro.Controls;
using MahApps.Metro.SampleData.MusicStore;
using ReactiveUI;
using Data = MahApps.Metro.SampleData.MusicStore.SampleData;

namespace TabControlSample
{
    public class ShellViewModel : ReactiveObject
    {
        public ReactiveCollection<Genre> Genres { get; set; }

        public ReactiveCollection<PanoramaGroup> Groups { get; set; }
        
        public string Title { get; set; }
        public int SelectedIndex { get; set; }
        public ReactiveCollection<Album> Albums { get; set; }
        public ReactiveCollection<Artist> Artists { get; set; }

        public ShellViewModel()
        {
            Genres = new ReactiveCollection<Genre>(Data.Genres);
            Albums = new ReactiveCollection<Album>(Data.Albums);
            Artists = new ReactiveCollection<Artist>(Data.Artists);
        }
    }
}
