namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[Token(Token = "0x20001F3")]
public class VolumeComponentMenu : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000973")]
	public readonly string menu; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000EDB")]
	public VolumeComponentMenu(string menu) { }

}

