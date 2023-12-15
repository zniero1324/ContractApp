using ContractApp.MVVM.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ContractApp.MVVM.ViewModels;

namespace ContractApp.Services
{
    public class Connection
    {
        public static ObservableCollection<OverAllDataModel> LoadOverAllDataObservable(string search = null)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = new ObservableCollection<OverAllDataModel>();

                // Your existing query
                string baseQuery = @"SELECT DISTINCT m.maidID AS 'MaidID', m.bioCode AS 'BioCode', m.name AS 'Name', m.wpNo AS 'wpNo', m.passportNo AS 'PassportNo',
                                           m.status AS 'Status', m.nationality AS 'Nationality', m.cardNo AS 'FinNo', m.dateOfBirth AS 'DOB', m.salary AS 'Salary',
                                           m.overseasFee AS 'OverseasFee', m.sgServiceFee AS 'SG_ServiceFee', m.restDaySalary AS 'RestDaySalary',
                                           m.deployDate AS 'DeployDate', m.backToAgency AS 'BackToAgency',
                                           fees.*, e.*,s.*
                                    FROM Maid m
                                    LEFT JOIN Fees fees ON m.maidID = fees.maidID
                                    LEFT JOIN Employer e ON m.empID = e.empID
                                    LEFT JOIN Employer s ON s.empID = e.spouseID"; // Join with the Employer table

                string finalQuery;

                if (!string.IsNullOrWhiteSpace(search))
                {
                    // If search is not null, include the search criteria
                    finalQuery = baseQuery + " WHERE m.name LIKE @Search ORDER BY m.name ASC";
                }
                else
                {
                    // If search is null or empty, fetch all maids
                    finalQuery = baseQuery + " ORDER BY m.name ASC";
                }

                var parameters = new DynamicParameters();
                parameters.Add("@Search", "%" + search + "%");

                var data = con.Query<MaidModel, FeesModel, EmployerModel, EmployerModel, OverAllDataModel>(
                    finalQuery,
                    (maid, fees, employer, spouse) =>
                    {
                        // Handle data mapping here
                        // Create and return OverAllDataModel object
                        return new OverAllDataModel
                        {
                            Maid = maid,
                            Fees = new ObservableCollection<FeesModel> { fees },
                            Employer = employer,
                            Spouse = spouse
                            
                            // Add other properties as needed
                        };
                    },
                    splitOn: "MaidID, FeeID, EmpId, EmpId",
                    param: parameters);


                foreach (var item in data)
                {
                    result.Add(item);
                }

                return result;
            }
        }


        public static ObservableCollection<Tuple<MaidModel, FeesModel>> LoadMaidObservable(string searchMaid)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                if (searchMaid != null)
                {
                    var result = new ObservableCollection<Tuple<MaidModel, FeesModel>>();

                    var maids = con.Query<MaidModel>($"SELECT \r\nmaidID AS \"MaidID\"," +
                        $"\r\nbioCode AS \"BioCode\"," +
                        $"\r\nname AS \"Name\",\r\nwpNo AS \"wpNo\",\r\npassportNo AS \"PassportNo\"," +
                        $"\r\nstatus AS \"Status\",\r\nnationality AS \"Nationality\",\r\ncardNo AS \"FinNo\"," +
                        $"\r\ndateOfBirth AS \"DOB\",\r\nsalary AS \"Salary\",\r\noverseasFee AS \"OverseasFee\"," +
                        $"\r\nsgServiceFee AS \"SG_ServiceFee\",\r\nrestDaySalary AS \"RestDaySalary\",\r\ndeployDate AS \"DeployDate\"," +
                        $"\r\nbackToAgency AS \"BackToAgency\",\r\nmaidID\r\n FROM Maid WHERE name LIKE '%{searchMaid}%'", new DynamicParameters());

                    foreach (var maid in maids)
                    {
                        if (maid.FinNo != null)
                        {
                            string finNo = maid.FinNo;
                            var fees = con.QueryFirstOrDefault<FeesModel>($"SELECT * FROM Maid WHERE maidID = (SELECT maidID WHERE cardNo = @FinNo)", new { FinNo = finNo });

                            result.Add(new Tuple<MaidModel, FeesModel>(maid, fees));
                        }
                    }

                    return result;
                }
                else
                {
                    var result = new ObservableCollection<Tuple<MaidModel, FeesModel>>();

                    var maids = con.Query<MaidModel>($"SELECT \r\nbioCode AS \"BioCode\"," +
                        $"\r\nname AS \"Name\",\r\nwpNo AS \"wpNo\",\r\npassportNo AS \"PassportNo\"," +
                        $"\r\nstatus AS \"Status\",\r\nnationality AS \"Nationality\",\r\ncardNo AS \"FinNo\"," +
                        $"\r\ndateOfBirth AS \"DOB\",\r\nsalary AS \"Salary\",\r\noverseasFee AS \"OverseasFee\"," +
                        $"\r\nsgServiceFee AS \"SG_ServiceFee\",\r\nrestDaySalary AS \"RestDaySalary\",\r\ndeployDate AS \"DeployDate\"," +
                        $"\r\nbackToAgency AS \"BackToAgency\",\r\nmaidID\r\n FROM Maid", new DynamicParameters());

                    foreach (var maid in maids)
                    {
                        if (maid.FinNo != null)
                        {
                            string finNo = maid.FinNo;
                            var fees = con.QueryFirstOrDefault<FeesModel>($"SELECT * FROM Fees WHERE maidID = (SELECT maidID FROM Maid WHERE cardNo = @FinNo)", new { FinNo = finNo });

                            result.Add(new Tuple<MaidModel, FeesModel>(maid, fees));
                        }
                    }

                    return result;

                }

            }
        }

        public static ObservableCollection<FamilyMemberModel> LoadFamilyMembers(string cardNo)
        {

            if (cardNo != null)
            {
                using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    var family = con.Query<FamilyMemberModel>($"SELECT name as 'Name', cardNo as 'CardNo', dateOfBirth as 'DateOfBirth', relationship as 'Relationship' FROM FamilyMember WHERE empID = (SELECT empID from Employer WHERE cardNo = 'Sxxxx56J')", new DynamicParameters());
                    return new ObservableCollection<FamilyMemberModel>(family);
                }

            }

            return new ObservableCollection<FamilyMemberModel>();

        }

        public static ObservableCollection<Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>> LoadEmployerObservable(string searchPattern = null)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                if (searchPattern != null)
                {
                    // Query employers
                    var employers = con.Query<EmployerModel>($"SELECT * FROM Employer WHERE empName LIKE '%{searchPattern}%' AND refNo IS NOT NULL ORDER BY empName ASC", new DynamicParameters());

                    // Observable collection to store tuples of EmployerModel and Spouse
                    var employerTuples = new ObservableCollection<Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>>();

                    // Iterate over each employer

                    foreach (var employer in employers)
                    {
                        if (employer.CardNo != null)
                        {
                            string cardNo = employer.CardNo;

                            // Query spouse based on empID
                            var spouse = con.Query<EmployerModel>($"SELECT * FROM employer WHERE spouseID = (SELECT empID FROM employer WHERE cardNo=@CardNo)", new { CardNo = cardNo });

                            var family = con.Query<FamilyMemberModel>($"SELECT name as 'Name', cardNo as 'CardNo', dateOfBirth as 'DateOfBirth', relationship as 'Relationship' FROM FamilyMember WHERE empID = (SELECT empID FROM employer WHERE cardNo=@CardNo)", new { CardNo = cardNo });
                            // Create a Tuple and add it to the observable collection
                            employerTuples.Add(new Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>(employer, spouse, family));
                        }
                    }
                    return employerTuples;
                }
                else
                {
                    // Query employers
                    var employers = con.Query<EmployerModel>("SELECT * FROM employer WHERE refNo IS NOT NULL ORDER BY empName ASC", new DynamicParameters());

                    // Observable collection to store tuples of EmployerModel and Spouse
                    var employerTuples = new ObservableCollection<Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>>();

                    // Iterate over each employer

                    foreach (var employer in employers)
                    {
                        if (employer.CardNo != null)
                        {
                            string cardNo = employer.CardNo;

                            // Query spouse based on empID
                            var spouse = con.Query<EmployerModel>($"SELECT * FROM employer WHERE empName LIKE '%{searchPattern}%' AND spouseID = (SELECT empID FROM employer WHERE cardNo=@CardNo)", new { CardNo = cardNo });

                            var family = con.Query<FamilyMemberModel>($"SELECT name as 'Name', cardNo as 'CardNo', " +
                               $"dateOfBirth as 'DateOfBirth', relationship as 'Relationship' FROM FamilyMember WHERE empID = (SELECT empID FROM employer WHERE cardNo=@CardNo)", new { CardNo = cardNo });

                            // Create a Tuple and add it to the observable collection
                            employerTuples.Add(new Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>(employer, spouse, family));
                        }
                    }
                    return employerTuples;
                }


            }
        }


        public static void SaveEmployer(EmployerModel employer)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("insert into employer (refNo, empName, cardNo, passportNo, dateOfBirth, address, status, profession, companyName, email, officeNo, telNo, handNo) " +
                    "values (@RefNo, @EmpName, @CardNo, @PassportNo, @DateOfBirth, @Address, @Status, @Profession, @CompanyName, @Email, @OfficeNo, @TelNo, @HandNo)", employer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            MessageBox.Show($"{employer.EmpName} was Successfully Added!");

        }

        public static void UpdateEmployer(EmployerModel employer)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("UPDATE Employer SET empName = @EmpName," +
                        "passportNo = @PassportNo, dateOfBirth = @DateOfBirth," +
                        "address = @Address,status = @Status, " +
                        "profession = @Profession, " +
                        "companyName = @CompanyName, " +
                        "email = @Email, " +
                        "telNo = @TelNo, " +
                        "officeNo = @OfficeNo, " +
                        "handNo = @HandNo WHERE empID = @EmpId;", employer);

                    MessageBox.Show($"Update Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }

        public static void UpdateMaid(MaidModel maid)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("UPDATE Maid SET bioCode = @BioCode," +
                        "name = @Name," +
                        "wpNo = @WpNo," +
                        "passportNo = @PassportNo," +
                        "status = @Status," +
                        "nationality =@Nationality," +
                        "cardNo = @FinNo," +
                        "dateOfBirth = @DOB," +
                        "salary = @Salary," +
                        "overseasFee = @OverseasFee," +
                        "sgServiceFee=@SG_ServiceFee," +
                        "restDaySalary=@RestDaySalary," +
                        "deployDate=@DeployDate," +
                        "backToAgency=@BackToAgency WHERE maidID = @MaidID", maid);

                    MessageBox.Show($"{maid.Name}\nUpdate Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }

        public static void UpdateFees(FeesModel fee)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("UPDATE Fees SET agencyFee =@AgencyFee, " +
                        "medicalExpenses = @MedicalExpenses," +
                        "newArrivalFee = @NewArrivalFee," +
                        "poea = @POEA," +
                        "pcr_hr = @PCR_HR," +
                        "expFee = @ExpFee," +
                        "insurance = @Insurance," +
                        "trf=@TRF," +
                        "airTicket_IndoEC =@AirTicket_IndoEC WHERE feeID = @FeeID;", fee);

                    MessageBox.Show($"Update Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }
        public static void UpdateFamily(FamilyMemberModel member)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("UPDATE FamilyMember SET name=@Name, dateOfBirth=@DateOfBirth, relationship=@Relationship WHERE cardNo = @CardNo", member);

                    MessageBox.Show($"{member.Name}\nUpdate Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }

        public static void AddSpouse(EmployerModel spouse, string cardNo)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                /*con.Execute("insert into employer (empName, cardNo, passportNo, dateOfBirth, address, status, profession, companyName, officeNo, telNo, handNo) " +
                    "values (@EmpName, @CardNo, @PassportNo, @DateOfBirth, @Address, @Status, @Profession, @CompanyName, @OfficeNo, @TelNo, @HandNo)", spouse);
                con.Execute($"UPDATE Employer SET spouseID = (SELECT empID FROM Employer WHERE cardNo = @CardNo) WHERE cardNo = '{cardNo}'", spouse);
                con.Execute($"UPDATE Employer SET spouseID = (SELECT empID FROM Employer WHERE cardNo = '{cardNo}') WHERE cardNo = @CardNo", spouse);

*/

                con.Open();

                string query = $"SELECT empId FROM Employer WHERE spouseID = (SELECT empId FROM Employer WHERE cardNo = '{cardNo}')";

                using (IDbCommand cmd = new SQLiteCommand(query, (SQLiteConnection)con))
                {
                    using (IDataReader reader = cmd.ExecuteReader())
                    {

                        int rowCount = 0;

                        while (reader.Read())
                        {
                            rowCount++;
                        }

                        if (rowCount < 1)
                        {
                            con.Execute("insert into employer (empName, cardNo, passportNo, dateOfBirth, address, status, profession, companyName, officeNo, telNo, handNo) " +
                                    "values (@EmpName, @CardNo, @PassportNo, @DateOfBirth, @Address, @Status, @Profession, @CompanyName, @OfficeNo, @TelNo, @HandNo)", spouse);
                            con.Execute($"UPDATE Employer SET spouseID = (SELECT empID FROM Employer WHERE cardNo = @CardNo) WHERE cardNo = '{cardNo}'", spouse);
                            con.Execute($"UPDATE Employer SET spouseID = (SELECT empID FROM Employer WHERE cardNo = '{cardNo}') WHERE cardNo = @CardNo", spouse);

                            MessageBox.Show("Spouse Detail Successfully added.");

                        }
                        else
                        {
                            MessageBox.Show("You can only add one spouse");
                        }
                    }
                }


            }

        }

        public static void AddFamily(FamilyMemberModel family, string cardNo)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {


                con.Open();

                string query = "SELECT famMemID FROM FamilyMember ORDER BY famMemID DESC LIMIT 1;";

                using (IDbCommand cmd = new SQLiteCommand(query, (SQLiteConnection)con))
                {
                    using (IDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("famMemID"));

                            con.Execute($"INSERT INTO FamilyMember (famMemID, name, cardNo, dateOfBirth, relationship, empID) " +
                                $"values ({id + 1}, @Name, @CardNo, @DateOfBirth, @Relationship,(SELECT empID FROM Employer WHERE cardNo = '{cardNo}'))", family);
                        }
                        else
                        {
                            con.Execute($"INSERT INTO FamilyMember (famMemID, name, cardNo, dateOfBirth, relationship, empID) " +
                                $"values (2001, @Name, @CardNo, @DateOfBirth, @Relationship,(SELECT empID FROM Employer WHERE cardNo = '{cardNo}'))", family);
                        }
                    }
                }
            }

        }

        public static void AddMaid(MaidModel maid, FeesModel fees, string cardNo)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute($"INSERT INTO Maid (bioCode, name, wpNo, passportNo, status, nationality, cardNo, dateOfBirth, salary, overseasFee, sgServiceFee, restDaySalary, deployDate, empID) " +
                    $"values (@BioCode, @Name,@WpNo, @PassportNo, @Status, @Nationality, @FinNo, @DOB, @Salary, @OverseasFee, @SG_ServiceFee, @RestDaySalary, @DeployDate, (SELECT empID FROM Employer WHERE cardNo = '{cardNo}'))", maid);

                    try
                    {
                        con.Execute($"INSERT INTO Fees (agencyFee, medicalExpenses, newArrivalFee, poea, pcr_hr, expFee, insurance, trf, airTicket_IndoEC, maidID) " +
                            $"values (@AgencyFee, @MedicalExpenses, @NewArrivalFee, @POEA, @PCR_HR, @ExpFee, @Insurance, @TRF, @AirTicket_IndoEC, (SELECT maidID FROM Maid WHERE cardNo = '{maid.FinNo}'))", fees);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void DeleteEmployer(string cardNo)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {

                con.Open();

                string query = $"SELECT empID FROM Employer WHERE cardNo = '{cardNo}'";
                using (IDbCommand cmd = new SQLiteCommand(query, (SQLiteConnection)con))
                {
                    using (IDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("empID"));

                            con.Execute($"DELETE FROM Employer WHERE empID = {id} OR spouseID = {id}");
                        }

                    }
                }
            }
        }

        public static void DeleteSpouse(string cardNo)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {

                con.Open();

                string query = $"SELECT empID FROM Employer WHERE cardNo = '{cardNo}'";
                using (IDbCommand cmd = new SQLiteCommand(query, (SQLiteConnection)con))
                {
                    using (IDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("empID"));

                            con.Execute($"DELETE FROM Employer WHERE empID = {id}");
                        }

                    }
                }
            }
        }

        public static void DeleteFamily(string cardNo)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {

                con.Execute($"DELETE FROM FamilyMember WHERE cardNo = '{cardNo}'");
            }
        }

        public static void DeleteMaid(MaidModel maid)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {

                con.Execute($"DELETE FROM Maid WHERE maidID = @MaidID", maid);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
