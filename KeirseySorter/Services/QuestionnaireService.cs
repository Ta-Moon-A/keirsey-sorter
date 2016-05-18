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

            Dictionary<int, double> ktFuzzySet = new Dictionary<int, double>();


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
                        ktFuzzySet.Add((int)answer.KType, typeGrade);
                    }
                    else
                    {
                        ktFuzzySet[(int)answer.KType] += typeGrade;
                    }

                }

            }


            var orderedanswers = ktFuzzySet.OrderByDescending(pair => pair.Value).Take(2).ToList();

            var result = new QuestionnaireResultViewModel()
            {
                PrimaryType = QuestionnaireData.ResultData[(KeirseyTypes)orderedanswers[0].Key],
                SecondaryType = QuestionnaireData.ResultData[(KeirseyTypes)orderedanswers[1].Key]
            };

            return result;
        }

    }
}