using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENROLLMENT_SYSTEM_1._1
{
    internal class Name
    {
        static List<string> users = new List<string>();
        static int studentCount = 0;
        public static void StudentNumber()
        {
            users.Add("2024-00001-BN-0");
            users.Add("2024-00002-BN-0");
            users.Add("2024-00003-BN-0");
            users.Add("2024-00004-BN-0");
            users.Add("2024-00005-BN-0");
            users.Add("2024-00006-BN-0");
            users.Add("2024-00007-BN-0");
            users.Add("2024-00008-BN-0");
            users.Add("2024-00009-BN-0");
            users.Add("2024-00010-BN-0");

        }
        public static string GetStudentNumber()
        {
            StudentNumber();
            if (studentCount >= users.Count)
            {
                return "No slot available";
            }
            return users[studentCount++];
        } 
    }
}
