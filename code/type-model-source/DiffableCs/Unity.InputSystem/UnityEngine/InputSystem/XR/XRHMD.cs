namespace UnityEngine.InputSystem.XR;

[InputControlLayout(isGenericTypeOfDevice = True, displayName = "XR HMD", canRunInBackground = True)]
[Token(Token = "0x20000E4")]
public class XRHMD : TrackedDevice
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400056E")]
	private Vector3Control <leftEyePosition>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400056F")]
	private QuaternionControl <leftEyeRotation>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000570")]
	private Vector3Control <rightEyePosition>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000571")]
	private QuaternionControl <rightEyeRotation>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000572")]
	private Vector3Control <centerEyePosition>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000573")]
	private QuaternionControl <centerEyeRotation>k__BackingField; //Field offset: 0x1D8

	[InputControl(noisy = True)]
	[Token(Token = "0x17000328")]
	public Vector3Control centerEyePosition
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C26")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C27")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000329")]
	public QuaternionControl centerEyeRotation
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C28")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C29")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000324")]
	public Vector3Control leftEyePosition
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C1E")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C1F")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000325")]
	public QuaternionControl leftEyeRotation
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C20")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C21")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000326")]
	public Vector3Control rightEyePosition
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C22")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C23")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True)]
	[Token(Token = "0x17000327")]
	public QuaternionControl rightEyeRotation
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C24")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C25")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28DA180", Offset = "0x28D9580", Length = "0x7")]
	[Token(Token = "0x6000C2B")]
	public XRHMD() { }

	[Address(RVA = "0x29D1C00", Offset = "0x29D1000", Length = "0x190")]
	[Token(Token = "0x6000C2A")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C26")]
	public Vector3Control get_centerEyePosition() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C28")]
	public QuaternionControl get_centerEyeRotation() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C1E")]
	public Vector3Control get_leftEyePosition() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C20")]
	public QuaternionControl get_leftEyeRotation() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C22")]
	public Vector3Control get_rightEyePosition() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C24")]
	public QuaternionControl get_rightEyeRotation() { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C27")]
	protected void set_centerEyePosition(Vector3Control value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C29")]
	protected void set_centerEyeRotation(QuaternionControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C1F")]
	protected void set_leftEyePosition(Vector3Control value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C21")]
	protected void set_leftEyeRotation(QuaternionControl value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C23")]
	protected void set_rightEyePosition(Vector3Control value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C25")]
	protected void set_rightEyeRotation(QuaternionControl value) { }

}

