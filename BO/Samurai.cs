namespace BO
{
    public class Samurai
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int Force { get; set; }

        public Arme? Arme { get; set; }

        public int? ArmeId { get; set; }
    }
}
