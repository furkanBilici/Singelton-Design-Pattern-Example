using Singleton.Class;

var customerManager = CustomerManager.CreateAsSingleton();//Açtığımız değişken bu fonksiyon sayesinde static ve bir nesne üzerinden çalışmış oluyor.
customerManager.Save();
