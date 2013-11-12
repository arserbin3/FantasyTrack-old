namespace Fantasy.Models
{
    // TODO: support a player changing teams (or coming from Free Agency)
    public class Player
    {
        public int ID { get; set; }

        public string Name { get; set; }

        // TODO: this should be a lookup
        public string Team { get; set; }

        // TODO: this should be a lookup
        public string Position { get; set; }
    }
}