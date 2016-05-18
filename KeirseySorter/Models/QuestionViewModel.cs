using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeirseySorter.Models
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public string Text { get; set; }
        public QuestionTypes Type { get; set; }
        public List<PicAnswerViewModel> PicAnswers { get; set; }
        public List<TxtAnswerViewModel> TxtAnswers { get; set; }

    }
}