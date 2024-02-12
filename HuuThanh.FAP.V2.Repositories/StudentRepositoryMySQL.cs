using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuuThanh.FAP.V2.Repositories
{
    public class StudentRepositoryMySQL : IStudentRepository
    {
        public List<Student> GetAll()
        {
            //đọc DB select * from Student
            return _ds;
        }

        //danh sách sv
        private List<Student> _ds = new List<Student>()
        {
            new Student() {Id = "SE1", Name = "MySQL", Address = "RDBMS", Gpa = 6.8},

        };

        //các hàm móc vào CSDL để lấy data

        //các hàm CRUD cung cấp cho UI


        /// <summary>
        /// Hàm trả về danh sách sinh viên
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAllStudents()
        {
            //đọc DB select * from Student
            return _ds;
        }

        /// <summary>
        /// Hàm nhận vào 1 sv và lưu vào CSDL
        /// </summary>
        /// <param name="x">x là 1 Student đủ info và sẽ đc add vào CSDL</param>
        public void Add(Student x)
        {
            _ds.Add(x);
            //insert into Student values(...) trên Sqlserver
        }
        public void Update(Student udtStudent)
        {
            //LINQ quay trở lại, tìm sv, 1 sv, update info
            var existingStudent = _ds.FirstOrDefault(s => s.Id == udtStudent.Id);
            //where trả về 1
            //ko trả new Student()
            //tham chiếu/trỏ Student đã new từ trước trong _ds
            if (existingStudent != null)
            {
                existingStudent.Name = udtStudent.Name;
                existingStudent.Address = udtStudent.Address;
                existingStudent.Gpa = udtStudent.Gpa;
            }
        }
        public void Delete(String id)
        {

            //xoá là phải tìm sv có tồn tại chưa, where id = id đưa vào
            var existingStudent = _ds.FirstOrDefault(s => s.Id == id);
            if (existingStudent != null)
            {
                //existingStudent nó đang trỏ vào vùng new Student() của bạn tìm thấy
                _ds.Remove(existingStudent);
            }
        }

        public List<Student> Search(string keyword)
        {
            //where keyword || cột mình thích
            //search keyword nằm trong 2 cột Name hoặc Address
            var result = _ds.Where(s => s.Name.ToLower().Contains(keyword.ToLower()) ||
                                        s.Address.ToLower().Contains(keyword.ToLower())).ToList();
            return result;
        }
    }
}
