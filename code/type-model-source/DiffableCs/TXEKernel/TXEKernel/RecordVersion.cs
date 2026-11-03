namespace TXEKernel;

[Token(Token = "0x2000092")]
public class RecordVersion : RecordInt64
{

	[Address(RVA = "0x26F6C60", Offset = "0x26F6060", Length = "0xAB")]
	[Token(Token = "0x60004E1")]
	public RecordVersion(string label, long defaultValue = 100) { }

	[Address(RVA = "0x26F6880", Offset = "0x26F5C80", Length = "0x48")]
	[Token(Token = "0x60004E2")]
	public RecordVersion(RecordVersion other) { }

}

