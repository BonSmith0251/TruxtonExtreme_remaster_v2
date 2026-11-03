namespace System.Reflection;

[Token(Token = "0x20004FB")]
internal sealed class SignatureByRefType : SignatureHasElementType
{

	[Token(Token = "0x1700045A")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022E4")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700045B")]
	public virtual bool IsVariableBoundArray
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022E5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700045C")]
	protected virtual string Suffix
	{
		[Address(RVA = "0x1F6B250", Offset = "0x1F6A650", Length = "0x2C")]
		[Token(Token = "0x60022E7")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1F6B200", Offset = "0x1F6A600", Length = "0x49")]
	[Token(Token = "0x60022E0")]
	internal SignatureByRefType(SignatureType elementType) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022E4")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022E5")]
	public virtual bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x1F6B250", Offset = "0x1F6A650", Length = "0x2C")]
	[Token(Token = "0x60022E7")]
	protected virtual string get_Suffix() { }

	[Address(RVA = "0x1F6B1B0", Offset = "0x1F6A5B0", Length = "0x4E")]
	[Token(Token = "0x60022E6")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022E1")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60022E2")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022E3")]
	protected virtual bool IsPointerImpl() { }

}

