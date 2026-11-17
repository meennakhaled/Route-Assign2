using System;
namespace C_AssignS2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //object b1 = new Book()
            //{
            //    Title = "My Book",
            //    Pages = 40
            //};
            //Console.WriteLine(b1); //print with override tostring
            #endregion

            #region Question2

            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b1.Equals(b1));
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(b1.GetType());


            #endregion

            #region Question3
            ////int pages = "464"; its compile time error
            //int pages = 464; //fix it with remove ""

            #endregion

            #region Question4

            //int x = 10;
            //int y = 0;

            //try
            //{
            //    int z = x / y;
            //    Console.WriteLine(z);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region Question5
            //int Pages = 300;
            //double PagesD = Pages;

            #endregion

            #region Question6
            //double Price = 49.99;
            //int PriceI = (int)Price;

            #endregion

            #region Question7
            //string pagesText = "464";
            //int Pages = Convert.ToInt32(pagesText);

            #endregion

            #region Question8

            //string yearText = "2023";

            //// Using int.Parse()
            //int year = int.Parse(yearText);
            //Console.WriteLine(year);

            //// Using int.TryParse()
            //string badText = "abc";

            //bool success = int.TryParse(badText, out int number);

            //if (success)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Question9

            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType());

            #endregion

            #region Question10

            //int copies = 100;
            //object copyObj = copies;
            //int copies2 = (int)copyObj;

            //Console.WriteLine(copyObj);
            //Console.WriteLine(copies2);

            #endregion

        }
    }
}