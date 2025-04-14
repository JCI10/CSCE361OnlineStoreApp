using Microsoft.Data.SqlClient;

public interface IConnectionAccessor

{
// Help: If errors with sql connection navigate to OnlineShoppingApp folder and in terminal give the command $dotnet add package Microsoft.Data.SqlClient
    SqlConnection GetConnection();
}