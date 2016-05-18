using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace KeirseySorter.Models
{
    public class PicAnswerViewModel
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public Image Data { get; set; }
        public int Questionid { get; set; }
        public bool Checked { get; set; }
        public KeirseyTypes KType { get; set; }


    }
}