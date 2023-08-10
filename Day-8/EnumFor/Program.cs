public enum ErrorStatus
{
    NotFound = 404,
    BadRequest = 400,
    InternalServerError = 500
}

class Program
{
    static void Main()
    {
        ErrorStatus error = ErrorStatus.NotFound;
        Console.WriteLine((int)error);
        Console.WriteLine(error);
        
        // Correctly get the enum values as IEnumerable<ErrorStatus>
        IEnumerable<ErrorStatus> values = Enum.GetValues(typeof(ErrorStatus)).Cast<ErrorStatus>();
        
        // Use the enum in a foreach loop
        foreach (ErrorStatus errorx in values)
        {
            Console.WriteLine(errorx);
        }
    }
}
