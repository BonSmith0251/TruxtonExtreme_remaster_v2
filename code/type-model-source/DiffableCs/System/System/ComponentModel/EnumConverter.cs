namespace System.ComponentModel;

[Token(Token = "0x20001AD")]
public class EnumConverter : TypeConverter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000679")]
	private StandardValuesCollection values; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400067A")]
	private Type type; //Field offset: 0x18

	[Token(Token = "0x170001FB")]
	protected override IComparer Comparer
	{
		[Address(RVA = "0x2661550", Offset = "0x2660950", Length = "0x4E")]
		[Token(Token = "0x6000A56")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170001F9")]
	protected Type EnumType
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000A51")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001FA")]
	protected StandardValuesCollection Values
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000A52")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000A53")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2370610", Offset = "0x236FA10", Length = "0x31")]
	[Token(Token = "0x6000A50")]
	public EnumConverter(Type type) { }

	[Address(RVA = "0x265FD30", Offset = "0x265F130", Length = "0xD4")]
	[Token(Token = "0x6000A54")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x265FE10", Offset = "0x265F210", Length = "0xDF")]
	[Token(Token = "0x6000A55")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x265FEF0", Offset = "0x265F2F0", Length = "0x445")]
	[Token(Token = "0x6000A57")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x2660340", Offset = "0x265F740", Length = "0xD56")]
	[Token(Token = "0x6000A58")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x2661550", Offset = "0x2660950", Length = "0x4E")]
	[Token(Token = "0x6000A56")]
	protected override IComparer get_Comparer() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000A51")]
	protected Type get_EnumType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000A52")]
	protected StandardValuesCollection get_Values() { }

	[Address(RVA = "0x2661130", Offset = "0x2660530", Length = "0x3D4")]
	[Token(Token = "0x6000A59")]
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x26610A0", Offset = "0x26604A0", Length = "0x8A")]
	[Token(Token = "0x6000A5A")]
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A5B")]
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x2661510", Offset = "0x2660910", Length = "0x3E")]
	[Token(Token = "0x6000A5C")]
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000A53")]
	protected void set_Values(StandardValuesCollection value) { }

}

