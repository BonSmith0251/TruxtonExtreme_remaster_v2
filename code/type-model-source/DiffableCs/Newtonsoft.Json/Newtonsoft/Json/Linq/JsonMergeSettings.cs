namespace Newtonsoft.Json.Linq;

[Token(Token = "0x200017E")]
public class JsonMergeSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006FF")]
	private MergeArrayHandling _mergeArrayHandling; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000700")]
	private MergeNullValueHandling _mergeNullValueHandling; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000701")]
	private StringComparison _propertyNameComparison; //Field offset: 0x18

	[Token(Token = "0x1700020E")]
	public MergeArrayHandling MergeArrayHandling
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000C9E")]
		 get { } //Length: 85
		[Address(RVA = "0x2189290", Offset = "0x2188690", Length = "0x63")]
		[Token(Token = "0x6000C9F")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700020F")]
	public MergeNullValueHandling MergeNullValueHandling
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000CA0")]
		 get { } //Length: 4
		[Address(RVA = "0x2189300", Offset = "0x2188700", Length = "0x63")]
		[Token(Token = "0x6000CA1")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000210")]
	public StringComparison PropertyNameComparison
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000CA2")]
		 get { } //Length: 4
		[Address(RVA = "0x2189370", Offset = "0x2188770", Length = "0x63")]
		[Token(Token = "0x6000CA3")]
		 set { } //Length: 99
	}

	[Address(RVA = "0x2189270", Offset = "0x2188670", Length = "0x1D")]
	[Token(Token = "0x6000C9D")]
	public JsonMergeSettings() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000C9E")]
	public MergeArrayHandling get_MergeArrayHandling() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000CA0")]
	public MergeNullValueHandling get_MergeNullValueHandling() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000CA2")]
	public StringComparison get_PropertyNameComparison() { }

	[Address(RVA = "0x2189290", Offset = "0x2188690", Length = "0x63")]
	[Token(Token = "0x6000C9F")]
	public void set_MergeArrayHandling(MergeArrayHandling value) { }

	[Address(RVA = "0x2189300", Offset = "0x2188700", Length = "0x63")]
	[Token(Token = "0x6000CA1")]
	public void set_MergeNullValueHandling(MergeNullValueHandling value) { }

	[Address(RVA = "0x2189370", Offset = "0x2188770", Length = "0x63")]
	[Token(Token = "0x6000CA3")]
	public void set_PropertyNameComparison(StringComparison value) { }

}

