using DemoApi.StudentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi
{
    public class MockStudentData : IStudentData
    {
        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
