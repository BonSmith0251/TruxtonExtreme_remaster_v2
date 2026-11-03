namespace TXEKernel;

[Token(Token = "0x2000091")]
public class RecordClampedInt64 : RecordClampedValue<Int64>
{

	[Address(RVA = "0x26F61D0", Offset = "0x26F55D0", Length = "0x6D")]
	[Token(Token = "0x60004DD")]
	public RecordClampedInt64(string label, long maxValue, int defaultValue = 0) { }

	[Address(RVA = "0x26F08D0", Offset = "0x26EFCD0", Length = "0x48")]
	[Token(Token = "0x60004DE")]
	public RecordClampedInt64(ClampedValueParams<Int64> p) { }

	[Address(RVA = "0x26F6180", Offset = "0x26F5580", Length = "0x48")]
	[Token(Token = "0x60004DF")]
	public RecordClampedInt64(RecordClampedInt64 other) { }

	[Address(RVA = "0x26F60A0", Offset = "0x26F54A0", Length = "0xD9")]
	[Token(Token = "0x60004E0")]
	public virtual long Clamp(long v) { }

}

