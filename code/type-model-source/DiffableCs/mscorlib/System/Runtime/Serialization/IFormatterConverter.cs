namespace System.Runtime.Serialization;

[CLSCompliant(False)]
[Token(Token = "0x20003D3")]
public interface IFormatterConverter
{

	[Token(Token = "0x6001D7E")]
	public object Convert(object value, Type type) { }

	[Token(Token = "0x6001D7F")]
	public bool ToBoolean(object value) { }

	[Token(Token = "0x6001D80")]
	public int ToInt32(object value) { }

	[Token(Token = "0x6001D81")]
	public long ToInt64(object value) { }

	[Token(Token = "0x6001D82")]
	public float ToSingle(object value) { }

	[Token(Token = "0x6001D83")]
	public string ToString(object value) { }

}

