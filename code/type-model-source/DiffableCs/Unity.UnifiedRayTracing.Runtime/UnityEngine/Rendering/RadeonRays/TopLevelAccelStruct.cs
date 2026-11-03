namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200000D")]
internal struct TopLevelAccelStruct : IDisposable
{
	[Token(Token = "0x400002D")]
	public const Target topLevelBvhTarget = 16; //Field offset: 0x0
	[Token(Token = "0x400002E")]
	public const Target instanceInfoTarget = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002F")]
	public GraphicsBuffer topLevelBvh; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000030")]
	public GraphicsBuffer bottomLevelBvhs; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000031")]
	public GraphicsBuffer instanceInfos; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000032")]
	public uint instanceCount; //Field offset: 0x18

	[Address(RVA = "0x2F61390", Offset = "0x2F60790", Length = "0x33")]
	[Token(Token = "0x6000026")]
	public override void Dispose() { }

}

