namespace Steamworks;

[Token(Token = "0x20001E4")]
public struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B51")]
	public uint m_SteamNetworkingPOPID; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000B3A")]
	public SteamNetworkingPOPID(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000B43")]
	public override int CompareTo(SteamNetworkingPOPID other) { }

	[Address(RVA = "0x63C650", Offset = "0x63BA50", Length = "0x7F")]
	[Token(Token = "0x6000B3C")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000B42")]
	public override bool Equals(SteamNetworkingPOPID other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000B3D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000B3E")]
	public static bool op_Equality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B40")]
	public static SteamNetworkingPOPID op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B41")]
	public static uint op_Explicit(SteamNetworkingPOPID that) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000B3F")]
	public static bool op_Inequality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000B3B")]
	public virtual string ToString() { }

}

