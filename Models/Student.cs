using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class Student
    {
        public int id { get; set; }
        public string? Фамилия { get; set; }
        public string? Имя { get; set; }
        public string? Отчество { get; set; }
        public int Рост { get; set; }

        [DataType(DataType.Date)]
        public DateTime День_Рождения { get; set; }
        public string? Группа { get; set; }
        public string? Специальность { get; set; }
        public string? Стипендия { get; set; }
        public int? Возраст { get; set; }
    }
}
