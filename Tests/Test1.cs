using System.Runtime.InteropServices;
using Coplt.Shader;
using Coplt.Shader.Shaders;
using Coplt.Mathematics;

namespace Tests.Test1;

[ShaderMemoryLayout]
public struct SceneInfo
{
    public ViewInfo view;
}

[ShaderMemoryLayout]
public struct ViewInfo
{
    public float4x4 proj;
    public float4x4 view;
}

[ShaderMemoryLayout]
public struct ObjectInfo
{
    public float4x4 transform;
}

[Shader]
public class Shader1 : IShaderModule
{
    [Uniform]
    public SceneInfo scene;
    [Storage]
    public ObjectInfo[] objects = null!;

    public Texture2d<float4> tex;
    public SamplerState ss;

    public struct VI
    {
        public float4 pos;
        public float2 uv;
        [Builtin(Semantics.InstanceId)]
        public uint iid;
    }

    public struct V2P
    {
        [Builtin(Semantics.Position)]
        public float4 pos;
        public float2 uv;
        [Builtin(Semantics.InstanceId)]
        [Interpolate(Interpolate.Flat)]
        public uint iid;
    }

    [VertexShader]
    public V2P Vertex(VI vi)
    {
        return default;
        // var obj = objects[vi.iid];
        // var pos = scene.view.proj * (scene.view.view * (obj.transform * vi.pos));
        // return new() { pos = pos, uv = vi.uv, iid = vi.iid };
    }

    [PixelShader]
    public float4 Pixel(V2P v2p) => tex.Sample(ss, v2p.uv);
}

public static class Test1
{
    public static void Foo()
    {
        var shader = ShaderLoader.Load<Shader1>(new() { RequiredType = ShaderModuleType.Hlsl });
        var code = MemoryMarshal.Cast<byte, char>(shader.Blob()).ToString();
        Console.WriteLine(code);
    }
}
