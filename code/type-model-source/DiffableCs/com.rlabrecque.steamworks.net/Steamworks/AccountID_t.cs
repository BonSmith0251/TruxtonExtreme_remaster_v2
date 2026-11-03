namespace Steamworks;

[Token(Token = "0x20001EB")]
public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
{
	[Token(Token = "0x4000B5D")]
	public static readonly AccountID_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B5E")]
	public uint m_AccountID; //Field offset: 0x0

	[Address(RVA = "0x604200", Offset = "0x603600", Length = "0x39")]
	[Token(Token = "0x6000B8F")]
	private static AccountID_t() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000B85")]
	public AccountID_t(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000B8E")]
	public override int CompareTo(AccountID_t other) { }

	[Address(RVA = "0x604130", Offset = "0x603530", Length = "0x97")]
	[Token(Token = "0x6000B87")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000B8D")]
	public override bool Equals(AccountID_t other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000B88")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000B89")]
	public static bool op_Equality(AccountID_t x, AccountID_t y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B8B")]
	public static AccountID_t op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B8C")]
	public static uint op_Explicit(AccountID_t that) { }

	[Address(RVA = "0x604270", Offset = "0x603670", Length = "0x4F")]
	[Token(Token = "0x6000B8A")]
	public static bool op_Inequality(AccountID_t x, AccountID_t y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000B86")]
	public virtual string ToString() { }

}

