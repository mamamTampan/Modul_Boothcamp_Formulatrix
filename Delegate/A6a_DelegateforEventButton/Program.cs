using System;

namespace EventHandling
{
    public delegate void ButtonClickDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            ButtonClickDelegate buttonClick = OnButtonClick;
            buttonClick();
        }

        static void OnButtonClick()
        {
            Console.WriteLine("Tombol ditekan!");
        }
    }
}