namespace System.Reflection;

[Token(Token = "0x20004FE")]
internal sealed class SignaturePointerType : SignatureHasElementType
{

	[Token(Token = "0x17000476")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002317")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000477")]
	public virtual bool IsVariableBoundArray
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002318")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000478")]
	protected virtual string Suffix
	{
		[Address(RVA = "0x1F6BAC0", Offset = "0x1F6AEC0", Length = "0x2C")]
		[Token(Token = "0x600231A")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1F6B200", Offset = "0x1F6A600", Length = "0x49")]
	[Token(Token = "0x6002313")]
	internal SignaturePointerType(SignatureType elementType) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002317")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002318")]
	public virtual bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x1F6BAC0", Offset = "0x1F6AEC0", Length = "0x2C")]
	[Token(Token = "0x600231A")]
	protected virtual string get_Suffix() { }

	[Address(RVA = "0x1F6BA70", Offset = "0x1F6AE70", Length = "0x4E")]
	[Token(Token = "0x6002319")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002314")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002315")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002316")]
	protected virtual bool IsPointerImpl() { }

}

