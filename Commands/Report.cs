using System.Collections.Generic;

namespace Accounting.Commands
{
    public class Report
    {
        public static IEnumerable<string> CreateReport()
        {
            var users = SqliteDataAccess.GetUsersForReport();

            var reports = new List<string>();

            foreach (var user in users)
            {
                reports.Add(string.Format("{0} {1} {2}, {3}, {4}, {5}, {6}, {7}",
                    user.LastName, user.Name, user.FatherName,
                    user.Department, user.Position, user.Salary,
                    user.PremiumType, user.Premium));
            }

            return reports;
        }
    }
}