using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KeirseySorter.Models;
using KeirseySorter.Services;

namespace KeirseySorter.Controllers
{
    public class QuestionController : Controller
    {
       
        public ActionResult LoadQuestion(string id)
        {
            int questionId;

            if (!int.TryParse(id, out questionId))
            {
                return View(new QuestionViewModel());
            }

            QuestionViewModel question = QuestionnaireData.QuestionList.FirstOrDefault(q => q.Id == questionId);

            if (question != null)
            {
                if (question.Type == QuestionTypes.PicQuestion)
                {
                    List<PicAnswerViewModel> picAnswers = QuestionnaireData.PicAnswerList
                                                                            .Where(a => a.Questionid == questionId)
                                                                            .OrderBy(a => a.OrderNo)
                                                                            .ToList();
                    question.PicAnswers = picAnswers;
                }
                else
                {
                    List<TxtAnswerViewModel> txtAnswers = QuestionnaireData.TxtAnswerList
                                                                           .Where(a => a.Questionid == questionId)
                                                                           .ToList();
                    question.TxtAnswers = txtAnswers;
                }
            }


            // check if question is already answered, load checked checkboxes

            var list = (List<QuestionViewModel>)Session["AnsweredData"];
            var currentQuestion = list?.SingleOrDefault(q => q.Id == questionId);

            if (currentQuestion != null)
            {
                question.TxtAnswers = currentQuestion.TxtAnswers;
                question.PicAnswers = currentQuestion.PicAnswers;
            }

            return View(question);
        }

        [HttpPost]
        public ActionResult LoadQuestion(QuestionViewModel question)
        {
            if (Session["AnsweredData"] == null)
            {
                Session["AnsweredData"] = new List<QuestionViewModel>();
                var list = (List<QuestionViewModel>)Session["AnsweredData"];
                list.Add(question);
            }
            else
            {
                var list = (List<QuestionViewModel>)Session["AnsweredData"];
                var currentQuestion = list.SingleOrDefault(q => q.Id == question.Id);

                list.Remove(currentQuestion);
                list.Add(question);
            }

            if (Request.Form["next"] != null)
            {
                return question.Id == 5 ? RedirectToAction("QuestionnaireResult")
                                        : RedirectToAction("LoadQuestion", new { id = question.Id + 1 });
            }

            return Request.Form["prev"] != null ? RedirectToAction("LoadQuestion", new { id = question.Id - 1 })
                                                : RedirectToAction("LoadQuestion");
        }


        [HttpGet]
        public ActionResult QuestionnaireResult()
        {

            if (Session["AnsweredData"] != null)
            {
                var answeredData = (List<QuestionViewModel>)Session["AnsweredData"];

                var result = QuestionnaireService.CalculateType(answeredData);

                return View(result);
            }
           return RedirectToAction("");
        }
    }
}