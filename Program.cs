using System;
using System.Runtime.Intrinsics.X86;

namespace ENROLLMENT_SYSTEM_1._1
{
    class ENROLLMENT1
    {
        public static void Main(string[] args)
        {
            bool top1 = true;
            while (top1)
            {
                bool top = true;
                while (top)
                {
                    Introduce();
                    Console.Write("Which program would you like to take? ");
                    int program = int.Parse(Console.ReadLine());

                    int course = GetC(program);

                    if (program == 1)
                    {
                        Console.Write("\n\tFirstname: ");
                        string fN = Console.ReadLine();
                        Console.Write("\tSurname: ");
                        string sN = Console.ReadLine();
                        Console.Write("\tMiddle Name: ");
                        string mN = Console.ReadLine();
                        Console.Write("\tBirth Month: ");
                        string bMonth = Console.ReadLine();
                        Console.Write("\tBirthday: ");
                        int bDay = int.Parse(Console.ReadLine());
                        Console.Write("\tBirth Year: ");
                        int bYear = int.Parse(Console.ReadLine());
                        Console.Write("\tAGE: ");
                        int iAge = int.Parse(Console.ReadLine());
                        Console.Write("\tGENDER: ");
                        string gender = Console.ReadLine();
                        Console.Write("\tCitizenship: ");
                        string citizen = Console.ReadLine();
                        Console.Write("\tAcademic Year: ");
                        int acadYear = int.Parse(Console.ReadLine());
                        Console.Write("\tContact Number: ");
                        long num = long.Parse(Console.ReadLine());

                        Note();

                        Console.Write("\nWOULD YOU LIKE TO CONTINUE? [YES/BACK] ");
                        string response = Console.ReadLine().ToUpper();
                        string resPonse = "YES";
                        string res2 = "BACK";
                        Console.Clear();

                        double gwa;
                        double ave = 87.00;
                        if (response == resPonse)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\n\t\t\t\t\t\tEVALUATION SECTION");
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                            Console.Write("\nLast academic year's GWA: ");
                            gwa = double.Parse(Console.ReadLine());
                            if (gwa >= ave)
                            {
                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\n\t\t\t\t\t   CONGRATULATIONS! You are eligible.");
                                Console.WriteLine("\n\nHere are the complete details you provided.");
                                Console.Write("Would you like to continue? [YES/NO] ");
                                string con = Console.ReadLine().ToUpper();
                                string con2 = "YES";

                                if (con == con2)
                                {
                                    string studNum = Name.GetStudentNumber();
                                    Console.Clear();
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n\t\t\t\t  POLYTECHNIC UNIVERSITY OF THE PHILIPPINES-BINAN CAMPUS");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                                    Name.StudentNumber();
                                    Console.WriteLine("                  \t\t                                                                                     ");
                                    Console.WriteLine($"\tAPPLICANT {sN} \t\t                                                                                    ");
                                    Console.WriteLine($"\t               \t\t+ [STUDENT NUMBER] {studNum}");
                                    Console.WriteLine($"\t               \t\t+ [NAME] {sN}, {fN} {mN}");
                                    Console.WriteLine($"\t               \t\t+ [AGE] {iAge} years old");
                                    Console.WriteLine($"\t               \t\t+ [BIRTHDATE] {bMonth} {bDay}, {bYear}");
                                    Console.WriteLine($"\t               \t\t+ [GENDER] {gender}");
                                    Console.WriteLine($"\t               \t\t+ [CITIZENSHIP] {citizen}");
                                    Console.WriteLine($"\t               \t\t+ [ACADEMIC YEAR] {acadYear}");
                                    Console.WriteLine($"\t               \t\t+ [CONTACT INFORMATION] {num}");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"\n\n\t\t\t[YOU ARE ELIGIBLE TO TAKE BACHELOR OF SCIENCE IN COMPUTER ENGINEERING]");
                                    Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("Would you like to register again? [YES/NO] ");
                                    string ans = Console.ReadLine().ToUpper();
                                    string ans1 = "YES";
                                    string ans2 = "NO".ToUpper();

                                    if (ans == ans1)
                                    {
                                        Console.Clear();
                                        top1 = true;
                                    }
                                    else if (ans == ans2)
                                    {
                                        top1 = false;
                                        Console.Clear();
                                    }

                                }
                                else
                                {
                                    Console.Clear();
                                }

                            }
                            else
                            {
                                Console.WriteLine("You are not eligible to enroll to this course.");
                            }
                            break;
                        }
                        else if (response == res2)
                        {
                            top = true;
                            Console.Clear();
                        }
                    }
                    if (program == 2)
                    {
                        Console.Write("\n\tFirstname: ");
                        string fN = Console.ReadLine();
                        Console.Write("\tSurname: ");
                        string sN = Console.ReadLine();
                        Console.Write("\tMiddle Name: ");
                        string mN = Console.ReadLine();
                        Console.Write("\tBirth Month: ");
                        string bMonth = Console.ReadLine();
                        Console.Write("\tBirthday: ");
                        int bDay = int.Parse(Console.ReadLine());
                        Console.Write("\tBirth Year: ");
                        int bYear = int.Parse(Console.ReadLine());
                        Console.Write("\tAGE: ");
                        int iAge = int.Parse(Console.ReadLine());
                        Console.Write("\tGENDER: ");
                        string gender = Console.ReadLine();
                        Console.Write("\tCitizenship: ");
                        string citizen = Console.ReadLine();
                        Console.Write("\tAcademic Year: ");
                        int acadYear = int.Parse(Console.ReadLine());
                        Console.Write("\tContact Number: ");
                        long num = long.Parse(Console.ReadLine());
                        //sort things out right here

                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\t\t\tNOTE: The applicant's general weighted average will be evaluated in this section.");
                        Console.WriteLine("\t***Applicants must have a minimum GWA of 87.00 for BSIE or its equivalent to be eligible for enrollment.***");
                        Console.WriteLine("\t\t\t***The GWA must be from the most recent completed academic term or year.***");
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                        Console.Write("\nWOULD YOU LIKE TO CONTINUE? [YES/BACK] ");
                        string response = Console.ReadLine().ToUpper();
                        string resPonse = "YES";
                        string res2 = "BACK";
                        double gwa;
                        double ave = 87.00;

                        if (response == resPonse)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\n\t\t\t\t\t\tEVALUATION SECTION");
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                            Console.Write("\nLast academic year's GWA: ");
                            gwa = double.Parse(Console.ReadLine());
                            if (gwa >= ave)
                            {
                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\n\t\t\t\t\t   CONGRATULATIONS! You are eligible.");
                                Console.WriteLine("\n\nHere are the complete details you provided.");
                                Console.Write("Would you like to continue? [YES/NO] ");
                                string con = Console.ReadLine().ToUpper();
                                string con2 = "YES";
                                string con3 = "NO";

                                if (con == con2)
                                {
                                    string studNum = Name.GetStudentNumber();
                                    Console.Clear();
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n\t\t\t\t  POLYTECHNIC UNIVERSITY OF THE PHILIPPINES-BINAN CAMPUS");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("                  \t\t                                                                                     ");
                                    Console.WriteLine($"\tAPPLICANT {sN} \t\t                                                                                     ");
                                    Console.WriteLine($"\t               \t\t+ [STUDENT NUMBER] {studNum}");
                                    Console.WriteLine($"\t               \t\t+ [NAME] {sN}, {fN} {mN}");
                                    Console.WriteLine($"\t               \t\t+ [AGE] {iAge} years old");
                                    Console.WriteLine($"\t               \t\t+ [BIRTHDATE] {bMonth} {bDay}, {bYear}");
                                    Console.WriteLine($"\t               \t\t+ [GENDER] {gender}");
                                    Console.WriteLine($"\t               \t\t+ [CITIZENSHIP] {citizen}");
                                    Console.WriteLine($"\t               \t\t+ [ACADEMIC YEAR] {acadYear}");
                                    Console.WriteLine($"\t               \t\t+ [CONTACT INFORMATION] {num}");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"\n\t\t\t[YOU ARE ELIGIBLE TO TAKE BACHELOR OF SCIENCE IN INDUSTRIAL ENGINEERING]");
                                    Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("Would you like to register again? [YES/NO] ");
                                    string ans = Console.ReadLine().ToUpper();
                                    string ans1 = "YES";
                                    string ans2 = "NO".ToUpper();

                                    if (ans == ans1)
                                    {
                                        Console.Clear();
                                        top1 = true;
                                    }
                                    else if (ans == ans2)
                                    {
                                        top1 = false;
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                }

                            }
                            else
                            {
                                Console.WriteLine("You are not eligible to enroll to this course.");
                            }
                            break;
                        }
                        else if (response == res2)
                        {
                            top = true;
                            Console.Clear();
                        }
                    }
                    else if (program == 3)
                    {
                        Console.Write("\n\tFirstname: ");
                        string fN = Console.ReadLine();
                        Console.Write("\tSurname: ");
                        string sN = Console.ReadLine();
                        Console.Write("\tMiddle Name: ");
                        string mN = Console.ReadLine();
                        Console.Write("\tBirth Month: ");
                        string bMonth = Console.ReadLine();
                        Console.Write("\tBirthday: ");
                        int bDay = int.Parse(Console.ReadLine());
                        Console.Write("\tBirth Year: ");
                        int bYear = int.Parse(Console.ReadLine());
                        Console.Write("\tAGE: ");
                        int iAge = int.Parse(Console.ReadLine());
                        Console.Write("\tGENDER: ");
                        string gender = Console.ReadLine();
                        Console.Write("\tCitizenship: ");
                        string citizen = Console.ReadLine();
                        Console.Write("\tAcademic Year: ");
                        int acadYear = int.Parse(Console.ReadLine());
                        Console.Write("\tContact Number: ");
                        long num = long.Parse(Console.ReadLine());
                        //sort things out right here

                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\t\t\tNOTE: The applicant's general weighted average will be evaluated in this section.");
                        Console.WriteLine("\t***Applicants must have a minimum GWA of 85.00 for BSIT or its equivalent to be eligible for enrollment.***");
                        Console.WriteLine("\t\t\t***The GWA must be from the most recent completed academic term or year.***");
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                        Console.Write("\nWOULD YOU LIKE TO CONTINUE? [YES/BACK] ");
                        string response = Console.ReadLine().ToUpper();
                        string resPonse = "YES";
                        string res2 = "BACK";
                        double gwa;
                        double ave = 85.00;

                        if (response == resPonse)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\n\t\t\t\t\t\tEVALUATION SECTION");
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                            Console.Write("\nLast academic year's GWA: ");
                            gwa = double.Parse(Console.ReadLine());
                            if (gwa >= ave)
                            {
                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\n\t\t\t\t\t   CONGRATULATIONS! You are eligible.");
                                Console.WriteLine("\n\nHere are the complete details you provided.");
                                Console.Write("Would you like to continue? [YES/NO] ");
                                string con = Console.ReadLine().ToUpper();
                                string con2 = "YES";
                                string con3 = "NO";

                                if (con == con2)
                                {
                                    string studNum = Name.GetStudentNumber();
                                    Console.Clear();
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n\t\t\t\t  POLYTECHNIC UNIVERSITY OF THE PHILIPPINES-BINAN CAMPUS");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("                  \t\t                                                                                     ");
                                    Console.WriteLine($"\tAPPLICANT {sN} \t\t                                                                                     ");
                                    Console.WriteLine($"\t               \t\t+ [STUDENT NUMBER] {studNum}");
                                    Console.WriteLine($"\t               \t\t+ [NAME] {sN}, {fN} {mN}");
                                    Console.WriteLine($"\t               \t\t+ [AGE] {iAge} years old");
                                    Console.WriteLine($"\t               \t\t+ [BIRTHDATE] {bMonth} {bDay}, {bYear}");
                                    Console.WriteLine($"\t               \t\t+ [GENDER] {gender}");
                                    Console.WriteLine($"\t               \t\t+ [CITIZENSHIP] {citizen}");
                                    Console.WriteLine($"\t               \t\t+ [ACADEMIC YEAR] {acadYear}");
                                    Console.WriteLine($"\t               \t\t+ [CONTACT INFORMATION] {num}");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"\n\t\t\t[YOU ARE ELIGIBLE TO TAKE BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY]");
                                    Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("Would you like to register again? [YES/NO] ");
                                    string ans = Console.ReadLine().ToUpper();
                                    string ans1 = "YES";
                                    string ans2 = "NO".ToUpper();

                                    if (ans == ans1)
                                    {
                                        Console.Clear();
                                        top1 = true;
                                    }
                                    else if (ans == ans2)
                                    {
                                        top1 = false;
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                }

                            }
                            else
                            {
                                Console.WriteLine("You are not eligible to enroll to this course.");
                            }
                            break;
                        }
                        else if (response == res2)
                        {
                            top = true;
                            Console.Clear();
                        }
                    }
                    else if (program == 4)
                    {
                        Console.Write("\n\tFirstname: ");
                        string fN = Console.ReadLine();
                        Console.Write("\tSurname: ");
                        string sN = Console.ReadLine();
                        Console.Write("\tMiddle Name: ");
                        string mN = Console.ReadLine();
                        Console.Write("\tBirth Month: ");
                        string bMonth = Console.ReadLine();
                        Console.Write("\tBirthday: ");
                        int bDay = int.Parse(Console.ReadLine());
                        Console.Write("\tBirth Year: ");
                        int bYear = int.Parse(Console.ReadLine());
                        Console.Write("\tAGE: ");
                        int iAge = int.Parse(Console.ReadLine());
                        Console.Write("\tGENDER: ");
                        string gender = Console.ReadLine();
                        Console.Write("\tCitizenship: ");
                        string citizen = Console.ReadLine();
                        Console.Write("\tAcademic Year: ");
                        int acadYear = int.Parse(Console.ReadLine());
                        Console.Write("\tContact Number: ");
                        long num = long.Parse(Console.ReadLine());
                        //sort things out right here

                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\t\t\tNOTE: The applicant's general weighted average will be evaluated in this section.");
                        Console.WriteLine("\t***Applicants must have a minimum GWA of 87.00 for DCpET or its equivalent to be eligible for enrollment.***");
                        Console.WriteLine("\t\t\t***The GWA must be from the most recent completed academic term or year.***");
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                        Console.Write("\nWOULD YOU LIKE TO CONTINUE? [YES/BACK] ");
                        string response = Console.ReadLine().ToUpper();
                        string resPonse = "YES";
                        string res2 = "BACK";
                        double gwa;
                        double ave = 87.00;

                        if (response == resPonse)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\n\t\t\t\t\t\tEVALUATION SECTION");
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                            Console.Write("\nLast academic year's GWA: ");
                            gwa = double.Parse(Console.ReadLine());
                            if (gwa >= ave)
                            {
                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\n\t\t\t\t\t   CONGRATULATIONS! You are eligible.");
                                Console.WriteLine("\n\nHere are the complete details you provided.");
                                Console.Write("Would you like to continue? [YES/NO] ");
                                string con = Console.ReadLine().ToUpper();
                                string con2 = "YES";
                                string con3 = "NO";

                                if (con == con2)
                                {
                                    string studNum = Name.GetStudentNumber();
                                    Console.Clear();
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n\t\t\t\t  POLYTECHNIC UNIVERSITY OF THE PHILIPPINES-BINAN CAMPUS");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("                  \t\t                                                                                     ");
                                    Console.WriteLine($"\tAPPLICANT {sN} \t\t                                                                                     ");
                                    Console.WriteLine($"\t               \t\t+ [STUDENT NUMBER] {studNum}");
                                    Console.WriteLine($"\t               \t\t+ [NAME] {sN}, {fN} {mN}");
                                    Console.WriteLine($"\t               \t\t+ [AGE] {iAge} years old");
                                    Console.WriteLine($"\t               \t\t+ [BIRTHDATE] {bMonth} {bDay}, {bYear}");
                                    Console.WriteLine($"\t               \t\t+ [GENDER] {gender}");
                                    Console.WriteLine($"\t               \t\t+ [CITIZENSHIP] {citizen}");
                                    Console.WriteLine($"\t               \t\t+ [ACADEMIC YEAR] {acadYear}");
                                    Console.WriteLine($"\t               \t\t+ [CONTACT INFORMATION] {num}");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"\n\t\t\t[YOU ARE ELIGIBLE TO TAKE DIPLOMA IN COMPUTER ENGINEERING]");
                                    Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("Would you like to register again? [YES/NO] ");
                                    string ans = Console.ReadLine().ToUpper();
                                    string ans1 = "YES";
                                    string ans2 = "NO".ToUpper();

                                    if (ans == ans1)
                                    {
                                        Console.Clear();
                                        top1 = true;
                                    }
                                    else if (ans == ans2)
                                    {
                                        top1 = false;
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                }

                            }
                            else
                            {
                                Console.WriteLine("You are not eligible to enroll to this course.");
                            }
                            break;
                        }
                        else if (response == res2)
                        {
                            top = true;
                            Console.Clear();
                        }
                    }
                    else if (program == 5)
                    {
                        Console.Write("\n\tFirstname: ");
                        string fN = Console.ReadLine();
                        Console.Write("\tSurname: ");
                        string sN = Console.ReadLine();
                        Console.Write("\tMiddle Name: ");
                        string mN = Console.ReadLine();
                        Console.Write("\tBirth Month: ");
                        string bMonth = Console.ReadLine();
                        Console.Write("\tBirthday: ");
                        int bDay = int.Parse(Console.ReadLine());
                        Console.Write("\tBirth Year: ");
                        int bYear = int.Parse(Console.ReadLine());
                        Console.Write("\tAGE: ");
                        int iAge = int.Parse(Console.ReadLine());
                        Console.Write("\tGENDER: ");
                        string gender = Console.ReadLine();
                        Console.Write("\tCitizenship: ");
                        string citizen = Console.ReadLine();
                        Console.Write("\tAcademic Year: ");
                        int acadYear = int.Parse(Console.ReadLine());
                        Console.Write("\tContact Number: ");
                        long num = long.Parse(Console.ReadLine());
                        //sort things out right here

                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\t\t\tNOTE: The applicant's general weighted average will be evaluated in this section.");
                        Console.WriteLine("\t***Applicants must have a minimum GWA of 85.00 for DCIT or its equivalent to be eligible for enrollment.***");
                        Console.WriteLine("\t\t\t***The GWA must be from the most recent completed academic term or year.***");
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                        Console.Write("\nWOULD YOU LIKE TO CONTINUE? [YES/BACK] ");
                        string response = Console.ReadLine().ToUpper();
                        string resPonse = "YES";
                        string res2 = "BACK";
                        double gwa;
                        double ave = 85.00;

                        if (response == resPonse)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("\n\t\t\t\t\t\tEVALUATION SECTION");
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                            Console.Write("\nLast academic year's GWA: ");
                            gwa = double.Parse(Console.ReadLine());
                            if (gwa >= ave)
                            {
                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\n\t\t\t\t\t   CONGRATULATIONS! You are eligible.");
                                Console.WriteLine("\n\nHere are the complete details you provided.");
                                Console.Write("Would you like to continue? [YES/NO] ");
                                string con = Console.ReadLine().ToUpper();
                                string con2 = "YES";
                                string con3 = "NO";

                                if (con == con2)
                                {
                                    string studNum = Name.GetStudentNumber();
                                    Console.Clear();
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n\t\t\t\t  POLYTECHNIC UNIVERSITY OF THE PHILIPPINES-BINAN CAMPUS");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("                  \t\t                                                                                     ");
                                    Console.WriteLine($"\tAPPLICANT {sN} \t\t                                                                                     ");
                                    Console.WriteLine($"\t               \t\t+ [STUDENT NUMBER] {studNum}");
                                    Console.WriteLine($"\t               \t\t+ [NAME] {sN}, {fN} {mN}");
                                    Console.WriteLine($"\t               \t\t+ [AGE] {iAge} years old");
                                    Console.WriteLine($"\t               \t\t+ [BIRTHDATE] {bMonth} {bDay}, {bYear}");
                                    Console.WriteLine($"\t               \t\t+ [GENDER] {gender}");
                                    Console.WriteLine($"\t               \t\t+ [CITIZENSHIP] {citizen}");
                                    Console.WriteLine($"\t               \t\t+ [ACADEMIC YEAR] {acadYear}");
                                    Console.WriteLine($"\t               \t\t+ [CONTACT INFORMATION] {num}");
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"\n\t\t\t[YOU ARE ELIGIBLE TO TAKE DIPLOMA IN INFORMATION TECHNOLOGY]");
                                    Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("Would you like to register again? [YES/NO] ");
                                    string ans = Console.ReadLine().ToUpper();
                                    string ans1 = "YES";
                                    string ans2 = "NO".ToUpper();

                                    if (ans == ans1)
                                    {
                                        Console.Clear();
                                        top1 = true;
                                    }
                                    else if (ans == ans2)
                                    {
                                        top1 = false;
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                }

                            }
                            else
                            {
                                Console.WriteLine("You are not eligible to enroll to this course.");
                            }
                            break;
                        }
                        else if (response == res2)
                        {
                            top = true;
                            Console.Clear();
                        }
                    }
                }
            }
        }
        public static void Introduce()
        {
            Console.WriteLine("\t\t\t\t\t     ENROLLMENT SYSTEM A.Y. 2024-2025");
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t  POLYTECHNIC UNIVERSITY OF THE PHILIPPINES-BINAN CAMPUS");
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n\t\t\t[1] BS COMPUTER ENGINEERING  \t\t[2] BS INDUSTRIAL ENGINEERING");
            Console.WriteLine("\n\t\t\t[3] BS INFORMATION TECHNOLOGY  \t\t[4] DIPLOMA in COMPUTER ENGINEERING");
            Console.WriteLine("\n\t\t\t\t       [5] DIPLOMA in INFORMATION TECHNOLOGY");
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
        }
        public static int GetC(int program)
        {
            int course = program;
            switch (program)
            {
                case 1:
                    Console.WriteLine("\nBACHELOR OF SCIENCE IN COMPUTER ENGINEERING");
                    break;
                case 2:
                    Console.WriteLine("\nBACHELOR OF SCIENCE IN INDUSTRIAL ENGINEERING");
                    break;
                case 3:
                    Console.WriteLine("\nBACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY");
                    break;
                case 4:
                    Console.WriteLine("\nDIPLOMA in COMPUTER ENGINEERING");
                    break;
                case 5:
                    Console.WriteLine("\nDIPLOMA in INFORMATION TECHNOLOGY");
                    break;
            }
            return course;
        }

        public static void Note()
        {
             Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\n\t\t\tNOTE: The applicant's general weighted average will be evaluated in this section.");
                    Console.WriteLine("\t***Applicants must have a minimum GWA of 87.00 for BSCpE or its equivalent to be eligible for enrollment.***");
                    Console.WriteLine("\t\t\t***The GWA must be from the most recent completed academic term or year.***");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
        }
    }
}