namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Headset (w/ on-headset controls)", hideInUI = True)]
[Token(Token = "0x2000010")]
public class OculusHMDExtended : OculusHMD
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000058")]
	private ButtonControl <back>k__BackingField; //Field offset: 0x248
	[CompilerGenerated]
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000059")]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x250

	[InputControl]
	[Token(Token = "0x17000053")]
	public ButtonControl back
	{
		[Address(RVA = "0x28EA530", Offset = "0x28E9930", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000BD")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA550", Offset = "0x28E9950", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000BE")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000054")]
	public Vector2Control touchpad
	{
		[Address(RVA = "0x28EA540", Offset = "0x28E9940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000BF")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA570", Offset = "0x28E9970", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000C0")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x60000C2")]
	public OculusHMDExtended() { }

	[Address(RVA = "0x28EA480", Offset = "0x28E9880", Length = "0xB0")]
	[Token(Token = "0x60000C1")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EA530", Offset = "0x28E9930", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000BD")]
	public ButtonControl get_back() { }

	[Address(RVA = "0x28EA540", Offset = "0x28E9940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000BF")]
	public Vector2Control get_touchpad() { }

	[Address(RVA = "0x28EA550", Offset = "0x28E9950", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000BE")]
	protected void set_back(ButtonControl value) { }

	[Address(RVA = "0x28EA570", Offset = "0x28E9970", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000C0")]
	protected void set_touchpad(Vector2Control value) { }

}

