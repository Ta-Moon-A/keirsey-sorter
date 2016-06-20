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
                                     TypeDesc = "სწრაფად ფეთქებადი, მგრძნობიარე და თავისი საქმის მიმართ თავდადებული. უხეში და არასტანდარტული. ყველაფერს გააკეთებს მიზნის მისაღწევად. ",
                                     TypeName = "მებრძოლი"
                                    }
            },
            { KeirseyTypes.ENTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მტკიცე, ანალიტიკური და ბუნებრივი სოცლიალური დომინანტი.",
                                      TypeName = "მეთაური"
                                    }
            },
            { KeirseyTypes.ENTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ასეთი პიროვნებები შესაძლებლობებს აბსოლიტურად ყველგან ხედავენ და არც ერთ იდეას არ მიიჩნევენ იმდენად რთულად, რომ მისი განხორციელება ვერ შეძლონ. მათი სწრაფი გონება და სახასიათო ბუნება ყოველთვის იხსნის იმ პრობლემებისგან, რომელშიც ხშირად ყოფენ  ხოლმე თავს.",
                                     TypeName = "გამომგონებელი"
                                    }
            },
            { KeirseyTypes.ESFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "თავდაუზოგავი, მშფოთვარე და საყვარელი ადამიანებისთვის უზომოდ თავდადებული. ყველაზე მეტად სურს, რომ ადმაიანები, რომლებზეც ზრუნავს ბედნიერები და ჯანმრთელები იყვნენ. ",
                                     TypeName = "მიმწოდებელი"
                                    }
            },
            { KeirseyTypes.ESFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ადაპტური, აწმყოზე ორიენტირებული და ზოგჯერ სრულიად გაუბედავი. მიუხედავად იმისა, რომ სიმამაცე ყოველთვის არ არის ამ პიროვნების წარმომჩენი თვისება, ის მაინც მზად არის გვერდით გადადოს თავისი  შიშები, როცა ეს მის საყავრელ ადამიანებს სჭირდებათ. ",
                                     TypeName = "შემსრულებელი"
                                    }
            },
            { KeirseyTypes.INFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ბრძენია, დამკვირვებელი და შეუძლია ადვილად  გამოიცნოს სხისი ქმედების მოტივი. ის ძალიან ანალიტიკურია მაშინ, როცა სიმართლისა და სიცრუის ერთმანეთისგან გამიჯვნა უწევს. ",
                                     TypeName = "მრჩეველი"
                                    }
            },
            { KeirseyTypes.ESTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ძლიერი, მკაცრი და საყვარელი ადამიანების დამცველი. ის ყველა გადაწვეტილებას ლოგიკასა და ლოიალურობაზე დაყრდნობით იღებს - ეს ის ორი პრინციპია, რომელიც მის ცხოვრებას მართავს.",
                                     TypeName = "ზედამხედველი"
                                    }
            },
            { KeirseyTypes.ESTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "კომუნიკაბელური, ათლეტური და ქმედებაზე ორიენტირებული პიროვნება. ",
                                     TypeName = "მფარველი"
                                    }
            },
            { KeirseyTypes.ISFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მორჩილი, მზრუნველი და უზომოდ თავგანწირული იმ ადამიანების მიმართ, ვისი მორალისადმიც რწმენაც აქვს. ასეთი პიროვნება ორიენტირებულია დაეხმაროს მისთის საყვარელ ადამიანებს და ბედნიერია ამით.",
                                     TypeName = "დამცველი"
                                    }
            },
            { KeirseyTypes.ISTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "პრინციპული, მტკიცე და უანგაროდ თავგანწირული სამართლიანობისთვის. ის უბრალო ადამიანია, არ  უყვარს ყურადღების ცენტრში ყოფნა.   შეუძლია წავიდეს ნებისმიერ რისკზე იმის დასაცავად, რაც მისთვის სამართლიანია.",
                                     TypeName = "ინსპექტორი"
                                    }
            },
            { KeirseyTypes.ISFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მოსიყვარულე, მზრუნველი  და თავდადებული. რეალურად, ის საკუთარ თავზე ჩაფიქრებული ადამიანია და მარტო ცხოვრება ყველაზე მეტად მას შეესაბამება. ",
                                     TypeName = "კომპოზიტორი"
                                    }
            },
            { KeirseyTypes.ISTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "კოორდინირებული, რაციონალური და გარესამყაროს სისტემის კარგი ამთვისებელი. აქვს მიდრეკილება წესების დარღვევისა და ფიზიკური დაბრკოლებების დაძლევისა.",
                                     TypeName = "ხელოსანი"
                                    }
            },
            { KeirseyTypes.INFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "რომატიული, გამჭრიახი და ამთვისებელი იმ კავშირებისა, რომლებსაც სხვები გაურბიან.  ძლიერი, უშიშარი და ლოიალური,  როცა საჭიროება მოითხოვს.",
                                     TypeName = "მკურნალი"
                                    }
            },
            { KeirseyTypes.ENFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "გულღია, ემპათიური და უბრალო, მას ნამდვიულად დამრიგებლური ხასიათი აქვს. ასეთ პიროვნებას შეუძლია კარგი დაინახოს ადამიანებში და თავი გასწიროს მათთვის  - არის ფრიად კაცთმოყვარე.",
                                     TypeName = "მასწავლებელი"
                                    }
            },
            { KeirseyTypes.INTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "დამცველი, ანალიტიკური და დაუღალავად ფილოსოფიური. ის ნებისმიერი გადაწყვეტილებისთვის ლოგიკას იშველიებს და სასოწარკვეთა იპყრობს, როცა ლოგიკას არ ექვემდებარება სიტუაცია. ",
                                     TypeName = "არქიტექტორი"
                                    }
            },
            { KeirseyTypes.INTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ამ ტიპს მიეკუთნება მკაცრი და ცივი ადამიანი, თუმცა მიუხედავად ცივი და თავშეკავებული ბუნებისა, ისინი ზოგჯერ შეიძლება იყვნენ ძალზედ ლოიალურები. ინტიუციური და ფარულად მოქმედი პიროვნება.",
                                     TypeName = "საიდუმლო ლიდერი"
                                    }
            }
        };

        public static QuestionViewModel[] QuestionList { get; } =
        {
            new QuestionViewModel() {Id = 1,OrderNo = 1,Text = "რომელი ანიმაციური ფილმის პერსონაჟ(ებ)თან გააიგივებდით საკუთარ თავს?",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 2,OrderNo = 2,Text = "რომელ ცნობილ ადამიან(ებ)თან გააიგივებდით საკუთარ თავს?",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 3,OrderNo = 3,Text = "ამოირჩიეთ თქვენი საყვარელი ცხოველ(ებ)ი",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 4,OrderNo = 4,Text = "ამოირჩიეთ თქვენთვის მისაღები ორნამენტ(ებ)ი",Type = QuestionTypes.PicQuestion},
            new QuestionViewModel() {Id = 5,OrderNo = 5,Text = "ამოირჩიეთ თქვენთვის მისაღები ფეისბუქ აქტივობა(ები)",Type = QuestionTypes.TxtQuestion}
        };

        public static PicAnswerViewModel[] PicAnswerList { get; } =
            {
                new PicAnswerViewModel {Id = 1, OrderNo = 1, Questionid = 1,   KType = KeirseyTypes.ISTJ, PicDescription = "მზეთუნახავი და ურჩხული"},
                new PicAnswerViewModel {Id = 2, OrderNo = 2, Questionid = 1,   KType = KeirseyTypes.ISFJ, PicDescription = "კონკია "},
                new PicAnswerViewModel {Id = 3, OrderNo = 3, Questionid = 1,   KType = KeirseyTypes.INFJ, PicDescription = "პოკაჰონდასი "},
                new PicAnswerViewModel {Id = 4, OrderNo = 4, Questionid = 1,   KType = KeirseyTypes.INTJ, PicDescription = "გაყინული "},
                new PicAnswerViewModel {Id = 29, OrderNo = 5, Questionid = 1,  KType = KeirseyTypes.ISTP, PicDescription = " ???? "},
                new PicAnswerViewModel {Id = 30, OrderNo = 6, Questionid = 1,  KType = KeirseyTypes.ISFP, PicDescription = "მეფე ლომი"},
                new PicAnswerViewModel {Id = 31, OrderNo = 7, Questionid = 1,  KType = KeirseyTypes.INFP, PicDescription = "მზეთუნახავი და ურჩხული"},
                new PicAnswerViewModel {Id = 32, OrderNo = 8, Questionid = 1,  KType = KeirseyTypes.INTP, PicDescription = "ვინი პუჰი"},
                new PicAnswerViewModel {Id = 33, OrderNo = 9, Questionid = 1,  KType = KeirseyTypes.ESTP, PicDescription = "რაპუნცელი"},
                new PicAnswerViewModel {Id = 34, OrderNo = 10, Questionid = 1, KType = KeirseyTypes.ESFP, PicDescription = "რობინ ჰუდი"},
                new PicAnswerViewModel {Id = 35, OrderNo = 11, Questionid = 1, KType = KeirseyTypes.ENFP, PicDescription = "ალადინი "},
                new PicAnswerViewModel {Id = 36, OrderNo = 12, Questionid = 1, KType = KeirseyTypes.ENTP, PicDescription = "კარიბის ზღვის მეკობრეები"},
                new PicAnswerViewModel {Id = 37, OrderNo = 13, Questionid = 1, KType = KeirseyTypes.ESTJ, PicDescription = "რაპუნცელი"},
                new PicAnswerViewModel {Id = 38, OrderNo = 14, Questionid = 1, KType = KeirseyTypes.ESFJ, PicDescription = "მერი პოპინსი"},
                new PicAnswerViewModel {Id = 39, OrderNo = 15, Questionid = 1, KType = KeirseyTypes.ENFJ, PicDescription = "მეფე ლომი"},
                new PicAnswerViewModel {Id = 40, OrderNo = 16, Questionid = 1, KType = KeirseyTypes.ENTJ, PicDescription = "მულანი"},


                new PicAnswerViewModel {Id = 5, OrderNo = 1, Questionid = 2,   KType = KeirseyTypes.ESFJ, PicDescription = "მომღერალი: უიტნი ჰიუსტონი"},
                new PicAnswerViewModel {Id = 6, OrderNo = 2, Questionid = 2,   KType = KeirseyTypes.ISFJ, PicDescription = "მსახიობი: ბრიუს უილისი"},
                new PicAnswerViewModel {Id = 7, OrderNo = 3, Questionid = 2,   KType = KeirseyTypes.ESTJ, PicDescription = "ბიზნესმენი: ჰენრი ფორდი"},
                new PicAnswerViewModel {Id = 8, OrderNo = 4, Questionid = 2,   KType = KeirseyTypes.ISTJ, PicDescription = "ფსიქოლოგი: ზიგმუნდ ფროიდი"},
                new PicAnswerViewModel {Id = 41, OrderNo = 5, Questionid = 2,  KType = KeirseyTypes.ESFP, PicDescription = "მწერალი: პაულო კოელიო"},
                new PicAnswerViewModel {Id = 42, OrderNo = 6, Questionid = 2,  KType = KeirseyTypes.ISFP, PicDescription = "მომღერალი: მაიკლ ჯექსონი"},
                new PicAnswerViewModel {Id = 43, OrderNo = 7, Questionid = 2,  KType = KeirseyTypes.ESTP, PicDescription = "მსახიობი: მერილ სტრიპი"},
                new PicAnswerViewModel {Id = 44, OrderNo = 8, Questionid = 2,  KType = KeirseyTypes.ISTP, PicDescription = "გამომგონებელი: სტივ ჯობსი"},
                new PicAnswerViewModel {Id = 45, OrderNo = 9, Questionid = 2,  KType = KeirseyTypes.ENFP, PicDescription = "მხატვარი: სალვადორ დალი"},
                new PicAnswerViewModel {Id = 46, OrderNo = 10, Questionid = 2, KType = KeirseyTypes.INFP, PicDescription = "მხატვარი: ვინსენტ ვან გოგი"},
                new PicAnswerViewModel {Id = 47, OrderNo = 11, Questionid = 2, KType = KeirseyTypes.ENFJ, PicDescription = "მწერალი: იოჰან ვოლფგანგ გოეთე"},
                new PicAnswerViewModel {Id = 48, OrderNo = 12, Questionid = 2, KType = KeirseyTypes.INFJ, PicDescription = "მწერალი: თედორე დოსტოევსკი"},
                new PicAnswerViewModel {Id = 49, OrderNo = 13, Questionid = 2, KType = KeirseyTypes.ENTP, PicDescription = "პოლიტიკოსი: ბარაკ ობამა"},
                new PicAnswerViewModel {Id = 50, OrderNo = 14, Questionid = 2, KType = KeirseyTypes.INTP, PicDescription = "მეცნიერი: ალბერტ აინშტაინი"},
                new PicAnswerViewModel {Id = 51, OrderNo = 15, Questionid = 2, KType = KeirseyTypes.ENTJ, PicDescription = "ბიზნესმენი: უილიამ ბილ გეიტსი"},
                new PicAnswerViewModel {Id = 52, OrderNo = 16, Questionid = 2, KType = KeirseyTypes.INTJ, PicDescription = "ბიზნესმენი: მარკ ცუკერბერგი "},



                new PicAnswerViewModel {Id = 9, OrderNo = 1, Questionid = 3,   KType = KeirseyTypes.INTP, PicDescription = "ბუ"},
                new PicAnswerViewModel {Id = 10, OrderNo = 2, Questionid = 3,  KType = KeirseyTypes.ESTP, PicDescription = "მელია "},
                new PicAnswerViewModel {Id = 11, OrderNo = 3, Questionid = 3,  KType = KeirseyTypes.ISFP, PicDescription = "ზანტი"},
                new PicAnswerViewModel {Id = 12, OrderNo = 4, Questionid = 3,  KType = KeirseyTypes.ENTJ, PicDescription = "ლომი"},
                new PicAnswerViewModel {Id = 53, OrderNo = 5, Questionid = 3,  KType = KeirseyTypes.ISFJ, PicDescription = "შველი "},
                new PicAnswerViewModel {Id = 54, OrderNo = 6, Questionid = 3,  KType = KeirseyTypes.INTJ, PicDescription = "რვაფეხა "},
                new PicAnswerViewModel {Id = 55, OrderNo = 7, Questionid = 3,  KType = KeirseyTypes.ISTP, PicDescription = "კატა "},
                new PicAnswerViewModel {Id = 56, OrderNo = 8, Questionid = 3,  KType = KeirseyTypes.ESFP, PicDescription = "წავი"},
                new PicAnswerViewModel {Id = 57, OrderNo = 9, Questionid = 3,  KType = KeirseyTypes.INFJ, PicDescription = "მგელი"},
                new PicAnswerViewModel {Id = 58, OrderNo = 10, Questionid = 3, KType = KeirseyTypes.ENFP, PicDescription = "დელფინი"},
                new PicAnswerViewModel {Id = 59, OrderNo = 11, Questionid = 3, KType = KeirseyTypes.ESTJ, PicDescription = "ფუტკარი"},
                new PicAnswerViewModel {Id = 60, OrderNo = 12, Questionid = 3, KType = KeirseyTypes.ISTJ, PicDescription = "თახვი"},
                new PicAnswerViewModel {Id = 61, OrderNo = 13, Questionid = 3, KType = KeirseyTypes.ENFJ, PicDescription = "ძაღლი "},
                new PicAnswerViewModel {Id = 62, OrderNo = 14, Questionid = 3, KType = KeirseyTypes.INFP, PicDescription = "მანგუსტი"},
                new PicAnswerViewModel {Id = 63, OrderNo = 15, Questionid = 3, KType = KeirseyTypes.ENTP, PicDescription = "თუთიყუში "},
                new PicAnswerViewModel {Id = 64, OrderNo = 16, Questionid = 3, KType = KeirseyTypes.ESFJ, PicDescription = "სპილო"},


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
            new TxtAnswerViewModel {Id = 21,OrderNo = 1,  Questionid = 5, Text = "რამდენიმე წლის განმავლობაში პერიოდულად ტვირთავს თავისი ქორწილის ფოტოებს",  KType = KeirseyTypes.ESFJ},
            new TxtAnswerViewModel {Id = 22,OrderNo = 2,  Questionid = 5, Text = "მორჩილად ალაიქებს ყველა თქვენ სტატუსს, რომელსაც ბოლო 10 წუთის განმავლობაში არ გამოუწვევია სხვების რეაქცია.",  KType = KeirseyTypes.ISFJ},
            new TxtAnswerViewModel {Id = 23,OrderNo = 3,  Questionid = 5, Text = "პროფილის ფოტოდ უყენია სურათი, რომელზეც ჩანს მხოლოდ მისი სახე, თითქოს ამ ფოტოს ხედავდეს მხოლოდ მისი პოტენციური დამქირავებელი.",  KType = KeirseyTypes.ESTJ},
            new TxtAnswerViewModel {Id = 24,OrderNo = 4,  Questionid = 5, Text = "პოსტავს ინტერნეტში აღმოჩენილ ბევრ სარკასტულ ფოტოს, რომელიც გამოხატავს კაცობრიობის  საქციელით გამოწვეულ მის იმედგაცრუებას",  KType = KeirseyTypes.ISTJ},
            new TxtAnswerViewModel {Id = 89,OrderNo = 5,  Questionid = 5, Text = "აგზავნის სხვადასხვა უცნაური წვეულების მოსაწვევებს განუწყვეტლივ რეჟიმში.",  KType = KeirseyTypes.ESFP},
            new TxtAnswerViewModel {Id = 90,OrderNo = 6,  Questionid = 5, Text = "დღეში იმაზე მეტ  self ფოტოს იღებს, ვიდრე თქვენ მთელი ცხოვრების მანძილზე გადაგიღიათ.",  KType = KeirseyTypes.ISFP},
            new TxtAnswerViewModel {Id = 91,OrderNo = 7, Questionid = 5, Text = "საკუთარ თავს ნიშნავს  მთვრალ მდგომარეობაში ბევრ ფოტოზე, რაც იწვევს ნათესავების  და ნაცნობების აღშფოთებას.",  KType = KeirseyTypes.ESTP},
            new TxtAnswerViewModel {Id = 92,OrderNo = 8, Questionid = 5, Text = "დღის განმავლობაში რამდენჯერმე გიწვევს 'ქენდი ქრაშის სათამაშოდ' , მიუხედავად იმისა, რომ ბოლო რამდენიმე წლის განმავლობაში არცერთხელ გაგიხსნია მისი ლინკი.",  KType = KeirseyTypes.ISTP},
            new TxtAnswerViewModel {Id = 93,OrderNo = 9, Questionid = 5, Text = "ენთუზიაზმით ცვლის თავისი ოჯახური მდგომარეობის/ადგილმდებარეობის/კარიერაში წინსვლის შესახებ ინფორმაციიას ყოველ 2-3 თვეში ერთხელ და იღებს ასობით ლაიქს.",  KType = KeirseyTypes.ENFP},
            new TxtAnswerViewModel {Id = 94,OrderNo = 10, Questionid = 5, Text = "არჩევანს აკეთებს თავის მეგობრებთან გადაღებული მხიარულ ფოტოს დადებასა და ადამიანის უფლებების დაცვასთან დაკავშირებულ პოსტის  დადებას შორის", KType = KeirseyTypes.INFP},
            new TxtAnswerViewModel {Id = 95,OrderNo = 11, Questionid = 5, Text = "პოსტავს უამრავ სტატუსს ისეთი ტექსტით, რომელზეც სავარაუდოდ კითხავ რას ნიშნავს.", KType = KeirseyTypes.ENFJ},
            new TxtAnswerViewModel {Id = 96,OrderNo = 12, Questionid = 5, Text = "ხშირად პოსტავს  სხვადასხვა ცნობილი ადამიანის გამონათქვამს.", KType = KeirseyTypes.INFJ},
            new TxtAnswerViewModel {Id = 97,OrderNo = 13, Questionid = 5, Text = "ყველა პოსტზე შეუძლია იკამათოს ყოველგვარი მიზეზის გარეშე.", KType = KeirseyTypes.ENTP},
            new TxtAnswerViewModel {Id = 98,OrderNo = 14, Questionid = 5, Text = "არაფერი დაუპოსტავს წლების განმავლობაში, მაგრამ სავარაუდოა რომ თითქმის ყველაფერს კითხულობს და თვალს ადევნებს.", KType = KeirseyTypes.INTP},
            new TxtAnswerViewModel {Id = 99,OrderNo = 15, Questionid = 5, Text = "ჩექინდება  ძალიან ბევრ ივენთზე და ნიშნავს თავს ყველა სურათზე.", KType = KeirseyTypes.ENTJ},
            new TxtAnswerViewModel {Id = 100,OrderNo = 16, Questionid = 5, Text = "პოსტავს  ცხოვრებისეულ სიახლეებს 3-5 დღის ინტერვალით. ფოტოებს ტვირთავს ძალიან იშვიათად, მხოლოდ იმ შემთხვევებში, როდესაც ფბ ამას ავტომატურად აკეთებს",KType = KeirseyTypes.INTJ},


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

        [Description("მეთაური")] //fieldmarshal
        ENTJ = 15,

        [Description("საიდუმლო ლიდერი")] // mastermind
        INTJ = 16
    }




}