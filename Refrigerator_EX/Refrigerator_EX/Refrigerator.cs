using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_EX
{
    class Refrigerator
    {
        private int refrigeratorID;
        private string model;
        private string color;
        private int numberOfShelves;
        private List<Shelf> shelves;

        public Refrigerator(int ID, string model, string color, int numberOfShelves)
        {
            this.refrigeratorID = ID;
            this.model = model;
            this.color = color;
            this.numberOfShelves = numberOfShelves;
            this.shelves = new List<Shelf>();
        }

        public int RefrigeratorID { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfShelves { get; set; }
        public List<Shelf> Shelves
        {
            get { return shelves; }
            set {; }
        }


        public double spaceInRefrigerator()//פונקציה שבודקת כמה מקום נשאר במקרר
        {
            //int wastedSpace = 0;
            double refrigeratorSpace = 0;
            foreach (Shelf shelf in shelves)
            {

               refrigeratorSpace += shelf.spaceInShelf();
                 //foreach (Item item in shelf.Items)
                 //{

                 //    wastedSpace += item.SpaceNeed;

                 //}
                 //refrigeratorSpace += (shelf.ShelfSpace - wastedSpace);

                
                //wastedSpace = 0;
            }
            return refrigeratorSpace;

        }


        public void addItemToRefrigerator(Item item)//פונקציה שמוסיפה פריט למקרר 
        {

            if (this.spaceInRefrigerator() < item.SpaceNeed)//אם אין בכל המקרר מקום להכניס את הפריט
                throw new Exception("There is not enough space in the fridge to put the item");
            else
            {
                foreach (Shelf shelf in shelves)// אופציה ב להשליםםם -אני צריכה לחפש במקרר מדף שיש בו מקום לפריט ואז לעדכן את מיקמו
                {
                    if (shelf.spaceInShelf() > item.SpaceNeed)
                    {//אם יש מקום במדף להכניס
                        shelf.addItemToShelf(item);
                        break;
                    }

                }
                if(item.ShelfId==0)//אם הגעתי לשלב הזה ועדיין הקוד של המדף הוא 0 זה אומר שבכללי יש מקום במקרר אבל המקום מפוזר בין המדפים בצורה כזאת שאין מקום בכל מדף וצריך לארגן לזה מקום
                {
                    throw new Exception("There is space in the fridge but you have to rearrange the items on the shelves so that there is space to put the item");
                }

                }
        
            
             
                
        }


       

        public void cleanTheRefrigerator()
        {
            Console.WriteLine("we clean the refrigerator");
            //DateTime currentDate = DateTime.Now;
            foreach (Shelf shelf in shelves)
            {

                shelf.cleanTheShelf();
                //for (int i = 0; i < shelf.Items.Count; i++)
                //{
                    
                //    if (shelf.Items[i].ExpiryDate.Date < currentDate.Date)
                //    {
                       
                //        shelf.Items.Remove(shelf.Items[i]);
                //    }
                //}
                //foreach (Item item in shelf.Items)
                //{
                //    if (currentDate > item.ExpiryDate)
                //    {
                //        shelf.Items.Remove(item);
                //    }
                //}
            }
        }


        public List<Item> FoodOptions(string kosher, string type)
        {
            List<Item> OptionalItems = new List<Item>();
            DateTime currentDate = DateTime.Now;
            foreach (Shelf shelf in shelves)
            {
                foreach (Item item in shelf.Items)
                {
                    if (item.Type.Equals(type) && item.Kashroot.Equals(kosher))
                        if (currentDate < item.ExpiryDate)
                            OptionalItems.Add(item);
                }
            }
            return OptionalItems;
        }

        //public List<Item> SortByExpirationDate()
        //{
        //    this.shelves.OrderBy()
        //}

        public Boolean IsSpacebBiggerThan20()
        {
            if (this.spaceInRefrigerator() >= 20)
                return true;
            return false;
        }

        //public void remove(List<Item> listToRemove)
        //{
        //    while (listToRemove.Count>0)
        //    {
        //        listToRemove.Remove(listToRemove[0]);
        //    }
        //}

        public List<Item> itemsToRemove(string kosher,int days)
        {
            
            DateTime currentDate = DateTime.Now;
            TimeSpan dayDifference;
            List<Item> itemsRemove = new List<Item>();
            foreach (Shelf shelf in shelves)
            {
                int itemLenght = shelf.Items.Count;
                for (int i = 0; i < shelf.Items.Count; i++)
                {
                    if (shelf.Items[i].Kashroot.Equals(kosher))
                    {
                        dayDifference = shelf.Items[i].ExpiryDate - currentDate;
                        if (dayDifference.TotalDays < days)
                        {
                            itemsRemove.Add(shelf.Items[i]);
                            shelf.Items.Remove(shelf.Items[i]);
                            i--;
                        }
                    }

                }
            } 
            return itemsRemove;
        }
        public void getReadyForShopping()
        {
            //List<Item> chalaviToRemove;
            //List<Item> besariToRemove;
            //List<Item> parveToRemove;
            int flag;
            if (this.IsSpacebBiggerThan20())
            {
                Console.WriteLine("Your fridge is ready for shopping. Good luck!");
                return;
            }

            this.cleanTheRefrigerator();
            Console.WriteLine("After cleaning you have {0} space in the fridge", this.spaceInRefrigerator());
            if (this.spaceInRefrigerator() >= 20)
            {
                Console.WriteLine("Your fridge is ready for shopping. Good luck!");
                return;
            }
           
            flag = ggggg("chalavi", 3);
            if (flag == 1)
                return;

            flag = ggggg("besari", 7);
            if (flag == 1)
                return;

            flag = ggggg("parve", 1);
            if (flag == 1)
                return;
            //chalaviToRemove = itemsToRemove("chalavi", 3);
            //Console.WriteLine("We removed the following chaalavi products from the fridge:");
            //foreach (Item item in chalaviToRemove)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //if (this.IsSpacebBiggerThan20())
            //{

            //    Console.WriteLine("Your fridge is ready for shopping. Good luck!");
            //    return;
            //}

            //besariToRemove = itemsToRemove("besari", 7);
            //Console.WriteLine("We removed the following besari products from the fridge:");
            //foreach (Item item in besariToRemove)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //if (this.IsSpacebBiggerThan20())
            //{
            //    Console.WriteLine("Your fridge is ready for shopping. Good luck!");
            //    return;
            //}
            //parveToRemove = itemsToRemove("parve", 1);
            //if (this.IsSpacebBiggerThan20())
            //{
            //    Console.WriteLine("We removed the following parve products from the fridge:");
            //    foreach (Item item in parveToRemove)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //    Console.WriteLine("Your fridge is ready for shopping. Good luck!");
            //    return;
            //}

            return;
        }


          public int ggggg(string kosher, int days)
           {

            List<Item> itemssToRemove;
           
            itemssToRemove = itemsToRemove(kosher, days);
            Console.WriteLine("We removed the following {0} products from the fridge:", kosher);
            foreach (Item item in itemssToRemove)
            {
                Console.WriteLine(item.Name);
            }
            if (this.IsSpacebBiggerThan20())
            {

                Console.WriteLine("Your fridge is ready for shopping. Good luck!");
                return 1;
            }
            return 0;
           }
 

    }


}
