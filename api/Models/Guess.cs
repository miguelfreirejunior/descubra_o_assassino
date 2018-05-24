using System;

namespace api.Models
{
    public class Guess
    {
        public string Id { get; set; }
        
        public int Suspeito { get; set; }

        public int Local { get; set; }

        public int Arma { get; set; }
    }
}