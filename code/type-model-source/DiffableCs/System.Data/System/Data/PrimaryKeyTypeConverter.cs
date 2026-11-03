namespace System.Data;

[Token(Token = "0x2000077")]
internal sealed class PrimaryKeyTypeConverter : ReferenceConverter
{

	[Address(RVA = "0x234ADD0", Offset = "0x234A1D0", Length = "0x8B")]
	[Token(Token = "0x600066E")]
	public PrimaryKeyTypeConverter() { }

	[Address(RVA = "0x230FBD0", Offset = "0x230EFD0", Length = "0x80")]
	[Token(Token = "0x6000670")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x234AC60", Offset = "0x234A060", Length = "0x16F")]
	[Token(Token = "0x6000671")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600066F")]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

