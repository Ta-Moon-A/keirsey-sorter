using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KeirseySorter.Models
{
    public class QuestionnaireData
    {
        public static Dictionary<KeirseyTypes, KeirseyTypeViewModel> ResultData { get; } = new Dictionary<KeirseyTypes, KeirseyTypeViewModel>
        {
            { KeirseyTypes.ENFP, new KeirseyTypeViewModel()
                                    {
                                     TypeDesc = "მებრძოლი desc",
                                     TypeName = "მებრძოლი"
                                    }
            },
            { KeirseyTypes.ENTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ფელდმარშალი desc",
                                      TypeName = "ფელდმარშალი"
                                    }
            },
            { KeirseyTypes.ENTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "გამომგონებელი desc",
                                     TypeName = "გამომგონებელი"
                                    }
            },
            { KeirseyTypes.ESFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მიმწოდებელი desc",
                                     TypeName = "მიმწოდებელი"
                                    }
            },
            { KeirseyTypes.ESFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "შემსრულებელი desc",
                                     TypeName = "შემსრულებელი"
                                    }
            },
            { KeirseyTypes.INFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მრჩეველი desc",
                                     TypeName = "მრჩეველი"
                                    }
            },
            { KeirseyTypes.ESTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ზედამხედველი desc",
                                     TypeName = "ზედამხედველი"
                                    }
            },
            { KeirseyTypes.ESTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მფარველი desc",
                                     TypeName = "მფარველი"
                                    }
            },
            { KeirseyTypes.ISFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "დამცველი desc",
                                     TypeName = "დამცველი"
                                    }
            },
            { KeirseyTypes.ISTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ინსპექტორი desc",
                                     TypeName = "ინსპექტორი"
                                    }
            },
            { KeirseyTypes.ISFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "კომპოზიტორი desc",
                                     TypeName = "კომპოზიტორი"
                                    }
            },
            { KeirseyTypes.ISTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ხელოსანი desc",
                                     TypeName = "ხელოსანი"
                                    }
            },
            { KeirseyTypes.INFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მკურნალი desc",
                                     TypeName = "მკურნალი"
                                    }
            },
            { KeirseyTypes.ENFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მასწავლებელი desc",
                                     TypeName = "მასწავლებელი"
                                    }
            },
            { KeirseyTypes.INTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "არქიტექტორი desc",
                                     TypeName = "არქიტექტორი"
                                    }
            },
            { KeirseyTypes.INTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "საიდუმლო ლიდერი desc",
                                     TypeName = "საიდუმლო ლიდერი"
                                    }
            }
        };

        public static QuestionViewModel[] QuestionList { get; } =
        {
            new QuestionViewModel() {Id = 1,OrderNo = 1,Text = "რომელი ანიმაციური ფილმის პერსონაჟთან გააიგივებდით საკუთარ თავს?",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 2,OrderNo = 2,Text = "რომელ ცნობილ ადამიანთან გააიგივებდით საკუთარ თავს?",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 3,OrderNo = 3,Text = "ამოირჩიეთ თქვენი საყვარელი ცხოველი",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 4,OrderNo = 4,Text = "ამოირჩიეთ თქვენთვის მისაღები ორნამენტი",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 5,OrderNo = 5,Text = "ამოირჩიეთ ფეისბუქ ატივობა",Type = QuestionTypes.TxtQuestion}
        };

        public static PicAnswerViewModel[] PicAnswerList { get; } =
            {
                new PicAnswerViewModel {Id = 1, OrderNo = 1, Questionid = 1,   KType = KeirseyTypes.ISTJ},
                new PicAnswerViewModel {Id = 2, OrderNo = 2, Questionid = 1,   KType = KeirseyTypes.ISFJ},
                new PicAnswerViewModel {Id = 3, OrderNo = 3, Questionid = 1,   KType = KeirseyTypes.INFJ},
                new PicAnswerViewModel {Id = 4, OrderNo = 4, Questionid = 1,   KType = KeirseyTypes.INTJ},
                new PicAnswerViewModel {Id = 29, OrderNo = 5, Questionid = 1,  KType = KeirseyTypes.ISTP},
                new PicAnswerViewModel {Id = 30, OrderNo = 6, Questionid = 1,  KType = KeirseyTypes.ISFP},
                new PicAnswerViewModel {Id = 31, OrderNo = 7, Questionid = 1,  KType = KeirseyTypes.INFP},
                new PicAnswerViewModel {Id = 32, OrderNo = 8, Questionid = 1,  KType = KeirseyTypes.INTP},
                new PicAnswerViewModel {Id = 33, OrderNo = 9, Questionid = 1,  KType = KeirseyTypes.ESTP},
                new PicAnswerViewModel {Id = 34, OrderNo = 10, Questionid = 1, KType = KeirseyTypes.ESFP},
                new PicAnswerViewModel {Id = 35, OrderNo = 11, Questionid = 1, KType = KeirseyTypes.ENFP},
                new PicAnswerViewModel {Id = 36, OrderNo = 12, Questionid = 1, KType = KeirseyTypes.ENTP},
                new PicAnswerViewModel {Id = 37, OrderNo = 13, Questionid = 1, KType = KeirseyTypes.ESTJ},
                new PicAnswerViewModel {Id = 38, OrderNo = 14, Questionid = 1, KType = KeirseyTypes.ESFJ},
                new PicAnswerViewModel {Id = 39, OrderNo = 15, Questionid = 1, KType = KeirseyTypes.ENFJ},
                new PicAnswerViewModel {Id = 40, OrderNo = 16, Questionid = 1, KType = KeirseyTypes.ENTJ},


                new PicAnswerViewModel {Id = 5, OrderNo = 1, Questionid = 2,   KType = KeirseyTypes.ESFJ},
                new PicAnswerViewModel {Id = 6, OrderNo = 2, Questionid = 2,   KType = KeirseyTypes.ISFJ},
                new PicAnswerViewModel {Id = 7, OrderNo = 3, Questionid = 2,   KType = KeirseyTypes.ESTJ},
                new PicAnswerViewModel {Id = 8, OrderNo = 4, Questionid = 2,   KType = KeirseyTypes.ISTJ},
                new PicAnswerViewModel {Id = 41, OrderNo = 5, Questionid = 2,  KType = KeirseyTypes.ESFP},
                new PicAnswerViewModel {Id = 42, OrderNo = 6, Questionid = 2,  KType = KeirseyTypes.ISFP},
                new PicAnswerViewModel {Id = 43, OrderNo = 7, Questionid = 2,  KType = KeirseyTypes.ESTP},
                new PicAnswerViewModel {Id = 44, OrderNo = 8, Questionid = 2,  KType = KeirseyTypes.ISTP},
                new PicAnswerViewModel {Id = 45, OrderNo = 9, Questionid = 2,  KType = KeirseyTypes.ENFP},
                new PicAnswerViewModel {Id = 46, OrderNo = 10, Questionid = 2, KType = KeirseyTypes.INFP},
                new PicAnswerViewModel {Id = 47, OrderNo = 11, Questionid = 2, KType = KeirseyTypes.ENFJ},
                new PicAnswerViewModel {Id = 48, OrderNo = 12, Questionid = 2, KType = KeirseyTypes.INFJ},
                new PicAnswerViewModel {Id = 49, OrderNo = 13, Questionid = 2, KType = KeirseyTypes.ENTP},
                new PicAnswerViewModel {Id = 50, OrderNo = 14, Questionid = 2, KType = KeirseyTypes.INTP},
                new PicAnswerViewModel {Id = 51, OrderNo = 15, Questionid = 2, KType = KeirseyTypes.ENTJ},
                new PicAnswerViewModel {Id = 52, OrderNo = 16, Questionid = 2, KType = KeirseyTypes.INTJ},



                new PicAnswerViewModel {Id = 9, OrderNo = 1, Questionid = 3,   KType = KeirseyTypes.INTP},
                new PicAnswerViewModel {Id = 10, OrderNo = 2, Questionid = 3,  KType = KeirseyTypes.ESTP},
                new PicAnswerViewModel {Id = 11, OrderNo = 3, Questionid = 3,  KType = KeirseyTypes.ISFP},
                new PicAnswerViewModel {Id = 12, OrderNo = 4, Questionid = 3,  KType = KeirseyTypes.ENTJ},
                new PicAnswerViewModel {Id = 53, OrderNo = 5, Questionid = 3,  KType = KeirseyTypes.ISFJ},
                new PicAnswerViewModel {Id = 54, OrderNo = 6, Questionid = 3,  KType = KeirseyTypes.INTJ},
                new PicAnswerViewModel {Id = 55, OrderNo = 7, Questionid = 3,  KType = KeirseyTypes.ISTP},
                new PicAnswerViewModel {Id = 56, OrderNo = 8, Questionid = 3,  KType = KeirseyTypes.ESFP},
                new PicAnswerViewModel {Id = 57, OrderNo = 9, Questionid = 3,  KType = KeirseyTypes.INFJ},
                new PicAnswerViewModel {Id = 58, OrderNo = 10, Questionid = 3, KType = KeirseyTypes.ENFP},
                new PicAnswerViewModel {Id = 59, OrderNo = 11, Questionid = 3, KType = KeirseyTypes.ESTJ},
                new PicAnswerViewModel {Id = 60, OrderNo = 12, Questionid = 3, KType = KeirseyTypes.ISTJ},
                new PicAnswerViewModel {Id = 61, OrderNo = 13, Questionid = 3, KType = KeirseyTypes.ENFJ},
                new PicAnswerViewModel {Id = 62, OrderNo = 14, Questionid = 3, KType = KeirseyTypes.INFP},
                new PicAnswerViewModel {Id = 63, OrderNo = 15, Questionid = 3, KType = KeirseyTypes.ENTP},
                new PicAnswerViewModel {Id = 64, OrderNo = 16, Questionid = 3, KType = KeirseyTypes.ESFJ},


                new PicAnswerViewModel {Id = 13, OrderNo = 1, Questionid = 4,  KType = KeirseyTypes.ESFJ},
                new PicAnswerViewModel {Id = 14, OrderNo = 2, Questionid = 4,  KType = KeirseyTypes.ISFJ},
                new PicAnswerViewModel {Id = 15, OrderNo = 3, Questionid = 4,  KType = KeirseyTypes.ESTJ},
                new PicAnswerViewModel {Id = 16, OrderNo = 4, Questionid = 4,  KType = KeirseyTypes.ISTJ},
                new PicAnswerViewModel {Id = 65, OrderNo = 5, Questionid = 4,  KType = KeirseyTypes.ESFP},
                new PicAnswerViewModel {Id = 66, OrderNo = 6, Questionid = 4,  KType = KeirseyTypes.ISFP},
                new PicAnswerViewModel {Id = 67, OrderNo = 7, Questionid = 4,  KType = KeirseyTypes.ESTP},
                new PicAnswerViewModel {Id = 68, OrderNo = 8, Questionid = 4,  KType = KeirseyTypes.ISTP},
                new PicAnswerViewModel {Id = 69, OrderNo = 9, Questionid = 4,  KType = KeirseyTypes.ENFP},
                new PicAnswerViewModel {Id = 70, OrderNo = 10, Questionid = 4, KType = KeirseyTypes.INFP},
                new PicAnswerViewModel {Id = 71, OrderNo = 11, Questionid = 4, KType = KeirseyTypes.ENFJ},
                new PicAnswerViewModel {Id = 72, OrderNo = 12, Questionid = 4, KType = KeirseyTypes.INFJ},
                new PicAnswerViewModel {Id = 73, OrderNo = 13, Questionid = 4, KType = KeirseyTypes.ENTP},
                new PicAnswerViewModel {Id = 74, OrderNo = 14, Questionid = 4, KType = KeirseyTypes.INTP},
                new PicAnswerViewModel {Id = 75, OrderNo = 15, Questionid = 4, KType = KeirseyTypes.ENTJ},
                new PicAnswerViewModel {Id = 76, OrderNo = 16, Questionid = 4, KType = KeirseyTypes.INTJ}
        };

        public static TxtAnswerViewModel[] TxtAnswerList { get; } =
          {
            new TxtAnswerViewModel {Id = 21,OrderNo = 1,  Questionid = 5, Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been",  KType = KeirseyTypes.ESFJ},
            new TxtAnswerViewModel {Id = 22,OrderNo = 2,  Questionid = 5, Text = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of  ",  KType = KeirseyTypes.ISFJ},
            new TxtAnswerViewModel {Id = 23,OrderNo = 3,  Questionid = 5, Text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered ",  KType = KeirseyTypes.ESTJ},
            new TxtAnswerViewModel {Id = 24,OrderNo = 4,  Questionid = 5, Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested",  KType = KeirseyTypes.ISTJ},
            new TxtAnswerViewModel {Id = 89,OrderNo = 5,  Questionid = 5, Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been",  KType = KeirseyTypes.ESFP},
            new TxtAnswerViewModel {Id = 90,OrderNo = 6,  Questionid = 5, Text = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of  ",  KType = KeirseyTypes.ISFP},
            new TxtAnswerViewModel {Id = 91,OrderNo = 7, Questionid = 5, Text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered ",  KType = KeirseyTypes.ESTP},
            new TxtAnswerViewModel {Id = 92,OrderNo = 8, Questionid = 5, Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested",  KType = KeirseyTypes.ISTP},
            new TxtAnswerViewModel {Id = 93,OrderNo = 9, Questionid = 5, Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been",  KType = KeirseyTypes.ENFP},
            new TxtAnswerViewModel {Id = 94,OrderNo = 10, Questionid = 5, Text = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of  ", KType = KeirseyTypes.INFP},
            new TxtAnswerViewModel {Id = 95,OrderNo = 11, Questionid = 5, Text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered ", KType = KeirseyTypes.ENFJ},
            new TxtAnswerViewModel {Id = 96,OrderNo = 12, Questionid = 5, Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested", KType = KeirseyTypes.INFJ},
            new TxtAnswerViewModel {Id = 97,OrderNo = 13, Questionid = 5, Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been", KType = KeirseyTypes.ENTP},
            new TxtAnswerViewModel {Id = 98,OrderNo = 14, Questionid = 5, Text = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of  ", KType = KeirseyTypes.INTP},
            new TxtAnswerViewModel {Id = 99,OrderNo = 15, Questionid = 5, Text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered ", KType = KeirseyTypes.ENTJ},
            new TxtAnswerViewModel {Id = 100,OrderNo = 16, Questionid = 5, Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested",KType = KeirseyTypes.INTJ},


            };
    }

    public enum QuestionTypes
    {
        PicQuestion = 1,
        TxtQuestion = 2
    }

    public enum KeirseyTypes
    {
        [Description("მიმწოდებელი")] //provider
        ESFJ = 1,

        [Description("დამცველი")] //protector
        ISFJ = 2,

        [Description("ზედამხედველი ")] //supervisor
        ESTJ = 3,

        [Description("ინსპექტორი")] // inspector
        ISTJ = 4,

        [Description("შემსრულებელი")] //performer
        ESFP = 5,

        [Description("კომპოზიტორი")] //composer
        ISFP = 6,

        [Description("მფარველი")] // promoter
        ESTP = 7,

        [Description("ხელოსანი")] //crafter
        ISTP = 8,

        [Description("მებრძოლი")] //champion
        ENFP = 9,

        [Description("მკურნალი ")] //healer
        INFP = 10,

        [Description("მასწავლებელი")] //teacher
        ENFJ = 11,

        [Description("მრჩეველი")] //counselor
        INFJ = 12,

        [Description(" გამომგონებელი")] //inventor
        ENTP = 13,

        [Description(" არქიტექტორი")] //architect
        INTP = 14,

        [Description("ფელდმარშალი")] //fieldmarshal
        ENTJ = 15,

        [Description("საიდუმლო ლიდერი")] // mastermind
        INTJ = 16
    }




}