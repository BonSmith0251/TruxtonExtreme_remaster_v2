namespace System.Reflection;

[Token(Token = "0x20004EA")]
public abstract class MemberInfo : ICustomAttributeProvider
{

	[Token(Token = "0x1700042F")]
	public abstract Type DeclaringType
	{
		[Token(Token = "0x600225E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700042D")]
	public abstract MemberTypes MemberType
	{
		[Token(Token = "0x600225C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000432")]
	public override int MetadataToken
	{
		[Address(RVA = "0x1F60360", Offset = "0x1F5F760", Length = "0x3E")]
		[Token(Token = "0x6002264")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000431")]
	public override Module Module
	{
		[Address(RVA = "0x1F603A0", Offset = "0x1F5F7A0", Length = "0xB2")]
		[Token(Token = "0x6002260")]
		 get { } //Length: 178
	}

	[Token(Token = "0x1700042E")]
	public abstract string Name
	{
		[Token(Token = "0x600225D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000430")]
	public abstract Type ReflectedType
	{
		[Token(Token = "0x600225F")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600225B")]
	protected MemberInfo() { }

	[Address(RVA = "0x1F4B850", Offset = "0x1F4AC50", Length = "0x8")]
	[Token(Token = "0x6002265")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x600225E")]
	public abstract Type get_DeclaringType() { }

	[Token(Token = "0x600225C")]
	public abstract MemberTypes get_MemberType() { }

	[Address(RVA = "0x1F60360", Offset = "0x1F5F760", Length = "0x3E")]
	[Token(Token = "0x6002264")]
	public override int get_MetadataToken() { }

	[Address(RVA = "0x1F603A0", Offset = "0x1F5F7A0", Length = "0xB2")]
	[Token(Token = "0x6002260")]
	public override Module get_Module() { }

	[Token(Token = "0x600225D")]
	public abstract string get_Name() { }

	[Token(Token = "0x600225F")]
	public abstract Type get_ReflectedType() { }

	[Token(Token = "0x6002262")]
	public abstract Object[] GetCustomAttributes(bool inherit) { }

	[Token(Token = "0x6002263")]
	public abstract Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6002266")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6002261")]
	public abstract bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F60460", Offset = "0x1F5F860", Length = "0x422")]
	[Token(Token = "0x6002267")]
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	[Address(RVA = "0x1F60890", Offset = "0x1F5FC90", Length = "0x13")]
	[Token(Token = "0x6002268")]
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

}

