using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.StudentData
{
    public interface IStudentData
    {
        List<Student> GetStudents();
    }
}
