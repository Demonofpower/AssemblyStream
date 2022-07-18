using System.Reflection;

Console.WriteLine("Insert path");

var path = Console.ReadLine();
var stream = File.ReadAllBytes(path);

var assembly = Assembly.Load(stream);

var instance = assembly.CreateInstance("AssemblyStream.ToLoad.CoolClass");

var secretCode = (string) instance.GetType().GetMethod("GetSecret").Invoke(instance, Array.Empty<object?>());

Console.WriteLine($"Code: {secretCode}");

return 0;