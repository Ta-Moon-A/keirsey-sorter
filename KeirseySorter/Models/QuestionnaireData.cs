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
                                     TypeDesc = "აღაფრთოვანებთ ახალი გარემოებები. უყვართ სიცოცხლე და ცდილობენ მიიღონ მისგან მაქსიმალური. ცხოვრების მანძილზე შეუძლიათ მოსინჯონ ძალები რამოდენიმე პროფესიაში. არიან გულწრფელად თბილები და დაინტერესებულნი ადამიანის პიროვნებით. განიცდიან მუდმივ მოთხოვნილებას იყვნენ გარშემომყოფთათვის მოსაწონნი. შესაძლოა იყვნენ მიდრეკილნი სენტიმენტალურობისკენ, პირფერობისკენ, უჩნდებათ სურვილი იყვნენ აღიარებულნი. შეუძლია ხანმოკლე ურთიერთობით, ინტუიტიურად შეიცნოს ადამიანები. ყოველდღიური ცხოვრების დეტალებს აღიქვამენ, როგორც უსიამოვნო წვრილმანებს. ცუდად გრძნობენ თავს თუ ზღუდავთ მკაცრი გრაფიკი და ყოველდღიური მოვალეობები. ხშირად განიცდიან დაძაბულობას, რადგან არიან ყურადღებიანები და გამუდმებით აკვირდებიან გარემოებას.",
                                     TypeName = "მებრძოლი"
                                    }
            },
            { KeirseyTypes.ENTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მეგობრული, პატიოსანი და ლოგიკურები. მკაცრად მომთხოვნები საკუთარი თავისა და გარშემომყოფების მიმართ. ხელიდან არ უშვებენ თავისი კომპეტენტურობის დემონსტრაციის შანსს. აქვთ ბრწყინვალე შესაძლებლობა აღმოაჩინონ რთულად ორგანიზებადი პრობლემების გადაწყვეტის გზა. ჭკვიანები და კარგად ინფორმირებულები. როგორც წესი, გააჩნიათ შესანიშნავი უნარი ფართო აუდიტორიის წინაშე საუბრის. აქვთ მოთხოვნილება გაუკეთონ ანალიზი ხალხს და მსოფლიოში მიმდინარე მოვლენებს. დაბადებულები არიან ლიდერებად. სახავენ გეგმებს და მოქმედებენ სტრატეგიულად. გააჩნიათ კარგი ინტუიციის გრძნობა. უპირატესობას ანიჭებენ ორგანიზებულ ცხოვრებას, ისინი მკაცრად მიიწევენ თავიანთი მიზნისკენ   და სხვებსაც აქეზებენ დასახული მიზნების შესრულებისაკენ.",
                                      TypeName = "მეთაური"
                                    }
            },
            { KeirseyTypes.ENTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მეგობრულები, მომხიბვლელები, კონტაქტურები,  მიხვედრილები, ენერგიულები, გამომგონებლები და კრეატიულები. ცნობისმოყვარეები, მოხერხებულები და არაპროგნოზირებადნი. ლოგიკურები და ანალიტიკურები. ხასიათდებიან ფართო აზროვნების უნარით. სიამოვნებას იღებენ დებატებში მონაწილეობით და თვლიან, რომ საუკეთესონი არიან ამ სფეროში. ინტერესდებიან ყველაფერ ახლით, იდეებით, ხალხით, ახალი საქმიანობით. ეძებენ მოდელებს და არსს გარემომცველ სამყაროში, უჩნდებათ მოთხოვნილება გარე მოვლენების ანალიზის. როგორც წესი ამ ტიპის ადამიანები ხასიათდებიან ენერგიულობით, ცხოვრობენ სპონტანური ცხოვრებით და არიან ენთუზიაზმით სავსე.",
                                     TypeName = "გამომგონებელი"
                                    }
            },
            { KeirseyTypes.ESFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "უყვართ ხალხი და მათთან ურთიერთობა. შეუძლიათ კარგად ამოიცნონ გარშემომყოფები, მათი შეხედულებები.თავის მოვალეობებს ეკიდებიან ძალიან სერიოზულად და არიან სანდოები. მათ სჭირდებათ გარშემომყოფების კეთილგანწობა, რომ თავი კარგად იგრძნონ. მათზე ცუდად მოქმედებს გულგრილობა. როგორც წესი ისინი არიან მიღებულები ხალხში, ასევე ხალხის ძალიან კარგი მანიპულატორები. მაგრამ მათ არ გააჩნიათ ინტუიციის გრძნობა რომ განსაზღვრონ რა მოყვება მათ ამათუიმ ქმედებას. სიამოვნებას იღებენ წესრიგის დამყარებით. არიან ტრადიციონალისტები და ამჯობინებენ ნაცადი მეთოდების გამოყენებას.",
                                     TypeName = "მიმწოდებელი"
                                    }
            },
            { KeirseyTypes.ESFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "კომუნიკაბელურები, აქტიურები, თბილები, იმპულსურები, ცნობისმოყვარეები, მგრძნობიარეები, მზრუნველები და ყველა სფეროში გარკვეულები. არ უყვართ თეორია და ობიექტური ანალიზი. უყვართ სხვების დახმარება და  საზოგადოების ყურადღების ცენტრში ყოფნა. დიდი ენთუზიაზმით აკვირდებიან მსოფლიოში მიმდინარე მოვლენებს. ისინი გაუთავებლად ისწრაფიან ახალი წამოწყებებისკენ. არიან ძალიან მზრუნველები და ამ მზრუნველობას გამოხატავენ ხალხისადმი თბილი დამოკიდებულებით. როგორ წესი არიან ენერგიულები და მარტივად ადაპტირებადი რეალისტები, რომლებიც ამჯობინებენ განიცადონ და მიიღონ ცხოვრება ისეთი როგორიც არის, ვიდრე თვითონ დაგეგმონ ის.",
                                     TypeName = "შემსრულებელი"
                                    }
            },
            { KeirseyTypes.INFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "დიდ მნიშვნელობას ანიჭებენ სიფრთხილეს და სისტემატიურობას. მოვლენებს აღიქვამენ ინტუიტიურად მიზეზების დადგენისა და დეტალების ცოდნის გარეშე. ვერ იტანენ კონფლიქტებს.  ყველაზე მეტად ენდობიან საკუთარ ინსტინქტებს, რამაც შესაძლოა გამოიწვიოს მათი სიჯიუტე და გარეშემომყოფთა აზრის იგნორირება. დარწმუნებულები არიან თავიანთ სიმართლეში. მათ სჯერათ მუდმივი პიროვნული ზრდის აუცილებლობის. წარმატებებს აღწევენ ისეთ სამსახურებში, სადაც შეუძლიათ გამოავლინონ შემოქმედებითი ნიჭი და იყვნენ დამოუკიდებლები. აქვთ ბუნებრივი მისწრაფება ხელოვნების მიმართ. ბევრი მათგანი გამოავლენს საკუთარ შესაძლებლობებს მეცნიერებაში, სადაც იყენებს საკუთარ ინტუიციას. ასევე კარგად გამოსდის მუშაობა მომსახურების სფეროში. არცთუ ისე ყურადღებიანია წვრილმანების და დეტალების მიმართ.",
                                     TypeName = "მრჩეველი"
                                    }
            },
            { KeirseyTypes.ESTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ცხოვრობენ ფაქტებისა და კონკრეტული მოხთოვნების სამყაროში. მუდმივად აკონტროლებენ გარესამყაროს, რათა იყვნენ დარწმუნებულები, რომ ყველაფერი მიდის გეგმის მიხედვით. პატივს სცემენ წესებსა და კანონებს. ამასვე მოითხოვენ გარშემომყოფებისგან. მატივად პოულობენ გამოსავალს სიტუაციებიდან, ამიტომ ხშირად იღებენ საკუთარ თავზე დიდ  პასუხისმგებლობას. ხალხთან ურთიერთობა ანიჭებთ სიამოვნებას და უყვართ გართობა. ისინი დიდ მნიშვნელობას ანიჭებენ, როგორც საკუთარ მოსაზრებებს, ასევე სერიოზულად ეკიდებიან გარშემომყოფების აზრებსაც. სტრესულ სიტუაციებში ხდებიან ჩაკეტილები. ვერ გამოხატავენ ემოციებს და უჭირთ ურთიერთობა. სამართლიანები, პრაქტიკულები, რეალისტები და სანდო პიროვნებები.",
                                     TypeName = "ზედამხედველი"
                                    }
            },
            { KeirseyTypes.ESTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "არიან კომუნიკაბელურები და აქტიური პიროვნებები. უხეშები, პირდაპირები და რისკის მოყვარულები. ისინი აკვირდებიან წვრილმანებს. როგორც წესი შესანიშნავად ყვებიან ისტორიებს და უკეთებენ იმპროვიზირებას. მათთვის დამახასიათებელია გააკეთონ საქმე ისე, როგორც იმ მომენტში ფიქრობენ და არა გეგმის მიხედვით. უყვართ გართობა და მოსწონთ როდესაც ირგვლივ არის მხიარული ხალხი. გადაწყვეტილების მიღებისას არ ითვალისწინებენ ხალხის აზრს, მოქმედებენ ფაქტებზე დაყრდნობით. ყველაზე ნაკლებად განვითარებული აქვთ ინტიუციური მხარე. ორიენტირებულები არიან ქმედებაზე. პრობლემების გადაწყვეტა შეუძლიათ ძალიან სწრაფად. მათ გააჩნიათ საქმის წამოწყების არაჩვეულებრივი ნიჭი. უჭირთ წამოწყებული საქმის გაგრძელება და შეუძლიათ დაუტოვონ ის სხვას. ",
                                     TypeName = "მფარველი"
                                    }
            },
            { KeirseyTypes.ISFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ისინი თბილები და კეთილები არიან. აფასებენ ჰარმონიულ ურთიერთობებს და გაგებით ეკიდებიან სხვების გრძნობებს. აქვთ შესანიშნავი მახსოვრობა. ისინი აფასებენ უსაფრთხოებას და სიკეთეს, პატივს სცემენ წესებსა და ტრადიციებს. გამოცდილებიდან უკეთ სწავლობენ ვიდრე წიგნებიდან. აქედან გამომდინარე, როგორც წესი ისინი არ მუშაობენ ისეთ ადგილებში სადაც მოეთხოვებათ თეორია. მათ აქვთ ძალიან კარგი გემოვნება. მათგან გამოდიან კარგი ინტერიერის დიზაინერები. კარგი გემოვნების საშუალებით ყოველთვის სწორად არჩევენ საჩუქრებს.მათ  გააჩნიათ პასუხისმგებლობის დიდი გრძნობა. უჭირთ არას თქმა, როდესაც მათ რაიმეს სთხოვენ. არაჰარმონიული ურთიერთობების ან პირდაპირი კრიტიკის შემთხვევაში ისინი ითრგუნებიან და კარგავენ საკუთარი თავის რწმენას.",
                                     TypeName = "დამცველი"
                                    }
            },
            { KeirseyTypes.ISTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "არიან ჩუმი და თავშეკავებული პიროვნებები. უყვართ უსაფრთხოება და მშვიდი ცხოვრება. ორგანიზებულები და მოთოდურები. მათ გააჩნიათ შეუდარებელი იუმორის გრძნობა.კანონებისა და ტრადიციების დაცვისაკენ მიმართულები გარეშემომყოფებისგანაც იგივეს მოელიან. ყოველთვის ასრულებს დანაპირებს. დიდ ყურადღებას აქცევს ფაქტებს, ამიტომ მეხსიერებაში ინახავს უამრავ მოვლენებს და წვრილმანებს. ყურადღებიანები არიან ახლობლების მიმართ, თუმცა არ უყვართ სიყვარულის გამოხატვა, გრძნობების გამოხატვას ამჯობინებენ საქციელით.გააჩნიათ გასაოცარი უნარი მიიღონ რაიმე დავალება, გაუწიონ ორგანიზება  და შეასრულონ ის ბოლომდე.სტრესულ სიტუაციებში საქმის გაფუჭების შიშმა შეიძლება ჩააგდოთ  დეპრესიაში.",
                                     TypeName = "ინსპექტორი"
                                    }
            },
            { KeirseyTypes.ISFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მორიდებულები და ძალიან მგრძნობიარეები, ჩაფიქრებულები, თავგანწირულები და ახლობლებთან სათუთები. კრიტიკისადმი მგრძნობიარეები. მათი წყენინება ძალიან  მარტივია. მარტივად ადაპტირებადი, ცნობისმოყვარე, რეალისტები, სერიოზულები, შთამბეჭდავები და კეთილები.  არ უყვართ კონფლიქტები და ცდილობენ თავი აარიდონ ისეთ ქმედებებს, რომლებსაც შეუძლიათ კამათის გამოწვევა. მათი ცხოვრების წესი მრავალფეროვანია, ხან ძალიან მშვიდი, ხან კი დაუფიქრებელი და სპონტანური. მათთვის დამახასიათებელია მზურველობის გამოხატვა შესამჩნევი ფორმით, რადგან ისინი ამჯობინებენ მოქმედებას სიტყვებით. გარშემომყოფები უპირველესად მათში ამჩნევენ შემდეგ თვისებებს: მარტივად ადაპტირებადობას, რეალიზმს და სპონტანურობას.",
                                     TypeName = "კომპოზიტორი"
                                    }
            },
            { KeirseyTypes.ISTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ამ ტიპის ადამიანები ძლიერები არიან ლოგიკურ ანალიზში და დიდი მონდომებით იყენებენ მას პრაქტიკულ სიტუაციებში. უყვართ ადრენალინი, იზიდავთ მოტოციკლეტები, თვითმფრინავები, გადმოხტომა პარაშუტით, სერფინგი და სხვა. რუტინულ სიტუაციებში მალე იწყენენ. მიუხედავად იმისა, რომ არ ემორჩილებიან ,,სისტემის” წესებსა და კანონებს, მათ ყოველთვის აქვთ თავისი წესები. საკუთარ თავში გასარკვევად სჭირდებათ დროის მარტო გატარება. სწრაფად და მიუკერძოებლად იღებენ გადაწყვეტილებებს. არ აინტერესებთ რა შთაბეჭდილებას ტოვებენ სხვებზე. სტრესულ სიტუაციებში თავის თავზე გაბრაზებულები იწყებებ მსჯელობას საკუთარ უუნარობაზე. არიან ოპტიმისტები, აქვთ კარგი იუმორი, თავმდაბლები, უბრალოები თავიანთ სურვილებში, არ იზღუდავენ თავს ვალდებულებებით.",
                                     TypeName = "ხელოსანი"
                                    }
            },
            { KeirseyTypes.INFP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "უკიდურესად ინტუიტიურები არიან.  როგორც წესი ძალიან ყურადღებიანი და მზრუნველი ხასიათით გამოირჩევიან და შეუძლიათ კარგი მოსმენა. თუმცა შესაძლოა იყვნენ საკმაოდ თავშეკავებულები ემოციების გამოხატვისას. მათ არ უყვართ კონფლიქტები, ყველაფერს გააკეთებენ, რათა თავიდან აიცილონ კონფლიქტური სიტუაცია. დამთმობი და მშვიდი სანამ არ ირღვევა მათი ფასეულობები. ისინი ორიენტირებულები არიან საკუთარ გრძნობებზე, ამიტომაც ხშირად უჭირთ იყვნენ ობიექტურები. სტრესულ სიტუაციებში ხშირად ავიწყდებათ ლოგიკა და არ აღიარებენ რეალურ ფაქტებს. როგორც წესი, არიან ნიჭიერი მწერლები. მათ უჭირთ სიტყვიერად აზრის გადმოცემა, თუმცა შესანიშნავად შეუძლიათ საკუთარი გრძნობების ქაღალდზე გადმოტანა. ისინი ხშირად ირჩევენ პროფესიას სოციალური მიმართულებით (კონსულტანტი, მასწავლებელი). უამრავი დიდებული მეცნიერი, რომელმაც გააკეთა უდიდესი აღმოჩენები ჰუმანიტარულ მეცნიერებებში, მიეკუთვნებოდა ამ ტიპს.",
                                     TypeName = "მკურნალი"
                                    }
            },
            { KeirseyTypes.ENFJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "მათ კარგად ესმით ადამიანების და ზრუნავენ მათზე. ფლობენ განსაკუთრებულ ნიჭს - აღმოაჩინონ საუკეთესო გარშემომყოფთა შორის. არ არიან მიდრეკილნი  საკუთარი თავის წარმოჩენისკენ. ამ ტიპის ადამიანები ხშირად თავს მარტოებად გრძნობენ, მაშინაც კი, როდესაც იმყოფებიან ადამიანების გარემოცვაში. უყვართ ყველაფრის წინასწარ დაგეგმვა. ყველაზე კარგად ახდენენ საკუთარი თვის რეალიზებას, ისეთ სამსახურებში სადაც აქვთ საშუალება ხალხთან ურთიერთობის. აქვთ ნიჭი გაუგონ ადამიანებს, ილაპარაკონ მოზომილად და თქვან მხოლოდ ის რაც აბედნიერებს მის მოსაუბრეს. არიან საკმაოდ მომხიბვლელები, თბილები, ხელოვანი და მრავალმხრივ განვითარებული ადამიანები.",
                                     TypeName = "მასწავლებელი"
                                    }
            },
            { KeirseyTypes.INTP, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ისინი არიან დამოუკიდებლები,სიტყვაძუნწები, ჩაკეტილები, ლოგიკურები, უემოციოები და კრეატიულები. ცნობისმოყვარენი და შანსს არ უშვებენ ხელიდან აიმაღლონ კომპეტენცია. ორიგინალურები და ამოუცნობები. ადამიანების გაგება მათი მთავარი მამოძრავებელი ძალაა. სურთ  შეიცნონ ყველა მოვლენის არსი და იღებენ სიამოვნებას კრეატიული გადაწყვეტილებებით. მათთვის ხშირად დამახასიათებელია ფაქტების კრიტიკა და მათი ეჭვქვეშ დაყენება. როგორც წესი არ გააჩნიათ სამყაროს კონტროლის და მასში ცვლილებების შეტანის მოთხოვნილებები. ხშირად ამჟღავნებენ ლმობიერებას ცხოვრების სტილში.",
                                     TypeName = "არქიტექტორი"
                                    }
            },
            { KeirseyTypes.INTJ, new KeirseyTypeViewModel()
                                    {
                                      TypeDesc = "ავტონომიურები, ცივები, მოაზროვნეები, კრიტიკულები, ანალიტიკურები, ლოგიკურები და ცნობისმოყვარეები. დიდ სურვილი აქვთ აიმაღლონ ცოდნა და გამოცდილება. საზოგადოებაში – ფრთხილები და ჩაკეტილები, ორგანიზებულები და გათვითცნობიერებულები. დამოუკიდებლები, ორიგინალურები და მიუკერძოებლები. გააჩნიათ შესაძლებლობა თეორია  აქციონ მოქმედების გეგმად. აფასებენ ცოდნას, კომპეტენტურობასა და წესრიგს. ინტუიცია ლოგიკურ ანალიზთან ერთად არის მათი ცხოვრების წესი. ისინი გამუდმებით ფიქრობენ. მათ სჯერათ თავიანთი წინათგრძნობის, კარგი ორიენტაციის წყალობით  კი ოცნებებს ხშირად აქცევენ  რეალობად.",
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
                new PicAnswerViewModel {Id = 1, OrderNo = 1, Questionid = 1,   KType = KeirseyTypes.ISTJ, PicDescription = "Cogsworth (მზეთ. და ურჩხული)"},
                new PicAnswerViewModel {Id = 2, OrderNo = 2, Questionid = 1,   KType = KeirseyTypes.ISFJ, PicDescription = "კონკია "},
                new PicAnswerViewModel {Id = 3, OrderNo = 3, Questionid = 1,   KType = KeirseyTypes.INFJ, PicDescription = "პოკაჰონდასი "},
                new PicAnswerViewModel {Id = 4, OrderNo = 4, Questionid = 1,   KType = KeirseyTypes.INTJ, PicDescription = "ელზა (გაყინული)"},
                new PicAnswerViewModel {Id = 29, OrderNo = 5, Questionid = 1,  KType = KeirseyTypes.ISTP, PicDescription = "ფლიკი (მწერის ცხოვრება)"},
                new PicAnswerViewModel {Id = 30, OrderNo = 6, Questionid = 1,  KType = KeirseyTypes.ISFP, PicDescription = "პუმბა (მეფე ლომი)"},
                new PicAnswerViewModel {Id = 31, OrderNo = 7, Questionid = 1,  KType = KeirseyTypes.INFP, PicDescription = "ბელი (მზეთ. და ურჩხული)"},
                new PicAnswerViewModel {Id = 32, OrderNo = 8, Questionid = 1,  KType = KeirseyTypes.INTP, PicDescription = "ბუ (ვინი პუჰი)"},
                new PicAnswerViewModel {Id = 33, OrderNo = 9, Questionid = 1,  KType = KeirseyTypes.ESTP, PicDescription = "ფლინი (რაპუნცელი)"},
                new PicAnswerViewModel {Id = 34, OrderNo = 10, Questionid = 1, KType = KeirseyTypes.ESFP, PicDescription = "რობინ ჰუდი"},
                new PicAnswerViewModel {Id = 35, OrderNo = 11, Questionid = 1, KType = KeirseyTypes.ENFP, PicDescription = "ალადინი "},
                new PicAnswerViewModel {Id = 36, OrderNo = 12, Questionid = 1, KType = KeirseyTypes.ENTP, PicDescription = "ჯეკი (კარიბის ზღვის მეკობრეები)"},
                new PicAnswerViewModel {Id = 37, OrderNo = 13, Questionid = 1, KType = KeirseyTypes.ESTJ, PicDescription = "მაქსიმუსი (რაპუნცელი)"},
                new PicAnswerViewModel {Id = 38, OrderNo = 14, Questionid = 1, KType = KeirseyTypes.ESFJ, PicDescription = "მერი პოპინსი"},
                new PicAnswerViewModel {Id = 39, OrderNo = 15, Questionid = 1, KType = KeirseyTypes.ENFJ, PicDescription = "მუფასა  (მეფე ლომი)"},
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
            new TxtAnswerViewModel {Id = 22,OrderNo = 2,  Questionid = 5, Text = "ალაიქებს ყველა იმ სტატუსს, რომელსაც ბოლო 10 წუთის განმავლობაში არ გამოუწვევია სხვების რეაქცია",  KType = KeirseyTypes.ISFJ},
            new TxtAnswerViewModel {Id = 23,OrderNo = 3,  Questionid = 5, Text = "პროფილის ფოტოზე ჩანს მხოლოდ მისი სახე",  KType = KeirseyTypes.ESTJ},
            new TxtAnswerViewModel {Id = 24,OrderNo = 4,  Questionid = 5, Text = "პოსტავს ბევრ ფოტოს, რომელიც გამოხატავს კაცობრიობის საქციელით გამოწვეულ მის იმედგაცრუებას",  KType = KeirseyTypes.ISTJ},
            new TxtAnswerViewModel {Id = 89,OrderNo = 5,  Questionid = 5, Text = "ხშირად აგზავნის უცნაური წვეულებების მოსაწვევებს",  KType = KeirseyTypes.ESFP},
            new TxtAnswerViewModel {Id = 90,OrderNo = 6,  Questionid = 5, Text = "დღის განმავლობაში იღებს უამრავ სელფს",  KType = KeirseyTypes.ISFP},
            new TxtAnswerViewModel {Id = 91,OrderNo = 7, Questionid = 5, Text = "თავს ნიშნავს მთვრალ მდგომარეობაში ბევრ ფოტოზე, რაც იწვევს მეგობრების აღშფოთებას",  KType = KeirseyTypes.ESTP},
            new TxtAnswerViewModel {Id = 92,OrderNo = 8, Questionid = 5, Text = "დღის განმავლობაში რამდენჯერმე იწვევს მეგობრებს 'ქენდი ქრაშის სათამაშოდ' , მიუხედავად იმისა, რომ ისინი არასდროს ხსნიან ამ ლინკებს",  KType = KeirseyTypes.ISTP},
            new TxtAnswerViewModel {Id = 93,OrderNo = 9, Questionid = 5, Text = "ენთუზიაზმით ცვლის თავისი ოჯახური მდგომარეობის/ადგილმდებარეობის/კარიერაში წინსვლის შესახებ ინფორმაციას ყოველ 2-3 თვეში ერთხელ და იღებს ასობით ლაიქს",  KType = KeirseyTypes.ENFP},
            new TxtAnswerViewModel {Id = 94,OrderNo = 10, Questionid = 5, Text = "არჩევანს აკეთებს მეგობრებთან გადაღებული მხიარული ფოტოების და ადამიანის უფლებების დაცვასთან დაკავშირებულ პოსტის გამოქვეყნებას შორის", KType = KeirseyTypes.INFP},
            new TxtAnswerViewModel {Id = 95,OrderNo = 11, Questionid = 5, Text = "წერს უამრავ სტატუსს ისეთი ტექსტით, რომელიც სავარაუდოდ მეგობრებში კითხვებს გააჩენს", KType = KeirseyTypes.ENFJ},
            new TxtAnswerViewModel {Id = 96,OrderNo = 12, Questionid = 5, Text = "ხშირად პოსტავს სხვადასხვა ცნობილი ადამიანის გამონათქვამს", KType = KeirseyTypes.INFJ},
            new TxtAnswerViewModel {Id = 97,OrderNo = 13, Questionid = 5, Text = "ყველა პოსტზე შეუძლია იკამათოს ყოველგვარი მიზეზის გარეშე", KType = KeirseyTypes.ENTP},
            new TxtAnswerViewModel {Id = 98,OrderNo = 14, Questionid = 5, Text = "არაფერი დაუპოსტავს წლების განმავლობაში, მაგრამ სავარაუდოა რომ თითქმის ყველაფერს კითხულობს და თვალს ადევნებს", KType = KeirseyTypes.INTP},
            new TxtAnswerViewModel {Id = 99,OrderNo = 15, Questionid = 5, Text = "ჩექინდება ძალიან ბევრ ივენთზე და ნიშნავს თავს ყველა სურათზე", KType = KeirseyTypes.ENTJ},
            new TxtAnswerViewModel {Id = 100,OrderNo = 16, Questionid = 5, Text = "პოსტავს ცხოვრებისეულ სიახლეებს 3-5 დღის ინტერვალით. ფოტოებს ტვირთავს ძალიან იშვიათად, მხოლოდ იმ შემთხვევებში, როდესაც ფბ ამას ავტომატურად აკეთებს",KType = KeirseyTypes.INTJ},


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