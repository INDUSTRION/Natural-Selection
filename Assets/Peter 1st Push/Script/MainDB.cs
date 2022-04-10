using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;

public class MainDB : MonoBehaviour
{
    private string dbName = "URI=file:Players.db";

    // Start is called before the first frame update
    void Start()
    {
        //run the method for create table
        CreateDB();
        
        //ID , SURNAME, NAME, SCHOOL, SUBJECT, AGE, SCORE, HP
        AddPlayer (1, "Mbuyazi" , "Fanelesibonge" , "WITS UNI" , "GEOGRAPHY" , 24 , 0);

        DisplayPlayers();
    }

//method to create a table if it doesn't exist already
public void CreateDB()

{

    //create the db connection
    using (var connection = new SqliteConnection (dbName))
    {
        connection.Open();

        //set up an object called command to allow db control
        using (var command = connection.CreateCommand())
        {

            //create a table called players if it doesnt exist already
            //the table has 7 fields
            command.CommandText = "CREATE TABLE IF NOT EXISTS players( Personid int IDENTITY(1,1), LastName varchar(255) NOT NULL, FirstName varchar(255), SchoolName varchar(255),Subject varchar(255), Age int,  Score int, PRIMARY KEY (Personid));";
            command.ExecuteNonQuery(); //this runs the SQL
        }

        connection.Close();
    }
}


public void AddPlayer (int pID, string surname, string name, string schoolName, string subject, int age , int score)
{
    using (var connection = new SqliteConnection(dbName))

    {

        connection.Open();


        //set up command
        using (var command = connection.CreateCommand())
        {
            //This command insterts the values into the existing players table
            command.CommandText = "INSERT INTO players (LastName, FirstName, SchoolName, SchoolName, Subject, Age, Score) VALUES ('"+  pID + "','"+ surname + "','"+ name+ "','"+schoolName+ "','"+ subject+ "','"+age + "','"+score +"');";
            command.ExecuteNonQuery(); //this runs the SQL
        }
        connection.Close();
    }
}

public void DisplayPlayers ()
{
     using (var connection = new SqliteConnection(dbName))
     {
         connection.Open();

         //setup command
          using (var command = connection.CreateCommand())
          {

              command.CommandText = "SELECT * FROM players;";

              using (IDataReader reader = command.ExecuteReader())
              {
                  while (reader.Read())

                  // prints the table values to screen
                    Debug.Log("ID: " + reader["Personid"] + "\tLastName: "  + reader["LastName"] + "\tFirstName: "  + reader["FirstName"] + "\tSchoolName: "  + reader["SchoolName"]+ "\tSubject: " + reader["Subject"] + "\tAge: "  + reader["Age"] + "\tScore: "  + reader["Score"] );
                reader.Close();
              }
              connection.Close();
          }
     }
}


    // Update is called once per frame
    void Update()
    {
        
    }
}
