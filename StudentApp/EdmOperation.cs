using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class EdmOperation
    {
        studentEntities1 entity = null;

        public EdmOperation()
        {
            entity = new studentEntities1();
        }
        public void insertOperation(student s)
        {
            STUDENT_DETAIL s1 = new STUDENT_DETAIL() { NAME = s.NAME, BRANCH = s.BRANCH, DIVISION = s.DIVISION, SCORE = s.SCORE };
            entity.STUDENT_DETAIL.Add(s1);
            entity.SaveChanges();
        }
        public List<STUDENT_DETAIL> ReadOperation()
        {
           List<STUDENT_DETAIL> allStudent = entity.STUDENT_DETAIL.ToList();
            return allStudent;
        }
    }
}
