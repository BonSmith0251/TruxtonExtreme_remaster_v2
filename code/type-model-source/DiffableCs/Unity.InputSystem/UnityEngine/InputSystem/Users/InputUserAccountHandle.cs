namespace UnityEngine.InputSystem.Users;

[Token(Token = "0x2000111")]
public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000644")]
	private string m_ApiName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000645")]
	private ulong m_Handle; //Field offset: 0x8

	[Token(Token = "0x1700036F")]
	public string apiName
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000D1E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000370")]
	public ulong handle
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000D1F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x29E1000", Offset = "0x29E0400", Length = "0x90")]
	[Token(Token = "0x6000D20")]
	public InputUserAccountHandle(string apiName, ulong handle) { }

	[Address(RVA = "0x29E0D80", Offset = "0x29E0180", Length = "0x7D")]
	[Token(Token = "0x6000D22")]
	public override bool Equals(InputUserAccountHandle other) { }

	[Address(RVA = "0x29E0E00", Offset = "0x29E0200", Length = "0xEC")]
	[Token(Token = "0x6000D23")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000D1E")]
	public string get_apiName() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000D1F")]
	public ulong get_handle() { }

	[Address(RVA = "0x29E0EF0", Offset = "0x29E02F0", Length = "0x59")]
	[Token(Token = "0x6000D26")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x29E10A0", Offset = "0x29E04A0", Length = "0x7F")]
	[Token(Token = "0x6000D24")]
	public static bool op_Equality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	[Address(RVA = "0x29E1120", Offset = "0x29E0520", Length = "0x83")]
	[Token(Token = "0x6000D25")]
	public static bool op_Inequality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	[Address(RVA = "0x29E0F50", Offset = "0x29E0350", Length = "0xA2")]
	[Token(Token = "0x6000D21")]
	public virtual string ToString() { }

}

