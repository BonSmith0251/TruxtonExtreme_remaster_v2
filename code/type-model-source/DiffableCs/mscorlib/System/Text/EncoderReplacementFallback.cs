namespace System.Text;

[Token(Token = "0x20002AB")]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B98")]
	private string _strDefault; //Field offset: 0x10

	[Token(Token = "0x17000221")]
	public string DefaultString
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60015E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000222")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x1E8D220", Offset = "0x1E8C620", Length = "0x1A")]
		[Token(Token = "0x60015E2")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x1E8CFA0", Offset = "0x1E8C3A0", Length = "0x3C")]
	[Token(Token = "0x60015DC")]
	public EncoderReplacementFallback() { }

	[Address(RVA = "0x1E8CFE0", Offset = "0x1E8C3E0", Length = "0xBB")]
	[Token(Token = "0x60015DD")]
	internal EncoderReplacementFallback(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1E8D0A0", Offset = "0x1E8C4A0", Length = "0x17C")]
	[Token(Token = "0x60015DF")]
	public EncoderReplacementFallback(string replacement) { }

	[Address(RVA = "0x1E8CE40", Offset = "0x1E8C240", Length = "0x81")]
	[Token(Token = "0x60015E1")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1E8CED0", Offset = "0x1E8C2D0", Length = "0x6D")]
	[Token(Token = "0x60015E3")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60015E0")]
	public string get_DefaultString() { }

	[Address(RVA = "0x1E8D220", Offset = "0x1E8C620", Length = "0x1A")]
	[Token(Token = "0x60015E2")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x60015E4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E8CF40", Offset = "0x1E8C340", Length = "0x56")]
	[Token(Token = "0x60015DE")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

