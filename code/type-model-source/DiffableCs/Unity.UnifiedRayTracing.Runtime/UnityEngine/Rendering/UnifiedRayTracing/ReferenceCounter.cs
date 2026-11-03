namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000058")]
internal class ReferenceCounter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E2")]
	public ulong value; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000186")]
	public ReferenceCounter() { }

	[Address(RVA = "0x2F64A00", Offset = "0x2F63E00", Length = "0x5")]
	[Token(Token = "0x6000185")]
	public void Dec() { }

	[Address(RVA = "0x2F64A10", Offset = "0x2F63E10", Length = "0x5")]
	[Token(Token = "0x6000184")]
	public void Inc() { }

}

