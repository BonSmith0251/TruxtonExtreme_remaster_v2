namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(AttitudeState), displayName = "Attitude")]
[Token(Token = "0x20000B3")]
public class AttitudeSensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000445")]
	private static AttitudeSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000444")]
	private QuaternionControl <attitude>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x17000293")]
	public QuaternionControl attitude
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009E2")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60009E3")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000294")]
	public private static AttitudeSensor current
	{
		[Address(RVA = "0x2992F60", Offset = "0x2992360", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60009E4")]
		 get { } //Length: 54
		[Address(RVA = "0x2992FA0", Offset = "0x29923A0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60009E5")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60009E9")]
	public AttitudeSensor() { }

	[Address(RVA = "0x2992E00", Offset = "0x2992200", Length = "0x6C")]
	[Token(Token = "0x60009E8")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009E2")]
	public QuaternionControl get_attitude() { }

	[Address(RVA = "0x2992F60", Offset = "0x2992360", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60009E4")]
	public static AttitudeSensor get_current() { }

	[Address(RVA = "0x2992E70", Offset = "0x2992270", Length = "0x58")]
	[Token(Token = "0x60009E6")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x2992ED0", Offset = "0x29922D0", Length = "0x90")]
	[Token(Token = "0x60009E7")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60009E3")]
	protected void set_attitude(QuaternionControl value) { }

	[Address(RVA = "0x2992FA0", Offset = "0x29923A0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60009E5")]
	private static void set_current(AttitudeSensor value) { }

}

