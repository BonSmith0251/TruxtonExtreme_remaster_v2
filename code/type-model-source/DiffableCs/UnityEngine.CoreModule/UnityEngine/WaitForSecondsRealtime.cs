namespace UnityEngine;

[Token(Token = "0x20001D7")]
public class WaitForSecondsRealtime : CustomYieldInstruction
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006BA")]
	private float <waitTime>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006BB")]
	private float m_WaitUntilTime; //Field offset: 0x14

	[Token(Token = "0x170002FD")]
	public virtual bool keepWaiting
	{
		[Address(RVA = "0x3075FC0", Offset = "0x30753C0", Length = "0x65")]
		[Token(Token = "0x60014C4")]
		 get { } //Length: 101
	}

	[Token(Token = "0x170002FC")]
	public float waitTime
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60014C2")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60014C3")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x3075F90", Offset = "0x3075390", Length = "0x2F")]
	[Token(Token = "0x60014C5")]
	public WaitForSecondsRealtime(float time) { }

	[Address(RVA = "0x3075FC0", Offset = "0x30753C0", Length = "0x65")]
	[Token(Token = "0x60014C4")]
	public virtual bool get_keepWaiting() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60014C2")]
	public float get_waitTime() { }

	[Address(RVA = "0x3075F80", Offset = "0x3075380", Length = "0x8")]
	[Token(Token = "0x60014C6")]
	public virtual void Reset() { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60014C3")]
	public void set_waitTime(float value) { }

}

