namespace System.ComponentModel;

[Token(Token = "0x2000166")]
public class CultureInfoConverter : TypeConverter
{
	[Token(Token = "0x2000167")]
	private class CultureComparer : IComparer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400060F")]
		private CultureInfoConverter _converter; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60008A1")]
		public CultureComparer(CultureInfoConverter cultureConverter) { }

		[Address(RVA = "0x2642DF0", Offset = "0x26421F0", Length = "0x1BB")]
		[Token(Token = "0x60008A2")]
		public override int Compare(object item1, object item2) { }

	}

	[Token(Token = "0x2000168")]
	private static class CultureInfoMapper
	{
		[Token(Token = "0x4000610")]
		private static readonly Dictionary<String, String> s_cultureInfoNameMap; //Field offset: 0x0

		[Address(RVA = "0x2647900", Offset = "0x2646D00", Length = "0x52")]
		[Token(Token = "0x60008A5")]
		private static CultureInfoMapper() { }

		[Address(RVA = "0x2643F20", Offset = "0x2643320", Length = "0x3932")]
		[Token(Token = "0x60008A3")]
		private static Dictionary<String, String> CreateMap() { }

		[Address(RVA = "0x2647860", Offset = "0x2646C60", Length = "0x92")]
		[Token(Token = "0x60008A4")]
		public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	}

	[Token(Token = "0x400060E")]
	private const string DefaultInvariantCultureString = "(Default)"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060D")]
	private StandardValuesCollection _values; //Field offset: 0x10

	[Token(Token = "0x1700019E")]
	private string DefaultCultureString
	{
		[Address(RVA = "0x2643EF0", Offset = "0x26432F0", Length = "0x2C")]
		[Token(Token = "0x6000897")]
		private get { } //Length: 44
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60008A0")]
	public CultureInfoConverter() { }

	[Address(RVA = "0x2642FB0", Offset = "0x26423B0", Length = "0x80")]
	[Token(Token = "0x6000899")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2643030", Offset = "0x2642430", Length = "0x9B")]
	[Token(Token = "0x600089A")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x26430D0", Offset = "0x26424D0", Length = "0x74A")]
	[Token(Token = "0x600089B")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x2643820", Offset = "0x2642C20", Length = "0x4C5")]
	[Token(Token = "0x600089C")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x2643EF0", Offset = "0x26432F0", Length = "0x2C")]
	[Token(Token = "0x6000897")]
	private string get_DefaultCultureString() { }

	[Address(RVA = "0xA4D5C0", Offset = "0xA4C9C0", Length = "0x2C")]
	[Token(Token = "0x6000898")]
	protected override string GetCultureName(CultureInfo culture) { }

	[Address(RVA = "0x2643CF0", Offset = "0x26430F0", Length = "0x1FF")]
	[Token(Token = "0x600089D")]
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600089E")]
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600089F")]
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

