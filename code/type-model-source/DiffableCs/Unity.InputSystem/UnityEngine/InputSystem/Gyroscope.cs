namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(GyroscopeState))]
[Token(Token = "0x20000B1")]
public class Gyroscope : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000441")]
	private static Gyroscope <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000440")]
	private Vector3Control <angularVelocity>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x1700028F")]
	public Vector3Control angularVelocity
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009D2")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60009D3")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000290")]
	public private static Gyroscope current
	{
		[Address(RVA = "0x2999F80", Offset = "0x2999380", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60009D4")]
		 get { } //Length: 54
		[Address(RVA = "0x2999FC0", Offset = "0x29993C0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60009D5")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60009D9")]
	public Gyroscope() { }

	[Address(RVA = "0x2999E20", Offset = "0x2999220", Length = "0x6C")]
	[Token(Token = "0x60009D8")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009D2")]
	public Vector3Control get_angularVelocity() { }

	[Address(RVA = "0x2999F80", Offset = "0x2999380", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60009D4")]
	public static Gyroscope get_current() { }

	[Address(RVA = "0x2999E90", Offset = "0x2999290", Length = "0x58")]
	[Token(Token = "0x60009D6")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x2999EF0", Offset = "0x29992F0", Length = "0x90")]
	[Token(Token = "0x60009D7")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60009D3")]
	protected void set_angularVelocity(Vector3Control value) { }

	[Address(RVA = "0x2999FC0", Offset = "0x29993C0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60009D5")]
	private static void set_current(Gyroscope value) { }

}

