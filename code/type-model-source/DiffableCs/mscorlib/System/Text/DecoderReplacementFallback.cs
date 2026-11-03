namespace System.Text;

[Token(Token = "0x20002A0")]
public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B79")]
	private string _strDefault; //Field offset: 0x10

	[Token(Token = "0x1700020F")]
	public string DefaultString
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600158C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000210")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x1E8D220", Offset = "0x1E8C620", Length = "0x1A")]
		[Token(Token = "0x600158E")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x20AFF10", Offset = "0x20AF310", Length = "0x19F")]
	[Token(Token = "0x6001588")]
	public DecoderReplacementFallback() { }

	[Address(RVA = "0x20B00B0", Offset = "0x20AF4B0", Length = "0xBB")]
	[Token(Token = "0x6001589")]
	internal DecoderReplacementFallback(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20B0170", Offset = "0x20AF570", Length = "0x17C")]
	[Token(Token = "0x600158B")]
	public DecoderReplacementFallback(string replacement) { }

	[Address(RVA = "0x20AFDC0", Offset = "0x20AF1C0", Length = "0x73")]
	[Token(Token = "0x600158D")]
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x20AFE40", Offset = "0x20AF240", Length = "0x6D")]
	[Token(Token = "0x600158F")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600158C")]
	public string get_DefaultString() { }

	[Address(RVA = "0x1E8D220", Offset = "0x1E8C620", Length = "0x1A")]
	[Token(Token = "0x600158E")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x6001590")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20AFEB0", Offset = "0x20AF2B0", Length = "0x56")]
	[Token(Token = "0x600158A")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

