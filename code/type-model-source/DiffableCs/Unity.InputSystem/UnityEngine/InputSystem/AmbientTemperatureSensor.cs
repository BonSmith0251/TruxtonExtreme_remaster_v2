namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Ambient Temperature")]
[Token(Token = "0x20000BA")]
public class AmbientTemperatureSensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000453")]
	private static AmbientTemperatureSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000452")]
	private AxisControl <ambientTemperature>k__BackingField; //Field offset: 0x190

	[InputControl(displayName = "Ambient Temperature", noisy = True)]
	[Token(Token = "0x170002A1")]
	public AxisControl ambientTemperature
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1A")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170002A2")]
	public private static AmbientTemperatureSensor current
	{
		[Address(RVA = "0x2992D60", Offset = "0x2992160", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1C")]
		 get { } //Length: 54
		[Address(RVA = "0x2992DA0", Offset = "0x29921A0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1D")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A21")]
	public AmbientTemperatureSensor() { }

	[Address(RVA = "0x2992C00", Offset = "0x2992000", Length = "0x6C")]
	[Token(Token = "0x6000A20")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1A")]
	public AxisControl get_ambientTemperature() { }

	[Address(RVA = "0x2992D60", Offset = "0x2992160", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1C")]
	public static AmbientTemperatureSensor get_current() { }

	[Address(RVA = "0x2992C70", Offset = "0x2992070", Length = "0x58")]
	[Token(Token = "0x6000A1E")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x2992CD0", Offset = "0x29920D0", Length = "0x90")]
	[Token(Token = "0x6000A1F")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1B")]
	protected void set_ambientTemperature(AxisControl value) { }

	[Address(RVA = "0x2992DA0", Offset = "0x29921A0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1D")]
	private static void set_current(AmbientTemperatureSensor value) { }

}

