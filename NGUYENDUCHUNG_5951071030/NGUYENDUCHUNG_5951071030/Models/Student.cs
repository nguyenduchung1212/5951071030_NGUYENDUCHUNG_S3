using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NGUYENDUCHUNG_5951071030.Models
{
    [DataContract]
    public class Student
    {
        [DataMember(Name = "hoten")]

        public string HoTen { get; set; }
        [DataMember(Name = "msv")]

        public string MSV { get; set; }
        [DataMember(Name = "lop")]

        public string Lop { get; set; }



    }
}