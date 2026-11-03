namespace System.Reflection.Emit;

[Token(Token = "0x2000533")]
public sealed class PropertyBuilder : PropertyInfo
{

	[Token(Token = "0x17000522")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1F62CA0", Offset = "0x1F620A0", Length = "0x3E")]
		[Token(Token = "0x600259A")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000523")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1F62CE0", Offset = "0x1F620E0", Length = "0x3E")]
		[Token(Token = "0x600259B")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000524")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F62D20", Offset = "0x1F62120", Length = "0x3E")]
		[Token(Token = "0x600259C")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000525")]
	public virtual string Name
	{
		[Address(RVA = "0x1F62D60", Offset = "0x1F62160", Length = "0x3E")]
		[Token(Token = "0x600259D")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000526")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x1F62DA0", Offset = "0x1F621A0", Length = "0x3E")]
		[Token(Token = "0x600259E")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000527")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F62DE0", Offset = "0x1F621E0", Length = "0x3E")]
		[Token(Token = "0x600259F")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F62CA0", Offset = "0x1F620A0", Length = "0x3E")]
	[Token(Token = "0x600259A")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x1F62CE0", Offset = "0x1F620E0", Length = "0x3E")]
	[Token(Token = "0x600259B")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1F62D20", Offset = "0x1F62120", Length = "0x3E")]
	[Token(Token = "0x600259C")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F62D60", Offset = "0x1F62160", Length = "0x3E")]
	[Token(Token = "0x600259D")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F62DA0", Offset = "0x1F621A0", Length = "0x3E")]
	[Token(Token = "0x600259E")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x1F62DE0", Offset = "0x1F621E0", Length = "0x3E")]
	[Token(Token = "0x600259F")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F62AE0", Offset = "0x1F61EE0", Length = "0x3E")]
	[Token(Token = "0x60025A0")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F62AA0", Offset = "0x1F61EA0", Length = "0x3E")]
	[Token(Token = "0x60025A1")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F62B20", Offset = "0x1F61F20", Length = "0x3E")]
	[Token(Token = "0x60025A2")]
	public virtual MethodInfo GetGetMethod(bool nonPublic) { }

	[Address(RVA = "0x1F62B60", Offset = "0x1F61F60", Length = "0x3E")]
	[Token(Token = "0x60025A3")]
	public virtual ParameterInfo[] GetIndexParameters() { }

	[Address(RVA = "0x1F62BA0", Offset = "0x1F61FA0", Length = "0x3E")]
	[Token(Token = "0x60025A4")]
	public virtual MethodInfo GetSetMethod(bool nonPublic) { }

	[Address(RVA = "0x1F62BE0", Offset = "0x1F61FE0", Length = "0x3E")]
	[Token(Token = "0x60025A5")]
	public virtual object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[Address(RVA = "0x1F62C20", Offset = "0x1F62020", Length = "0x3E")]
	[Token(Token = "0x60025A6")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F62C60", Offset = "0x1F62060", Length = "0x3E")]
	[Token(Token = "0x60025A7")]
	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

}

