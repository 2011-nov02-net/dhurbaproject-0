using System;

namespace dhurbaproject_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome back to Dhurba Grocery Store, Are you John, Matt, Jessica or Shayam");
            string customerName = Console.ReadLine();
            Console.WriteLine($"Welcome {customerName}, Nice to see u again. Please choose one of the store (1,2 or 3) that you would like to shop from");

            // display list of store and ask to choose one

            //creating an object of class DisplayStore
            DisplayStore myDisplayProduct = new DisplayStore();

            //initializing allStore


            //calling method of DisplayStore to display list of store


            //customer choice of store
            string storeNumber = Console.ReadLine();
           // int storenumber = Int.Parse(storeNumber);
            //display items available at that store


            //creating object of class DisplayProduct
            DisplayProduct displayProduct = new DisplayProduct();





        }


        /* return new List<Product>{
             new Product("1","Orange",100),
             new Product("2","Apple",100),
             new Product("3","Mango",100)
         };*/
    }
    /* static Dictionary<Store,List<Product>>allProduct(){
        return List<Product>productList= new List<Product>{
             new Product("1","Orange",100),
             new Product("2","Apple",100),
             new Product("3","Mango",100)
        };
        myDictionary.Add("1",new List<Product>{new Product("1","Orange",100),new Product("2","Apple",100),new Product("3","Mango",100)});
         myDictionary .Add(2,new List<Product>{new Product("1","Orange",100),new Product("2","Apple",100),new Product("3","Mango",100)});
         myDictionary.Add(3,new List<Product>{new Product("1","Orange",100), new Product("2","Apple",100), new Product("3","Mango",100)});

        return myDictionary;
        */

    /* {
          new Product("1","Orange",100),
          new Product("2","Apple",100),
          new Product("3","Mango",100)
      };
     */


    
}
