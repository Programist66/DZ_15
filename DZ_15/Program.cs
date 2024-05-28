using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int Month, int Year, int ClientCode, int Duration)> data = new List<(int, int, int, int)>
        {
            (3, 2022, 101, 5),
            (4, 2022, 102, 7),
            (5, 2022, 103, 6),
            (6, 2022, 104, 8),
            (6, 2022, 105, 8),
            (7, 2022, 106, 6)
        };
            var maxDurationItem = data
                .OrderByDescending(item => item.Year)
                .ThenByDescending(item => item.Month)
                .ThenByDescending(item => item.Duration)
                .FirstOrDefault();

            if (maxDurationItem != default)
            {
                Console.WriteLine($"{maxDurationItem.Duration} {maxDurationItem.Year} {maxDurationItem.Month}");
            }
            else
            {
                Console.WriteLine("Последовательность пуста");
            }

            Console.ReadLine();

        //    List<(int Year, int SchoolNumber, string LastName)> applicants = new List<(int, int, string)>
        //{
        //    (2020, 101, "Иванов"),
        //    (2021, 102, "Петров"),
        //    (2020, 103, "Сидоров"),
        //    (2021, 104, "Кузнецов"),
        //    (2022, 105, "Смирнов"),
        //    (2022, 106, "Михайлов"),
        //    (2022, 107, "Федоров")
        //};


        //    var applicantsByYear = applicants
        //        .GroupBy(a => a.Year)
        //        .Select(g => new { Year = g.Key, Count = g.Count() })
        //        .OrderByDescending(x => x.Count)
        //        .ThenBy(x => x.Year);


        //    foreach (var group in applicantsByYear)
        //    {
        //        Console.WriteLine($"{group.Count} {group.Year}");
        //    }

        //    Console.ReadLine();

        //    List<(string LastName, int SchoolNumber, int Year)> applicants2 = new List<(string, int, int)>
        //{
        //    ("Иванов", 101, 2020),
        //    ("Петров", 102, 2021),
        //    ("Сидоров", 101, 2020),
        //    ("Кузнецов", 104, 2021),
        //    ("Смирнов", 105, 2022),
        //    ("Михайлов", 101, 2022),
        //    ("Федоров", 107, 2022)
        //};
        //    var applicantsBySchool = applicants2
        //    .GroupBy(a => a.SchoolNumber)
        //    .Select(g => new { SchoolNumber = g.Key, Count = g.Count(), Applicants = g.OrderBy(a => a.SchoolNumber).ThenBy(a => applicants.IndexOf(a)) })
        //    .OrderByDescending(x => x.Count)
        //    .ThenBy(x => x.SchoolNumber);


        //    int maxCount = applicantsBySchool.Max(x => x.Count);


        //    foreach (var group in applicantsBySchool.Where(x => x.Count == maxCount))
        //    {
        //        foreach (var applicant in group.Applicants)
        //        {
        //            Console.WriteLine($"{applicant.SchoolNumber} {applicant.LastName}");
        //        }
        //    }

        //    Console.ReadLine();

        //    {

        //        List<(string LastName, int ApartmentNumber, double Debt)> debtors = new List<(string, int, double)>
        //{
        //    ("Иванов", 101, 1234.56),
        //    ("Петров", 23, 789.12),
        //    ("Сидоров", 144, 345.67),
        //    ("Кузнецов", 89, 987.65),
        //    ("Смирнов", 5, 234.45),
        //    ("Михайлов", 101, 456.78),
        //    ("Федоров", 23, 678.90)
        //};


        //        var debtorsByFloor = debtors
        //            .GroupBy(d => (d.ApartmentNumber - 1) / 4 + 1)
        //            .Select(g => new { Floor = g.Key, Count = g.Count(), TotalDebt = g.Sum(d => d.Debt) })
        //            .OrderBy(x => x.Count)
        //            .ThenBy(x => x.Floor);


        //        foreach (var group in debtorsByFloor)
        //        {
        //            Console.WriteLine($"{group.Count} {group.Floor} {group.TotalDebt:F2}");
        //        }

        //        Console.ReadLine();

        //        List<(double Debt, string LastName, int ApartmentNumber)> debtors = new List<(double, string, int)>
        //{
        //    (1234.56, "Иванов", 101),
        //    (789.12, "Петров", 23),
        //    (345.67, "Сидоров", 144),
        //    (987.65, "Кузнецов", 89),
        //    (234.45, "Смирнов", 5),
        //    (456.78, "Михайлов", 101),
        //    (678.90, "Федоров", 23)
        //};


        //        var debtorsByFloor = debtors
        //            .GroupBy(d => (d.ApartmentNumber - 1) / 4 + 1)
        //            .Select(g => new { Floor = g.Key, TotalDebt = g.Sum(d => d.Debt), Count = g.Count() })
        //            .OrderByDescending(x => x.Floor);


        //        var allFloors = Enumerable.Range(1, 9)
        //            .Select(f => new { Floor = f, TotalDebt = 0.0, Count = 0 })
        //            .ToList();


        //        var result = allFloors
        //            .Union(debtorsByFloor)
        //            .OrderByDescending(x => x.Floor);


        //        foreach (var floor in result)
        //        {
        //            Console.WriteLine($"{floor.Floor} {floor.TotalDebt:F2} {floor.Count}");
        //        }

        //        Console.ReadLine();
        //    }
        }
    }
}