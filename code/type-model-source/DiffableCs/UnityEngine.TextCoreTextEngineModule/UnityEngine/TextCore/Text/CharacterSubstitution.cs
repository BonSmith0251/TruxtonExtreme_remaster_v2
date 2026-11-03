namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000055")]
internal struct CharacterSubstitution
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000330")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000331")]
	public uint unicode; //Field offset: 0x4

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x600023D")]
	public CharacterSubstitution(int index, uint unicode) { }

}

