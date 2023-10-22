
using Refrigerator_EX;
using System;

class Program
{
    static void Main()
    {
        DateTime date1 = new DateTime(2023, 10, 21);
        Item item1 = new Item(1,1,"apple","food","parve", date1,3);
        DateTime date2 = new DateTime(2023, 10, 29);
        Item item2 = new Item(2, 1, "milk", "drink", "chalavi", date2, 5);
        DateTime date3 = new DateTime(2023, 10, 21);
        Item item3 = new Item(3, 1, "gvina", "food", "chalavi", date3, 2);
        DateTime date4 = new DateTime(2023, 10, 28);
        Item item4 = new Item(4, 2, "chaze", "food", "besari", date4, 6);
        DateTime date5 = new DateTime(2023, 10, 22);
        Item item5 = new Item(5, 2, "maadan", "food", "chalavi", date5, 3);
        DateTime date6 = new DateTime(2023, 10, 26);
        Item item6 = new Item(6, 3, "tachun", "food", "besari", date6, 11);
        DateTime date7 = new DateTime(2023, 11, 12);
        Item item7 = new Item(7, 3, "cake", "food", "parve", date7, 8);
        DateTime date8 = new DateTime(2023, 11,11);
        Item item8 = new Item(8, 3, "water", "drink", "parve", date8, 3);
        DateTime date9 = new DateTime(2023, 10, 24);
        Item item9 = new Item(9, 3, "shokolate", "food", "chalavi", date9, 2);
        DateTime date10 = new DateTime(2023, 10, 20);
        Item item10 = new Item(10, 4, "cucamber", "food", "parve", date10,4);
        DateTime date11 = new DateTime(2023, 10, 29);
        Item item11 = new Item(11, 4, "potato", "food", "parve", date11, 12);


        Shelf shelf1 = new Shelf(1,1,13);
        shelf1.Items.Add(item1);
        shelf1.Items.Add(item2);
        shelf1.Items.Add(item3);
        Shelf shelf2 = new Shelf(2, 2, 13);
        shelf2.Items.Add(item4);
        shelf2.Items.Add(item5);
        Shelf shelf3 = new Shelf(3, 3, 25);
        shelf3.Items.Add(item6);
        shelf3.Items.Add(item7);
        shelf3.Items.Add(item8);
        shelf3.Items.Add(item9);
        Shelf shelf4 = new Shelf(4, 4, 17);
        shelf4.Items.Add(item10);
        shelf4.Items.Add(item11);

        Refrigerator refrigerator = new Refrigerator(1,"sumsung","black",4);
        refrigerator.Shelves.Add(shelf1);
        refrigerator.Shelves.Add(shelf2);
        refrigerator.Shelves.Add(shelf3);
        refrigerator.Shelves.Add(shelf4);

     

        Console.WriteLine("the space {0}", refrigerator.spaceInRefrigerator());
    
        refrigerator.getReadyForShopping();

        Console.WriteLine("the space {0}", refrigerator.spaceInRefrigerator());
        
    }
}
