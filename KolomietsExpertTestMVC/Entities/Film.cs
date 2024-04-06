namespace KolomietsExpertTestMVC.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        //relations
        public ICollection<FilmCategory> FilmCategories { get; set; }
    }
}
