namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(GravityState), displayName = "Gravity")]
[Token(Token = "0x20000B2")]
public class GravitySensor : Sensor
{
	[CompilerGenerated]
	[Token(Token = "0x4000443")]
	private static GravitySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000442")]
	private Vector3Control <gravity>k__BackingField; //Field offset: 0x190

	[Token(Token = "0x17000292")]
	public private static GravitySensor current
	{
		[Address(RVA = "0x2999D80", Offset = "0x2999180", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60009DC")]
		 get { } //Length: 54
		[Address(RVA = "0x2999DC0", Offset = "0x29991C0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x60009DD")]
		private set { } //Length: 81
	}

	[Token(Token = "0x17000291")]
	public Vector3Control gravity
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009DA")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60009DB")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60009E1")]
	public GravitySensor() { }

	[Address(RVA = "0x2999C20", Offset = "0x2999020", Length = "0x6C")]
	[Token(Token = "0x60009DE")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x2999D80", Offset = "0x2999180", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60009DC")]
	public static GravitySensor get_current() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009DA")]
	public Vector3Control get_gravity() { }

	[Address(RVA = "0x2999C90", Offset = "0x2999090", Length = "0x58")]
	[Token(Token = "0x60009DF")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x2999CF0", Offset = "0x29990F0", Length = "0x90")]
	[Token(Token = "0x60009E0")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x2999DC0", Offset = "0x29991C0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x60009DD")]
	private static void set_current(GravitySensor value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60009DB")]
	protected void set_gravity(Vector3Control value) { }

}

