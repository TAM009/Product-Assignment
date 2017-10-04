using System;

namespace Product
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Display objDisplay = new Display();
                int option1, option2,index,start,end;
                string ch1=null;
                string ch2=null;

                do
                {
                    Console.WriteLine("Please enter the number corresponding to your choice");
                    Console.WriteLine("1.Display all the items in the list");
                    Console.WriteLine("2.Sort the items based on product name");
                    Console.WriteLine("3.Display details of product by customised searching");
                    Console.WriteLine("4.Delete record of your own choice and display the new list");

                    option1=int.Parse(Console.ReadLine());

                    switch(option1)
                    {
                        case 1:Console.WriteLine("-------------------------------------------");
                               objDisplay.DisplayAllItems();

                               break;

                        case 2:Console.WriteLine("--------------------------------------------");
                               objDisplay.DisplaySortedProducts();
                               break;

                        case 3:Console.WriteLine("--------------------------------------------");
                               Console.WriteLine("Please enter the product name you want to search");
                               String search=Console.ReadLine();
                               objDisplay.DisplayFoundItems(search);

                               break;

                        case 4:do
                                {
                                    Console.WriteLine("Please enter the mode of deletion");
                                    Console.WriteLine("1.Delete items meeting a paricular requirement");
                                    Console.WriteLine("2.Delete at a specific index");
                                    Console.WriteLine("3.Delete a range of products");

                                    option2=int.Parse(Console.ReadLine());

                                    switch(option2)
                                    {
                                        case 1:Console.WriteLine("----------------------------------");
                                               Console.WriteLine("Deleting products whose rate is greater than 100");
                                               objDisplay.DisplayAfterDeletion1();
                                               break;

                                        case 2:Console.WriteLine("-----------------------------------");
                                               Console.WriteLine("Enter the particular index of the product you want to delete");
                                               index=int.Parse(Console.ReadLine());
                                               objDisplay.DisplayAfterDeletion2(index);
                                               break;

                                        case 3:Console.WriteLine("------------------------------------");
                                               Console.WriteLine("Enter the start index and number of products following the start you want to remove respectively ");
                                               start=int.Parse(Console.ReadLine());
                                               end=int.Parse(Console.ReadLine());
                                               objDisplay.DisplayAfterDeletion3(start,end);
                                               break;

                                        default:Console.WriteLine("You entered an invalid input!");
                                                Console.WriteLine("Do you want to try again?(Yes/No)");
                                                break;

                                    }
                                    Console.WriteLine("Do you want to try delete process again?(yes/no)");
                                    ch1=Console.ReadLine();

                                }while(ch1.ToUpper()=="YES"); 
                                break;
                        
                        default:Console.WriteLine("Sorry wrong input");
                                break;
                    }

                    Console.WriteLine("Do you want to try again?(yes/no)");
                    ch2=Console.ReadLine();
                }while(ch2.ToUpper()=="YES");
            
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
