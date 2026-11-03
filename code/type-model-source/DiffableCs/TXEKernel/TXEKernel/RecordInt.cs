namespace TXEKernel;

[Token(Token = "0x200008E")]
public class RecordInt : RecordValue<Int32>
{

	[Address(RVA = "0x26F6920", Offset = "0x26F5D20", Length = "0x58")]
	[Token(Token = "0x60004D3")]
	public RecordInt(string label, int defaultValue = 0) { }

	[Address(RVA = "0x26F6980", Offset = "0x26F5D80", Length = "0x48")]
	[Token(Token = "0x60004D4")]
	public RecordInt(BaseParamsT<Int32> p) { }

	[Address(RVA = "0x26F68D0", Offset = "0x26F5CD0", Length = "0x48")]
	[Token(Token = "0x60004D5")]
	public RecordInt(RecordInt other) { }

}

