namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x20000D5")]
internal struct NativeTextDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000411")]
	public UnsafeText* m_TextData; //Field offset: 0x0

	[Address(RVA = "0x28C8EF0", Offset = "0x28C82F0", Length = "0xDC")]
	[Token(Token = "0x60009E5")]
	public void Dispose() { }

}

