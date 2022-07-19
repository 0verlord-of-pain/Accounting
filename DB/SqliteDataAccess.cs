using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Accounting.Entities;
using Accounting.Enums;
using Accounting.ModalViews;
using Dapper;

namespace Accounting
{
    public class SqliteDataAccess
    {
        private const string connection = "Data Source=./DB/AccountingDB.db";

        public static IEnumerable<PayoutView> GetPayouts()
        {
            using var cnn = new SQLiteConnection(connection);
            return cnn.Query<PayoutView>(@"Select d.Name As Department, Sum(s.Value) As Money
                        From User Join Department d On User.DepartmentId = d.DepartmentId
                        Join Salary s On User.SalaryId = s.SalaryId
                        Group By d.Name");
        }

        public static IEnumerable<Department> GetDepartments()
        {
            using var cnn = new SQLiteConnection(connection);
            return cnn.Query<Department>("Select * From Department");
        }

        public static IEnumerable<Position> GetPositions()
        {
            using var cnn = new SQLiteConnection(connection);
            return cnn.Query<Position>("Select * From Position");
        }

        public static IEnumerable<UserView> GetUsers()
        {
            IDbConnection cnn = new SQLiteConnection(connection);

            var users = cnn.Query<UserView>(
                @"Select UserId, 
                        (Select Name From Name Where NameId = User.NameId) As Name,
                        (Select LastName From LastName Where LastNameId = User.LastNameId)  As LastName,
                        (Select FatherName From FatherName Where FatherNameId = User.FatherNameId) As FatherName,
                        (Select Name From Department Where DepartmentId = User.DepartmentId) As Department,
                        (Select Name From Position Where PositionId = User.PositionId) As Position,
                        (Select Value From Salary Where SalaryId = User.SalaryId) As Salary,
                        (Select Value From PremiumFactor Where PremiumFactorId =  User.PremiumFactorId) As PremiumFactor
                    From User");

            foreach (var user in users)
            {
                switch (user.PremiumType)
                {
                    case PremiumType.A:
                        user.Premium = user.Salary * 0.8m;
                        break;
                    case PremiumType.B:
                        user.Premium = user.Salary * 0.7m;
                        break;
                    case PremiumType.C:
                        user.Premium = user.Salary * 0.6m;
                        break;
                }
            }
            return users;
        }

        public static UserInfoView GetUserById(int userId)
        {
            using var cnn = new SQLiteConnection(connection);
            var user = cnn.QueryFirstOrDefault<UserInfoView>(
                @$"Select UserId, 
                        (Select Name From Name Where NameId = User.NameId) As Name,
                        (Select LastName From LastName Where LastNameId = User.LastNameId)  As LastName,
                        (Select FatherName From FatherName Where FatherNameId = User.FatherNameId) As FatherName,
                        PhoneNumber,
                        Address,
                        (Select Name From Department Where DepartmentId = User.DepartmentId) As Department,
                        (Select Name From Position Where PositionId = User.PositionId) As Position,
                        (Select Value From Salary Where SalaryId = User.SalaryId) As Salary,
                        (Select Value From PremiumFactor Where PremiumFactorId =  User.PremiumFactorId) As PremiumFactor
                    From User Where UserId = {userId}");

            switch (user.PremiumType)
            {
                case PremiumType.A:
                    user.Premium = user.Salary * 0.8m;
                    break;
                case PremiumType.B:
                    user.Premium = user.Salary * 0.7m;
                    break;
                case PremiumType.C:
                    user.Premium = user.Salary * 0.6m;
                    break;
            }

            return user;
        }

        public static IEnumerable<UserView> GetUsersForReport()
        {
            var users = GetUsers().OrderBy(i => i.Department);
            return users;
        }

        public static void UpdateUser(int userId, string name, string lastName, string fatherName,
            string phoneNumber, string address, string department, string position, decimal salary, PremiumType premiumType)
        {
            using var cnn = new SQLiteConnection(connection);
            var nameId = InsertName(name);
            var lastNameId = InsertLastName(lastName);
            var fatherNameId = InsertFatherName(fatherName);
            var departmentId = InsertDepartment(department);
            var positionId = InsertPosition(position);
            var premiumFactorId = InsertPremiumFactor(premiumType.ToString());
            var salaryId = InsertSalary(salary);
            cnn.Query(@$"Update User Set
                NameId = {nameId}, LastNameId = {lastNameId}, FatherNameId = {fatherNameId}, DepartmentId = {departmentId},
                PositionId = {positionId}, PremiumFactorId = {premiumFactorId}, SalaryId = {salaryId},
                PhoneNumber = '{phoneNumber}', Address = '{address}'
                    Where UserId = {userId}");
        }

        public static void InsertUser(string name, string lastName, string fatherName,
            string phoneNumber, string address, string department, string position, decimal salary, PremiumType premiumType)
        {
            using var cnn = new SQLiteConnection(connection);
            var nameId = InsertName(name);
            var lastNameId = InsertLastName(lastName);
            var fatherNameId = InsertFatherName(fatherName);
            var departmentId = InsertDepartment(department);
            var positionId = InsertPosition(position);
            var premiumFactorId = InsertPremiumFactor(premiumType.ToString());
            var salaryId = InsertSalary(salary);

            cnn.Query(@$"Insert Into User 
                        (NameId, LastNameId, FatherNameId, DepartmentId, PositionId, PremiumFactorId, SalaryId, PhoneNumber, Address)
                        Values ({nameId},{lastNameId}, {fatherNameId},{departmentId},{positionId},
                            {premiumFactorId},{salaryId},'{phoneNumber}','{address}')");
        }

        public static int InsertName(string name)
        {
            using var cnn = new SQLiteConnection(connection);
            var nameId = cnn.QueryFirstOrDefault<int>($"Select NameId From Name Where Name = '{name}'");

            if (nameId == 0)
            {
                cnn.Query($"Insert Into Name (Name) Values('{name}')");
                nameId = cnn.QueryFirstOrDefault<int>($"Select NameId From Name Where Name = '{name}'");
            }

            return nameId;
        }

        public static int InsertLastName(string lastName)
        {
            using var cnn = new SQLiteConnection(connection);
            var lastNameId = cnn.QueryFirstOrDefault<int>($"Select LastNameId From LastName Where LastName = '{lastName}'");

            if (lastNameId == 0)
            {
                cnn.Query($"Insert Into LastName (LastName) Values('{lastName}')");
                lastNameId = cnn.QueryFirstOrDefault<int>($"Select LastNameId From LastName Where LastName = '{lastName}'");
            }

            return lastNameId;
        }

        public static int InsertFatherName(string fatherName)
        {
            using var cnn = new SQLiteConnection(connection);
            var fatherNameId = cnn.QueryFirstOrDefault<int>($"Select FatherNameId From FatherName Where FatherName = '{fatherName}'");

            if (fatherNameId == 0)
            {
                cnn.Query($"Insert Into FatherName (FatherName) Values('{fatherName}')");
                fatherNameId = cnn.QueryFirstOrDefault<int>($"Select FatherNameId From FatherName Where FatherName = '{fatherName}'");
            }

            return fatherNameId;
        }

        public static int InsertDepartment(string department)
        {
            using var cnn = new SQLiteConnection(connection);
            var departmentId = cnn.QueryFirstOrDefault<int>($"Select DepartmentId From Department Where Name = '{department}'");

            if (departmentId == 0)
            {
                cnn.Query($"Insert Into Department (Name) Values('{department}')");
                departmentId = cnn.QueryFirstOrDefault<int>($"Select DepartmentId From Department Where Name = '{department}'");
            }

            return departmentId;
        }

        public static int InsertPosition(string position)
        {
            using var cnn = new SQLiteConnection(connection);
            var positionId = cnn.QueryFirstOrDefault<int>($"Select PositionId From Position Where Name = '{position}'");

            if (positionId == 0)
            {
                cnn.Query($"Insert Into Position (Name) Values('{position}')");
                positionId = cnn.QueryFirstOrDefault<int>($"Select PositionId From Position Where Name = '{position}'");
            }

            return positionId;
        }

        public static int InsertPremiumFactor(string premiumType)
        {
            using var cnn = new SQLiteConnection(connection);
            var premiumTypeId = cnn.QueryFirstOrDefault<int>($"Select PremiumFactorId From PremiumFactor Where Value = '{premiumType}'");

            if (premiumTypeId == 0)
            {
                cnn.Query($"Insert Into PremiumFactor (Value) Values('{premiumType}')");
                premiumTypeId = cnn.QueryFirstOrDefault<int>($"Select PremiumFactorId From PremiumFactor Where Value = '{premiumType}'");
            }

            return premiumTypeId;
        }

        public static int InsertSalary(decimal salary)
        {
            using var cnn = new SQLiteConnection(connection);
            var salaryId = cnn.QueryFirstOrDefault<int>($"Select SalaryId From Salary Where Value = '{salary}'");

            if (salaryId == 0)
            {
                cnn.Query($"Insert Into Salary (Value) Values('{salary}')");
                salaryId = cnn.QueryFirstOrDefault<int>($"Select SalaryId From Salary Where Value = '{salary}'");
            }

            return salaryId;
        }

        public static void DeleteUser(int userId)
        {
            using var cnn = new SQLiteConnection(connection);
            cnn.Query<int>($"Delete From User Where UserId = {userId}");
        }

        public static void DeleteDepartment(int departmentId)
        {
            using var cnn = new SQLiteConnection(connection);
            cnn.Query<int>($"Delete From Department Where DepartmentId = {departmentId}");
        }

        public static void DeletePosition(int positionId)
        {
            using var cnn = new SQLiteConnection(connection);
            cnn.Query<int>($"Delete From Position Where PositionId = {positionId}");
        }

        public static void UpdateDepartment(int departmentId, string name)
        {
            using var cnn = new SQLiteConnection(connection);
            cnn.Query(@$"Update Department Set
                DepartmentId = {departmentId} , Name = '{name}'
                Where DepartmentId = {departmentId}");
        }

        public static void UpdatePosition(int positionId, string name)
        {
            using var cnn = new SQLiteConnection(connection);
            cnn.Query(@$"Update Position Set
                PositionId = {positionId} , Name = '{name}'
                Where PositionId = {positionId}");
        }
    }
}