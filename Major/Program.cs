using System;

namespace MajorProject {
    class Program {
        static void Main(string[] args) {
           
            var accounting = new  Major (100,1000, "Accounting");
            var business = new Major(200, 1000, "Busines");
            var engineering = new Major(300,1200, "Engineering");

            accounting.Print();
            business.Print();
            engineering.Print();



            }
        }
    }
