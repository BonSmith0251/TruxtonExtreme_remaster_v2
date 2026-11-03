namespace UnityEngine.UI.CoroutineTween;

[Token(Token = "0x200008B")]
internal struct ColorTween : ITweenValue
{
	[Token(Token = "0x200008D")]
	internal class ColorTweenCallback : UnityEvent<Color>
	{

		[Address(RVA = "0x3462EC0", Offset = "0x34622C0", Length = "0x39")]
		[Token(Token = "0x6000577")]
		public ColorTweenCallback() { }

	}

	[Token(Token = "0x200008C")]
	internal enum ColorTweenMode : int
	{
		All = 0,
		RGB = 1,
		Alpha = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000278")]
	private ColorTweenCallback m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000279")]
	private Color m_StartColor; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027A")]
	private Color m_TargetColor; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400027B")]
	private ColorTweenMode m_TweenMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400027C")]
	private float m_Duration; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400027D")]
	private bool m_IgnoreTimeScale; //Field offset: 0x30

	[Token(Token = "0x17000162")]
	public override float duration
	{
		[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
		[Token(Token = "0x600056E")]
		 get { } //Length: 6
		[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
		[Token(Token = "0x600056F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000163")]
	public override bool ignoreTimeScale
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000570")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x6000571")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700015F")]
	public Color startColor
	{
		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[Token(Token = "0x6000568")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
		[Token(Token = "0x6000569")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000160")]
	public Color targetColor
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x600056A")]
		 get { } //Length: 11
		[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
		[Token(Token = "0x600056B")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000161")]
	public ColorTweenMode tweenMode
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x600056C")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x600056D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3462F00", Offset = "0x3462300", Length = "0xB7")]
	[Token(Token = "0x6000573")]
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
	[Token(Token = "0x600056E")]
	public override float get_duration() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000570")]
	public override bool get_ignoreTimeScale() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[Token(Token = "0x6000568")]
	public Color get_startColor() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x600056A")]
	public Color get_targetColor() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x600056C")]
	public ColorTweenMode get_tweenMode() { }

	[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
	[Token(Token = "0x6000575")]
	public float GetDuration() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000574")]
	public bool GetIgnoreTimescale() { }

	[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
	[Token(Token = "0x600056F")]
	public void set_duration(float value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x6000571")]
	public void set_ignoreTimeScale(bool value) { }

	[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
	[Token(Token = "0x6000569")]
	public void set_startColor(Color value) { }

	[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
	[Token(Token = "0x600056B")]
	public void set_targetColor(Color value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x600056D")]
	public void set_tweenMode(ColorTweenMode value) { }

	[Address(RVA = "0x3462FC0", Offset = "0x34623C0", Length = "0x121")]
	[Token(Token = "0x6000572")]
	public override void TweenValue(float floatPercentage) { }

	[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
	[Token(Token = "0x6000576")]
	public override bool ValidTarget() { }

}

