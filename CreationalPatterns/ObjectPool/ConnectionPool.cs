namespace ObjectPool;

public class ConnectionPool
{
    private readonly int _maxSize;

    private readonly List<Connection> _connections;

    public ConnectionPool(int minSize, int maxSize)
    {
        _maxSize = maxSize;

        _connections = new List<Connection>(minSize);

        for (var i = 0; i < minSize; i++)
        {
            var connection = new Connection(this);
            _connections.Add(connection);
        }
    }

    public Connection GetConnection()
    {
        var connection = _connections.FirstOrDefault(x => !x.IsUse) ?? CreateConnection();
        connection.IsUse = true;
        return connection;
    }

    public void ReleaseConnection(Connection connection)
    {
        if (connection.Pool != this)
        {
            throw new InvalidOperationException();
        }

        connection.IsUse = false;
    }

    private Connection CreateConnection()
    {
        if (_connections.Count == _maxSize)
        {
            throw new InvalidOperationException();
        }

        var connection = new Connection(this);
        _connections.Add(connection);
        return connection;
    }
}