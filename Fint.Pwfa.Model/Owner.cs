namespace Fint.Pwfa.Model
{
    public class Owner
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        //TODO Should this be English rather than Norwegian?
        public enum Relasjonsnavn
        {
            DOG
        }
    }
}
