namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005E8")]
internal class GradientRemap : LinkedPoolItem<GradientRemap>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001584")]
	public int origIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001585")]
	public int destIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001586")]
	public RectInt location; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001587")]
	public GradientRemap next; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001588")]
	public TextureId atlas; //Field offset: 0x38

	[Address(RVA = "0x33181E0", Offset = "0x33175E0", Length = "0x39")]
	[Token(Token = "0x6002A61")]
	public GradientRemap() { }

	[Address(RVA = "0x3318170", Offset = "0x3317570", Length = "0x63")]
	[Token(Token = "0x6002A60")]
	public void Reset() { }

}

