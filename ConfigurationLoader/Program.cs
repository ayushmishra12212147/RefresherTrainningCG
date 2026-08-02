using System;

interface IConfigurationSource
{
    bool TryLoad(out string configuration);
}

class EnvironmentVariableSource : IConfigurationSource
{
    public bool TryLoad(out string configuration)
    {
        configuration = "";
        return false;
    }
}

class JsonFileSource : IConfigurationSource
{
    public bool TryLoad(out string configuration)
    {
        configuration = "";
        return false;
    }
}

class DatabaseSource : IConfigurationSource
{
    public bool TryLoad(out string configuration)
    {
        configuration = "Database Configuration Loaded";
        return true;
    }
}

static class ConfigurationLoader
{
    public static void Load(params IConfigurationSource[] sources)
    {
        foreach (var source in sources)
        {
            if (source.TryLoad(out string config))
            {
                Console.WriteLine("Configuration Loaded Successfully");
                Console.WriteLine(config);
                return;
            }
        }

        Console.WriteLine("No Configuration Found.");
    }
}

class Program
{
    static void Main()
    {
        ConfigurationLoader.Load(
            new EnvironmentVariableSource(),
            new JsonFileSource(),
            new DatabaseSource()
        );
    }
}