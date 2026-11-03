namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(LinearAccelerationState), displayName = "Linear Acceleration")]
[Token(Token = "0x20000B4")]
public class LinearAccelerationSensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000447")]
	private static LinearAccelerationSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000446")]
	private Vector3Control <acceleration>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x17000295")]
	public Vector3Control acceleration
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009EA")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60009EB")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000296")]
	public private static LinearAccelerationSensor current
	{
		[Address(RVA = "0x29AE470", Offset = "0x29AD870", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60009EC")]
		 get { } //Length: 54
		[Address(RVA = "0x29AE4B0", Offset = "0x29AD8B0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60009ED")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60009F1")]
	public LinearAccelerationSensor() { }

	[Address(RVA = "0x29AE310", Offset = "0x29AD710", Length = "0x6C")]
	[Token(Token = "0x60009F0")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009EA")]
	public Vector3Control get_acceleration() { }

	[Address(RVA = "0x29AE470", Offset = "0x29AD870", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60009EC")]
	public static LinearAccelerationSensor get_current() { }

	[Address(RVA = "0x29AE380", Offset = "0x29AD780", Length = "0x58")]
	[Token(Token = "0x60009EE")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29AE3E0", Offset = "0x29AD7E0", Length = "0x90")]
	[Token(Token = "0x60009EF")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60009EB")]
	protected void set_acceleration(Vector3Control value) { }

	[Address(RVA = "0x29AE4B0", Offset = "0x29AD8B0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60009ED")]
	private static void set_current(LinearAccelerationSensor value) { }

}

