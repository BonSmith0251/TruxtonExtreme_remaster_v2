namespace UnityEngine.Rendering;

[Token(Token = "0x2000092")]
internal class DebugActionDesc
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001FB")]
	public InputAction buttonAction; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FC")]
	public DebugActionRepeatMode repeatMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001FD")]
	public float repeatDelay; //Field offset: 0x1C

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000671")]
	public DebugActionDesc() { }

}

