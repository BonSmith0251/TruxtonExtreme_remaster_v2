namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Light")]
[Token(Token = "0x20000B6")]
public class LightSensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x400044B")]
	private static LightSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400044A")]
	private AxisControl <lightLevel>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x1700029A")]
	public private static LightSensor current
	{
		[Address(RVA = "0x29AE270", Offset = "0x29AD670", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60009FC")]
		 get { } //Length: 54
		[Address(RVA = "0x29AE2B0", Offset = "0x29AD6B0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60009FD")]
		private set { } //Length: 81
	}

	[InputControl(displayName = "Light Level", noisy = True)]
	[Token(Token = "0x17000299")]
	public AxisControl lightLevel
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009FA")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60009FB")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A01")]
	public LightSensor() { }

	[Address(RVA = "0x29AE110", Offset = "0x29AD510", Length = "0x6C")]
	[Token(Token = "0x6000A00")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29AE270", Offset = "0x29AD670", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60009FC")]
	public static LightSensor get_current() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009FA")]
	public AxisControl get_lightLevel() { }

	[Address(RVA = "0x29AE180", Offset = "0x29AD580", Length = "0x58")]
	[Token(Token = "0x60009FE")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29AE1E0", Offset = "0x29AD5E0", Length = "0x90")]
	[Token(Token = "0x60009FF")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29AE2B0", Offset = "0x29AD6B0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60009FD")]
	private static void set_current(LightSensor value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60009FB")]
	protected void set_lightLevel(AxisControl value) { }

}

