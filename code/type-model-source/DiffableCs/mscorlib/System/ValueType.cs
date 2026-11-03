namespace System;

[ComVisible(True)]
[Token(Token = "0x20001DC")]
public abstract class ValueType
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010BC")]
	protected ValueType() { }

	[Address(RVA = "0x20A9610", Offset = "0x20A8A10", Length = "0x1C3")]
	[Token(Token = "0x60010BE")]
	internal static bool DefaultEquals(object o1, object o2) { }

	[Address(RVA = "0x2063C60", Offset = "0x2063060", Length = "0x8")]
	[Token(Token = "0x60010BF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x20A97E0", Offset = "0x20A8BE0", Length = "0x8E")]
	[Token(Token = "0x60010C1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20A9870", Offset = "0x20A8C70", Length = "0x5")]
	[Token(Token = "0x60010BD")]
	private static bool InternalEquals(object o1, object o2, out Object[] fields) { }

	[Address(RVA = "0x20A9880", Offset = "0x20A8C80", Length = "0x5")]
	[Token(Token = "0x60010C0")]
	internal static int InternalGetHashCode(object o, out Object[] fields) { }

	[Address(RVA = "0x20A9890", Offset = "0x20A8C90", Length = "0x30")]
	[Token(Token = "0x60010C2")]
	public virtual string ToString() { }

}

