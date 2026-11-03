namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000F3")]
public struct Eyes
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005B1")]
	public Vector3 m_LeftEyePosition; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005B2")]
	public Quaternion m_LeftEyeRotation; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40005B3")]
	public Vector3 m_RightEyePosition; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005B4")]
	public Quaternion m_RightEyeRotation; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B5")]
	public Vector3 m_FixationPoint; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40005B6")]
	public float m_LeftEyeOpenAmount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005B7")]
	public float m_RightEyeOpenAmount; //Field offset: 0x48

	[Token(Token = "0x1700033B")]
	public Vector3 fixationPoint
	{
		[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
		[Token(Token = "0x6000C7F")]
		 get { } //Length: 19
		[Address(RVA = "0x1D14930", Offset = "0x1D13D30", Length = "0x10")]
		[Token(Token = "0x6000C80")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700033C")]
	public float leftEyeOpenAmount
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x6000C81")]
		 get { } //Length: 6
		[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
		[Token(Token = "0x6000C82")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000337")]
	public Vector3 leftEyePosition
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[Token(Token = "0x6000C77")]
		 get { } //Length: 18
		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[Token(Token = "0x6000C78")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000338")]
	public Quaternion leftEyeRotation
	{
		[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
		[Token(Token = "0x6000C79")]
		 get { } //Length: 11
		[Address(RVA = "0x28A7D40", Offset = "0x28A7140", Length = "0x8")]
		[Token(Token = "0x6000C7A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700033D")]
	public float rightEyeOpenAmount
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x6000C83")]
		 get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[Token(Token = "0x6000C84")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000339")]
	public Vector3 rightEyePosition
	{
		[Address(RVA = "0x29B63B0", Offset = "0x29B57B0", Length = "0x13")]
		[Token(Token = "0x6000C7B")]
		 get { } //Length: 19
		[Address(RVA = "0x29B63D0", Offset = "0x29B57D0", Length = "0x10")]
		[Token(Token = "0x6000C7C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700033A")]
	public Quaternion rightEyeRotation
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x6000C7D")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
		[Token(Token = "0x6000C7E")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
	[Token(Token = "0x6000C7F")]
	public Vector3 get_fixationPoint() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x6000C81")]
	public float get_leftEyeOpenAmount() { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x6000C77")]
	public Vector3 get_leftEyePosition() { }

	[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
	[Token(Token = "0x6000C79")]
	public Quaternion get_leftEyeRotation() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x6000C83")]
	public float get_rightEyeOpenAmount() { }

	[Address(RVA = "0x29B63B0", Offset = "0x29B57B0", Length = "0x13")]
	[Token(Token = "0x6000C7B")]
	public Vector3 get_rightEyePosition() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x6000C7D")]
	public Quaternion get_rightEyeRotation() { }

	[Address(RVA = "0x1D14930", Offset = "0x1D13D30", Length = "0x10")]
	[Token(Token = "0x6000C80")]
	public void set_fixationPoint(Vector3 value) { }

	[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
	[Token(Token = "0x6000C82")]
	public void set_leftEyeOpenAmount(float value) { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x6000C78")]
	public void set_leftEyePosition(Vector3 value) { }

	[Address(RVA = "0x28A7D40", Offset = "0x28A7140", Length = "0x8")]
	[Token(Token = "0x6000C7A")]
	public void set_leftEyeRotation(Quaternion value) { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[Token(Token = "0x6000C84")]
	public void set_rightEyeOpenAmount(float value) { }

	[Address(RVA = "0x29B63D0", Offset = "0x29B57D0", Length = "0x10")]
	[Token(Token = "0x6000C7C")]
	public void set_rightEyePosition(Vector3 value) { }

	[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
	[Token(Token = "0x6000C7E")]
	public void set_rightEyeRotation(Quaternion value) { }

}

