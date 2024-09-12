using Coplt.Shader.Shaders.Markers;

namespace Coplt.Shader.Shaders;

[GpuOnly]
public class ConstantBuffer<T> : Buffer<Uniform, Read, Single, T>
{
    public static implicit operator ConstantBuffer<T>(AnyResource _) => throw Shader.GpuOnlyErr();
    
    public static implicit operator T(ConstantBuffer<T> buffer) => throw Shader.GpuOnlyErr();

    public T Value => throw Shader.GpuOnlyErr();
}
