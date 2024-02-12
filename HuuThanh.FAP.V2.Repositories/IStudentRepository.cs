using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuuThanh.FAP.V2.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetAll();
        public void Add(Student student);
        public void Update(Student student);
        public void Delete(string id);
        public List<Student> Search(string keyword);
    }
}
