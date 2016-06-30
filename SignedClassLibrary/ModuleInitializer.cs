/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
using System;
using System.Security;
public static class ModuleInitializer
{
    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        var ad = AppDomain.CurrentDomain;
        try
        {
            var ps = ad.PermissionSet;
            Console.WriteLine("Works Do bad stuff here!");
        }
        catch(MethodAccessException ex)
        {
            Console.WriteLine("Exeption Happend! :O");
        }
    }
}