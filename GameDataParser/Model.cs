

public class Model {
    private string input;

    public string InputForFileName() {
        while (!IsNotNullOrEmpty()) {
            Console.WriteLine("Error, null input");
        }
        return input;
    }

    private bool IsNotNullOrEmpty() {
        input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Error: Input is null or empty");
            return false;
        }
        return true;
    }
}