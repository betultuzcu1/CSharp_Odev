﻿using Newtonsoft.Json;

namespace MVC_MyProject.Utilities
{
    public static class SessionHelper
    {

        public static void SetJsonProduct(this ISession _session, string _key, object _value)
        {
            _session.SetString(_key, JsonConvert.SerializeObject(_value));
        }


        public static T GetProductFromJson<T>(this ISession session, string key)
        {
            var result = session.GetString(key);

            if (result == null)
            {
                return default(T);
            }
            else
            {
                var deserialize = JsonConvert.DeserializeObject<T>(result);
                return deserialize;
            }

        }
    }
}
