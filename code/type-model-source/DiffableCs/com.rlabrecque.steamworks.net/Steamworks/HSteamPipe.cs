namespace Steamworks;

[Token(Token = "0x20001F6")]
public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B71")]
	public int m_HSteamPipe; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000BF5")]
	public HSteamPipe(int value) { }

	[Address(RVA = "0x60B4B0", Offset = "0x60A8B0", Length = "0x8")]
	[Token(Token = "0x6000BFE")]
	public override int CompareTo(HSteamPipe other) { }

	[Address(RVA = "0x646A90", Offset = "0x645E90", Length = "0x7F")]
	[Token(Token = "0x6000BF7")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000BFD")]
	public override bool Equals(HSteamPipe other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000BF8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000BF9")]
	public static bool op_Equality(HSteamPipe x, HSteamPipe y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000BFB")]
	public static HSteamPipe op_Explicit(int value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000BFC")]
	public static int op_Explicit(HSteamPipe that) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000BFA")]
	public static bool op_Inequality(HSteamPipe x, HSteamPipe y) { }

	[Address(RVA = "0x60B560", Offset = "0x60A960", Length = "0x7")]
	[Token(Token = "0x6000BF6")]
	public virtual string ToString() { }

}

