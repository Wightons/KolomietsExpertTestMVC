namespace KolomietsExpertTestMVC.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        //relations
        public ICollection<FilmCategory> FilmCategories { get; set; }
    }
}
