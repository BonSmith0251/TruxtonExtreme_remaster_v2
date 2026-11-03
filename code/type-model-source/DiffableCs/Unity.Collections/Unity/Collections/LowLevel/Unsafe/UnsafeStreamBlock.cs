namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200013F")]
internal struct UnsafeStreamBlock
{
	[CompilerGenerated]
	[Token(Token = "0x2000140")]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000523")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000521")]
	internal UnsafeStreamBlock* Next; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(byte), 1)]
	[Token(Token = "0x4000522")]
	internal <Data>e__FixedBuffer Data; //Field offset: 0x8

}

