using System;

public delegate void ButtonClickEventHandler(object sender, EventArgs e);

public class Button
{
    public event ButtonClickEventHandler ButtonClicked;

    public void OnButtonClicked()
    {
        if (ButtonClicked != null)
        {
            ButtonClicked(this, EventArgs.Empty);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Button button = new Button();
        button.ButtonClicked += OnButtonClick;
        button.OnButtonClicked();
    }

    public static void OnButtonClick(object sender, EventArgs e)
    {
        Console.WriteLine("Tombol ditekan!");
    }
}