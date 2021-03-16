using NGUYENDUCHUNG_5951071030.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NGUYENDUCHUNG_5951071030.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            var studentInList = new List<Student>();
            {
                var studentInfor = new Student
                {
                    HoTen = "NGUYEN DUC HUNG",
                    MSV = "5951071030",
                    Lop = "CNTT K59"

                };
                studentInList.Add(studentInfor);

            }
            return studentInList;
           
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
