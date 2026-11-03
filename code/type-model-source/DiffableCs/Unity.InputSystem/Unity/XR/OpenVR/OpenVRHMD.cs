namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "OpenVR Headset", hideInUI = True)]
[Token(Token = "0x2000005")]
public class OpenVRHMD : XRHMD
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000006")]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000007")]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000008")]
	private Vector3Control <leftEyeVelocity>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000009")]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400000A")]
	private Vector3Control <rightEyeVelocity>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400000B")]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400000C")]
	private Vector3Control <centerEyeVelocity>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400000D")]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; //Field offset: 0x218

	[InputControl(noisy = True)]
	[Token(Token = "0x17000008")]
	public Vector3Control centerEyeAngularVelocity
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000012")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000013")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000007")]
	public Vector3Control centerEyeVelocity
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000010")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000011")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000002")]
	public Vector3Control deviceAngularVelocity
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000001")]
	public Vector3Control deviceVelocity
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000004")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000005")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000004")]
	public Vector3Control leftEyeAngularVelocity
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600000A")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600000B")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000003")]
	public Vector3Control leftEyeVelocity
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000009")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000006")]
	public Vector3Control rightEyeAngularVelocity
	{
		[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600000E")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600000F")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000005")]
	public Vector3Control rightEyeVelocity
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600000C")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600000D")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x6000015")]
	public OpenVRHMD() { }

	[Address(RVA = "0x28EB2F0", Offset = "0x28EA6F0", Length = "0x1F4")]
	[Token(Token = "0x6000014")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000012")]
	public Vector3Control get_centerEyeAngularVelocity() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000010")]
	public Vector3Control get_centerEyeVelocity() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	public Vector3Control get_deviceAngularVelocity() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000004")]
	public Vector3Control get_deviceVelocity() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600000A")]
	public Vector3Control get_leftEyeAngularVelocity() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	public Vector3Control get_leftEyeVelocity() { }

	[Address(RVA = "0x28EA8E0", Offset = "0x28E9CE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600000E")]
	public Vector3Control get_rightEyeAngularVelocity() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600000C")]
	public Vector3Control get_rightEyeVelocity() { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000013")]
	protected void set_centerEyeAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000011")]
	protected void set_centerEyeVelocity(Vector3Control value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000005")]
	protected void set_deviceVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600000B")]
	protected void set_leftEyeAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000009")]
	protected void set_leftEyeVelocity(Vector3Control value) { }

	[Address(RVA = "0x28EA980", Offset = "0x28E9D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600000F")]
	protected void set_rightEyeAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600000D")]
	protected void set_rightEyeVelocity(Vector3Control value) { }

}

