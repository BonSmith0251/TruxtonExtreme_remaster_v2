namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001CE")]
internal class XProcessingInstructionWrapper : XObjectWrapper
{

	[Token(Token = "0x1700028F")]
	public virtual string LocalName
	{
		[Address(RVA = "0x21B3480", Offset = "0x21B2880", Length = "0x71")]
		[Token(Token = "0x6000F7E")]
		 get { } //Length: 113
	}

	[Nullable(1)]
	[Token(Token = "0x1700028E")]
	private XProcessingInstruction ProcessingInstruction
	{
		[Address(RVA = "0x21B3500", Offset = "0x21B2900", Length = "0x6B")]
		[NullableContext(1)]
		[Token(Token = "0x6000F7C")]
		private get { } //Length: 107
	}

	[Token(Token = "0x17000290")]
	public virtual string Value
	{
		[Address(RVA = "0x21B3570", Offset = "0x21B2970", Length = "0x71")]
		[Token(Token = "0x6000F7F")]
		 get { } //Length: 113
		[Address(RVA = "0x21B35F0", Offset = "0x21B29F0", Length = "0xA1")]
		[Token(Token = "0x6000F80")]
		 set { } //Length: 161
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000F7D")]
	public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction) { }

	[Address(RVA = "0x21B3480", Offset = "0x21B2880", Length = "0x71")]
	[Token(Token = "0x6000F7E")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21B3500", Offset = "0x21B2900", Length = "0x6B")]
	[NullableContext(1)]
	[Token(Token = "0x6000F7C")]
	private XProcessingInstruction get_ProcessingInstruction() { }

	[Address(RVA = "0x21B3570", Offset = "0x21B2970", Length = "0x71")]
	[Token(Token = "0x6000F7F")]
	public virtual string get_Value() { }

	[Address(RVA = "0x21B35F0", Offset = "0x21B29F0", Length = "0xA1")]
	[Token(Token = "0x6000F80")]
	public virtual void set_Value(string value) { }

}

