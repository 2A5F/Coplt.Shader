using System.Runtime.CompilerServices;
using System.Text;
using Coplt.Mathematics;

namespace MathTests;

public class Test1
{
#if NET8_0_OR_GREATER
    [Test]
    public void Foo()
    {
        var a = new float4(123, 123, 123, 123);
        var r = simd_log_float.LogFast2(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(MathF.Log(123));
    }
#endif

}
