using System.Security.Principal;

namespace Project21_Class_Property_Field;

// class Product
// {
//     int id;
// string name;
// decimal price;
// bool isActive;

// }


//Class içindeki bilgilerin dışaırya kontrollü bir şekilde açılmasını sağlayan yapılara Property diyoruz. Yaptığımız bu işleme ise kapsülleme (Encapsulation) denir.
// public string Name
// {
//     get
//     {
//         string result = name.Substring(0, 3).ToUpper();

//         return result;
//     }
//     set
//     {
//         name = value;
//     }
// }


// public decimal Price
// {
//     get
//     {
//         return price;
//     }
//     set
//     {
//         if (value < 0)
//         {
//             price = 0;
//         }
//         else
//         {
//             price = value;
//         }
//         // price = value<0 ? 0 : value;           
//     }
// }

 //class Product{

 //propfull snippet   
    // private int id;
    // public int Id
    // {
    //     get { return id; }
    //     set { id = value; }
    // }
    
    // //prop ( propfull yapmıcaksan bunu kullanabilirsin)
    // public int Id{ get; set; }

    // public string Name { get; set; } = "";
    // public string? Description { get; set; }
    // public required string Notes { get; set; }// required null hatasının önüne geçer ?, "" un diğer yolu
    // public decimal Price { get; set; }
    // public bool isActive { get; set; }



//}


class Student
{
    public Student()
    { // constructor aşağıda new içine otomatik veri gelsin istiyorsak bu oluşturulacak
        Console.WriteLine($"{DateTime.Now} zamanında yeni bir Student olşturuldu. ");
    }


    public Student(int studentNumber)  //constuctor overload
    {
        StudentNumber = studentNumber;
        Console.WriteLine($"{DateTime.Now} zamanında yeni bir Student olşturuldu. ");

    }
    public int StudentNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte age { get; set; }
    public bool IsActive { get; set; }

}

class Category
{
    public Category(int id)
    {
        Id = id;
    }

    public Category(int id, string name)
    {
        Id=Id;
        Name = name;

    }

    public Category(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        Category category1 = new Category(56);
        Category category2 = new Category(60, "Bilgisayar");

        Category category3 = new Category(65, "Telefonlar", "Telefonlar burada");















        // Student s1 = new Student();
        // Student s2 = new Student(48);
        // System.Console.WriteLine(s2.StudentNumber);



















        // Product product1 = new Product();
        // product1.Name= "IPhone14";
        // Console.WriteLine(product1.Name);

        // product1.Price = 6000;
        // System.Console.WriteLine(product1.Price);

        // Product product1 = new Product() { Notes = "ABC" };
        // product1.Id = 5;
        // product1.Price = 800;
        // System.Console.WriteLine(product1.Id);
        // product1.Name = "Mcbook Air M2";
    }
}
