
using System.Text.Json;
public static class JsonUtility
{
    private static readonly string FilePath = "humans.json";

    public static void SaveHumans(List<Human> humans)
    {
        string jsonString = JsonSerializer.Serialize(humans);
        File.WriteAllText(FilePath, jsonString);
    }

    public static List<Human> LoadHumans()
    {
        if (File.Exists(FilePath))
        {
            string jsonString = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Human>>(jsonString);
        }

        return new List<Human>();
    }
}