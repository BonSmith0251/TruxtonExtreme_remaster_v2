namespace System.Collections.Generic;

[Token(Token = "0x200061E")]
internal class NullableEqualityComparer : EqualityComparer<Nullable`1<T>>
{

	[Address(RVA = "0xD9BE80", Offset = "0xD9B280", Length = "0x14")]
	[Token(Token = "0x6002DAF")]
	public NullableEqualityComparer`1() { }

	[Address(RVA = "0xD9A610", Offset = "0xD99A10", Length = "0xC4")]
	[Token(Token = "0x6002DA9")]
	public virtual bool Equals(Nullable<T> x, Nullable<T> y) { }

	[Address(RVA = "0xD9A590", Offset = "0xD99990", Length = "0x72")]
	[Token(Token = "0x6002DAD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xD9AA90", Offset = "0xD99E90", Length = "0x20")]
	[Token(Token = "0x6002DAA")]
	public virtual int GetHashCode(Nullable<T> obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002DAE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xD9B1D0", Offset = "0xD9A5D0", Length = "0x18A")]
	[Token(Token = "0x6002DAB")]
	internal virtual int IndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

	[Address(RVA = "0xD9BCD0", Offset = "0xD9B0D0", Length = "0x18A")]
	[Token(Token = "0x6002DAC")]
	internal virtual int LastIndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

}

