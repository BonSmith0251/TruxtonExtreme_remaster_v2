namespace System.Reflection;

[Token(Token = "0x20004F8")]
public abstract class PropertyInfo : MemberInfo
{

	[Token(Token = "0x17000452")]
	public abstract bool CanRead
	{
		[Token(Token = "0x60022C0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000453")]
	public abstract bool CanWrite
	{
		[Token(Token = "0x60022C1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000454")]
	public override MethodInfo GetMethod
	{
		[Address(RVA = "0x1F62F30", Offset = "0x1F62330", Length = "0x16")]
		[Token(Token = "0x60022C2")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000450")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
		[Token(Token = "0x60022BD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000451")]
	public abstract Type PropertyType
	{
		[Token(Token = "0x60022BE")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60022BC")]
	protected PropertyInfo() { }

	[Address(RVA = "0x1F4B850", Offset = "0x1F4AC50", Length = "0x8")]
	[Token(Token = "0x60022CD")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x60022C0")]
	public abstract bool get_CanRead() { }

	[Token(Token = "0x60022C1")]
	public abstract bool get_CanWrite() { }

	[Address(RVA = "0x1F62F30", Offset = "0x1F62330", Length = "0x16")]
	[Token(Token = "0x60022C2")]
	public override MethodInfo get_GetMethod() { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x60022BD")]
	public virtual MemberTypes get_MemberType() { }

	[Token(Token = "0x60022BE")]
	public abstract Type get_PropertyType() { }

	[Address(RVA = "0x1F62E20", Offset = "0x1F62220", Length = "0x16")]
	[Token(Token = "0x60022C3")]
	public override MethodInfo GetGetMethod() { }

	[Token(Token = "0x60022C4")]
	public abstract MethodInfo GetGetMethod(bool nonPublic) { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x60022CE")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x60022BF")]
	public abstract ParameterInfo[] GetIndexParameters() { }

	[Token(Token = "0x60022C6")]
	public abstract MethodInfo GetSetMethod(bool nonPublic) { }

	[Address(RVA = "0x1F62E40", Offset = "0x1F62240", Length = "0x16")]
	[Token(Token = "0x60022C5")]
	public override MethodInfo GetSetMethod() { }

	[Address(RVA = "0x1F62E80", Offset = "0x1F62280", Length = "0x36")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60022C8")]
	public override object GetValue(object obj, Object[] index) { }

	[Token(Token = "0x60022C9")]
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[Address(RVA = "0x1F62E60", Offset = "0x1F62260", Length = "0x17")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60022C7")]
	public object GetValue(object obj) { }

	[Address(RVA = "0x1F339B0", Offset = "0x1F32DB0", Length = "0x29")]
	[Token(Token = "0x60022CF")]
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	[Address(RVA = "0x1F342C0", Offset = "0x1F336C0", Length = "0x3E")]
	[Token(Token = "0x60022D0")]
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	[Address(RVA = "0x1F62EC0", Offset = "0x1F622C0", Length = "0x25")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60022CA")]
	public void SetValue(object obj, object value) { }

	[Address(RVA = "0x1F62EF0", Offset = "0x1F622F0", Length = "0x36")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60022CB")]
	public override void SetValue(object obj, object value, Object[] index) { }

	[Token(Token = "0x60022CC")]
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

}

