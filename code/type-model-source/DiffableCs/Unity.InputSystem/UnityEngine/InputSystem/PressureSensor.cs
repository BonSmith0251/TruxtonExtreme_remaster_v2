namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Pressure")]
[Token(Token = "0x20000B7")]
public class PressureSensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x400044D")]
	private static PressureSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400044C")]
	private AxisControl <atmosphericPressure>k__BackingField; //Field offset: 0x190

	[InputControl(displayName = "Atmospheric Pressure", noisy = True)]
	[Token(Token = "0x1700029B")]
	public AxisControl atmosphericPressure
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A02")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A03")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700029C")]
	public private static PressureSensor current
	{
		[Address(RVA = "0x29B0980", Offset = "0x29AFD80", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000A04")]
		 get { } //Length: 54
		[Address(RVA = "0x29B09C0", Offset = "0x29AFDC0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000A05")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A09")]
	public PressureSensor() { }

	[Address(RVA = "0x29B0820", Offset = "0x29AFC20", Length = "0x6C")]
	[Token(Token = "0x6000A08")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A02")]
	public AxisControl get_atmosphericPressure() { }

	[Address(RVA = "0x29B0980", Offset = "0x29AFD80", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000A04")]
	public static PressureSensor get_current() { }

	[Address(RVA = "0x29B0890", Offset = "0x29AFC90", Length = "0x58")]
	[Token(Token = "0x6000A06")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29B08F0", Offset = "0x29AFCF0", Length = "0x90")]
	[Token(Token = "0x6000A07")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A03")]
	protected void set_atmosphericPressure(AxisControl value) { }

	[Address(RVA = "0x29B09C0", Offset = "0x29AFDC0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000A05")]
	private static void set_current(PressureSensor value) { }

}

