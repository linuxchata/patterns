using ObjectPool;

Console.WriteLine("Create Connection pool");
var pool = new ConnectionPool(2, 3);
Console.WriteLine("Connection pool was created");

Console.WriteLine("Get connection #1 (fast)");
var connection1 = pool.GetConnection();

Console.WriteLine("Get connection #2 (fast)");
var connection2 = pool.GetConnection();

Console.WriteLine("Get connection #3 (slow)");
var connection3 = pool.GetConnection();

pool.ReleaseConnection(connection3);

Console.WriteLine("Get connection #4 (fast)");
var connection4 = pool.GetConnection();

Console.WriteLine($"Connection #4 is equal to connection #3 {ReferenceEquals(connection3, connection4)}");

Console.ReadKey();
