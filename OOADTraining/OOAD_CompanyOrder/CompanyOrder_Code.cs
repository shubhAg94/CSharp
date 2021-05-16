using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_CompanyOrder
{
    class Item
    {
        private string Description;
        private double Rate;

        public Item(string desc, double r)
        {
            Description = desc;
            Rate = r;
        }

        public string getDescription()
        {
            return Description;
        }
        public double getRate()
        {
            return Rate;
        }
    }

    class OrderedItem
    {
        private Item t;
        private int Quantity;


        public OrderedItem(Item t1, int q)
        {
            t = t1;
            Quantity = q;
        }
        public Item getItem()
        {
            return t;
        }
        public int getQuantity()
        {
            return Quantity;
        }
    }

    class Customer
    {

        private string Name;
        private string Address;

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }
        ~Customer()
        { }
        public string getAddress()
        {
            return Address;
        }
        public string getName()
        {
            return Name;
        }
    }
    class RegCustomer : Customer
    {

        private double splDiscount;
        private int RegCustID;

        public RegCustomer(string name, string address, double discount, int id) : base(name, address)
        {

            splDiscount = discount;
            RegCustID = id;
        }

        public double getsplDiscount()
        {
            return splDiscount;
        }

        public int getRegCustID()
        {
            return RegCustID;
        }
    };

    class Order
    {

        private List<OrderedItem> orderedItemList;
        private Customer Cust;

        public Order(List<OrderedItem> o, Customer c)
        {
            orderedItemList = o;
            Cust = c;
        }
        public List<OrderedItem> getOrderedItemList()
        {
            return orderedItemList;
        }

        public Customer getCustomer()
        {
            return Cust;
        }
    }


    class IDGenerator
    {
        private static int id;

        public static int getID()
        {
            return ++id;
        }
        static IDGenerator()
        {
            id = 0;
        }
    }


    class Company
    {

        private string Name;
        private string Address;
        private List<Item> _itemList = null;
        private List<Order> _orderList = null;

        public Company(string name, string address)
        {
            Name = name;
            Address = address;
            _itemList = new List<Item>();
            _orderList = new List<Order>();
            _itemList.Add(new Item("Mouse", 250));
            _itemList.Add(new Item("Laptop", 40000));
            _itemList.Add(new Item("Modem", 15500));
            _itemList.Add(new Item("Desktop", 23500));
        }

        public string getName()
        {
            return Name;
        }
        public string getAddress()
        {
            return Address;
        }
        public void setItemList(Item t)
        {
            _itemList.Add(t);
        }
        public void setorderList(Order o)
        {
            _orderList.Add(o);
        }

        public List<Item> getItemList()
        {
            return _itemList;
        }

        public List<Order> getOrderList()
        {
            return _orderList;
        }
        public void AddCustomer()
        {
            List<OrderedItem> ol = new List<OrderedItem>();
            Customer c = null;

            Item item_data;
            int i = 0;
            string name, address;
            int choice, quantity;
            Console.WriteLine("1:Add Registered Customer \n2:Add Unregistered Customer");
            Console.WriteLine("enter your choice");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name and address");
            name = Console.ReadLine();
            address = Console.ReadLine();

            if (choice == 1)
                c = new RegCustomer(name, address, 0.10, IDGenerator.getID());
            else if (choice == 2)
                c = new Customer(name, address);
            do
            {

                Console.WriteLine("The existing items details are");


                for (i = 0; i < _itemList.Count; i++)
                {
                    item_data = _itemList[i];
                    Console.WriteLine(item_data.getDescription() + "\t" + item_data.getRate());

                }
                Console.WriteLine("enter your item to order");
                Console.WriteLine("1:Mouse 2:Laptop 3:Modem 4:Desktop\n");
                choice = int.Parse(Console.ReadLine());
                item_data = _itemList[choice - 1];
                Console.WriteLine("enter the quantity required");
                quantity = int.Parse(Console.ReadLine());
                ol.Add(new OrderedItem(item_data, quantity));
                Console.WriteLine("enter 1 to add one more item to the order");
                choice = int.Parse(Console.ReadLine());
            } while (choice == 1);

            _orderList.Add(new Order(ol, c));
            Console.WriteLine("No: Of Orders:" + _orderList.Count);

        }



        public void DisplayOrderDetails()
        {
            double actual_cost = 0.0, cost = 0.0;
            Customer c = null;
            RegCustomer rc = null;
            Order o = null;


            if (getOrderList().Count == 0)
                Console.WriteLine("No orders are available ");
            else
            {

                for (int i = 0; i < _orderList.Count; i++)
                {
                    Console.WriteLine("");
                    o = _orderList[i];
                    c = o.getCustomer();
                    if (c.GetType().Name.Equals("RegCustomer"))
                    {
                        Console.WriteLine("Customer Type:Registered Customer");
                        rc = (RegCustomer)(c);
                        Console.WriteLine("CustomerID:" + rc.getRegCustID());
                        Console.WriteLine("Special Discount:" + rc.getsplDiscount());
                    }
                    else
                        Console.WriteLine("Customer Type:Unregistered Customer");
                    Console.WriteLine("Customer Name:" + c.getName());
                    Console.WriteLine("Customer Address:" + c.getAddress());

                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("The order details associated with the customer " + c.getName() + " are");
                    List<OrderedItem> orderedItemList = o.getOrderedItemList();
                    Console.WriteLine("-----------------------------------------------------");

                    for (int j = 0; j < orderedItemList.Count; j++)
                    {
                        OrderedItem oi = orderedItemList[j];
                        Item it = oi.getItem();
                        Console.WriteLine("Item description:" + it.getDescription());
                        Console.WriteLine("Item Rate:" + it.getRate());
                        Console.WriteLine("Quantity:" + oi.getQuantity());
                        cost = it.getRate() * oi.getQuantity();
                        if (c.GetType().Name.Equals("RegCustomer"))
                            actual_cost = cost - (cost * (rc.getsplDiscount()));
                        else
                            actual_cost = cost;

                        Console.WriteLine("Actual Cost:" + actual_cost);
                        Console.WriteLine("-----------------------------------------------------");
                    }
                    Console.WriteLine("");

                }

            }

        }

        public void DisplayTotalOrderWorth()
        {
            double sum = 0.0, quantity, rate, cost, discount;
            Customer cust = null;
            RegCustomer rcust = null;
            Item _item = null;
            Order o = null;
            OrderedItem oi = null;
            List<OrderedItem> _orderItem;


            if (getOrderList().Count == 0)
                Console.WriteLine("No orders are available ");
            else
            {

                for (int i = 0; i < _orderList.Count; i++)
                {
                    o = _orderList[i];
                    cust = o.getCustomer();
                    _orderItem = o.getOrderedItemList();
                    Console.WriteLine("");
                    if (cust.GetType().Name.Equals("RegCustomer"))
                        Console.WriteLine("Customer Type:" + "Registered Customer");
                    else
                        Console.WriteLine("Customer Type:" + "UnRegistered Customer");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Customer Name:" + cust.getName());
                    Console.WriteLine("Customer Address:" + cust.getAddress());
                    Console.WriteLine("The Items ordered by the customer " + cust.getName() + " are");
                    for (int j = 0; j < _orderItem.Count; j++)
                    {
                        oi = _orderItem[j];
                        quantity = oi.getQuantity();
                        _item = oi.getItem();
                        rate = _item.getRate();

                        Console.WriteLine("Description:" + _item.getDescription());
                        Console.WriteLine("Rate:" + rate);
                        Console.WriteLine("Quantity:" + quantity);
                        cost = rate * quantity;
                        if (cust.GetType().Name.Equals("RegCustomer"))
                        {
                            rcust = (RegCustomer)(cust);
                            discount = rcust.getsplDiscount();
                            cost = cost - (cost * discount);
                        }

                        Console.WriteLine("Total Cost:" + cost);
                        Console.WriteLine("-------------------------------");
                        sum += cost;
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("Total Worth of Orders Placed is:" + sum);
            }
        }

    }


    class CompanyOrder_Code
    {
        public static void Main(string[] args)
        {

            Company c = new Company("Rushil Technologies", "#327 , Rajathadri , Hebbal");
            int choice = 0;
            do
            {
                Console.WriteLine("1:Add a Customer to the company");
                Console.WriteLine("2:Display the customer order details");
                Console.WriteLine("3:display total worth of orders placed by the customers");

                Console.WriteLine("enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        c.AddCustomer();
                        break;

                    case 2:
                        c.DisplayOrderDetails();
                        break;

                    case 3:
                        c.DisplayTotalOrderWorth();
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                Console.WriteLine("enter 1 to continue");
                choice = int.Parse(Console.ReadLine());
            } while (choice == 1);
        }
    }
}
