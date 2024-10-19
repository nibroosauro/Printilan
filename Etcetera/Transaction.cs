using ClassPrintilanApp;
using System;

namespace ClassPrintilanApp
{
    class Transactions
    {
        public enum payStatus
        {
            Pending,
            Completed,
            Failed
        }

        public enum deliveryStatus
        {
            Pending,
            Shipped,
            Delivered,
            Failed
        }

        // atributes
        private int _transactionID;
        private DateTime _transactionTime;
        private payStatus _paymentstats;
        private deliveryStatus _deliverystats;
        private int _customerID;
        private int _productID;

        // properties
        public int TransactionID 
        {
            get { return _transactionID; }
        }

        public DateTime TransactionTime 
        {
            get { return _transactionTime; }
        }

        public payStatus PaymentStats 
        {
            get { return _paymentstats; }
        }

        public deliveryStatus DeliveryStats 
        {
            get { return _deliverystats; }
        }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        // constuctor
        public Transactions(int transactionID, DateTime transactionTime, payStatus paymentstats, deliveryStatus deliverystats, int customerID, int productID)
        {
            _transactionID = transactionID;
            _transactionTime = transactionTime;
            _paymentstats = paymentstats;
            _deliverystats = deliverystats;
            _customerID = customerID;
            _productID = productID;
        }
    }
}