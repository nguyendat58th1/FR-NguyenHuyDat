using System;
using System.Text;

namespace DelegateEvent
{

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string data)
        {
            this.data = data;
        }
        // Lưu dữ liệu gửi đi từ publisher
        private string data;

        public string Data
        {
            get { return data; }
        }
    }

    class Family
    {
        public event EventHandler sendMessage;
        public void Send()
        {
            sendMessage?.Invoke(this,new MyEventArgs("Thông báo em bé đã chào đời !"));
        }
    }
    class Friend
    {
        public string Name { get; set; }
        public Friend(string name)
        {
            this.Name = name;
        }

        public void Sub(Family flm)
        {
            flm.sendMessage += Notify;
        }
        public void Notify(object sender, EventArgs e)
        {
            MyEventArgs mea = (MyEventArgs)e;
            Console.WriteLine($"{this.Name } : {mea.Data}");
        }

    }
    class Neighbor
    {
        public void Sub(Family flm)
        {
            flm.sendMessage += Notify;
        }
        public void Notify(object sender, EventArgs e)
        {
            MyEventArgs mea = (MyEventArgs)e;
            Console.WriteLine($"Hàng xóm: {mea.Data}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Family flm = new Family();
            Friend fr1 = new Friend("Nam");
            Neighbor neighbor = new Neighbor();
            neighbor.Sub(flm);
            fr1.Sub(flm);
            flm.Send();
        }
    }
}
