/*
 * Description of the problem:
 * 
 * Write a program to read a large collection of products (name + price) 
 * and efficiently find the first 20 products in the price range [a…b].
 * 
 * Test for 500 000 products and 10 000 price searches.
 * Hint: you may use OrderedBag<T> and sub-ranges.
 * 
 * 
 * Full homework description can be seen at: https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/14.%20Advanced-Data-Structures/homework
 */
namespace _2.OrderedBag
{
    using Wintellect.PowerCollections;
    using System.Collections.Generic;

    class OrderedBagMain
    {
        static void Main()
        {
            OrderedBag<Product> product = new OrderedBag<Product>();
        }
    }
}
