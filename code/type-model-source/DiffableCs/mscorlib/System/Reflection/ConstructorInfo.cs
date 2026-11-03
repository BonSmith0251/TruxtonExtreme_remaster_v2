namespace System.Reflection;

[Token(Token = "0x20004DB")]
public abstract class ConstructorInfo : MethodBase
{
	[Token(Token = "0x400131C")]
	public static readonly string ConstructorName; //Field offset: 0x0
	[Token(Token = "0x400131D")]
	public static readonly string TypeConstructorName; //Field offset: 0x8

	[Token(Token = "0x1700041F")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6002217")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1F33900", Offset = "0x1F32D00", Length = "0xA5")]
	[Token(Token = "0x600221E")]
	private static ConstructorInfo() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6002216")]
	protected ConstructorInfo() { }

	[Address(RVA = "0x1F338A0", Offset = "0x1F32CA0", Length = "0x8")]
	[Token(Token = "0x600221A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6002217")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x1F338B0", Offset = "0x1F32CB0", Length = "0x7")]
	[Token(Token = "0x600221B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F338C0", Offset = "0x1F32CC0", Length = "0x36")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002218")]
	public object Invoke(Object[] parameters) { }

	[Token(Token = "0x6002219")]
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F339B0", Offset = "0x1F32DB0", Length = "0x29")]
	[Token(Token = "0x600221C")]
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	[Address(RVA = "0x1F339E0", Offset = "0x1F32DE0", Length = "0x93")]
	[Token(Token = "0x600221D")]
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

}

