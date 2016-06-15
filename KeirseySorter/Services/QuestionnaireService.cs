
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KeirseySorter.Models;
using System.ComponentModel;

namespace KeirseySorter.Services
{
    public class QuestionnaireService
    {

        public static QuestionnaireResultViewModel CalculateType(List<QuestionViewModel> answeredData)
        {

            Dictionary<int, Tuple<double,int>> ktFuzzySet = new Dictionary<int, Tuple<double, int>>();


            foreach (var question in answeredData)
            {

                var answers = (int)question.Type == (int)QuestionTypes.PicQuestion ? question.PicAnswers.Select(a => new { a.Checked, a.KType }).ToList()
                                                                                   : question.TxtAnswers.Select(a => new { a.Checked, a.KType }).ToList();

                var checkedAnswerCount = answers.Count(a => a.Checked);

                foreach (var answer in answers)
                {
                    float dividend = 1;

                    var typeGrade = answer.Checked ? dividend / checkedAnswerCount : 0;

                    if (!ktFuzzySet.ContainsKey((int)answer.KType))
                    {
                        
                        ktFuzzySet.Add((int)answer.KType, new Tuple<double, int> (typeGrade, typeGrade == 0 ? 0 : 1));
                    }
                    else
                    {
                        if(ktFuzzySet[(int)answer.KType].Item1 < typeGrade)
                        {
                            var counter = ktFuzzySet[(int)answer.KType].Item2;
                            ktFuzzySet[(int)answer.KType] = new Tuple<double, int>(typeGrade, counter++);
                        }
                    }
                 }
            }


            var orderedanswers = ktFuzzySet.OrderByDescending(pair => pair.Value.Item1)
                                           .OrderByDescending(r => r.Value.Item2)
                                           .Take(2).ToList();


            var result = new QuestionnaireResultViewModel()
            {
                PrimaryType = QuestionnaireData.ResultData[(KeirseyTypes)orderedanswers[0].Key],
                SecondaryType = QuestionnaireData.ResultData[(KeirseyTypes)orderedanswers[1].Key]
            };

            return result;
        }

    }
}