using SomePeerDependency;

namespace SomeClassLib;

public class Class1
{
    private readonly Class1 _otherClass;

    public Class1(Class1 otherClass)
    {
        _otherClass = otherClass;
    }

    public static string Greet(string name)
    {
        return $"Hello, {PeerClass.Upper(name)}";
    }
}
