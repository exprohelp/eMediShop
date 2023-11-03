using System;
using System.Collections.Generic;
using System.Text;

public delegate void SearchUpdateEventHandler(object sender, SearchUpdatedEventArgs e);
//Step 2 
public delegate void textBoxKeyUpEventHandler(object sender, textBoxKeyUpEventArgs e);
//Step 2 
public delegate void comboIndexChangeEventHandler(object sender, comboChangeEventArgs e);
public class SearchUpdatedEventArgs : System.EventArgs
{
    private string productID;
    public SearchUpdatedEventArgs(string productID)
    {
        this.productID = productID;

    }
    public string ProductID
    {
        get
        {
            return this.productID;
        }
    }
}
//Step 1 
public class textBoxKeyUpEventArgs : System.EventArgs
{
    private int lvindex;
    private string textboxvalue;
    public textBoxKeyUpEventArgs(int lvIndex, string textboxValue)
    {
        this.lvindex = lvIndex;
        this.textboxvalue = textboxValue;

    }
    public int LVindex
    {
        get
        {
            return this.lvindex;
        }
    }
    public string TextBoxValue
    {
        get
        {
            return this.textboxvalue;
        }
    }

}

//Step 1 
public class comboChangeEventArgs : System.EventArgs
{
    private int lvindex;
    private string combotext;
    public comboChangeEventArgs(int lvIndex, string comboText)
    {
        this.lvindex = lvIndex;
        this.combotext = comboText;

    }
    public int LVindex
    {
        get
        {
            return this.lvindex;
        }
    }
    public string ComboText
    {
        get
        {
            return this.combotext;
        }
    }

}

