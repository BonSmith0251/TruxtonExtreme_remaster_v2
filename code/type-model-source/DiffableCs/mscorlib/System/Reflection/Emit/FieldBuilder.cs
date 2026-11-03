namespace System.Reflection.Emit;

[Token(Token = "0x200052C")]
public sealed class FieldBuilder : FieldInfo
{

	[Token(Token = "0x1700050E")]
	public virtual FieldAttributes Attributes
	{
		[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
		[Token(Token = "0x6002561")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700050F")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
		[Token(Token = "0x6002562")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000510")]
	public virtual RuntimeFieldHandle FieldHandle
	{
		[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
		[Token(Token = "0x6002563")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000511")]
	public virtual Type FieldType
	{
		[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
		[Token(Token = "0x6002564")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000512")]
	public virtual string Name
	{
		[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
		[Token(Token = "0x6002565")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000513")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
		[Token(Token = "0x6002566")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002561")]
	public virtual FieldAttributes get_Attributes() { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002562")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002563")]
	public virtual RuntimeFieldHandle get_FieldHandle() { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002564")]
	public virtual Type get_FieldType() { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002565")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002566")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002567")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002568")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x6002569")]
	public virtual object GetValue(object obj) { }

	[Address(RVA = "0x1F5E160", Offset = "0x1F5D560", Length = "0x9")]
	[Token(Token = "0x600256A")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F5E170", Offset = "0x1F5D570", Length = "0x3E")]
	[Token(Token = "0x600256B")]
	public virtual void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

