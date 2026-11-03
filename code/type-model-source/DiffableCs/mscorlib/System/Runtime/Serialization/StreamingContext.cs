namespace System.Runtime.Serialization;

[ComVisible(True)]
[IsReadOnly]
[Token(Token = "0x20003FB")]
public struct StreamingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F83")]
	internal readonly object m_additionalContext; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000F84")]
	internal readonly StreamingContextStates m_state; //Field offset: 0x8

	[Token(Token = "0x170003DB")]
	public object Context
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001E88")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003DC")]
	public StreamingContextStates State
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6001E8B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1F2C5B0", Offset = "0x1F2B9B0", Length = "0x11")]
	[Token(Token = "0x6001E86")]
	public StreamingContext(StreamingContextStates state) { }

	[Address(RVA = "0x1F2C5D0", Offset = "0x1F2B9D0", Length = "0xE")]
	[Token(Token = "0x6001E87")]
	public StreamingContext(StreamingContextStates state, object additional) { }

	[Address(RVA = "0x1F2C500", Offset = "0x1F2B900", Length = "0xAC")]
	[Token(Token = "0x6001E89")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6001E88")]
	public object get_Context() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6001E8B")]
	public StreamingContextStates get_State() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6001E8A")]
	public virtual int GetHashCode() { }

}

