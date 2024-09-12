using Coplt.Shader.Shaders.Markers;

namespace Coplt.Shader.Shaders;

[GpuOnly]
public interface IBuffer<out Address, out Access, out Size, Type>;

[GpuOnly]
public class Buffer<Address, Access, Size, Type> : IBuffer<Address, Access, Size, Type>
{
    public static implicit operator Buffer<Address, Access, Size, Type>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class StorageBuffer<T> : Buffer<Storage, Read, Array, T>
{
    public static implicit operator StorageBuffer<T>(AnyResource _) => throw Shader.GpuOnlyErr();

    public T this[int index] => throw Shader.GpuOnlyErr();

    public T this[uint index] => throw Shader.GpuOnlyErr();
}

public class RwStorageBuffer<T> : Buffer<Storage, ReadWrite, Array, T>
{
    public static implicit operator RwStorageBuffer<T>(AnyResource _) => throw Shader.GpuOnlyErr();

    public ref T this[int index] => throw Shader.GpuOnlyErr();

    public ref T this[uint index] => throw Shader.GpuOnlyErr();
}
