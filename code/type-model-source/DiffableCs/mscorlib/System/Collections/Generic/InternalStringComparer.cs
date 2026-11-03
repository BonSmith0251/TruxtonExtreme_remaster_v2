namespace System.Collections.Generic;

[Token(Token = "0x2000625")]
internal sealed class InternalStringComparer : EqualityComparer<String>
{

	[Address(RVA = "0x1FC8670", Offset = "0x1FC7A70", Length = "0x39")]
	[Token(Token = "0x6002DD5")]
	public InternalStringComparer() { }

	[Address(RVA = "0x1FC85B0", Offset = "0x1FC79B0", Length = "0x28")]
	[Token(Token = "0x6002DD3")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0xDF9380", Offset = "0xDF8780", Length = "0x22")]
	[Token(Token = "0x6002DD2")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x1FC85E0", Offset = "0x1FC79E0", Length = "0x84")]
	[Token(Token = "0x6002DD4")]
	internal virtual int IndexOf(String[] array, string value, int startIndex, int count) { }

}

