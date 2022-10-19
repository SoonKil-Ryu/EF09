using System.ComponentModel.DataAnnotations.Schema;

namespace EF09.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int Kor { get; set; }
        public int Eng { get; set; }
        public int Math { get; set; }


        // foreign key.
        [ForeignKey("Student")]
        public int S_Id { get; set; }

        // navigation property.
        public Student Student { get; set; }

    }
}
