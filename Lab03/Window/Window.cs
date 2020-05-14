using System;

namespace Window
{
    class Window
    {
       //Constructor takes two integers to 
       // fix location on the console
       public Window(int top,int left)
        {
            this.top = top;
            this.left = left;
        }
        // simlates drawing the window
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing window at {0}, {1}", top, left);
        }
        protected int top;
        protected int left;
    }
}
