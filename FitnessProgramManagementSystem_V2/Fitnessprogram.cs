﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class Fitnessprogram
    {
        public Fitnessprogram(string fitnessProgramId, string title, string duration, decimal price)
        {
            FitnessProgramId = fitnessProgramId;
            Title = title;
            Duration = duration;
            Price = price;
        }

        public string FitnessProgramId { get; set; }
        public string Title { get; set; }
        public string Duration
        { get;
            set; }

        public decimal Price {  get; set; } 


















    }
}
