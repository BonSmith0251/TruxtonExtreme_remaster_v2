namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000019")]
internal struct Spinner
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000E")]
	private int m_Lock; //Field offset: 0x0

	[Address(RVA = "0x28C5090", Offset = "0x28C4490", Length = "0x50")]
	[Token(Token = "0x6000049")]
	internal void Acquire() { }

	[Address(RVA = "0x28C50E0", Offset = "0x28C44E0", Length = "0x1A")]
	[Token(Token = "0x600004C")]
	internal void Release() { }

	[Address(RVA = "0x28C5100", Offset = "0x28C4500", Length = "0x48")]
	[Token(Token = "0x600004A")]
	internal bool TryAcquire() { }

	[Address(RVA = "0x28C5150", Offset = "0x28C4550", Length = "0x90")]
	[Token(Token = "0x600004B")]
	internal bool TryAcquire(bool spin) { }

}

