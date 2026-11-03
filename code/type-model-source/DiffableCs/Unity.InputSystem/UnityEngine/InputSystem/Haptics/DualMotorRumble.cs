namespace UnityEngine.InputSystem.Haptics;

[Token(Token = "0x2000174")]
internal struct DualMotorRumble
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000949")]
	private float <lowFrequencyMotorSpeed>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400094A")]
	private float <highFrequencyMotorSpeed>k__BackingField; //Field offset: 0x4

	[Token(Token = "0x17000439")]
	public private float highFrequencyMotorSpeed
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000FA3")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000FA4")]
		private set { } //Length: 6
	}

	[Token(Token = "0x1700043A")]
	public bool isRumbling
	{
		[Address(RVA = "0x29EB830", Offset = "0x29EAC30", Length = "0x3C")]
		[Token(Token = "0x6000FA5")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000438")]
	public private float lowFrequencyMotorSpeed
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000FA1")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FA2")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000FA3")]
	public float get_highFrequencyMotorSpeed() { }

	[Address(RVA = "0x29EB830", Offset = "0x29EAC30", Length = "0x3C")]
	[Token(Token = "0x6000FA5")]
	public bool get_isRumbling() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000FA1")]
	public float get_lowFrequencyMotorSpeed() { }

	[Address(RVA = "0x29EB410", Offset = "0x29EA810", Length = "0x133")]
	[Token(Token = "0x6000FA6")]
	public void PauseHaptics(InputDevice device) { }

	[Address(RVA = "0x29EB550", Offset = "0x29EA950", Length = "0xA9")]
	[Token(Token = "0x6000FA8")]
	public void ResetHaptics(InputDevice device) { }

	[Address(RVA = "0x29EB600", Offset = "0x29EAA00", Length = "0xAC")]
	[Token(Token = "0x6000FA7")]
	public void ResumeHaptics(InputDevice device) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000FA4")]
	private void set_highFrequencyMotorSpeed(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FA2")]
	private void set_lowFrequencyMotorSpeed(float value) { }

	[Address(RVA = "0x29EB6B0", Offset = "0x29EAAB0", Length = "0x176")]
	[Token(Token = "0x6000FA9")]
	public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency) { }

}

