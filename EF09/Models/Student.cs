namespace EF09.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int S_No { get; set; }
        public string Name { get; set; }
        public string Addr { get; set; }



        // navigation property.
        public Score Score { get; set; }


    }
}
