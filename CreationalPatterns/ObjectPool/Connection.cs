namespace ObjectPool;

public class Connection
{
    public ConnectionPool Pool { get; }

    public bool IsUse { get; set; }

    public Connection(ConnectionPool pool)
    {
        Pool = pool;

        Console.WriteLine("Trying to open...");

        Thread.Sleep(TimeSpan.FromSeconds(1));

        Console.WriteLine("Connection is open");
    }
}