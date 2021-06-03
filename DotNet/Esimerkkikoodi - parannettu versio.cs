public class Customer
{
    public void StoreToDatabase(string id, string name, DateTime firstOrderDate)
    {
        try
        {
            // store data to database here
        }
        catch (Exception ex)
        {
            string error = $"Exception of type {ex.GetType().FullName}: {ex.Message}";
            Logging.LogErrorMessage(error);
        }
    }    
}

public class Logging
{
    public static void LogErrorMessage(string error)
    {
        const string LogFilename = @"C:\MyLogs\MyApp.log";
        File.AppendAllText(LogFilename, error + "\r\n");
    }
}

public class Discount
{
    public string CustomerType { get; set; }

    public virtual float GetDiscountedPrice(float basePrice, Dictionary<string, float> discountLevels)
    {
        float discount = discountLevels[CustomerType];
        return basePrice * discount;
    }
}

Dictionary<string, float> discountLevels = new() {
    "Silver", 0.9f,
    "Gold", 0.8f,
    "Platinum", 0.7f
}
