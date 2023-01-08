using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;



namespace laba2
{
    class Program
    {
        class Person
        {
            public string name;
            public string secondName;
            public System.DateTime dateOfBirth;

            public Person(string name, string secondName, DateTime dateOfBirth)
            {
                this.name = name;
                this.secondName = secondName;
                this.dateOfBirth = dateOfBirth;
            }

            public Person()
            {
                this.name = "Александр";
                this.SecondName = "Петров";
                this.dateOfBirth = new DateTime(1987, 09, 17);
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string SecondName
            {
                get { return secondName; }
                set { secondName = value; }
            }

            public DateTime DateOfBirth
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            public int YearDateOfBirth
            {
                get { return YearDateOfBirth; }
                set { dateOfBirth = new DateTime(value); }
            }

            public string ToFullString()
            {
                return "Имя и Фамилия: " + name + " " + secondName + "Дата рождения: " + dateOfBirth;
            }

            public string ToShortString()
            {
                return "Имя и Фамилия: " + name + " " + secondName;
            }
        }

        enum Education
        {
            Специалитет, Бакалавриат , ВтороеОбразование
        }

        class Exam
        {
            public string Discipline;
            public int Rate;
            public DateTime DateOfExam;
        
            public Exam(string discipline, int rate, DateTime DateOfExam)
            {
                this.Discipline = discipline;
                this.Rate = rate;
                this.DateOfExam = DateOfExam;
            }

            public Exam()
            {
                Discipline = "Программирование";
                Rate = 5;
                DateOfExam = new DateTime(2022, 10, 23);
            }

                public string ToFullString()
            {
                return "Дисциплина: " + Discipline + ", оценка: " + Rate + ", дата экзамена: " + DateOfExam;
            }
        }

        class Student
        {
            public Education education;
            public int group;
            public Person person;
            public Exam[] _passedExams;
            public double Avgrate;

            public Student(Education education, int group, Person person)
            {
                this.education = education;
                this.group = group;
                this.person = person;
                this._passedExams = new Exam[0];
            }

            public Student()
            {
                this.person = new Person();
                this.education = Education.Бакалавриат;
                this.group = 11;
                this._passedExams = new Exam[0];

            }
            public Person persons
            {
                get { return person; }
                set { person = value; }
            }

            public Education educations
            {
                get { return education; }
                set { education = value; }
            }

            public int groups
            {
                get { return group; }
                set { group = value; }
            }

            public double AvgRate
            {

                get
                {
                    double sum = 0;
                    int i;
                    for (i = 0; i < _passedExams.Length; i++)
                    {
                        sum = sum + _passedExams[i].Rate;

                    }
                    if (_passedExams.Length != 0)
                    {
                        return sum / _passedExams.Length;
                    }
                    else
                        return 0;
                }
            }
                


            public void AddExams(params Exam[] exams)
            {
                int _OldSize = _passedExams.Length;
                Array.Resize<Exam>(ref _passedExams, _OldSize + exams.Length);
                exams.CopyTo(_passedExams, _OldSize);
            }

            public string ToFullString()
            {
                string examens = "";
                foreach (var item in _passedExams)
                    examens += item.Discipline + item.Rate + ";\n";
                return "Имя: " + person.Name + ", Фамилия: " + person.SecondName + ", Дата рождения: " + person.dateOfBirth + ", форма обучения: " + education + ", группа: " + group + ", результаты экзаменов: " + "\n" + examens;
            }

            public string ToShortString()
            {
                return "Имя: " + person.Name + ", Фамилия: " + person.SecondName + ", Дата рождения: " + person.dateOfBirth + ",  форма обучения: " + education + ", группа: " + group + ", средний балл: " + AvgRate;
            }
        }

        static void Main()
        {
            Person p1 = new Person();
            p1.Name = "Александр";
            p1.SecondName = "Перетягин";
            p1.DateOfBirth = new DateTime(2003, 08, 26);

            Exam[] exams = new Exam[5];
            exams[0] = new Exam("Вышмат: ", 4 , new DateTime(2008, 6, 1));
            exams[1] = new Exam("Дискретная математика: ", 5 , new DateTime(2006, 6, 1));
            exams[2] = new Exam("Программирование: ", 4 , new DateTime(2001, 6, 1));
            exams[3] = new Exam("База данных: ", 5 , new DateTime(2002, 6, 1));
            exams[4] = new Exam("Информационные технологии: ", 4 , new DateTime(2003, 6, 1));

            Student student1 = new Student(Education.Бакалавриат, 11, p1);

            student1.AddExams(exams);
            Console.WriteLine(student1.ToShortString());
            Console.WriteLine(student1.ToFullString());
        }
    }


}