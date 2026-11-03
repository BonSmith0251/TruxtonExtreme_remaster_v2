namespace Steamworks;

[Token(Token = "0x20001E5")]
public struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B52")]
	public uint m_RemotePlaySessionID; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000B44")]
	public RemotePlaySessionID_t(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000B4D")]
	public override int CompareTo(RemotePlaySessionID_t other) { }

	[Address(RVA = "0x639700", Offset = "0x638B00", Length = "0x7F")]
	[Token(Token = "0x6000B46")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000B4C")]
	public override bool Equals(RemotePlaySessionID_t other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000B47")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000B48")]
	public static bool op_Equality(RemotePlaySessionID_t x, RemotePlaySessionID_t y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B4A")]
	public static RemotePlaySessionID_t op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B4B")]
	public static uint op_Explicit(RemotePlaySessionID_t that) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000B49")]
	public static bool op_Inequality(RemotePlaySessionID_t x, RemotePlaySessionID_t y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000B45")]
	public virtual string ToString() { }

}

