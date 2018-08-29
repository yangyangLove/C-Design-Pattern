using System.Collections.Generic;

namespace DesignPattern.ObserverPattern_观察者模式_
{
    internal class TenXun
    {
        private List<IObserver> list = new List<IObserver>();
        public string Symbol { get; set; }
        public string Info { get; set; }
        public TenXun(string symbol, string info)
        {
            Symbol = symbol;
            Info = info;
        }


        public void AddObserver(IObserver ob)
        {
            list.Add(ob);
        }

        public void Remove(IObserver ob)
        {
            list.Remove(ob);
        }

        public void Update()
        {
            foreach (var ob in list)
            {
                if (ob != null)
                {
                    ob.ReceiveAndPrint(this);
                }
            }
        }
    }
}
