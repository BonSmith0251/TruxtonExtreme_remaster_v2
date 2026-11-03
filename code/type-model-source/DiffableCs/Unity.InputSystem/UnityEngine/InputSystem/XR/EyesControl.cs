namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000F5")]
public class EyesControl : InputControl<Eyes>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40005BB")]
	private Vector3Control <leftEyePosition>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40005BC")]
	private QuaternionControl <leftEyeRotation>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40005BD")]
	private Vector3Control <rightEyePosition>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40005BE")]
	private QuaternionControl <rightEyeRotation>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40005BF")]
	private Vector3Control <fixationPoint>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40005C0")]
	private AxisControl <leftEyeOpenAmount>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40005C1")]
	private AxisControl <rightEyeOpenAmount>k__BackingField; //Field offset: 0x1C8

	[InputControl(offset = 56, displayName = "FixationPoint")]
	[Token(Token = "0x17000345")]
	public Vector3Control fixationPoint
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C97")]
		 get { } //Length: 8
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C98")]
		 set { } //Length: 19
	}

	[InputControl(offset = 68, displayName = "LeftEyeOpenAmount")]
	[Token(Token = "0x17000346")]
	public AxisControl leftEyeOpenAmount
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C99")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C9A")]
		 set { } //Length: 19
	}

	[InputControl(offset = 0, displayName = "LeftEyePosition")]
	[Token(Token = "0x17000341")]
	public Vector3Control leftEyePosition
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C8F")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C90")]
		 set { } //Length: 19
	}

	[InputControl(offset = 12, displayName = "LeftEyeRotation")]
	[Token(Token = "0x17000342")]
	public QuaternionControl leftEyeRotation
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C91")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C92")]
		 set { } //Length: 19
	}

	[InputControl(offset = 72, displayName = "RightEyeOpenAmount")]
	[Token(Token = "0x17000347")]
	public AxisControl rightEyeOpenAmount
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C9B")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C9C")]
		 set { } //Length: 19
	}

	[InputControl(offset = 28, displayName = "RightEyePosition")]
	[Token(Token = "0x17000343")]
	public Vector3Control rightEyePosition
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C93")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C94")]
		 set { } //Length: 19
	}

	[InputControl(offset = 40, displayName = "RightEyeRotation")]
	[Token(Token = "0x17000344")]
	public QuaternionControl rightEyeRotation
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C95")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C96")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x29B6370", Offset = "0x29B5770", Length = "0x39")]
	[Token(Token = "0x6000CA0")]
	public EyesControl() { }

	[Address(RVA = "0x29B5E20", Offset = "0x29B5220", Length = "0x1E9")]
	[Token(Token = "0x6000C9D")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C97")]
	public Vector3Control get_fixationPoint() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C99")]
	public AxisControl get_leftEyeOpenAmount() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C8F")]
	public Vector3Control get_leftEyePosition() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C91")]
	public QuaternionControl get_leftEyeRotation() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C9B")]
	public AxisControl get_rightEyeOpenAmount() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C93")]
	public Vector3Control get_rightEyePosition() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C95")]
	public QuaternionControl get_rightEyeRotation() { }

	[Address(RVA = "0x29B6010", Offset = "0x29B5410", Length = "0x1B6")]
	[Token(Token = "0x6000C9E")]
	public virtual Eyes ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C98")]
	public void set_fixationPoint(Vector3Control value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C9A")]
	public void set_leftEyeOpenAmount(AxisControl value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C90")]
	public void set_leftEyePosition(Vector3Control value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C92")]
	public void set_leftEyeRotation(QuaternionControl value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C9C")]
	public void set_rightEyeOpenAmount(AxisControl value) { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C94")]
	public void set_rightEyePosition(Vector3Control value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C96")]
	public void set_rightEyeRotation(QuaternionControl value) { }

	[Address(RVA = "0x29B61D0", Offset = "0x29B55D0", Length = "0x196")]
	[Token(Token = "0x6000C9F")]
	public virtual void WriteValueIntoState(Eyes value, Void* statePtr) { }

}

