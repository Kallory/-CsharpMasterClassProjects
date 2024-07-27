


public class Model {
    private string input;

    public string InputForFileName() {

        bool IsHappyFileName = false;
        while (!IsHappyFileName) {
            input = Console.ReadLine();
            if (!IsNotNullOrEmpty(input)) {
                Console.WriteLine("Error, null input");
                continue;
            }

            if (!FileNameExists(input)) {
                Console.WriteLine("Error, file not found");
                continue;
            }

            IsHappyFileName= true;
        }
        return input;
    }

    private bool FileNameExists(string fileName) {
        if (File.Exists(fileName)) {
            return true;
        } 
        return false;
    }

    private bool IsNotNullOrEmpty(string input) {
        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Error: Input is null or empty");
            return false;
        }
        return true;
    }
}