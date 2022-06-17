using FinalTeacherStudentProject.Data.ApplicationContext;
using FinalTeacherStudentProject.Data.Models;
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
                            Id = "4"
                        },
                         new Student()
                        {
                            FirstName = "Gosho",
                            Surname = "Vladislavov",
                            FamilyName = "Edrov",
                            Id = "5"
                        },
                            new Student()
                        {
                            FirstName = "Mi60",
                            Surname = "Goshov",
                            FamilyName = "Peshov",
                            Id = "6"
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
                             FirstName = "Fa6o",
                            Surname = "Vurtoglavov",
                            FamilyName = "Pulev",
                            Id = "2"
                        },
                         new Teacher()
                        {
                             FirstName = "Koko",
                            Surname = "Kukov",
                            FamilyName = "Bonov",
                            Id = "3"
                        },

                         new Teacher()
                        {
                             FirstName = "Seb",
                            Surname = "Astian",
                            FamilyName = "Vettelov",
                            Id = "4"
                        },
                          new Teacher()
                        {
                             FirstName = "Lewis",
                            Surname = "FantasticP",
                            FamilyName = "Hamilton",
                            Id = "420"
                        }

                    });
                    context.SaveChanges();

                    if (!context.Specialities.Any())
                    {
                        context.Specialities.AddRange(new List<Speciality>()
                        {
                            new Speciality()
                            {
                                Id = "1",
                                SpecialityName = "Math"
                            },
                            new Speciality()
                            {
                                Id = "2",
                                SpecialityName = "Bulgarian"

                            },
                            new Speciality()
                            {
                                Id = "3",
                                SpecialityName = "English"
                            },
                            new Speciality()
                            {
                                Id = "9/11",
                                SpecialityName = "Bombing"
                            }
                        }) ;
                        context.SaveChanges();

                    }
                }

            }
        }
    }
}
