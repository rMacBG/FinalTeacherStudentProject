using TeacherStudentProject.Data.ApplicationContext;
using TeacherStudentProject.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.DataSeeder
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SchoolLibDbContext>();

                context.Database.EnsureCreated();

                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()

                    {
                        new Student()
                        {
                            FirstName = "Pesho",
                            Surname = "Petrov",
                            FamilyName = "Petrov",
                            Speciality = Speciality.Chinese,
                            Grade = Grade.SixthGrade

                        },
                         new Student()
                        {
                            FirstName = "Petar",
                            Surname = "Petkov",
                            FamilyName = "Iavorov",
                            Speciality = Speciality.Russian,
                            Grade = Grade.SecondGrade

                        },
                            new Student()
                        {
                            FirstName = "Bobcho",
                            Surname = "Goshov",
                            FamilyName = "Peshov",
                            Speciality = Speciality.English,
                            Grade = Grade.TwlelfthGrade

                        },
                                new Student()
                        {
                            FirstName = "Iasen",
                            Surname = "Ivanov",
                            FamilyName = "Toshkov",
                            Speciality = Speciality.Math,
                            Grade = Grade.EleventhGrade

                        },
                                 new Student()
                        {
                            FirstName = "Ivan",
                            Surname = "Goranov",
                            FamilyName = "Georgiev",
                            Speciality = Speciality.Chemistry,
                            Grade = Grade.NinthGrade

                        },

                    });
                    context.SaveChanges();
                }
                if (!context.Teachers.Any())
                {
                    context.Teachers.AddRange(new List<Teacher>()
                    {
                        new Teacher()
                        {
                             FirstName = "Georgi",
                            Surname = "Vurtoglavov",
                            FamilyName = "Pulev",
                            Speciality = Speciality.Math

                        },
                         new Teacher()
                        {
                             FirstName = "Iordan",
                            Surname = "Stefanov",
                            FamilyName = "Iavorov",
                            Speciality = Speciality.English

                        },

                         new Teacher()
                        {
                             FirstName = "Valentin",
                            Surname = "Andrew",
                            FamilyName = "Kolev",
                            Speciality = Speciality.Russian

                        },
                          new Teacher()
                        {
                             FirstName = "Cheko",
                            Surname = "Totev",
                            FamilyName = "Petrov",
                            Speciality = Speciality.Chinese

                        },
                          new Teacher()
                        {
                             FirstName = "Evgeni",
                            Surname = "Cvetomirov",
                            FamilyName = "Niikolov",
                            Speciality = Speciality.Biology

                        }

                    });
                    context.SaveChanges();

                   

                    }
                }

            }
        }
    }

