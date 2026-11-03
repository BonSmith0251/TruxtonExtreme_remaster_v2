namespace System.Collections;

[Token(Token = "0x20005B1")]
internal sealed class CompatibleComparer : IEqualityComparer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017B9")]
	private readonly IHashCodeProvider _hcp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017BA")]
	private readonly IComparer _comparer; //Field offset: 0x18

	[Token(Token = "0x17000631")]
	internal IComparer Comparer
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600298B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000630")]
	internal IHashCodeProvider HashCodeProvider
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600298A")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6002989")]
	internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	[Address(RVA = "0x1FC12A0", Offset = "0x1FC06A0", Length = "0x1B8")]
	[Token(Token = "0x600298D")]
	public int Compare(object a, object b) { }

	[Address(RVA = "0x1FC1460", Offset = "0x1FC0860", Length = "0x188")]
	[Token(Token = "0x600298C")]
	public override bool Equals(object a, object b) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600298B")]
	internal IComparer get_Comparer() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600298A")]
	internal IHashCodeProvider get_HashCodeProvider() { }

	[Address(RVA = "0x1FC15F0", Offset = "0x1FC09F0", Length = "0xC0")]
	[Token(Token = "0x600298E")]
	public override int GetHashCode(object obj) { }

}

