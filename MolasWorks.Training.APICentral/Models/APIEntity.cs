﻿using SQLite;

namespace MolasWorks.Training.APICentral.Models
{
    public class APIEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string API { get; set; }
        public string Description { get; set; }
        public string Auth { get; set; }
        public bool HTTPS { get; set; }
        public string Cors { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
    }
}
