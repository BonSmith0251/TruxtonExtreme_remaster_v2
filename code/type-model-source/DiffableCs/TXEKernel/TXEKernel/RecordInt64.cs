namespace TXEKernel;

[Token(Token = "0x2000090")]
public class RecordInt64 : RecordValue<Int64>
{

	[Address(RVA = "0x26F6820", Offset = "0x26F5C20", Length = "0x58")]
	[Token(Token = "0x60004DA")]
	public RecordInt64(string label, long defaultValue = 0) { }

	[Address(RVA = "0x26F66A0", Offset = "0x26F5AA0", Length = "0x48")]
	[Token(Token = "0x60004DB")]
	public RecordInt64(BaseParamsT<Int64> p) { }

	[Address(RVA = "0x26F6880", Offset = "0x26F5C80", Length = "0x48")]
	[Token(Token = "0x60004DC")]
	public RecordInt64(RecordInt64 other) { }

}

