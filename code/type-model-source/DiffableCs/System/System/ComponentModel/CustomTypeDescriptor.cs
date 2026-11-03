namespace System.ComponentModel;

[Token(Token = "0x2000169")]
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000611")]
	private readonly ICustomTypeDescriptor _parent; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008A6")]
	protected CustomTypeDescriptor() { }

	[Address(RVA = "0x265C920", Offset = "0x265BD20", Length = "0xF3")]
	[Token(Token = "0x60008A7")]
	public override AttributeCollection GetAttributes() { }

	[Address(RVA = "0x265CA20", Offset = "0x265BE20", Length = "0x4C")]
	[Token(Token = "0x60008A8")]
	public override string GetClassName() { }

	[Address(RVA = "0x265CA70", Offset = "0x265BE70", Length = "0x4C")]
	[Token(Token = "0x60008A9")]
	public override string GetComponentName() { }

	[Address(RVA = "0x265CAC0", Offset = "0x265BEC0", Length = "0xFB")]
	[Token(Token = "0x60008AA")]
	public override TypeConverter GetConverter() { }

	[Address(RVA = "0x265CBC0", Offset = "0x265BFC0", Length = "0xC0")]
	[Token(Token = "0x60008AB")]
	public override EventDescriptor GetDefaultEvent() { }

	[Address(RVA = "0x265CC80", Offset = "0x265C080", Length = "0xC0")]
	[Token(Token = "0x60008AC")]
	public override PropertyDescriptor GetDefaultProperty() { }

	[Address(RVA = "0x265CD40", Offset = "0x265C140", Length = "0x60")]
	[Token(Token = "0x60008AD")]
	public override object GetEditor(Type editorBaseType) { }

	[Address(RVA = "0x265CDA0", Offset = "0x265C1A0", Length = "0xFF")]
	[Token(Token = "0x60008AE")]
	public override EventDescriptorCollection GetEvents() { }

	[Address(RVA = "0x265CEA0", Offset = "0x265C2A0", Length = "0x103")]
	[Token(Token = "0x60008AF")]
	public override EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	[Address(RVA = "0x265D0C0", Offset = "0x265C4C0", Length = "0xFF")]
	[Token(Token = "0x60008B0")]
	public override PropertyDescriptorCollection GetProperties() { }

	[Address(RVA = "0x265CFB0", Offset = "0x265C3B0", Length = "0x103")]
	[Token(Token = "0x60008B1")]
	public override PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	[Address(RVA = "0x265D1C0", Offset = "0x265C5C0", Length = "0x60")]
	[Token(Token = "0x60008B2")]
	public override object GetPropertyOwner(PropertyDescriptor pd) { }

}

