using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying2_ariel_mizrahi.bacic_object
{
    class objectempler
    {
        public int intProperty = 10;

        public string stringProperty = "ariel mizrahi";

        public bool boolProperty = false;

        public void ToggleBoolProperty()
        {
            boolProperty = !boolProperty;
        }

    }
    public class TestBasicObject
    {
        public static void Demo()
        {
            objectempler template1 = new objectempler();


            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            template1.boolProperty = true;
            template1.stringProperty = "another string";
            template1.intProperty = 20;
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            objectempler template2 = new objectempler();

            Console.WriteLine("Template 2 = intProperty = {0} , string property = {1}, boolProperty ={2} "
               , template2.intProperty, template2.stringProperty, template2.boolProperty);


        }
    }
}
