namespace UnityEngine.UIElements;

[Token(Token = "0x2000222")]
public static class PointerId
{
	[Token(Token = "0x40008B8")]
	public static readonly int maxPointers; //Field offset: 0x0
	[Token(Token = "0x40008B9")]
	public static readonly int invalidPointerId; //Field offset: 0x4
	[Token(Token = "0x40008BA")]
	public static readonly int mousePointerId; //Field offset: 0x8
	[Token(Token = "0x40008BB")]
	public static readonly int touchPointerIdBase; //Field offset: 0xC
	[Token(Token = "0x40008BC")]
	public static readonly int touchPointerCount; //Field offset: 0x10
	[Token(Token = "0x40008BD")]
	public static readonly int penPointerIdBase; //Field offset: 0x14
	[Token(Token = "0x40008BE")]
	public static readonly int penPointerCount; //Field offset: 0x18
	[Token(Token = "0x40008BF")]
	public static readonly int trackedPointerIdBase; //Field offset: 0x1C
	[Token(Token = "0x40008C0")]
	public static readonly int trackedPointerCount; //Field offset: 0x20
	[Token(Token = "0x40008C1")]
	internal static readonly Int32[] screenHoveringPointers; //Field offset: 0x28

	[Address(RVA = "0x33D98E0", Offset = "0x33D8CE0", Length = "0x162")]
	[Token(Token = "0x6000ECE")]
	private static PointerId() { }

}

