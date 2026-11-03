namespace UnityEngine.VFX;

[Token(Token = "0x200002C")]
internal struct VisualEffectPlayableSerializedEventNoColor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000081")]
	public double time; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000082")]
	public PlayableTimeSpace timeSpace; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000083")]
	public ExposedProperty name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000084")]
	public EventAttributes eventAttributes; //Field offset: 0x18

	[Address(RVA = "0x2F7D6A0", Offset = "0x2F7CAA0", Length = "0x7C")]
	[Token(Token = "0x600006A")]
	public static VisualEffectPlayableSerializedEvent op_Implicit(VisualEffectPlayableSerializedEventNoColor evt) { }

}

