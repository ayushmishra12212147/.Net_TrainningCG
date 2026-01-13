using Day4OOPDemo;



System.Console.WriteLine("Code Running");


// IAdd m1=new MathClass();
// IAddSub m2=new MathClass();
// IAll m3=new MathClass();

// m1.add(2,3);




//Old Way to give Value 
Product pro=new Product();
pro.Name="Abc";
pro.ProdId=123;

//Object Initilizer
Product obj=new Product(){ProdId=123,Name="Brorsil",Price=2222};

//Collection Initilizer
List<Product> prodList=new List<Product>()
{
    new Product(){ProdId=101,Name="Brorsil",Price=225},
    new Product(){ProdId=102,Name="Vicks",Price=20},
    new Product(){ProdId=103,Name="Body Lotion",Price=286},
    new Product(){ProdId=104,Name="Marker",Price=25},
};


foreach(var item in prodList)
{
    System.Console.WriteLine($"{item.ProdId}\t{item.Name}\t{item.Price}");
}
