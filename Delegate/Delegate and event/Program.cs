
public delegate void EventHandlerDelegate(object sender, EventArgs e);


public class EventPublisher {
    public event EventHandlerDelegate MyEvent;
    public void DoSomething() {
        Console.WriteLine("Doing something interesting...");
        OnMyEvent();
    }

    protected virtual void OnMyEvent() {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

public class EventSubscriber {
    public void HandleEvent(object sender, EventArgs e) {
        Console.WriteLine(sender.ToString());
        Console.WriteLine("B1_Event handled by subscriber.");
    }
}

public class Program {
    static void Main(string[] args) {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber();

        publisher.MyEvent += subscriber.HandleEvent;
        publisher.DoSomething();
    }
}
