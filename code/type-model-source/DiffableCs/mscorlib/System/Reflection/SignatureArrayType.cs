namespace System.Reflection;

[Token(Token = "0x20004FA")]
internal sealed class SignatureArrayType : SignatureHasElementType
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013A8")]
	private readonly int _rank; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40013A9")]
	private readonly bool _isMultiDim; //Field offset: 0x24

	[Token(Token = "0x17000457")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x1F6B0F0", Offset = "0x1F6A4F0", Length = "0x8")]
		[Token(Token = "0x60022DC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000458")]
	public virtual bool IsVariableBoundArray
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[Token(Token = "0x60022DD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000459")]
	protected virtual string Suffix
	{
		[Address(RVA = "0x1F6B100", Offset = "0x1F6A500", Length = "0xA3")]
		[Token(Token = "0x60022DF")]
		 get { } //Length: 163
	}

	[Address(RVA = "0x1F6B080", Offset = "0x1F6A480", Length = "0x6C")]
	[Token(Token = "0x60022D8")]
	internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim) { }

	[Address(RVA = "0x1F6B0F0", Offset = "0x1F6A4F0", Length = "0x8")]
	[Token(Token = "0x60022DC")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[Token(Token = "0x60022DD")]
	public virtual bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x1F6B100", Offset = "0x1F6A500", Length = "0xA3")]
	[Token(Token = "0x60022DF")]
	protected virtual string get_Suffix() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60022DE")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60022D9")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022DA")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022DB")]
	protected virtual bool IsPointerImpl() { }

}

