using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class Recognize
    {
        public int RecognizeId { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public int Likes { get; set; }

        public int EmpId { get; set; }
    }
}
