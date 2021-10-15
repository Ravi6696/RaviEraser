using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


    namespace RaviEraser.Models
    {
        public class Eraser
        {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Color { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public decimal Rating { get; set; }



    }
    }

