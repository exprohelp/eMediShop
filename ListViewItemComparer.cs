using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace eMediShop
{
    // Implements the manual sorting of items by columns.
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
public int Compare(object x, object y) // IComparer Member 
    { 
        if (!(x is ListViewItem)) 
            return (0); 
        if (!(y is ListViewItem)) 
            return (0); 
 
        ListViewItem l1 = (ListViewItem)x; 
        ListViewItem l2 = (ListViewItem)y; 
 
        if (l1.ListView.Columns[col].Tag == null) 
        { 
            l1.ListView.Columns[col].Tag = "Text"; 
        } 
 
        if (l1.ListView.Columns[col].Tag.ToString() == "Numeric") 
        { 
            float fl1 = float.Parse(l1.SubItems[col].Text); 
            float fl2 = float.Parse(l2.SubItems[col].Text); 
 
            if (order == SortOrder.Ascending) 
            { 
                return fl1.CompareTo(fl2); 
            } 
            else 
            { 
                return fl2.CompareTo(fl1); 
            } 
        } 
        else 
        { 
            string str1 = l1.SubItems[col].Text; 
            string str2 = l2.SubItems[col].Text; 
 
            if (order == SortOrder.Ascending) 
            { 
                return str1.CompareTo(str2); 
            } 
            else 
            { 
                return str2.CompareTo(str1); 
            } 
        } 
    } 
    }

}
