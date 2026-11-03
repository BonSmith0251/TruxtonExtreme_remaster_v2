namespace System.Data;

[Token(Token = "0x2000026")]
internal sealed class ColumnTypeConverter : TypeConverter
{
	[Token(Token = "0x40000E9")]
	private static readonly Type[] s_types; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EA")]
	private StandardValuesCollection _values; //Field offset: 0x10

	[Address(RVA = "0x2310570", Offset = "0x230F970", Length = "0xE6A")]
	[Token(Token = "0x6000321")]
	private static ColumnTypeConverter() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000319")]
	public ColumnTypeConverter() { }

	[Address(RVA = "0x230FBD0", Offset = "0x230EFD0", Length = "0x80")]
	[Token(Token = "0x600031C")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x230FC50", Offset = "0x230F050", Length = "0x9B")]
	[Token(Token = "0x600031A")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x230FCF0", Offset = "0x230F0F0", Length = "0x1FD")]
	[Token(Token = "0x600031D")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x230FEF0", Offset = "0x230F2F0", Length = "0x53B")]
	[Token(Token = "0x600031B")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x2310430", Offset = "0x230F830", Length = "0x135")]
	[Token(Token = "0x600031E")]
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600031F")]
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000320")]
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

