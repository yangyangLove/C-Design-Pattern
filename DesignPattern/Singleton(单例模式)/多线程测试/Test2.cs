namespace DesignPattern.Singleton_单例模式_.多线程测试
{
    public class Test2 : Test1
    {
        public bool IsNull()
        {
            return default(Test1) == null;
        }
    }
}
