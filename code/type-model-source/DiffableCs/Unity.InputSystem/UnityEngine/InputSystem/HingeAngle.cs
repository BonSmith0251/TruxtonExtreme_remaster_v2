namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Hinge Angle")]
[Token(Token = "0x20000BC")]
public class HingeAngle : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000457")]
	private static HingeAngle <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000456")]
	private AxisControl <angle>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x170002A5")]
	public AxisControl angle
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2A")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170002A6")]
	public private static HingeAngle current
	{
		[Address(RVA = "0x299A180", Offset = "0x2999580", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2C")]
		 get { } //Length: 54
		[Address(RVA = "0x299A1C0", Offset = "0x29995C0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2D")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A31")]
	public HingeAngle() { }

	[Address(RVA = "0x299A020", Offset = "0x2999420", Length = "0x6C")]
	[Token(Token = "0x6000A30")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2A")]
	public AxisControl get_angle() { }

	[Address(RVA = "0x299A180", Offset = "0x2999580", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2C")]
	public static HingeAngle get_current() { }

	[Address(RVA = "0x299A090", Offset = "0x2999490", Length = "0x58")]
	[Token(Token = "0x6000A2E")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x299A0F0", Offset = "0x29994F0", Length = "0x90")]
	[Token(Token = "0x6000A2F")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2B")]
	protected void set_angle(AxisControl value) { }

	[Address(RVA = "0x299A1C0", Offset = "0x29995C0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2D")]
	private static void set_current(HingeAngle value) { }

}

