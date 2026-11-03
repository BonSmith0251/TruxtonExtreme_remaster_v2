namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "Vive Tracker")]
[Token(Token = "0x2000009")]
public class ViveTracker : TrackedDevice
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000023")]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000024")]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1B8

	[InputControl(noisy = True)]
	[Token(Token = "0x1700001F")]
	public Vector3Control deviceAngularVelocity
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000047")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000048")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x1700001E")]
	public Vector3Control deviceVelocity
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000045")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000046")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28DA180", Offset = "0x28D9580", Length = "0x7")]
	[Token(Token = "0x600004A")]
	public ViveTracker() { }

	[Address(RVA = "0x28F24C0", Offset = "0x28F18C0", Length = "0xA4")]
	[Token(Token = "0x6000049")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000047")]
	public Vector3Control get_deviceAngularVelocity() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000045")]
	public Vector3Control get_deviceVelocity() { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000048")]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000046")]
	protected void set_deviceVelocity(Vector3Control value) { }

}

