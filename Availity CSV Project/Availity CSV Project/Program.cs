using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Availity_CSV_Project
{
    class Program
    {//this is made that insurance companies are a static number of possibilities
        static void Main(string[] args)
        {//read csv file
            string[] lines = File.ReadAllLines("test.csv");
            //gather insurance 1 and order them
            IEnumerable<string> queryI1 =
                from line in lines
                let x = line.Split(',')
                orderby x[1]
                where  x[4] == "insurance1"
                select line;
            //takes sorted group, checks for duplicate userIDs, and displays the one of highest version
            var distictUsers1 = queryI1.GroupBy(x => x[0]).Select(y => y.Max());
            //writes to the insurance 1 csv
            File.WriteAllLines("insurance1.csv", distictUsers1.ToArray());

            IEnumerable<string> queryI2 =
                from line in lines
                let x = line.Split(',')
                orderby x[1]
                where x[4] == "insurance2"
                select line;

            var distinctUsers2 = queryI2.GroupBy(x => x[0]).Select(y => y.Max());

            File.WriteAllLines("insurance2.csv", distinctUsers2.ToArray());
        }
    }
}
