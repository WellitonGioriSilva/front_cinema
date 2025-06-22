using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace front_cinema.Client.Models
{
    public class ResponseApi
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public Dictionary<string, string[]> Errors { get; set; }
    }
}