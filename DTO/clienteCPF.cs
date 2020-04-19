using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public struct ObjPessoa
    {
        public string name { get; set; }
        public string federalTaxNumber { get; set; }
        public string status { get; set; }
        public string createdOn { get; set; }
        public string birthOn { get; set; }
        //-- e outros...
    }

    public class NaturalPerson
    {
        public DateTime birthOn { get; set; }
        public DateTime createdOn { get; set; }
        public string status { get; set; }
        public string federalTaxNumber { get; set; }
        public string name { get; set; }
    }

    public class RootObject
    {
        public NaturalPerson naturalPerson { get; set; }
    }
}

