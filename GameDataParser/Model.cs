


public class Model {
    private string input;

    public string InputForFileName() {

        bool IsHappyFileName = false;
        while (!IsHappyFileName) {
            input = Console.ReadLine();
            if (!IsNotNullOrEmpty(input)) {
                continue;
            }

            if (!FileNameExists(input)) {
                continue;
            }

            IsHappyFileName= true;
        }
        return input;
    }

    private bool FileNameExists(string fileName) {
        if (!File.Exists(fileName)) {
            Console.WriteLine("Filename not found, type a valid filename: ");
            return false;
        } 
        return true;
    }

    private bool IsNotNullOrEmpty(string input) {
        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Error: Input is null or empty, type a valid filename: ");
            return false;
        }
        return true;
    }
}