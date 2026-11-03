namespace Unity.XR.Oculus.Input;

[Token(Token = "0x200000E")]
public class OculusTrackingReference : TrackedDevice
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000053")]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000054")]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x1B8

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"trackingReferenceIsTracked"})]
	[Token(Token = "0x1700004F")]
	public ButtonControl isTracked
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000B1")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000B2")]
		 set { } //Length: 19
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"trackingReferenceTrackingState"})]
	[Token(Token = "0x1700004E")]
	public IntegerControl trackingState
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000AF")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000B0")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28DA180", Offset = "0x28D9580", Length = "0x7")]
	[Token(Token = "0x60000B4")]
	public OculusTrackingReference() { }

	[Address(RVA = "0x28EAF70", Offset = "0x28EA370", Length = "0xB0")]
	[Token(Token = "0x60000B3")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000B1")]
	public ButtonControl get_isTracked() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000AF")]
	public IntegerControl get_trackingState() { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000B2")]
	protected void set_isTracked(ButtonControl value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000B0")]
	protected void set_trackingState(IntegerControl value) { }

}

