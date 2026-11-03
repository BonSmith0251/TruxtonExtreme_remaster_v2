namespace TMPro;

[Token(Token = "0x2000036")]
internal struct ColorTween : ITweenValue
{
	[Token(Token = "0x2000038")]
	internal class ColorTweenCallback : UnityEvent<Color>
	{

		[Address(RVA = "0x2EAE2D0", Offset = "0x2EAD6D0", Length = "0x39")]
		[Token(Token = "0x600018E")]
		public ColorTweenCallback() { }

	}

	[Token(Token = "0x2000037")]
	internal enum ColorTweenMode : int
	{
		All = 0,
		RGB = 1,
		Alpha = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000183")]
	private ColorTweenCallback m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000184")]
	private Color m_StartColor; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000185")]
	private Color m_TargetColor; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000186")]
	private ColorTweenMode m_TweenMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000187")]
	private float m_Duration; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000188")]
	private bool m_IgnoreTimeScale; //Field offset: 0x30

	[Token(Token = "0x17000046")]
	public override float duration
	{
		[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
		[Token(Token = "0x6000185")]
		 get { } //Length: 6
		[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
		[Token(Token = "0x6000186")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000047")]
	public override bool ignoreTimeScale
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000187")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x6000188")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000043")]
	public Color startColor
	{
		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[Token(Token = "0x600017F")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
		[Token(Token = "0x6000180")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000044")]
	public Color targetColor
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000181")]
		 get { } //Length: 11
		[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
		[Token(Token = "0x6000182")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000045")]
	public ColorTweenMode tweenMode
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000183")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x6000184")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2EAE310", Offset = "0x2EAD710", Length = "0xB7")]
	[Token(Token = "0x600018A")]
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
	[Token(Token = "0x6000185")]
	public override float get_duration() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000187")]
	public override bool get_ignoreTimeScale() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[Token(Token = "0x600017F")]
	public Color get_startColor() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x6000181")]
	public Color get_targetColor() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000183")]
	public ColorTweenMode get_tweenMode() { }

	[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
	[Token(Token = "0x600018C")]
	public float GetDuration() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x600018B")]
	public bool GetIgnoreTimescale() { }

	[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
	[Token(Token = "0x6000186")]
	public void set_duration(float value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x6000188")]
	public void set_ignoreTimeScale(bool value) { }

	[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
	[Token(Token = "0x6000180")]
	public void set_startColor(Color value) { }

	[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
	[Token(Token = "0x6000182")]
	public void set_targetColor(Color value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000184")]
	public void set_tweenMode(ColorTweenMode value) { }

	[Address(RVA = "0x2EAE3D0", Offset = "0x2EAD7D0", Length = "0x121")]
	[Token(Token = "0x6000189")]
	public override void TweenValue(float floatPercentage) { }

	[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
	[Token(Token = "0x600018D")]
	public override bool ValidTarget() { }

}

