namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Tracked Device", isGenericTypeOfDevice = True)]
[Token(Token = "0x20000BF")]
public class TrackedDevice : InputDevice
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000467")]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000468")]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000469")]
	private Vector3Control <devicePosition>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x400046A")]
	private QuaternionControl <deviceRotation>k__BackingField; //Field offset: 0x1A8

	[InputControl(noisy = True, dontReset = True)]
	[Token(Token = "0x170002AD")]
	public Vector3Control devicePosition
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A4C")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A4D")]
		 set { } //Length: 19
	}

	[InputControl(noisy = True, dontReset = True)]
	[Token(Token = "0x170002AE")]
	public QuaternionControl deviceRotation
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A4E")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A4F")]
		 set { } //Length: 19
	}

	[InputControl(synthetic = True)]
	[Token(Token = "0x170002AC")]
	public ButtonControl isTracked
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A4A")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A4B")]
		 set { } //Length: 19
	}

	[InputControl(synthetic = True)]
	[Token(Token = "0x170002AB")]
	public IntegerControl trackingState
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A48")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A49")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A51")]
	public TrackedDevice() { }

	[Address(RVA = "0x29B4030", Offset = "0x29B3430", Length = "0x138")]
	[Token(Token = "0x6000A50")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A4C")]
	public Vector3Control get_devicePosition() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A4E")]
	public QuaternionControl get_deviceRotation() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A4A")]
	public ButtonControl get_isTracked() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A48")]
	public IntegerControl get_trackingState() { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A4D")]
	protected void set_devicePosition(Vector3Control value) { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A4F")]
	protected void set_deviceRotation(QuaternionControl value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A4B")]
	protected void set_isTracked(ButtonControl value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A49")]
	protected void set_trackingState(IntegerControl value) { }

}

