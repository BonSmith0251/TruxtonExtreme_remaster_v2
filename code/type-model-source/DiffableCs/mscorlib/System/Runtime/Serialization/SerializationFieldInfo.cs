namespace System.Runtime.Serialization;

[Token(Token = "0x20003F9")]
internal sealed class SerializationFieldInfo : FieldInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F75")]
	private RuntimeFieldInfo m_field; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F76")]
	private string m_serializationName; //Field offset: 0x18

	[Token(Token = "0x170003D4")]
	public virtual FieldAttributes Attributes
	{
		[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
		[Token(Token = "0x6001E61")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003CF")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
		[Token(Token = "0x6001E55")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003D3")]
	public virtual RuntimeFieldHandle FieldHandle
	{
		[Address(RVA = "0x1F298A0", Offset = "0x1F28CA0", Length = "0x2A")]
		[Token(Token = "0x6001E60")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003D2")]
	internal RuntimeFieldInfo FieldInfo
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001E5F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003D1")]
	public virtual Type FieldType
	{
		[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
		[Token(Token = "0x6001E5A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003CD")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
		[Token(Token = "0x6001E52")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003CC")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
		[Token(Token = "0x6001E51")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003CE")]
	public virtual string Name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001E54")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003D0")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
		[Token(Token = "0x6001E56")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1F29790", Offset = "0x1F28B90", Length = "0xA3")]
	[Token(Token = "0x6001E53")]
	internal SerializationFieldInfo(RuntimeFieldInfo field, string namePrefix) { }

	[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
	[Token(Token = "0x6001E61")]
	public virtual FieldAttributes get_Attributes() { }

	[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
	[Token(Token = "0x6001E55")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F298A0", Offset = "0x1F28CA0", Length = "0x2A")]
	[Token(Token = "0x6001E60")]
	public virtual RuntimeFieldHandle get_FieldHandle() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001E5F")]
	internal RuntimeFieldInfo get_FieldInfo() { }

	[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
	[Token(Token = "0x6001E5A")]
	public virtual Type get_FieldType() { }

	[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
	[Token(Token = "0x6001E52")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
	[Token(Token = "0x6001E51")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001E54")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
	[Token(Token = "0x6001E56")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F29510", Offset = "0x1F28910", Length = "0x2A")]
	[Token(Token = "0x6001E57")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F29540", Offset = "0x1F28940", Length = "0x2A")]
	[Token(Token = "0x6001E58")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0xA75530", Offset = "0xA74930", Length = "0x2A")]
	[Token(Token = "0x6001E5B")]
	public virtual object GetValue(object obj) { }

	[Address(RVA = "0x1F29570", Offset = "0x1F28970", Length = "0xA5")]
	[Token(Token = "0x6001E5C")]
	internal object InternalGetValue(object obj) { }

	[Address(RVA = "0x1F29620", Offset = "0x1F28A20", Length = "0xF4")]
	[Token(Token = "0x6001E5E")]
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[Address(RVA = "0x1F29720", Offset = "0x1F28B20", Length = "0x2A")]
	[Token(Token = "0x6001E59")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F29750", Offset = "0x1F28B50", Length = "0x32")]
	[Token(Token = "0x6001E5D")]
	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

