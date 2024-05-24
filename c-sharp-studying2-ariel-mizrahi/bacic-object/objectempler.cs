using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying2_ariel_mizrahi.bacic_object
{
   public class Phone
    {
        public int price = 10;

        public string type = "";

        public bool ison = false;
        public Phone(int price,string type, bool ison)
        {
            this.price = price;
            this.type = type;
            this.ison = ison;
        }
        public Phone()
        {
            
        }
        public void ToggleBoolProperty()
        {
            ison = !ison;
        }
        public void DisplayPhone()
        {

            Console.WriteLine("Template  = price = {0} , type = {1}, is on ={2} "
                ,price, type, ison);
        }

    }
    public class Store
    {
     public  Phone[] phon1 = new Phone[12];

        public Store()
        {
            phon1[0] = new Phone(); 

        }
    }
    public class TestBasicObject
    {
        public static void Demo()
        {
            Phone template1 = new Phone();
            template1.DisplayPhone();

            
            template1.ison = true;
            template1.type = "iphone 12 mini";
            template1.price = 2000;
            template1.DisplayPhone();

            Phone template2 = new Phone();
            Console.WriteLine(template2.ison);
            template2.ToggleBoolProperty();
            template2.DisplayPhone();

            Store st1 = new Store();
            
            st1.phon1[0] = template1;
            st1.phon1[0].DisplayPhone();
           

        }
    }
}
