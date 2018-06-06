using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InterfaceSamples002
{
    public enum SourceType
    {
        CSV,
        JSON
    }
    public interface IParser
    {
        void Parse();
    }

    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public abstract class People : IParser
    {

        public List<Person> Items { get; protected set; }

        protected People()
        {
            Items = new List<Person>();
        }

        public abstract void Parse();
    }


    /// <summary>
    /// 從 CSV 檔取得資料
    /// </summary>
    internal class PeopleFromCSV : People
    {

        public override void Parse()
        {
            Items.Clear();
            char[] splitor = new char[] { ',' };
            string[] lines = File.ReadAllLines("Data.txt");
            foreach (var line in lines)
            {
                string[] items = line.Split(splitor);
                var person = new Person();
                person.Name = items[0];
                person.Address = items[1];
                person.Phone = items[2];
                Items.Add(person);
            }

        }
    }

    /// <summary>
    /// 從 json 檔取得資料
    /// </summary>
   internal class PeopleFromJson : People
    {
        public override void Parse()
        {
            Items.Clear();
            string source = File.ReadAllText("Data.json");
            Items.AddRange(JsonConvert.DeserializeObject<List<Person>>(source));
        }
    }


}
