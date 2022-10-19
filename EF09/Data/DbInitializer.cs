using EF09.Models;

namespace EF09.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            if (context.Students.Any())
            {
                return;

            }

            var students = new Student[]
            {
                new Student {S_No=1, Name="유순길", Addr="수원"},
                new Student {S_No=2, Name="유은희", Addr="수원"},
                new Student {S_No=3, Name="최금자", Addr="수원"}
            };
            context.Students.AddRange(students);
            context.SaveChanges();

            var scores = new Score[]
            {
                new Score {S_Id=1, Kor=51, Eng=51, Math=51},
                new Score {S_Id=2, Kor=99, Eng=89, Math=79},
                new Score {S_Id=3, Kor=95, Eng=69, Math=79}
            };
            context.Scores.AddRange(scores);
            context.SaveChanges();

        }
    }
}
