using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Events
{
    public delegate void OrderPlacedhandler(String orderID);
    public class OrderService
    {
        public event OrderPlacedhandler? OrderPlaced;

        public void PlaceOrder(string orderID)
        {
            Console.WriteLine("Order placed for {0} Successfully",orderID );
            OnOrderPlaced(orderID);
        }

        protected virtual void OnOrderPlaced(string orderId)
        {
            OrderPlaced?.Invoke(orderId);
        }
    }

    public class SendMail
    {
        public void MailSent(string orderID)
        {
            Console.WriteLine("Mail Sent Successfully to Order ID {0}", orderID);
        }
    }

    public class SendSMS
    {
        public void SMSSent(string orderID)
        {
            Console.WriteLine("SMS Sent Successfully to Order ID {0}", orderID);
        }
    }

    public class Oredr
    {
        public static void Main(string orderID)
        {
            OrderService os = new OrderService();
            SendMail sm = new SendMail();
            SendSMS ss = new SendSMS();

            os.OrderPlaced += sm.MailSent;
            os.OrderPlaced += ss.SMSSent;

            OrderService.PlaceOrder("A12C");

        }
    }
}
