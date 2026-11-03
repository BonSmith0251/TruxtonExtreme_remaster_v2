namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(AccelerometerState))]
[Token(Token = "0x20000B0")]
public class Accelerometer : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x400043F")]
	private static Accelerometer <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400043E")]
	private Vector3Control <acceleration>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x1700028D")]
	public Vector3Control acceleration
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009CA")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60009CB")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700028E")]
	public private static Accelerometer current
	{
		[Address(RVA = "0x2992B60", Offset = "0x2991F60", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60009CC")]
		 get { } //Length: 54
		[Address(RVA = "0x2992BA0", Offset = "0x2991FA0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60009CD")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60009D1")]
	public Accelerometer() { }

	[Address(RVA = "0x2992A00", Offset = "0x2991E00", Length = "0x6C")]
	[Token(Token = "0x60009D0")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009CA")]
	public Vector3Control get_acceleration() { }

	[Address(RVA = "0x2992B60", Offset = "0x2991F60", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60009CC")]
	public static Accelerometer get_current() { }

	[Address(RVA = "0x2992A70", Offset = "0x2991E70", Length = "0x58")]
	[Token(Token = "0x60009CE")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x2992AD0", Offset = "0x2991ED0", Length = "0x90")]
	[Token(Token = "0x60009CF")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60009CB")]
	protected void set_acceleration(Vector3Control value) { }

	[Address(RVA = "0x2992BA0", Offset = "0x2991FA0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60009CD")]
	private static void set_current(Accelerometer value) { }

}

