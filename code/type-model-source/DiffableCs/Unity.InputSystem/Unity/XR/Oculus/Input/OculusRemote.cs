namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Remote", hideInUI = True)]
[Token(Token = "0x200000F")]
public class OculusRemote : InputDevice
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000055")]
	private ButtonControl <back>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000056")]
	private ButtonControl <start>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000057")]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x1A0

	[InputControl]
	[Token(Token = "0x17000050")]
	public ButtonControl back
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000B5")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000B6")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000051")]
	public ButtonControl start
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000B7")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000B8")]
		 set { } //Length: 19
	}

	[InputControl]
	[Token(Token = "0x17000052")]
	public Vector2Control touchpad
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000B9")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000BA")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60000BC")]
	public OculusRemote() { }

	[Address(RVA = "0x28EA9E0", Offset = "0x28E9DE0", Length = "0xE8")]
	[Token(Token = "0x60000BB")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000B5")]
	public ButtonControl get_back() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000B7")]
	public ButtonControl get_start() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000B9")]
	public Vector2Control get_touchpad() { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000B6")]
	protected void set_back(ButtonControl value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000B8")]
	protected void set_start(ButtonControl value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000BA")]
	protected void set_touchpad(Vector2Control value) { }

}

