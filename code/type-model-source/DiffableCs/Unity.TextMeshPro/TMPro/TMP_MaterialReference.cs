namespace TMPro;

[Token(Token = "0x2000013")]
public struct TMP_MaterialReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000028")]
	public Material material; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000029")]
	public int referenceCount; //Field offset: 0x8

}

