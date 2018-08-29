using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DesignPattern.Singleton_单例模式_.多线程测试
{
    public class Test1
    {
        private Test1 test1;
        private static Test1 _instance;
        private static readonly object lockObject = new object();
        private Dictionary<int, Dictionary<int, List<string>>> _dic;
        public static Test1 Instance()
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Test1();
                        Console.WriteLine("初始化TEST1");
                    }
                }
            }
            return _instance;
        }

        public Test1()
        {
            _dic = new Dictionary<int, Dictionary<int, List<string>>>();
        }

        public List<string> LoadString(int asid, int pid)
        {
            List<string> m = new List<string>();
            if (!_dic.ContainsKey(asid))
            {
                lock (_dic)
                {
                    if (!_dic.ContainsKey(asid))
                    {
                        var c = new Dictionary<int, List<string>>();
                        _dic.Add(asid, c);
                        Console.WriteLine(" 1add asid" + asid);
                    }
                }
            }
            m = GetVs();
            if (!_dic[asid].ContainsKey(pid))
            {
                lock (_dic)
                {
                    if (!_dic[asid].ContainsKey(pid))
                    {
                        _dic[asid].Add(pid, m);
                        Console.WriteLine(pid + " add：" + string.Join("|", m));
                        Console.WriteLine(" 1count:" + _dic.Count);
                        foreach (var item in _dic[asid].Keys)
                        {
                            Console.WriteLine(" 12count:" + string.Join("|", _dic[asid][item]));
                        }
                    }
                }
            }

            return _dic[asid][pid];
        }
        public List<string> LoadString1(int asid, int pid)
        {
            List<string> m = new List<string>();
            if (!_dic.ContainsKey(asid))
            {
                lock (_dic)
                {
                    if (!_dic.ContainsKey(asid))
                    {
                        var c = new Dictionary<int, List<string>>();
                        _dic.Add(asid, c);
                        Console.WriteLine(" 2add asid" + asid);
                    }
                }
            }
            m = GetVs1();
            if (!_dic[asid].ContainsKey(pid))
            {

                lock (_dic)
                {
                    if (!_dic[asid].ContainsKey(pid))
                    {
                        _dic[asid].Add(pid, m);
                        Console.WriteLine(pid + " add：" + string.Join("|", m));
                        Console.WriteLine(" 2count:" + _dic.Count);
                    }
                }
            }

            return m;
        }
        public void RemoveString(int asid)
        {
            Console.WriteLine(" remove" + asid);
            if (_dic.ContainsKey(asid))
            {
                lock (_dic)
                {
                    _dic.Remove(asid);
                }
                Console.WriteLine(" remove count:" + _dic.Count);
            }

        }
        public List<string> GetVs()
        {
            return new List<string>() { "1", "2", "3" };
        }

        public List<string> GetVs1()
        {
            return new List<string>() { "s", "d", "l" };
        }
    }
}