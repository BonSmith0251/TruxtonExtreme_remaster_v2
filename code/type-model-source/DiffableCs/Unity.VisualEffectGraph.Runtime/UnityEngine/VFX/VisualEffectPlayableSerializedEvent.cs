namespace UnityEngine.VFX;

[Token(Token = "0x200002B")]
internal struct VisualEffectPlayableSerializedEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007C")]
	public Color editorColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007D")]
	public double time; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007E")]
	public PlayableTimeSpace timeSpace; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400007F")]
	public ExposedProperty name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000080")]
	public EventAttributes eventAttributes; //Field offset: 0x28

}

