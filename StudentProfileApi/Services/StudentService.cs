using StudentProfileApi.Models;
using MongoDB.Driver;

namespace StudentProfileApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> students;

        public StudentService(IStudentStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            students = database.GetCollection<Student>(settings.StudentCollectionName);
        }
        public Student Create(Student student)
        {
            students.InsertOne(student);
            return student;
        }

        public List<Student> Get()
        {
            return students.Find(student => true).ToList();
        }

        public Student Get(string id)
        {
            return students.Find(student => student.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            students.DeleteOne(student => student.Id == id);
        }

        public void Update(string id, Student student)
        {
            students.ReplaceOne(student => student.Id == id, student);

        }
    }
}
