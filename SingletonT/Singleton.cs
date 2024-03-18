using System.Reflection;

namespace SingletonT
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
                            foreach (MethodInfo method in typeOfT.GetMethods())
                            {
                                if (method.Name == typeOfT.Name
                                    && method.IsPrivate && method.GetParameters().Length == 0)
                                {
                                    if (true)
                                    {
                                        s_Instance = (T)method.Invoke(null, null);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                return s_Instance;
            }
        }
    }
}
