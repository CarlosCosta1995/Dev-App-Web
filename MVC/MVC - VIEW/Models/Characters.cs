namespace Ficha10.Models
{
    public class Characters
    {
        public List<Character> CharactersList { get; set; }
        public Characters()
        {
            CharactersList = new List<Character>();
        }
        public Characters(List<Character> listaChars) {
            CharactersList = listaChars;
        }

    }
}
