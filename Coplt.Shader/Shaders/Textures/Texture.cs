using Coplt.Shader.Shaders.Markers;

namespace Coplt.Shader.Shaders;

[GpuOnly]
public interface ITexture<out Address, out Dimension, out Size, Type>;

[GpuOnly]
public class Texture<Address, Dimension, Size, Type> : ITexture<Address, Dimension, Size, Type>
{
    public static implicit operator Texture<Address, Dimension, Size, Type>(AnyResource _) => throw Shader.GpuOnlyErr();
}

#region Sampled

public class Texture1D<T> : Texture<Sampled, D1, Single, T>
{
    public static implicit operator Texture1D<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class Texture2D<T> : Texture<Sampled, D2, Single, T>
{
    public static implicit operator Texture2D<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class Texture3D<T> : Texture<Sampled, D3, Single, T>
{
    public static implicit operator Texture3D<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class TextureCube<T> : Texture<Sampled, Cube, Single, T>
{
    public static implicit operator TextureCube<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class Texture1DArray<T> : Texture<Sampled, D1, Array, T>
{
    public static implicit operator Texture1DArray<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class Texture2DArray<T> : Texture<Sampled, D2, Array, T>
{
    public static implicit operator Texture2DArray<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class TextureCubeArray<T> : Texture<Sampled, Cube, Array, T>
{
    public static implicit operator TextureCubeArray<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

#endregion

#region MultiSampled

public class Texture2DMS<T> : Texture<MultiSampled, D2, Single, T>
{
    public static implicit operator Texture2DMS<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class Texture2DMSArray<T> : Texture<MultiSampled, D2, Array, T>
{
    public static implicit operator Texture2DMSArray<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

#endregion

#region Storage

public class RWTexture1D<T> : Texture<Storage, D1, Single, T>
{
    public static implicit operator RWTexture1D<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class RWTexture2D<T> : Texture<Storage, D2, Single, T>
{
    public static implicit operator RWTexture2D<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class RWTexture2DArray<T> : Texture<Storage, D2, Array, T>
{
    public static implicit operator RWTexture2DArray<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

public class RWTexture3D<T> : Texture<Storage, D3, Single, T>
{
    public static implicit operator RWTexture3D<T>(AnyResource _) => throw Shader.GpuOnlyErr();
}

#endregion
