namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate {  get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; } //Creating the "Many to Many" relationship
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
