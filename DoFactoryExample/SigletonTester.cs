using System;

namespace DoFactoryExample
{
    public class SigletonTester
    {
        public bool IsSingleton<T>(Func<(T, int)> func)
        {
            var invoke = func.Invoke();

            return invoke.Item2 == 1;
        }
    }
}