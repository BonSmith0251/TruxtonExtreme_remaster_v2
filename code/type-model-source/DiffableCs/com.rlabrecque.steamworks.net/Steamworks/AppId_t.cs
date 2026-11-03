namespace Steamworks;

[Token(Token = "0x20001EC")]
public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
{
	[Token(Token = "0x4000B5F")]
	public static readonly AppId_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B60")]
	public uint m_AppId; //Field offset: 0x0

	[Address(RVA = "0x6044C0", Offset = "0x6038C0", Length = "0x39")]
	[Token(Token = "0x6000B9A")]
	private static AppId_t() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000B90")]
	public AppId_t(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000B99")]
	public override int CompareTo(AppId_t other) { }

	[Address(RVA = "0x604420", Offset = "0x603820", Length = "0x97")]
	[Token(Token = "0x6000B92")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000B98")]
	public override bool Equals(AppId_t other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000B93")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000B94")]
	public static bool op_Equality(AppId_t x, AppId_t y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B96")]
	public static AppId_t op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B97")]
	public static uint op_Explicit(AppId_t that) { }

	[Address(RVA = "0x604500", Offset = "0x603900", Length = "0x4F")]
	[Token(Token = "0x6000B95")]
	public static bool op_Inequality(AppId_t x, AppId_t y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000B91")]
	public virtual string ToString() { }

}

