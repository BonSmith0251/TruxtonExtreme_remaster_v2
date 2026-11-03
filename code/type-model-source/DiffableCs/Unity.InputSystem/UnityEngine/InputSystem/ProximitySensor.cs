namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Proximity")]
[Token(Token = "0x20000B8")]
public class ProximitySensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x400044F")]
	private static ProximitySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400044E")]
	private AxisControl <distance>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x1700029E")]
	public private static ProximitySensor current
	{
		[Address(RVA = "0x29B0B80", Offset = "0x29AFF80", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0C")]
		 get { } //Length: 54
		[Address(RVA = "0x29B0BC0", Offset = "0x29AFFC0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0D")]
		private set { } //Length: 81
	}

	[InputControl(displayName = "Distance", noisy = True)]
	[Token(Token = "0x1700029D")]
	public AxisControl distance
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0A")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0B")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A11")]
	public ProximitySensor() { }

	[Address(RVA = "0x29B0A20", Offset = "0x29AFE20", Length = "0x6C")]
	[Token(Token = "0x6000A10")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29B0B80", Offset = "0x29AFF80", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0C")]
	public static ProximitySensor get_current() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0A")]
	public AxisControl get_distance() { }

	[Address(RVA = "0x29B0A90", Offset = "0x29AFE90", Length = "0x58")]
	[Token(Token = "0x6000A0E")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29B0AF0", Offset = "0x29AFEF0", Length = "0x90")]
	[Token(Token = "0x6000A0F")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29B0BC0", Offset = "0x29AFFC0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0D")]
	private static void set_current(ProximitySensor value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0B")]
	protected void set_distance(AxisControl value) { }

}

