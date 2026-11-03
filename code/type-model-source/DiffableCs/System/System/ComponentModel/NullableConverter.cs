namespace System.ComponentModel;

[Token(Token = "0x200018A")]
public class NullableConverter : TypeConverter
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000649")]
	private readonly Type <NullableType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400064A")]
	private readonly Type <UnderlyingType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400064B")]
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001CF")]
	public Type NullableType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000988")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D0")]
	public Type UnderlyingType
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000989")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D1")]
	public TypeConverter UnderlyingTypeConverter
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600098A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2666800", Offset = "0x2665C00", Length = "0x121")]
	[Token(Token = "0x600097B")]
	public NullableConverter(Type type) { }

	[Address(RVA = "0x2665F20", Offset = "0x2665320", Length = "0xA2")]
	[Token(Token = "0x600097C")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2665FD0", Offset = "0x26653D0", Length = "0xA2")]
	[Token(Token = "0x600097E")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x2666080", Offset = "0x2665480", Length = "0x12C")]
	[Token(Token = "0x600097D")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x26661B0", Offset = "0x26655B0", Length = "0x1C0")]
	[Token(Token = "0x600097F")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x2666380", Offset = "0x2665780", Length = "0x3D")]
	[Token(Token = "0x6000980")]
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000988")]
	public Type get_NullableType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000989")]
	public Type get_UnderlyingType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600098A")]
	public TypeConverter get_UnderlyingTypeConverter() { }

	[Address(RVA = "0x26663C0", Offset = "0x26657C0", Length = "0x3D")]
	[Token(Token = "0x6000981")]
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x2666440", Offset = "0x2665840", Length = "0x48")]
	[Token(Token = "0x6000982")]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[Address(RVA = "0x2666400", Offset = "0x2665800", Length = "0x3D")]
	[Token(Token = "0x6000983")]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x2666510", Offset = "0x2665910", Length = "0x291")]
	[Token(Token = "0x6000984")]
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x2666490", Offset = "0x2665890", Length = "0x3D")]
	[Token(Token = "0x6000985")]
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x26664D0", Offset = "0x26658D0", Length = "0x3D")]
	[Token(Token = "0x6000986")]
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x26667B0", Offset = "0x2665BB0", Length = "0x49")]
	[Token(Token = "0x6000987")]
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

}

