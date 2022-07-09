using System;
using System.Collections.Generic;
using System.Data;
using TeachAssist.DAL;
using TeachAssist.Models;

namespace TeachAssist.BLL
{
    public class StudentService
    {
        StudentDAO studentDAO = new StudentDAO();

        public List<Student> GetAllStudent()
        {
            // 记录日志...
            return studentDAO.GetStudents();
        }

        public List<Student> GetPresentStudents()
        {
            // 记录日志...
            return studentDAO.GetStudents(1);
        }

        public List<Student> GetAbsentStudents()
        {
            // 记录日志...
            return studentDAO.GetStudents(2);
        }

        public int SaveUpdate(Student student)
        {
            return studentDAO.UpdateStudent(student);
        }

        public int SaveAdd(Student student)
        {
            if (studentDAO.GetStudentById(student.Id) != null)
            {
                throw new Exception($"这个学生已经存在，不能重复添加: {student.Id}");
            }
            return studentDAO.AddStudent(student);
        }

        public int Delete(string id)
        {
            return studentDAO.DeleteStudent(id);
        }

        public List<Student> SearchStudent(string condition)
        {
            if (condition == "")
            {
                return studentDAO.GetStudents();
            }
            return studentDAO.SearchStudents(condition);
        }

        public DataSet GetStudentsAndGroups()
        {
            return studentDAO.GetStudentsAndGroups();
        }

        public void SaveGroups(List<(int id, string leader, List<string> members)> groups)
        {
            studentDAO.SaveGroups(groups);
        }
    }
}
