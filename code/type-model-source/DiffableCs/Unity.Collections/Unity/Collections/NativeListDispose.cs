namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x200009C")]
internal struct NativeListDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003C2")]
	public UntypedUnsafeList* m_ListData; //Field offset: 0x0

	[Address(RVA = "0x28C8960", Offset = "0x28C7D60", Length = "0x39")]
	[Token(Token = "0x60007C3")]
	public void Dispose() { }

}

