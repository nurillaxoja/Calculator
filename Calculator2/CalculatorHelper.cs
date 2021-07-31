using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace Calculator2
{
    class CalculatorHelper
    {
        public LiteDatabase DB { get; set; }
        public LiteCollection<CalculatorModule> col { get; set; }
        public static IEnumerable<CalculatorModule> CalculatorCollections()
        {
            var items = new List<CalculatorModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<CalculatorModule>("Calculator");
                var result = collection.FindAll();
                items.AddRange(result);
            }
            return items;
        }
        //public static double AddSaved()// not complated 
        //{
        //    double totalResult = 0;
        //    var items = new List<CalculatorModule>();
        //    using (var db = new LiteDatabase(dbConnection.dbLocation))
        //    {
                   
            
        //    }
        //    return totalResult;
        //}
        public static CalculatorModule Get()
        {
            var calculatorToReturn = new List<CalculatorModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var calculator = db.GetCollection<CalculatorModule>("Calculator");
                var result = calculator.FindAll();
                foreach(CalculatorModule calcItem in result)
                {
                    calculatorToReturn.Add(calcItem);
                }
                return calculatorToReturn.FirstOrDefault(p => p.Id > 0);
            }
        }

        public static void CalculatorInsert(double first, double second, double total) 
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<CalculatorModule>("Calculator");
                collection.DeleteAll();
                collection.Insert(new CalculatorModule() {Id= 1, FirstNumber = first, SecondNumber = second, Total = total });
            }
        }

        public static void DeleteAll()
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation)) {
                var collection = db.GetCollection<CalculatorModule>("Calculator");
                collection.DeleteAll();
            }
        }

        
        public static void MemoryRecall()
        {
            var items = new List<CalculatorModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<CalculatorModule>("Calculator");
               
            }
        }



    }
}
