namespace Fint.Pwfa.Model
{
    public class Dog
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        //TODO Should this be English rather than Norwegian?
        public enum Relasjonsnavn
        {
            OWNER
        }
    }
}
