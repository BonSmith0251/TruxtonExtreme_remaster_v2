namespace System.ComponentModel;

[Token(Token = "0x200019C")]
public abstract class TypeListConverter : TypeConverter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400066F")]
	private readonly Type[] _types; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000670")]
	private StandardValuesCollection _values; //Field offset: 0x18

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000A11")]
	protected TypeListConverter(Type[] types) { }

	[Address(RVA = "0x2642FB0", Offset = "0x26423B0", Length = "0x80")]
	[Token(Token = "0x6000A12")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2679060", Offset = "0x2678460", Length = "0x9B")]
	[Token(Token = "0x6000A13")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x2679100", Offset = "0x2678500", Length = "0xFA")]
	[Token(Token = "0x6000A14")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x2679200", Offset = "0x2678600", Length = "0x17F")]
	[Token(Token = "0x6000A15")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x2679380", Offset = "0x2678780", Length = "0xC5")]
	[Token(Token = "0x6000A16")]
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A17")]
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A18")]
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

