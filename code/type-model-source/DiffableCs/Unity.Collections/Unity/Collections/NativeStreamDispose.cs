namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x20000D0")]
internal struct NativeStreamDispose
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400040A")]
	public UnsafeStream m_StreamData; //Field offset: 0x0

	[Address(RVA = "0x28C8B20", Offset = "0x28C7F20", Length = "0xE")]
	[Token(Token = "0x6000968")]
	public void Dispose() { }

}

