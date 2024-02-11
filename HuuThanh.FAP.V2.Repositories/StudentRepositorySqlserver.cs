using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuuThanh.FAP.V2.Repositories
{
    /// <summary>
    /// Classs này là nguồn data cho các UI Forms
    /// Nó chịu trách nhiệm lấy data từ CSDL SQLServer đem lên
    /// Chứa lệnh móc vào CSDL, lấy và đẩy data về cho Form
    /// </summary>
    public class StudentRepositorySqlserver
    {
        private List<Student> _ds = new List<Student>()
        { 
            new Student() {Id = "SE1", Name = "An", Address = "Tân Bình", Gpa = 8.0},
            new Student() {Id = "SE2", Name = "Dũng", Address = "Tân Thành", Gpa = 5.0},
            new Student() {Id = "SE3", Name = "Thành", Address = "An Giang", Gpa = 7.0},
            new Student() {Id = "SE4", Name = "Bình", Address = "Dương Đông", Gpa = 3.0}
        };

        //các hàm móc vào CSDL để lấy data

        //các hàm CRUD cung cấp cho UI

        /// <summary>
        /// Hàm trả về danh sách sinh viên
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAll()
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
            var existingStudent = _ds.FirstOrDefault(s => s.Id.ToLower().Equals(udtStudent.Id.ToLower()));
                                //where trả về 1
                                //ko trả new Student()
                                //tham chiếu/trỏ Student đã new từ trc
            if (existingStudent != null)
            {
                existingStudent.Name = udtStudent.Name;
                existingStudent.Address = udtStudent.Address;
                existingStudent.Gpa = udtStudent.Gpa;
            }
        }
        public void Delete(String id)
        {
            //xóa là phải tìm sv có tồn tại chưa, where id = id đưa vào
            var existingStudent = _ds.FirstOrDefault(s => s.Id.ToLower().Equals(id.ToLower()));

            if (existingStudent != null)
            {
                _ds.Remove(existingStudent);
            }
        }

        public List <Student> Search(string keyword)
        {
            //where keyword || cột mình thích
            var result = _ds.Where(xxx =>
            {
                return (xxx.Name.ToLower().Contains(keyword.ToLower())) || (xxx.Address.ToLower().Contains(keyword.ToLower()));
            }
            ).ToList();
            return result;
        }
    }
}
