using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCONNECTSQLSERVER
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public Image Photo { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string gender, DateTime dateOfBirth, string email, double salary, string address, Image photo)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            Salary = salary;
            Address = address;
            Photo = photo;
        }

        public Employee(
            int id,
            string firstName,
            string lastName,
            string gender,
            DateTime dateOfBirth,
            string email,
            double salary,
            string address,
            Image photo)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            Salary = salary;
            Address = address;
            Photo = photo;
        }

        public object[] Record()
        {
            return new object[] { 
                $"{Id:000}", 
                FirstName, 
                LastName, 
                Gender, 
                $"{DateOfBirth:dd-MM-yyyy}",
                Email, 
                $"{Salary:c2}",
                Address,
                Photo
            };
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            string sql = "SELECT * FROM ss20.dbo.tblEmployee ORDER BY id DESC;";

            SqlCommand s = new SqlCommand(sql, DataConnect.DataCon);
            SqlDataReader r = s.ExecuteReader();

            while(r.Read())
            {
                int id = int.Parse(r[0].ToString()); // get from index of record
                string firstName = r["first_name"].ToString(); // get instand column name
                string lastName = r[2].ToString();
                string gender = r[3].ToString();
                DateTime dateOfBirth = ((DateTime)(r[4]));
                string email = r[5].ToString();
                double salary = double.Parse(r[6].ToString());
                string address = r[7].ToString();
                byte[] bytes = (byte[])(r[8]);
                MemoryStream memoryStream = new MemoryStream(bytes);
                Image photo = Image.FromStream(memoryStream);
                employees.Add(
                    new Employee(
                        id,
                        firstName,
                        lastName,
                        gender,
                        dateOfBirth,
                        email,
                        salary,
                        address,
                        photo
                    )
                 );
            }

            s.Dispose();
            r.Close();
            return employees;
        }

        public override string ToString()
        {
            return $"{Id:0000}-{FirstName} {LastName}";
        }


        internal void Save()
        {
            string insertQuery = "INSERT INTO ss20.dbo.tblEmployee (first_name, last_name, gender, date_of_birth, email, salary, address, photo) VALUES (@first_name, @last_name, @gender, @date_of_birth, @email, @salary, @address,@photo)";

            SqlCommand command = new SqlCommand(insertQuery, DataConnect.DataCon);
            command.Parameters.AddWithValue("@first_name", FirstName);
            command.Parameters.AddWithValue("@last_name", LastName);
            command.Parameters.AddWithValue("@gender", Gender);
            command.Parameters.AddWithValue("@date_of_birth", DateOfBirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@salary", Salary);
            command.Parameters.AddWithValue("@address", Address);
            MemoryStream stream= new MemoryStream();
            Photo.Save(stream,Photo.RawFormat);
            command.Parameters.AddWithValue("@photo", stream.ToArray());

            int rowsAffected = command.ExecuteNonQuery();
            MessageBox.Show($"{rowsAffected} rows inserted.");
        }

        internal static bool EmailIsExist(string email)
        {
            string sql = $"SELECT email FROM ss20.dbo.tblEmployee where email=@email;";
            SqlCommand s = new SqlCommand(sql, DataConnect.DataCon);
            s.Parameters.AddWithValue("email", email);
            SqlDataReader r = s.ExecuteReader();
            bool isExist = r.Read();
            r.Close();
            s.Dispose();
            return isExist;
        }
    }
}
