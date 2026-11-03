namespace TMPro;

[Token(Token = "0x2000039")]
internal struct FloatTween : ITweenValue
{
	[Token(Token = "0x200003A")]
	internal class FloatTweenCallback : UnityEvent<Single>
	{

		[Address(RVA = "0x2EAE970", Offset = "0x2EADD70", Length = "0x39")]
		[Token(Token = "0x600019C")]
		public FloatTweenCallback() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018D")]
	private FloatTweenCallback m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400018E")]
	private float m_StartValue; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400018F")]
	private float m_TargetValue; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000190")]
	private float m_Duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000191")]
	private bool m_IgnoreTimeScale; //Field offset: 0x14

	[Token(Token = "0x1700004A")]
	public override float duration
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000193")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6000194")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700004B")]
	public override bool ignoreTimeScale
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000195")]
		 get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[Token(Token = "0x6000196")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000048")]
	public float startValue
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x600018F")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x6000190")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000049")]
	public float targetValue
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x6000191")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x6000192")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2EAE9B0", Offset = "0x2EADDB0", Length = "0xB7")]
	[Token(Token = "0x6000198")]
	public void AddOnChangedCallback(UnityAction<Single> callback) { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000193")]
	public override float get_duration() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000195")]
	public override bool get_ignoreTimeScale() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[Token(Token = "0x600018F")]
	public float get_startValue() { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x6000191")]
	public float get_targetValue() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x600019A")]
	public float GetDuration() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000199")]
	public bool GetIgnoreTimescale() { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6000194")]
	public void set_duration(float value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x6000196")]
	public void set_ignoreTimeScale(bool value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x6000190")]
	public void set_startValue(float value) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x6000192")]
	public void set_targetValue(float value) { }

	[Address(RVA = "0x2EAEA70", Offset = "0x2EADE70", Length = "0x80")]
	[Token(Token = "0x6000197")]
	public override void TweenValue(float floatPercentage) { }

	[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
	[Token(Token = "0x600019B")]
	public override bool ValidTarget() { }

}

