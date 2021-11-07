using System;
using System.Collections.Generic;
using System.Linq;
using MeuApp.ContentContext;
using MeuApp.SubscriptionContext;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles = new List<Article>();
            articles.Add(new Article("C#", "csharp"));
            articles.Add(new Article("Orientação Objetos#", "OOP"));
            articles.Add(new Article("SQL", "sql-server"));
            articles.Add(new Article(".NETCORE", "dotnetcore"));
            Console.WriteLine("Listando Artigos: \n");

            foreach (var article in articles)
            {
                Console.WriteLine($"ID = {article.Id}");
                Console.WriteLine($"Artigo = {article.Title}");
                Console.WriteLine($"URL = {article.Url}");
                Console.WriteLine("-------------------------------------------------\n");
            }

            Console.ReadKey();


            //-----------------------------------------------------//
            //-------CARREIRAS--------------------------//

            Console.Clear();

            //Instanciando a lista de cursos
            var courses = new List<Course>();

            //criando os cursos individualmente
            var courseCsharp = new Course("Fundamentos do C#", "csharp-fundamentals");
            courseCsharp.Level = ContentContext.Enums.EContentLevel.Beginner;
            courseCsharp.DurationInMinutes = 720;

            var courseOOP = new Course("Fundamentos do Orientação Objetos#", "OOP");
            courseOOP.Level = ContentContext.Enums.EContentLevel.Intermediary;
            courseOOP.DurationInMinutes = 252;

            var courseSQL = new Course("SQL Server", "sql-server");
            courseSQL.Level = ContentContext.Enums.EContentLevel.Advanced;
            courseSQL.DurationInMinutes = 240;

            var courseDotnet = new Course(".NET Framework", "dotnet");
            courseDotnet.Level = ContentContext.Enums.EContentLevel.Fundamentals;
            courseDotnet.DurationInMinutes = 163;


            //Inserindo os cursos na lista de cursos
            courses.Add(courseCsharp);
            courses.Add(courseOOP);
            courses.Add(courseSQL);
            courses.Add(courseDotnet);


            //Criando lista das carreiras
            var careers = new List<Career>();

            //criando a carreira de desenvolvedor .NET
            var careerDesenvolvedorDotnet = new Career("Carreira Desenvolvedor .NET", "desenvolvedor-dotnet");

            //Criando os cursos da carreira de desenvolvedor
            var careerItemCourseOOP = new CareerItem(3, "Aprenda OOP", "", courseOOP);
            var careerItemCourseSQL = new CareerItem(4, "Aprenda Banco de dados", "", courseSQL);
            var careerItemCourseDotnet = new CareerItem(2, "Aprenda .NET", "", courseDotnet);
            var careerItemCourseCsharp = new CareerItem(1, "Comece por Aqui", "", courseCsharp);
            var careerItemCourseNull = new CareerItem(5, "Aprenda Ingles", "", null);

            //Adicionando os cursos na carreira desenvolvedor dotnet
            careerDesenvolvedorDotnet.Items.Add(careerItemCourseCsharp);
            careerDesenvolvedorDotnet.Items.Add(careerItemCourseOOP);
            careerDesenvolvedorDotnet.Items.Add(careerItemCourseSQL);
            careerDesenvolvedorDotnet.Items.Add(careerItemCourseDotnet);
            careerDesenvolvedorDotnet.Items.Add(careerItemCourseNull);


            //Adicionando a carreira de desenvolvedor dotnet a lista de carreiras
            careers.Add(careerDesenvolvedorDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(c => c.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"\t{item.Course?.Title}");
                    Console.WriteLine($"\tNível: {item.Course?.Level}");
                    Console.WriteLine($"\tDuração: {item.Course?.DurationInMinutes}");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - { notification.Message}");
                    }
                    Console.WriteLine("---------------------------------");
                }
                Console.ReadKey();
            }

            //VERIFICAR ASSINATURAS DOS ESTUDANTES
            Console.Clear();
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            Console.ReadKey();

            Console.WriteLine(student);
            Console.WriteLine(student.Notifications);
            Console.WriteLine(student.Subscriptions);

            student.CreateSubscription(payPalSubscription);
            Console.WriteLine(student);
            Console.WriteLine(student.Notifications);
            Console.WriteLine(student.Subscriptions);
            Console.ReadKey();

            student.CreateSubscription(payPalSubscription);
            Console.WriteLine(student);
            Console.WriteLine(student.Notifications);
            Console.WriteLine(student.Subscriptions);
            Console.ReadKey();
        }
    }
}
