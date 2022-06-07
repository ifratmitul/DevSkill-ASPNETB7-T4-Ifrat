using Task2;


List<Customer> customers = new List<Customer>();
customers.Add(new Customer { Name = "jalaluddin", Id = 1, Address = "Dhaka" });
customers.Add(new Customer { Name = "tareq", Id = 2, Address = "Sylhet" });
customers.Add(new Customer { Name = "hasan", Id = 3, Address = "Khulna" });
customers.Add(new Customer { Name = "hasan", Id = 4, Address = "Rajshahi" });

List<Purchase> purchases = new List<Purchase>();
purchases.Add(new Purchase { Amount = 300.5, CustomerId = 1, PurchasedOn = new System.DateTime(2002, 3, 3) });
purchases.Add(new Purchase { Amount = 245.9, CustomerId = 2, PurchasedOn = new System.DateTime(2022, 3, 8) });
purchases.Add(new Purchase { Amount = 37.8, CustomerId = 3, PurchasedOn = new System.DateTime(2021, 5, 2) });
purchases.Add(new Purchase { Amount = 980.0, CustomerId = 4, PurchasedOn = new System.DateTime(2011, 6, 9) });

DataOperation op = new DataOperation();
op.MergeData(customers, purchases);