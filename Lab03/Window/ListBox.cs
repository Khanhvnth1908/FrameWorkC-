using System;
using System.Collections.Generic;
using System.Text;

namespace Window
{
    class ListBox : Window
    {
        //constructor add a parameter
        public ListBox(int top,int left,string contents):base(top,left)
        {
            listBoxContents = contents;
        }
        //an overridden version (note keyword) because the
        //derived medthod we change the behavior 
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writeing string to the listbox: {0}", listBoxContents);
        }

        private string listBoxContents;
    }
}
