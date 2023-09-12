namespace CarList.Services
{
    public interface ICacheManager
    {
        public T Get<T>(string key);
        public void Set<T>(string key, T value, TimeSpan expirationTime);
        public void Remove(string key);
    }
}
