using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
public static void Main()
{
SqlConnection connection= new SqlConnection("data source=LAPTOP-53S2KQS8;initial catalog=A;integratedsecurity=false");
SqlCommand command = new SqlCommand("Select * from Employee" , connection);
connection.Open();
 SqlDataReader reader = command.ExecuteReader();
  while(reader.Read())
{
 Console.WriteLine(reader[0].ToString() + " " + reader[1]);

}
reader.Close();
connection.Close();
}