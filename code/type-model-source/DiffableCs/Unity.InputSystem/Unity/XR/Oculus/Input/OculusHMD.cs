namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Headset", hideInUI = True)]
[Token(Token = "0x200000C")]
public class OculusHMD : XRHMD
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000035")]
	private ButtonControl <userPresence>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000036")]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000037")]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000038")]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000039")]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400003A")]
	private Vector3Control <leftEyeAcceleration>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400003B")]
	private Vector3Control <leftEyeAngularAcceleration>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400003C")]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400003D")]
	private Vector3Control <rightEyeAcceleration>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400003E")]
	private Vector3Control <rightEyeAngularAcceleration>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x400003F")]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000040")]
	private Vector3Control <centerEyeAcceleration>k__BackingField; //Field offset: 0x238
	[CompilerGenerated]
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000041")]
	private Vector3Control <centerEyeAngularAcceleration>k__BackingField; //Field offset: 0x240

	[InputControl(noisy = True)]
	[Token(Token = "0x1700003B")]
	public Vector3Control centerEyeAcceleration
	{
		[Address(RVA = "0x28EA8B0", Offset = "0x28E9CB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000085")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA920", Offset = "0x28E9D20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000086")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700003C")]
	public Vector3Control centerEyeAngularAcceleration
	{
		[Address(RVA = "0x28EA8C0", Offset = "0x28E9CC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000087")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA940", Offset = "0x28E9D40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000088")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700003A")]
	public Vector3Control centerEyeAngularVelocity
	{
		[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000083")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000084")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000032")]
	public Vector3Control deviceAcceleration
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000073")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000074")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000033")]
	public Vector3Control deviceAngularAcceleration
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000075")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000076")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000031")]
	public Vector3Control deviceAngularVelocity
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000071")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000072")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000035")]
	public Vector3Control leftEyeAcceleration
	{
		[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000079")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600007A")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000036")]
	public Vector3Control leftEyeAngularAcceleration
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600007B")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600007C")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000034")]
	public Vector3Control leftEyeAngularVelocity
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000077")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000078")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000038")]
	public Vector3Control rightEyeAcceleration
	{
		[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600007F")]
		 get { } //Length: 8
		[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000080")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000039")]
	public Vector3Control rightEyeAngularAcceleration
	{
		[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000081")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000082")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000037")]
	public Vector3Control rightEyeAngularVelocity
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600007D")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600007E")]
		 set { } //Length: 19
	}

	[InputControl]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new IL2CPP_TYPE_STRING[] {"devicetrackingstate"})]
	[InputControl(name = "isTracked", layout = "Button", aliases = new IL2CPP_TYPE_STRING[] {"deviceistracked"})]
	[Token(Token = "0x17000030")]
	public ButtonControl userPresence
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600006F")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000070")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x600008A")]
	public OculusHMD() { }

	[Address(RVA = "0x28EA590", Offset = "0x28E9990", Length = "0x31C")]
	[Token(Token = "0x6000089")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EA8B0", Offset = "0x28E9CB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000085")]
	public Vector3Control get_centerEyeAcceleration() { }

	[Address(RVA = "0x28EA8C0", Offset = "0x28E9CC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000087")]
	public Vector3Control get_centerEyeAngularAcceleration() { }

	[Address(RVA = "0x28EA8D0", Offset = "0x28E9CD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000083")]
	public Vector3Control get_centerEyeAngularVelocity() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000073")]
	public Vector3Control get_deviceAcceleration() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000075")]
	public Vector3Control get_deviceAngularAcceleration() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000071")]
	public Vector3Control get_deviceAngularVelocity() { }

	[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000079")]
	public Vector3Control get_leftEyeAcceleration() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600007B")]
	public Vector3Control get_leftEyeAngularAcceleration() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000077")]
	public Vector3Control get_leftEyeAngularVelocity() { }

	[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600007F")]
	public Vector3Control get_rightEyeAcceleration() { }

	[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000081")]
	public Vector3Control get_rightEyeAngularAcceleration() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600007D")]
	public Vector3Control get_rightEyeAngularVelocity() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600006F")]
	public ButtonControl get_userPresence() { }

	[Address(RVA = "0x28EA920", Offset = "0x28E9D20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000086")]
	protected void set_centerEyeAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28EA940", Offset = "0x28E9D40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000088")]
	protected void set_centerEyeAngularAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28EA960", Offset = "0x28E9D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000084")]
	protected void set_centerEyeAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000074")]
	protected void set_deviceAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000076")]
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000072")]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600007A")]
	protected void set_leftEyeAcceleration(Vector3Control value) { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600007C")]
	protected void set_leftEyeAngularAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000078")]
	protected void set_leftEyeAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000080")]
	protected void set_rightEyeAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28EA9A0", Offset = "0x28E9DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000082")]
	protected void set_rightEyeAngularAcceleration(Vector3Control value) { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600007E")]
	protected void set_rightEyeAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000070")]
	protected void set_userPresence(ButtonControl value) { }

}

