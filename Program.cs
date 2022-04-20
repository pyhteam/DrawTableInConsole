using DrawTableInConsole.Models;
using DrawTableInConsole.Uliti;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DrawTableInConsole
{
    internal class Program
    {
        
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            ShowStudent();
        }
        static void CreateData()
        {
            
            var students = new List<Student>
            {
            new Student { Id = 1,Name = "Nguyen Van A",Address = "Hanoi",Email = "nguyenvana@gmail.com",Birthday = DateTime.Parse("2000-01-01"),Created_At = DateTime.Now},
            new Student { Id = 2,Name = "Nguyen Van B",Address = "Hanoi",Email = "nguyenvanB@gmail.com", Birthday = DateTime.Parse("1999-01-01"),Created_At = DateTime.Now},
            new Student { Id = 3,Name = "Nguyen Van C",Address = "Hanoi",Email = "nguyenvanC@gmail.com", Birthday = DateTime.Parse("1998-01-01"),Created_At = DateTime.Now},
            new Student { Id = 4,Name = "Tran Thi Ti",Address = "Ho CHi Minh",Email = "tranthiti@gmail.com", Birthday = DateTime.Parse("1997-01-01"),Created_At = DateTime.Now},
            };
            // get local project path
            string path = Directory.GetCurrentDirectory()+"\\Data";
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            // convert to json
            var json = JsonSerializer.Serialize(students);
            // write to file
            
            File.WriteAllText(path+"\\data.json", json);
        }
        static void ReadData()
        {
            // get local project path
            string path = Directory.GetCurrentDirectory()+"\\Data\\data.json";
            // read from file
            string json = File.ReadAllText(path);
            // convert to list
            students = JsonSerializer.Deserialize<List<Student>>(json);
        }
        static void ShowStudent()
        {
            // check exis file json
            if(File.Exists(Directory.GetCurrentDirectory()+"\\Data\\data.json"))
            {
                // read data
                ReadData();
            }
            else
            {
                CreateData();
            }
            IPrintTabularData<Student> studentDataPrinter = new TablePrinter<Student>();
            studentDataPrinter.PrintTable(students);
        }
    }
}
