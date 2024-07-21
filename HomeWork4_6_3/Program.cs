using System.Diagnostics;
using System.Reflection;

public static class Program {

    public static void Main() {
        var filePath = Path.GetFullPath(@"..\..\..\..\HomeWork4_6_2\bin\Debug\net8.0\HomeWork4_6_2.dll");
        var assembly = Assembly.LoadFile(filePath);
        var tcType = assembly.GetType("HomeWork4_6_2.TemperatureConverter");
        var tc = Activator.CreateInstance(tcType);
        var methInfo = tcType.GetMethod("CelsiusToFahrenheit");

        float tempCels1 = 26;
        object[] prms = new object[] { tempCels1 };
        var tempFarenhg1 = (float)methInfo.Invoke(tc, prms);


        float tempCels2 = 0;
        prms = new object[] { tempCels2 };
        var tempFarenhg2 = (float)methInfo.Invoke(tc, prms);

        Console.WriteLine($"{tempCels1} C = {tempFarenhg1} F");
        Console.WriteLine($"{tempCels2} C = {tempFarenhg2} F");

        Debug.Assert(tempFarenhg2 == 32, "Temperature convertion failed");
    }

}