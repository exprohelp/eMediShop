using System;
using System.Collections.Generic;
using System.Text;

namespace eMediShop
{
 public  class AddValue
    {
     private object newValue;
     private String strDescription;

     public AddValue(object NewValue,String NewDescription)
     {
         newValue = NewValue;
         strDescription=NewDescription;
     }

     public string Value{
         get { return newValue.ToString(); }
     }
     public string NewDescription{
     get{return strDescription;}
     }
     public override string  ToString()
     {
           return strDescription;
     }
  
    }

    public class ExproComboBox
    {
        private object objValue;
        private String strDescription;

        public ExproComboBox(object NewValue, String NewDescription)
        {
            objValue = NewValue;
            strDescription = NewDescription;
        }

        public string Value
        {
            get { return objValue.ToString(); }
        }
        public string NewDescription
        {
            get { return strDescription; }
        }
        public override string ToString()
        {
            return strDescription;
        }
    }
}
