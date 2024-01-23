using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class Prepod
    {
        public int id { get; set; }
        public string? Фамилия { get; set; }
        public string? Имя { get; set; }
        public string? Отчество { get; set; }
        public string? Куратор_Группы { get; set; }
        public string? Профессия { get; set; }

        [DataType(DataType.Date)]
        public DateTime День_Рождения { get; set; }
        public int Номер_Кабинета { get; set; }
        public int Зарплата { get; set; }
        public int Стаж { get; set; }
    }
}
