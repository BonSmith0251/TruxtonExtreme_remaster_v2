namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x200024D")]
internal static class MemoryHelpers
{
	[Token(Token = "0x200024E")]
	internal struct BitRegion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C9D")]
		public uint bitOffset; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000C9E")]
		public uint sizeInBits; //Field offset: 0x4

		[Token(Token = "0x170005FB")]
		public bool isEmpty
		{
			[Address(RVA = "0x29217E0", Offset = "0x2920BE0", Length = "0x8")]
			[Token(Token = "0x600159C")]
			 get { } //Length: 8
		}

		[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
		[Token(Token = "0x600159D")]
		public BitRegion(uint bitOffset, uint sizeInBits) { }

		[Address(RVA = "0x29217D0", Offset = "0x2920BD0", Length = "0xB")]
		[Token(Token = "0x600159E")]
		public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits) { }

		[Address(RVA = "0x29217E0", Offset = "0x2920BE0", Length = "0x8")]
		[Token(Token = "0x600159C")]
		public bool get_isEmpty() { }

		[Address(RVA = "0x2921720", Offset = "0x2920B20", Length = "0xA7")]
		[Token(Token = "0x600159F")]
		public BitRegion Overlap(BitRegion other) { }

	}


	[Address(RVA = "0x2922040", Offset = "0x2921440", Length = "0x77")]
	[Token(Token = "0x600159B")]
	public static uint AlignNatural(uint offset, uint sizeInBytes) { }

	[Address(RVA = "0x29220C0", Offset = "0x29214C0", Length = "0x77")]
	[Token(Token = "0x6001589")]
	public static bool Compare(Void* ptr1, Void* ptr2, BitRegion region) { }

	[Address(RVA = "0x2922140", Offset = "0x2921540", Length = "0x18")]
	[Token(Token = "0x600158A")]
	public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits) { }

	[Address(RVA = "0x2922160", Offset = "0x2921560", Length = "0x176")]
	[Token(Token = "0x600158E")]
	public static bool MemCmpBitRegion(Void* ptr1, Void* ptr2, uint bitOffset, uint bitCount, Void* mask = null) { }

	[Address(RVA = "0x29222E0", Offset = "0x29216E0", Length = "0xFE")]
	[Token(Token = "0x600158D")]
	public static void MemCpyBitRegion(Void* destination, Void* source, uint bitOffset, uint bitCount) { }

	[Address(RVA = "0x29223E0", Offset = "0x29217E0", Length = "0x110")]
	[Token(Token = "0x6001590")]
	public static void MemCpyMasked(Void* destination, Void* source, int numBytes, Void* mask) { }

	[Address(RVA = "0x29224F0", Offset = "0x29218F0", Length = "0xCA")]
	[Token(Token = "0x600158F")]
	public static void MemSet(Void* destination, int numBytes, byte value) { }

	[Address(RVA = "0x29225C0", Offset = "0x29219C0", Length = "0x2A")]
	[Token(Token = "0x6001595")]
	public static int ReadExcessKMultipleBitsAsInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[Address(RVA = "0x29225F0", Offset = "0x29219F0", Length = "0x6D")]
	[Token(Token = "0x6001597")]
	public static float ReadMultipleBitsAsNormalizedUInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[Address(RVA = "0x2922660", Offset = "0x2921A60", Length = "0x1CD")]
	[Token(Token = "0x6001591")]
	public static uint ReadMultipleBitsAsUInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[Address(RVA = "0x2922830", Offset = "0x2921C30", Length = "0x23")]
	[Token(Token = "0x600158C")]
	public static bool ReadSingleBit(Void* ptr, uint bitOffset) { }

	[Address(RVA = "0x2922860", Offset = "0x2921C60", Length = "0x8")]
	[Token(Token = "0x6001593")]
	public static int ReadTwosComplementMultipleBitsAsInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[Address(RVA = "0x2922870", Offset = "0x2921C70", Length = "0x280")]
	[Token(Token = "0x6001599")]
	public static void SetBitsInBuffer(Void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) { }

	[Address(RVA = "0x725F70", Offset = "0x725370", Length = "0x33")]
	[Token(Token = "0x600159A")]
	public static void Swap(ref TValue a, ref TValue b) { }

	[Address(RVA = "0x2922B00", Offset = "0x2921F00", Length = "0x29")]
	[Token(Token = "0x6001596")]
	public static void WriteIntAsExcessKMultipleBits(Void* ptr, uint bitOffset, uint bitCount, int value) { }

	[Address(RVA = "0x2922B30", Offset = "0x2921F30", Length = "0xE")]
	[Token(Token = "0x6001594")]
	public static void WriteIntAsTwosComplementMultipleBits(Void* ptr, uint bitOffset, uint bitCount, int value) { }

	[Address(RVA = "0x2922B40", Offset = "0x2921F40", Length = "0x6C")]
	[Token(Token = "0x6001598")]
	public static void WriteNormalizedUIntAsMultipleBits(Void* ptr, uint bitOffset, uint bitCount, float value) { }

	[Address(RVA = "0x2922BB0", Offset = "0x2921FB0", Length = "0x24")]
	[Token(Token = "0x600158B")]
	public static void WriteSingleBit(Void* ptr, uint bitOffset, bool value) { }

	[Address(RVA = "0x2922BE0", Offset = "0x2921FE0", Length = "0x1FB")]
	[Token(Token = "0x6001592")]
	public static void WriteUIntAsMultipleBits(Void* ptr, uint bitOffset, uint bitCount, uint value) { }

}

