﻿namespace MauiAppTempoAgora.Models
{
    public class Tempo
    {
        public double lon { get; set; }
        public double lat { get; set; }
        public int temp_min { get; set; }
        public int temp_max { get; set; }
        public int visibility { get; set; }
        public double speed { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }

    }
}
