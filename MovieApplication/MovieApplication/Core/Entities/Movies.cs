namespace MovieApplication.Core.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        public string? BackdropUrl { get; set; }
        public double Budget { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ImdbUrl { get; set; }
        public string? OriginalLanguage { get; set; }
        public string? Overview { get; set; }
        public string? PosterUrl { get; set; }
        public double Price { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public double Revenue { get; set; }
        public int Runtime { get; set; }
        public string? Tagline { get; set; }
        public string? Title { get; set; }
        public string? TmdbUrl { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
