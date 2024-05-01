using System.Runtime.CompilerServices;
using Coplt.Mathematics;

namespace MathTests;

public class Test1
{
    [MethodImpl(256 | 512)]
    public void Foo(int i)
    {
        var a = new int4(1, 2, 3, 4);
        a.yzx = a.yzw;
        if (i == 8888) { Thread.Sleep(100); }
        if (i == 9999)
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }
        Console.WriteLine(a);
    }

    [Test]
    public void Swizzel1()
    {
        for (var i = 0; i < 20000; i++)
        {
            Foo(i);
        }
    }
}
