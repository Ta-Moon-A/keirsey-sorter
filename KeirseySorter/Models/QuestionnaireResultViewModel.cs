using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeirseySorter.Models
{
    public class QuestionnaireResultViewModel
    {
        public KeirseyTypeViewModel PrimaryType { get; set; }
        public KeirseyTypeViewModel SecondaryType { get; set; }
    }
}