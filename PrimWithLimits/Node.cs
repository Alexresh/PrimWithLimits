namespace PrimWithLimits
{
    class Node
    {
        private int connectionCount;

        public Node() 
        {
            connectionCount = 0;
        }

        public void AddConnection()
        {
            connectionCount++;
        }

        public int GetConnectionCount() 
        {
            return connectionCount;
        } 
    }
}
