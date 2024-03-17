using System;
using System.Reflection;

namespace BasicFacebookFeatures
{
    public static class Singleton<T>
        where T : class
    {
        private static T s_Instance = null;
        private static object s_LockObj = new object();
        static Singleton()
        {

        }
        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            Type typeOfT = typeof(T);
                            ConstructorInfo constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                            s_Instance = (T)constructor.Invoke(null) as T;
                        }
                    }
                }
                return s_Instance;
            }
        }
    }
}
