namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005E5")]
internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400157E")]
	public int useCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400157F")]
	public GradientRemap firstGradientRemap; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001580")]
	public Alloc gradientSettingsAlloc; //Field offset: 0x28

	[Address(RVA = "0x332E670", Offset = "0x332DA70", Length = "0x11C")]
	[Token(Token = "0x6002A5A")]
	public VectorImageRenderInfo() { }

	[Address(RVA = "0x332E640", Offset = "0x332DA40", Length = "0x30")]
	[Token(Token = "0x6002A59")]
	public void Reset() { }

}

