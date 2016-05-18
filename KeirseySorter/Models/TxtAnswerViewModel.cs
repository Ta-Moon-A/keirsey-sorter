using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeirseySorter.Models
{
    public class TxtAnswerViewModel
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public string Text { get; set; }
        public int Questionid { get; set; }
        public bool Checked { get; set; }
        public KeirseyTypes KType { get; set; }
    }
}