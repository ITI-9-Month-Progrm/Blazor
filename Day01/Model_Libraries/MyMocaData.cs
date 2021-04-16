using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Libraries
{
    public static class MyMocaData
    {
        public static  List<Trainee> trainees = new List<Trainee>()
            {
                new Trainee {
                    Trainee_ID=1,
                    Name="Asmaa Khaled",
                    Email="asmaakhaled603@gmail.com",
                    IsGraduated=Graduated.Student,
                    Gender=Gender.female,
                    Birthdate=new DateTime(1998, 8, 22),
                    MobileNumber = "01015069799",
                    
                },
                new Trainee {
                    Trainee_ID=2,
                    Name="Omar Ali",
                    Email="omarali22@gmail.com",
                    IsGraduated=Graduated.Graduated,
                    Gender=Gender.male,
                    Birthdate=new DateTime(1996, 10, 2),
                    MobileNumber = "01015011111",
                    
                }
            };

        public static List<Track> tracks = new List<Track>()
        {
            new Track { Name = "SD", Description = "System Development" },
            new Track { Name = "MN", Description = "Mobile Native" }
        };
    }
}
