namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Magnetic Field")]
[Token(Token = "0x20000B5")]
public class MagneticFieldSensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000449")]
	private static MagneticFieldSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000448")]
	private Vector3Control <magneticField>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x17000298")]
	public private static MagneticFieldSensor current
	{
		[Address(RVA = "0x29AE670", Offset = "0x29ADA70", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60009F4")]
		 get { } //Length: 54
		[Address(RVA = "0x29AE6B0", Offset = "0x29ADAB0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60009F5")]
		private set { } //Length: 81
	}

	[InputControl(displayName = "Magnetic Field", noisy = True)]
	[Token(Token = "0x17000297")]
	public Vector3Control magneticField
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009F2")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60009F3")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60009F9")]
	public MagneticFieldSensor() { }

	[Address(RVA = "0x29AE510", Offset = "0x29AD910", Length = "0x6C")]
	[Token(Token = "0x60009F8")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29AE670", Offset = "0x29ADA70", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60009F4")]
	public static MagneticFieldSensor get_current() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009F2")]
	public Vector3Control get_magneticField() { }

	[Address(RVA = "0x29AE580", Offset = "0x29AD980", Length = "0x58")]
	[Token(Token = "0x60009F6")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29AE5E0", Offset = "0x29AD9E0", Length = "0x90")]
	[Token(Token = "0x60009F7")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29AE6B0", Offset = "0x29ADAB0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60009F5")]
	private static void set_current(MagneticFieldSensor value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60009F3")]
	protected void set_magneticField(Vector3Control value) { }

}

