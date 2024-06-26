﻿using Models.Models;

namespace Models.DTO
{
    public class CountryDetailDTO
    {
        public CountryName Name { get; set; }

        public string[]? Capital { get; set; }

        public string? Region { get; set; }

        public Dictionary<string, string>? Languages { get; set; } 


    }
}
