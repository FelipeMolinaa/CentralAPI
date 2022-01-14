namespace MolasWorks.Training.APICentral.ConsumingApi
{
    public class APIEntity
    {
        public string API { get; set; }
        public string Description { get; set; }
        public string Auth { get; set; }
        public bool HTTPS { get; set; }
        public string Cors { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"API:{API}";
        }
    }
}
