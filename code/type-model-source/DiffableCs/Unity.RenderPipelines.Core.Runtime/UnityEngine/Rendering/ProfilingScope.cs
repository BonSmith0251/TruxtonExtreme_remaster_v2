namespace UnityEngine.Rendering;

[Token(Token = "0x20000D9")]
public struct ProfilingScope : IDisposable
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007C1")]
	public ProfilingScope(ProfilingSampler sampler) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007C2")]
	public ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007C3")]
	public ProfilingScope(BaseCommandBuffer cmd, ProfilingSampler sampler) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007C4")]
	public override void Dispose() { }

}

