using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;

namespace flexGridTest.Models
{

    [DataContract]
    public class PersonsList
    {
        [DataMember(Name = "page")]
        public int Page { get; private set; }

        [DataMember(Name = "total")]
        public int Total { get; private set; }

        [DataMember(Name = "rows")]
        public IEnumerable<Person> Rows { get; private set; }

        public PersonsList(int page, int total, IEnumerable<Person> persons)
        {
            this.Page = page;
            this.Total = total;
            this.Rows = persons;
        }

    }
}