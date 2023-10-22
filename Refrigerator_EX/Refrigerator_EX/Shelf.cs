using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_EX
{
    class Shelf
    {
        private int ID;
        private int floorNumber;
        private int shelfSpace;
        private List<Item> items;

       
        public int Id
        { 
            get{return ID; } 
            set {ID=value; } 
        }
        public int FloorNumber
        {
            get { return floorNumber; } set {; }
        }
        public int ShelfSpace 
        {
            get { return shelfSpace; } set {; }
        }
        public List<Item> Items 
        {
            get { return items; } set {; } 
        }

        public Shelf(int ID,int floorNumber,int shelfSpace)
        {
           
            this.ID = ID;
            this.floorNumber = floorNumber;
            this.shelfSpace = shelfSpace;
            this.items = new List<Item>();
            
        }


        public double spaceInShelf()
        {
            double wastedSpace = 0;
           
            foreach (Item item in items)
            {

                wastedSpace += item.SpaceNeed;

            }
            return  (ShelfSpace - wastedSpace);


            
        }

        public void addItemToShelf(Item item)
        {
            this.items.Add(item);
            item.ShelfId= this.ID;//עדכון המדף אליו הוא נכנס
            Console.WriteLine("The item has been placed on the shelf {0}", ID);
        }

        public void cleanTheShelf()
        {
            DateTime currentDate = DateTime.Now;
            for (int i = 0; i < Items.Count; i++)
            {

                if (Items[i].ExpiryDate.Date < currentDate.Date)
                {

                    Items.Remove(Items[i]);
                }
            }
        }



    }
}
