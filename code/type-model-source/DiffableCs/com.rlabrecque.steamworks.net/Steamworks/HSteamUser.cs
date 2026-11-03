namespace Steamworks;

[Token(Token = "0x20001F7")]
public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B72")]
	public int m_HSteamUser; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000BFF")]
	public HSteamUser(int value) { }

	[Address(RVA = "0x60B4B0", Offset = "0x60A8B0", Length = "0x8")]
	[Token(Token = "0x6000C08")]
	public override int CompareTo(HSteamUser other) { }

	[Address(RVA = "0x646B10", Offset = "0x645F10", Length = "0x7F")]
	[Token(Token = "0x6000C01")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000C07")]
	public override bool Equals(HSteamUser other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000C02")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000C03")]
	public static bool op_Equality(HSteamUser x, HSteamUser y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000C05")]
	public static HSteamUser op_Explicit(int value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000C06")]
	public static int op_Explicit(HSteamUser that) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000C04")]
	public static bool op_Inequality(HSteamUser x, HSteamUser y) { }

	[Address(RVA = "0x60B560", Offset = "0x60A960", Length = "0x7")]
	[Token(Token = "0x6000C00")]
	public virtual string ToString() { }

}

