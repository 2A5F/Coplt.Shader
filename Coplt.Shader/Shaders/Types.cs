namespace Coplt.Shader.Shaders;

[GpuOnly]
public record struct unorm<T>(T Value)
{
    public static implicit operator T(unorm<T> a) => a.Value;
    public static implicit operator unorm<T>(T a) => new(a);
}

[GpuOnly]
public record struct snorm<T>(T Value)
{
    public static implicit operator T(snorm<T> a) => a.Value;
    public static implicit operator snorm<T>(T a) => new(a);
}

[GpuOnly]
public record struct uniform<T>(T Value)
{
    public static implicit operator T(uniform<T> a) => a.Value;
    public static implicit operator uniform<T>(T a) => new(a);
}

[GpuOnly]
public record struct row_major<T>(T Value)
{
    public static implicit operator T(row_major<T> a) => a.Value;
    public static implicit operator row_major<T>(T a) => new(a);
}

[GpuOnly]
public record struct column_major<T>(T Value)
{
    public static implicit operator T(column_major<T> a) => a.Value;
    public static implicit operator column_major<T>(T a) => new(a);
}
