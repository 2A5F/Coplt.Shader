using System.Runtime.InteropServices;
using Coplt.Shader;
using Coplt.Shader.Shaders;
using Coplt.Mathematics;

namespace Tests.Test1;

public struct SceneInfo
{
    public ViewInfo view;
}

public struct ViewInfo
{
    public float4x4 proj;
    public float4x4 view;
}

public struct ObjectInfo
{
    public float4x4 transform;
}

public class Shader1 : IShaderModule
{
    [Uniform]
    public SceneInfo scene;
    [Storage]
    public ObjectInfo[] objects = null!;

    public Texture2D<float4> tex;
    public SamplerState ss;

    public struct Attributes
    {
        [Semantic("POSITION")]
        public float4 pos;
        [Semantic("TEXCOORD")]
        public float2 uv;
        [SV_InstanceID]
        public uint iid;
    }

    public struct Varyings
    {
        [SV_Position]
        public float4 pos;
        public float2 uv;
        [NoInterpolation]
        public uint iid;
    }

    [Shader("vertex")]
    public Varyings Vertex(Attributes input)
    {
        var obj = objects[input.iid];
        var pos = scene.view.proj.mul(scene.view.view.mul(obj.transform.mul(input.pos)));
        return new() { pos = pos, uv = input.uv, iid = input.iid };
    }

    [Shader("pixel"), SV_Target]
    public float4 Pixel(Varyings input) => tex.Sample(ss, input.uv);
}

public static class Test1
{
    public static void Foo()
    {
        var shader = ShaderLoader.Of<Shader1>().Load(ShaderTarget.DirectX, ShaderModuleType.Hlsl);
        var code = MemoryMarshal.Cast<byte, char>(shader.Blob()).ToString();
        Console.WriteLine(code);
    }
}
