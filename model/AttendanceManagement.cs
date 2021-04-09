using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAttendance.model
{
    class AttendanceManagement
    {
        private  List<Course> courses;
        private List<Teacher> teachers;
        private List<Room> rooms;
        private List<Attendance> attendance;

        public AttendanceManagement()
        {
            courses = new List<Course>();
            teachers = new List<Teacher>();
            rooms = new List<Room>();
        }

        public void addNewCourse(String CoursName)
        {
            courses.Add(new Course(courses.Count + 1, CoursName));
        }

        public List<Course> getAllCourses()
        {
            List<Course> temp;

            temp = courses.GetRange(0, courses.Count);

            temp.Add(new Course(0, "Add new course..."));

            return temp;

        }

        public void addNewTeacher(String TeacherName)
        {
            teachers.Add(new Teacher(teachers.Count + 1, TeacherName));
        }

        public List<Teacher> getAllTeachers()
        {
            List<Teacher> temp;

            temp = teachers.GetRange(0, teachers.Count);

            temp.Add(new Teacher(0, "Add new course..."));

            return temp;

        }

        public void addTeacher(String TeacherName)
        {
            teachers.Add(new Teacher(teachers.Count + 1, TeacherName));
        }


        public void addNewRoom(String RoomName)
        {
            rooms.Add(new Room(rooms.Count + 1, RoomName));
        }

        public List<Room> getAllRooms()
        {
            List<Room> temp;

            temp = rooms.GetRange(0, rooms.Count);

            temp.Add(new Room(0, "Add new room/lab..."));

            return temp;

        }


    }





}
