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
            LogErrorMessage(error);
        }
    }

    
}

public class Logging {

    public void LogErrorMessage(string error)
    {
        const string LogFilename = @"C:\MyLogs\MyApp.log";
        File.AppendAllText(LogFilename, error + "\r\n");
    }
}

public class Discount
{
    public string CustomerType { get; set; }

    public float GetDiscountedPrice(float basePrice)
    {
        if (CustomerType == "Silver")
        {
            return basePrice * 0.9f;
        }
        else
        {
            return basePrice * 0.8f;
        }
    }
}