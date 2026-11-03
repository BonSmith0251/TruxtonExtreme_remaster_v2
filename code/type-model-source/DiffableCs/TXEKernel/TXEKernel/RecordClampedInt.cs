namespace TXEKernel;

[Token(Token = "0x200008F")]
public class RecordClampedInt : RecordClampedValue<Int32>
{

	[Address(RVA = "0x26F6370", Offset = "0x26F5770", Length = "0x6D")]
	[Token(Token = "0x60004D6")]
	public RecordClampedInt(string label, int maxValue, int defaultValue = 0) { }

	[Address(RVA = "0x26F63E0", Offset = "0x26F57E0", Length = "0x48")]
	[Token(Token = "0x60004D7")]
	public RecordClampedInt(ClampedValueParams<Int32> p) { }

	[Address(RVA = "0x26F6320", Offset = "0x26F5720", Length = "0x48")]
	[Token(Token = "0x60004D8")]
	public RecordClampedInt(RecordClampedInt other) { }

	[Address(RVA = "0x26F6240", Offset = "0x26F5640", Length = "0xD1")]
	[Token(Token = "0x60004D9")]
	public virtual int Clamp(int v) { }

}

