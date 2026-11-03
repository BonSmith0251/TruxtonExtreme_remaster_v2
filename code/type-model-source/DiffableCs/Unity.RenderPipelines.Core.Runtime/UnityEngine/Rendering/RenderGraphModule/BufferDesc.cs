namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000288")]
public struct BufferDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B5C")]
	public int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B5D")]
	public int stride; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B5E")]
	public string name; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B5F")]
	public Target target; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B60")]
	public UsageFlags usageFlags; //Field offset: 0x14

	[Address(RVA = "0x2C8D200", Offset = "0x2C8C600", Length = "0x15")]
	[Token(Token = "0x6001220")]
	public BufferDesc(int count, int stride) { }

	[Address(RVA = "0x2C8D220", Offset = "0x2C8C620", Length = "0x14")]
	[Token(Token = "0x6001221")]
	public BufferDesc(int count, int stride, Target target) { }

	[Address(RVA = "0x2C8D1C0", Offset = "0x2C8C5C0", Length = "0x39")]
	[Token(Token = "0x6001222")]
	public virtual int GetHashCode() { }

}

