namespace System.Collections.Generic;

[Token(Token = "0x2000620")]
internal class ByteEqualityComparer : EqualityComparer<Byte>
{

	[Address(RVA = "0x1FBF930", Offset = "0x1FBED30", Length = "0x39")]
	[Token(Token = "0x6002DBD")]
	public ByteEqualityComparer() { }

	[Address(RVA = "0x1FBF5F0", Offset = "0x1FBE9F0", Length = "0x7")]
	[Token(Token = "0x6002DB7")]
	public virtual bool Equals(byte x, byte y) { }

	[Address(RVA = "0x1FBF600", Offset = "0x1FBEA00", Length = "0x71")]
	[Token(Token = "0x6002DBB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xDEE3A0", Offset = "0xDED7A0", Length = "0x19")]
	[Token(Token = "0x6002DB8")]
	public virtual int GetHashCode(byte b) { }

	[Address(RVA = "0x1FBF680", Offset = "0x1FBEA80", Length = "0x4C")]
	[Token(Token = "0x6002DBC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1FBF6D0", Offset = "0x1FBEAD0", Length = "0x1F3")]
	[Token(Token = "0x6002DB9")]
	internal virtual int IndexOf(Byte[] array, byte value, int startIndex, int count) { }

	[Address(RVA = "0x1FBF8D0", Offset = "0x1FBECD0", Length = "0x52")]
	[Token(Token = "0x6002DBA")]
	internal virtual int LastIndexOf(Byte[] array, byte value, int startIndex, int count) { }

}

