namespace System.Runtime.Serialization;

[Token(Token = "0x20003DB")]
public class FormatterConverter : IFormatterConverter
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001DA1")]
	public FormatterConverter() { }

	[Address(RVA = "0x1F02070", Offset = "0x1F01470", Length = "0x9D")]
	[Token(Token = "0x6001D9A")]
	public override object Convert(object value, Type type) { }

	[Address(RVA = "0x1F02110", Offset = "0x1F01510", Length = "0x4E")]
	[Token(Token = "0x6001DA0")]
	private static void ThrowValueNullException() { }

	[Address(RVA = "0x1F02160", Offset = "0x1F01560", Length = "0x8E")]
	[Token(Token = "0x6001D9B")]
	public override bool ToBoolean(object value) { }

	[Address(RVA = "0x1F021F0", Offset = "0x1F015F0", Length = "0x8E")]
	[Token(Token = "0x6001D9C")]
	public override int ToInt32(object value) { }

	[Address(RVA = "0x1F02280", Offset = "0x1F01680", Length = "0x8E")]
	[Token(Token = "0x6001D9D")]
	public override long ToInt64(object value) { }

	[Address(RVA = "0x1F02310", Offset = "0x1F01710", Length = "0x8E")]
	[Token(Token = "0x6001D9E")]
	public override float ToSingle(object value) { }

	[Address(RVA = "0x1F023A0", Offset = "0x1F017A0", Length = "0x8E")]
	[Token(Token = "0x6001D9F")]
	public override string ToString(object value) { }

}

