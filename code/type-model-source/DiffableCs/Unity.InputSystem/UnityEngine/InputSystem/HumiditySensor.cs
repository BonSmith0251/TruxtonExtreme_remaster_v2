namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Humidity")]
[Token(Token = "0x20000B9")]
public class HumiditySensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000451")]
	private static HumiditySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000450")]
	private AxisControl <relativeHumidity>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x170002A0")]
	public private static HumiditySensor current
	{
		[Address(RVA = "0x299A380", Offset = "0x2999780", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000A14")]
		 get { } //Length: 54
		[Address(RVA = "0x299A3C0", Offset = "0x29997C0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000A15")]
		private set { } //Length: 81
	}

	[InputControl(displayName = "Relative Humidity", noisy = True)]
	[Token(Token = "0x1700029F")]
	public AxisControl relativeHumidity
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A12")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A13")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A19")]
	public HumiditySensor() { }

	[Address(RVA = "0x299A220", Offset = "0x2999620", Length = "0x6C")]
	[Token(Token = "0x6000A18")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x299A380", Offset = "0x2999780", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000A14")]
	public static HumiditySensor get_current() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A12")]
	public AxisControl get_relativeHumidity() { }

	[Address(RVA = "0x299A290", Offset = "0x2999690", Length = "0x58")]
	[Token(Token = "0x6000A16")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x299A2F0", Offset = "0x29996F0", Length = "0x90")]
	[Token(Token = "0x6000A17")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x299A3C0", Offset = "0x29997C0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000A15")]
	private static void set_current(HumiditySensor value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A13")]
	protected void set_relativeHumidity(AxisControl value) { }

}

