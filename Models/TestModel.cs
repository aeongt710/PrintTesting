using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class TestModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
