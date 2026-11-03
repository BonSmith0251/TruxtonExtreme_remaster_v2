namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x20000A0")]
public struct NativeKeyValueArrays : INativeDisposable, IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C5")]
	public NativeArray<TKey> Keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C6")]
	public NativeArray<TValue> Values; //Field offset: 0x0

	[Token(Token = "0x170000D7")]
	public int Length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60007CD")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xD6DC70", Offset = "0xD6D070", Length = "0xC6")]
	[Token(Token = "0x60007CE")]
	public NativeKeyValueArrays`2(int length, AllocatorHandle allocator, NativeArrayOptions options) { }

	[Address(RVA = "0xD6CDC0", Offset = "0xD6C1C0", Length = "0x6B")]
	[Token(Token = "0x60007CF")]
	public override void Dispose() { }

	[Address(RVA = "0xD6CD00", Offset = "0xD6C100", Length = "0xB9")]
	[Token(Token = "0x60007D0")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60007CD")]
	public int get_Length() { }

}

