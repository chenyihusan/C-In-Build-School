using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Files.Model;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
         var lines =  File.ReadAllLines("test03.txt");
            
            CultureInfo info = new CultureInfo("zh-TW");
            DateTime dateValue;
            foreach(string line in lines )
            { if ((line.Substring(0, 3) == 695.ToString() || line.Substring(0, 3) == 525.ToString())
                && (DateTime.TryParseExact(line.Substring(13, 8), "yyyyMMdd", info,
                                 DateTimeStyles.None, out dateValue)) &&( DateTime.TryParseExact(line.Substring(21, 8), "yyyyMMdd", info,
                                 DateTimeStyles.None, out dateValue)))
                {
                    FileTable context = new FileTable()
                {
                    TickNumber = line.Substring(0, 12),
                    FlyingDay = dateValue,
                    Birthday  = dateValue
                };
                    try
                    {
                        FileModel context1 = new FileModel();
                        context1.FileTable.Add(context);
                        context1.SaveChanges();
                        Console.WriteLine(context.TickNumber + context.FlyingDay + context.Birthday);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"發生錯誤{ex}");
                    }
                    
                    

                }
           
                
              


            }
            Console.ReadLine();

        }

       
    }
}
