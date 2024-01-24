using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp2.Models;
using System.Security.Policy;
using System.Xml;

    public class BlazorApp2Context : DbContext
    {
        public BlazorApp2Context (DbContextOptions<BlazorApp2Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp2.Models.Student> Student { get; set; } = default!;

        public DbSet<BlazorApp2.Models.Prepod> Prepod { get; set; } = default!;

    public void EnsureData()
    {
        if (!Student.Any())
        {
            var data = ReadDataFromFile();
            Student.AddRange(data);
            SaveChanges();
        }
    }

    public List<Student> ReadDataFromFile()
    {
        List<string> lines = File.ReadAllLines("..\\BlazorApp2\\wwwroot\\Base\\Students.csv").ToList();
        List<Student> students = new List<Student>();

        foreach (var line in lines)
        {
            string[] splitLine = line.Split(';');
            var student = new Student
            {
                Фамилия = splitLine[0],
                Имя = splitLine[1],
                Отчество = splitLine[2],
                Рост = int.Parse(splitLine[3]),
                День_Рождения = Convert.ToDateTime(splitLine[4]),
                Группа = splitLine[5],
                Специальность = splitLine[6],
                Стипендия = splitLine[7],
                Возраст = int.Parse(splitLine[8])
            };
            students.Add(student);
        }

        return students;
    }

    public void EnsureData2()
    {
        if (!Prepod.Any())
        {
            var data = ReadDataFromFile2();
            Prepod.AddRange(data);
            SaveChanges();
        }
    }
    public List<Prepod> ReadDataFromFile2()
    {
        List<Prepod> prepods = new List<Prepod>();
        XmlDocument xDoc = new XmlDocument();
        xDoc.Load("..\\BlazorApp2\\wwwroot\\Base\\Prepods.xml");

        XmlElement? xRoot = xDoc.DocumentElement;
        if (xRoot != null)
        {
            foreach (XmlElement xnode in xRoot)
            {
                XmlNode? attr = xnode.Attributes.GetNamedItem("");

                var prepod = new Prepod
                {
                    Фамилия = xnode.SelectSingleNode("Фамилия")?.InnerText,
                    Имя = xnode.SelectSingleNode("Имя")?.InnerText,
                    Отчество = xnode.SelectSingleNode("Отчество")?.InnerText,
                    Куратор_Группы = xnode.SelectSingleNode("Куратор_Группы")?.InnerText,
                    Профессия = xnode.SelectSingleNode("Профессия")?.InnerText,
                    День_Рождения = Convert.ToDateTime(xnode.SelectSingleNode("День_Рождения")?.InnerText).Date,
                    Номер_Кабинета = int.Parse(xnode.SelectSingleNode("Номер_Кабинета")?.InnerText),
                    Зарплата = int.Parse(xnode.SelectSingleNode("Зарплата")?.InnerText),
                    Стаж = int.Parse(xnode.SelectSingleNode("Стаж")?.InnerText),

                };
                prepods.Add(prepod);
            }


        }
        return prepods;
    }
}
