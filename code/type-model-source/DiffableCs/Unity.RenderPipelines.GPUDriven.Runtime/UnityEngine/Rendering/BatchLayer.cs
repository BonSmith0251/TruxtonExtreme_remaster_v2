namespace UnityEngine.Rendering;

[Token(Token = "0x2000008")]
public class BatchLayer
{
	[Token(Token = "0x4000008")]
	public const byte InstanceCullingDirect = 29; //Field offset: 0x0
	[Token(Token = "0x4000009")]
	public const byte InstanceCullingIndirect = 28; //Field offset: 0x0
	[Token(Token = "0x400000A")]
	public const uint InstanceCullingDirectMask = 536870912; //Field offset: 0x0
	[Token(Token = "0x400000B")]
	public const uint InstanceCullingIndirectMask = 268435456; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	public const uint InstanceCullingMask = 805306368; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600000C")]
	public BatchLayer() { }

}

