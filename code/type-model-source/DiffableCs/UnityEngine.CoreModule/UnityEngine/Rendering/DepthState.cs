namespace UnityEngine.Rendering;

[Token(Token = "0x20003D5")]
public struct DepthState : IEquatable<DepthState>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C76")]
	private byte m_WriteEnabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000C77")]
	private sbyte m_CompareFunction; //Field offset: 0x1

	[Token(Token = "0x1700041E")]
	public static DepthState defaultValue
	{
		[Address(RVA = "0x30BDA90", Offset = "0x30BCE90", Length = "0x51")]
		[Token(Token = "0x6001D95")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x30BDA20", Offset = "0x30BCE20", Length = "0x6A")]
	[Token(Token = "0x6001D96")]
	public DepthState(bool writeEnabled = true, CompareFunction compareFunction = 2) { }

	[Address(RVA = "0x30BD9C0", Offset = "0x30BCDC0", Length = "0x12")]
	[Token(Token = "0x6001D97")]
	public override bool Equals(DepthState other) { }

	[Address(RVA = "0x30BD910", Offset = "0x30BCD10", Length = "0xA0")]
	[Token(Token = "0x6001D98")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30BDA90", Offset = "0x30BCE90", Length = "0x51")]
	[Token(Token = "0x6001D95")]
	public static DepthState get_defaultValue() { }

	[Address(RVA = "0x30BD9E0", Offset = "0x30BCDE0", Length = "0x34")]
	[Token(Token = "0x6001D99")]
	public virtual int GetHashCode() { }

}

