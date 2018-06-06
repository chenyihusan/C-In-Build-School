using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSamples002
{
    public class PeopleFactory
    {
        private  Dictionary<SourceType, People> Sources;

        public PeopleFactory ()
        {
            Sources = new Dictionary<SourceType, People>();
            Sources.Add(SourceType.CSV, new PeopleFromCSV());
            Sources.Add(SourceType.JSON, new PeopleFromJson()); 
        }

        public List<Person> GetPeopleList(SourceType type)
        {
            Sources[type].Parse();
            return Sources[type].Items;
        }
    }
}
