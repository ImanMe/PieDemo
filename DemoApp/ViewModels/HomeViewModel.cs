using System.Collections.Generic;
using DemoApp.Models;

namespace DemoApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}