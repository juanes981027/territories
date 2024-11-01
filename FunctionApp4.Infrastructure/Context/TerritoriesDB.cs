using System;
using FunctionApp4.Domain.Models;
using System.Data.SqlClient;

namespace FunctionApp4.Infrastructure.Context;

public class TerritoriesDB
{
    private string connectionString = "Server=GETCOLAPP003254;Database=testdb;";

    public List<Territory> Get()
    {
        List<Territory> territories = new List<Territory>();
        string query = "select TerritoryName, TerritoryNumber from Territories";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Territory territory = new Territory();
                string territoryName = reader.GetString(1);
                string territoryNumber = reader.GetString(2);

                territory.TerritoryName = territoryName;
                territory.TerritoryNumber = territoryNumber;

                territories.Add(territory);
            }


            reader.Close();
            connection.Close(); 

        }

        return territories;

    }

}
