namespace Steamworks;

[Token(Token = "0x20001DC")]
public struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
{
	[Token(Token = "0x4000B0E")]
	public static readonly HSteamNetPollGroup Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B0F")]
	public uint m_HSteamNetPollGroup; //Field offset: 0x0

	[Address(RVA = "0x60B900", Offset = "0x60AD00", Length = "0x39")]
	[Token(Token = "0x6000B04")]
	private static HSteamNetPollGroup() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000AFA")]
	public HSteamNetPollGroup(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000B03")]
	public override int CompareTo(HSteamNetPollGroup other) { }

	[Address(RVA = "0x60B860", Offset = "0x60AC60", Length = "0x97")]
	[Token(Token = "0x6000AFC")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000B02")]
	public override bool Equals(HSteamNetPollGroup other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000AFD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000AFE")]
	public static bool op_Equality(HSteamNetPollGroup x, HSteamNetPollGroup y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B00")]
	public static HSteamNetPollGroup op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B01")]
	public static uint op_Explicit(HSteamNetPollGroup that) { }

	[Address(RVA = "0x60B940", Offset = "0x60AD40", Length = "0x4F")]
	[Token(Token = "0x6000AFF")]
	public static bool op_Inequality(HSteamNetPollGroup x, HSteamNetPollGroup y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000AFB")]
	public virtual string ToString() { }

}

