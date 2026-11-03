namespace System.Reflection;

[Token(Token = "0x20004EF")]
public abstract class MethodInfo : MethodBase
{

	[Token(Token = "0x17000443")]
	internal override int GenericParameterCount
	{
		[Address(RVA = "0x1F618B0", Offset = "0x1F60CB0", Length = "0x29")]
		[Token(Token = "0x6002295")]
		internal get { } //Length: 41
	}

	[Token(Token = "0x17000440")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x6002288")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000441")]
	public override ParameterInfo ReturnParameter
	{
		[Address(RVA = "0x1F618E0", Offset = "0x1F60CE0", Length = "0x27")]
		[Token(Token = "0x6002289")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000442")]
	public override Type ReturnType
	{
		[Address(RVA = "0x1F61910", Offset = "0x1F60D10", Length = "0x27")]
		[Token(Token = "0x600228A")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002287")]
	protected MethodInfo() { }

	[Address(RVA = "0x1F61720", Offset = "0x1F60B20", Length = "0x4E")]
	[Token(Token = "0x600228F")]
	public override Delegate CreateDelegate(Type delegateType) { }

	[Address(RVA = "0x1F61770", Offset = "0x1F60B70", Length = "0x4E")]
	[Token(Token = "0x6002290")]
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	[Address(RVA = "0x1F4B850", Offset = "0x1F4AC50", Length = "0x8")]
	[Token(Token = "0x6002291")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F618B0", Offset = "0x1F60CB0", Length = "0x29")]
	[Token(Token = "0x6002295")]
	internal override int get_GenericParameterCount() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x6002288")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x1F618E0", Offset = "0x1F60CE0", Length = "0x27")]
	[Token(Token = "0x6002289")]
	public override ParameterInfo get_ReturnParameter() { }

	[Address(RVA = "0x1F61910", Offset = "0x1F60D10", Length = "0x27")]
	[Token(Token = "0x600228A")]
	public override Type get_ReturnType() { }

	[Token(Token = "0x600228E")]
	public abstract MethodInfo GetBaseDefinition() { }

	[Address(RVA = "0x1F617C0", Offset = "0x1F60BC0", Length = "0x4E")]
	[Token(Token = "0x600228B")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x1F61810", Offset = "0x1F60C10", Length = "0x4E")]
	[Token(Token = "0x600228C")]
	public override MethodInfo GetGenericMethodDefinition() { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6002292")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F61860", Offset = "0x1F60C60", Length = "0x4E")]
	[Token(Token = "0x600228D")]
	public override MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	[Address(RVA = "0x1F339B0", Offset = "0x1F32DB0", Length = "0x29")]
	[Token(Token = "0x6002293")]
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	[Address(RVA = "0x1F342C0", Offset = "0x1F336C0", Length = "0x3E")]
	[Token(Token = "0x6002294")]
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

}

