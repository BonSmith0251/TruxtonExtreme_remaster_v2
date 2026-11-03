namespace System.ComponentModel;

[Token(Token = "0x200018F")]
public class ReferenceConverter : TypeConverter
{
	[Token(Token = "0x2000190")]
	private class ReferenceComparer : IComparer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000662")]
		private ReferenceConverter _converter; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60009E0")]
		public ReferenceComparer(ReferenceConverter converter) { }

		[Address(RVA = "0x2669C90", Offset = "0x2669090", Length = "0xAD")]
		[Token(Token = "0x60009E1")]
		public override int Compare(object item1, object item2) { }

	}

	[Token(Token = "0x4000660")]
	private static readonly string s_none; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000661")]
	private Type _type; //Field offset: 0x10

	[Address(RVA = "0x266A920", Offset = "0x2669D20", Length = "0x62")]
	[Token(Token = "0x60009DF")]
	private static ReferenceConverter() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60009D7")]
	public ReferenceConverter(Type type) { }

	[Address(RVA = "0x2669D40", Offset = "0x2669140", Length = "0x85")]
	[Token(Token = "0x60009D8")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2669DD0", Offset = "0x26691D0", Length = "0x277")]
	[Token(Token = "0x60009D9")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x266A050", Offset = "0x2669450", Length = "0x358")]
	[Token(Token = "0x60009DA")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x266A3B0", Offset = "0x26697B0", Length = "0x562")]
	[Token(Token = "0x60009DB")]
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60009DC")]
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60009DD")]
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60009DE")]
	protected override bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

}

