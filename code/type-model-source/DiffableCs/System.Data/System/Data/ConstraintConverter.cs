namespace System.Data;

[Token(Token = "0x200002A")]
internal sealed class ConstraintConverter : ExpandableObjectConverter
{

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6000367")]
	public ConstraintConverter() { }

	[Address(RVA = "0x2313B80", Offset = "0x2312F80", Length = "0x9B")]
	[Token(Token = "0x6000368")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x2313C20", Offset = "0x2313020", Length = "0xBEE")]
	[Token(Token = "0x6000369")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

