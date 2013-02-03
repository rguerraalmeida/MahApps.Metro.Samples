using System.ComponentModel;

namespace MahApps.Metro.SampleData
{
    public class Album
    {
        public int AlbumId { get; set; }

        [DisplayName("Genre")]
        public int GenreId { get; set; }

        [DisplayName("Artist")]
        public int ArtistId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        [DisplayName("Album Art URL")]
        public string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}