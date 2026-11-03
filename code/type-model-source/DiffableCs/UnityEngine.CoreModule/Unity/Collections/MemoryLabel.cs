namespace Unity.Collections;

[IsReadOnly]
[Token(Token = "0x200004E")]
public struct MemoryLabel
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000E5")]
	internal readonly IntPtr pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E6")]
	internal readonly Allocator allocator; //Field offset: 0x8

	[Token(Token = "0x1700001A")]
	public bool IsCreated
	{
		[Address(RVA = "0x2043720", Offset = "0x2042B20", Length = "0x8")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2FE32B0", Offset = "0x2FE26B0", Length = "0x14D")]
	[Token(Token = "0x60000DC")]
	public MemoryLabel(string areaName, string objectName, Allocator allocator = 4) { }

	[Address(RVA = "0x2043720", Offset = "0x2042B20", Length = "0x8")]
	[Token(Token = "0x60000E0")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x2153440", Offset = "0x2152840", Length = "0x7")]
	[Token(Token = "0x60000DE")]
	private static bool IsNullOrEmpty(string str) { }

	[Address(RVA = "0x2FE3270", Offset = "0x2FE2670", Length = "0x11")]
	[Token(Token = "0x60000DF")]
	private static bool IsNullOrEmpty__Unmanaged(Byte* name, int nameLen) { }

	[Address(RVA = "0x2FE3290", Offset = "0x2FE2690", Length = "0x12")]
	[Token(Token = "0x60000DD")]
	public static bool SupportsAllocator(Allocator allocator) { }

}

