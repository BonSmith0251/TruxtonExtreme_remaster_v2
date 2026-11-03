namespace UnityEngine;

[Token(Token = "0x20001D9")]
public sealed class WaitUntil : CustomYieldInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006BF")]
	private readonly Func<Boolean> m_Predicate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006C0")]
	private readonly Action m_TimeoutCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006C1")]
	private readonly WaitTimeoutMode m_TimeoutMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006C2")]
	private readonly double m_MaxExecutionTime; //Field offset: 0x28

	[Token(Token = "0x170002FE")]
	public virtual bool keepWaiting
	{
		[Address(RVA = "0x30760D0", Offset = "0x30754D0", Length = "0x83")]
		[Token(Token = "0x60014C7")]
		 get { } //Length: 131
	}

	[Address(RVA = "0x3076090", Offset = "0x3075490", Length = "0x3F")]
	[Token(Token = "0x60014C8")]
	public WaitUntil(Func<Boolean> predicate) { }

	[Address(RVA = "0x30760D0", Offset = "0x30754D0", Length = "0x83")]
	[Token(Token = "0x60014C7")]
	public virtual bool get_keepWaiting() { }

	[Address(RVA = "0x3076060", Offset = "0x3075460", Length = "0x21")]
	[Token(Token = "0x60014C9")]
	private double GetTime() { }

}

