//using System;
//using System.Collections.Generic;
//using Microsoft.Extensions.Caching.Memory;

//namespace CarList.Services
//{
//    public class CacheManager : ICacheManager
//    {
//        private readonly IMemoryCache _cache;

//        public CacheManager(IMemoryCache cache)
//        {
//            _cache = cache;
//        }

//        public T Get<T>(string key)
//        {
//            return _cache.Get<T>(key);
//        }

//        public void Set<T>(string key, T value, TimeSpan expirationTime)
//        {
//            var cacheEntryOptions = new MemoryCacheEntryOptions()
//                .SetAbsoluteExpiration(expirationTime);

//            _cache.Set(key, value, cacheEntryOptions);
//        }

//        public void Remove(string key)
//        {
//            _cache.Remove(key);
//        }
//    }
//}
