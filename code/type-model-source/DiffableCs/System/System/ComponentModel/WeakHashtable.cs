namespace System.ComponentModel;

[Token(Token = "0x20001C4")]
internal sealed class WeakHashtable : Hashtable
{
	[Token(Token = "0x20001C5")]
	private class WeakKeyComparer : IEqualityComparer
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B70")]
		public WeakKeyComparer() { }

		[Address(RVA = "0x2696780", Offset = "0x2695B80", Length = "0x1A0")]
		[Token(Token = "0x6000B6E")]
		private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

		[Address(RVA = "0x2696920", Offset = "0x2695D20", Length = "0x2C")]
		[Token(Token = "0x6000B6F")]
		private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	}

	[Token(Token = "0x40006E3")]
	private static IEqualityComparer _comparer; //Field offset: 0x0

	[Address(RVA = "0x26966A0", Offset = "0x2695AA0", Length = "0x73")]
	[Token(Token = "0x6000B6D")]
	private static WeakHashtable() { }

	[Address(RVA = "0x2696720", Offset = "0x2695B20", Length = "0x5E")]
	[Token(Token = "0x6000B6A")]
	internal WeakHashtable() { }

	[Address(RVA = "0x2696680", Offset = "0x2695A80", Length = "0x7")]
	[Token(Token = "0x6000B6B")]
	public virtual void Clear() { }

	[Address(RVA = "0x2696690", Offset = "0x2695A90", Length = "0x8")]
	[Token(Token = "0x6000B6C")]
	public virtual void Remove(object key) { }

}

