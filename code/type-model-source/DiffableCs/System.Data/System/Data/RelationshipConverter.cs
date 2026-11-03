namespace System.Data;

[Token(Token = "0x2000084")]
internal sealed class RelationshipConverter : ExpandableObjectConverter
{

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x60006DF")]
	public RelationshipConverter() { }

	[Address(RVA = "0x234C300", Offset = "0x234B700", Length = "0x9B")]
	[Token(Token = "0x60006E0")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x234C3A0", Offset = "0x234B7A0", Length = "0xE5E")]
	[Token(Token = "0x60006E1")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

