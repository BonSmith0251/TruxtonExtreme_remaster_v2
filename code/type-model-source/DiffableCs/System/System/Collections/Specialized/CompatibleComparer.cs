namespace System.Collections.Specialized;

[Token(Token = "0x20001EA")]
internal class CompatibleComparer : IEqualityComparer
{
	[Token(Token = "0x400073B")]
	private static IComparer defaultComparer; //Field offset: 0x0
	[Token(Token = "0x400073D")]
	private static IHashCodeProvider defaultHashProvider; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400073A")]
	private IComparer _comparer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400073C")]
	private IHashCodeProvider _hcp; //Field offset: 0x18

	[Token(Token = "0x17000268")]
	public IComparer Comparer
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C6C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700026A")]
	public static IComparer DefaultComparer
	{
		[Address(RVA = "0x2679EF0", Offset = "0x26792F0", Length = "0xE5")]
		[Token(Token = "0x6000C6E")]
		 get { } //Length: 229
	}

	[Token(Token = "0x1700026B")]
	public static IHashCodeProvider DefaultHashCodeProvider
	{
		[Address(RVA = "0x2679FE0", Offset = "0x26793E0", Length = "0xEC")]
		[Token(Token = "0x6000C6F")]
		 get { } //Length: 236
	}

	[Token(Token = "0x17000269")]
	public IHashCodeProvider HashCodeProvider
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C6D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000C69")]
	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	[Address(RVA = "0x2679D10", Offset = "0x2679110", Length = "0x10A")]
	[Token(Token = "0x6000C6A")]
	public override bool Equals(object a, object b) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C6C")]
	public IComparer get_Comparer() { }

	[Address(RVA = "0x2679EF0", Offset = "0x26792F0", Length = "0xE5")]
	[Token(Token = "0x6000C6E")]
	public static IComparer get_DefaultComparer() { }

	[Address(RVA = "0x2679FE0", Offset = "0x26793E0", Length = "0xEC")]
	[Token(Token = "0x6000C6F")]
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C6D")]
	public IHashCodeProvider get_HashCodeProvider() { }

	[Address(RVA = "0x2679E20", Offset = "0x2679220", Length = "0xCB")]
	[Token(Token = "0x6000C6B")]
	public override int GetHashCode(object obj) { }

}

