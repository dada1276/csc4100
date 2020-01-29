using System;
namespace inheritance_1_27 {

   class people {
        public  abstract class Person {
            public string firstName;
            public string lastName;
            public string email;
            public int zip;
        }

        public class student : Person {
            public string major;

            public student(string firstName, string lastName, string email, int zip, string major) {
                this.firstName = firstName;
                this.lastName = lastName;
                this.email = email;
                this.zip = zip;
                this.major = major;
            }
        }
        public class Instructor {
            string firstName;
            string lastName;
            string email;
            int zip;
            string sujectMatter;
        }

        public class staff {
            string firstName;
            string lastName;
            string email;
            int zip;
            string areaOfExpertise;
        }
    }
}
