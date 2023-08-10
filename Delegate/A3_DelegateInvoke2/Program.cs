using System;

public delegate void PlayerAction();

class Program {
    static void Main(string[] args) {
        PlayerAction jumpAction = Player.Jump;
        PlayerAction runAction = Player.Run;
        PlayerAction swimAction = Player.Swim;

        Console.WriteLine("Choose an action (J for Jump, R for Run, S for Swim):");
        char input = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (input) {
            case 'J':
                PerformAction(jumpAction);
                break;
            case 'R':
                PerformAction(runAction);
                break;
            case 'S':
                PerformAction(swimAction);
                break;
            default:
                Console.WriteLine("Invalid input. Please press J, R, or S.");
                break;
        }
    }

    static void PerformAction(PlayerAction action) {
        action.Invoke();
    }
}


public class Player {
    // Player action methods
    public static void Jump() {
        Console.WriteLine("The player is jumping.");
    }

    public static void Run() {
        Console.WriteLine("The player is running.");
    }

    public static void Swim() {
        Console.WriteLine("The player is swimming.");
    }
}
