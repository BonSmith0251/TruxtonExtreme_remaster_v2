namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Step Counter")]
[Token(Token = "0x20000BB")]
public class StepCounter : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000455")]
	private static StepCounter <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000454")]
	private IntegerControl <stepCounter>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x170002A4")]
	public private static StepCounter current
	{
		[Address(RVA = "0x29B2160", Offset = "0x29B1560", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000A24")]
		 get { } //Length: 54
		[Address(RVA = "0x29B21A0", Offset = "0x29B15A0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000A25")]
		private set { } //Length: 81
	}

	[InputControl(displayName = "Step Counter", noisy = True)]
	[Token(Token = "0x170002A3")]
	public IntegerControl stepCounter
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A22")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A23")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A29")]
	public StepCounter() { }

	[Address(RVA = "0x29B2000", Offset = "0x29B1400", Length = "0x6C")]
	[Token(Token = "0x6000A28")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29B2160", Offset = "0x29B1560", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000A24")]
	public static StepCounter get_current() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A22")]
	public IntegerControl get_stepCounter() { }

	[Address(RVA = "0x29B2070", Offset = "0x29B1470", Length = "0x58")]
	[Token(Token = "0x6000A26")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29B20D0", Offset = "0x29B14D0", Length = "0x90")]
	[Token(Token = "0x6000A27")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29B21A0", Offset = "0x29B15A0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000A25")]
	private static void set_current(StepCounter value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A23")]
	protected void set_stepCounter(IntegerControl value) { }

}

