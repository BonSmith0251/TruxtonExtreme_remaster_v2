namespace UnityEngine.UI.CoroutineTween;

[Token(Token = "0x200008E")]
internal struct FloatTween : ITweenValue
{
	[Token(Token = "0x200008F")]
	internal class FloatTweenCallback : UnityEvent<Single>
	{

		[Address(RVA = "0x3466FA0", Offset = "0x34663A0", Length = "0x39")]
		[Token(Token = "0x6000585")]
		public FloatTweenCallback() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000282")]
	private FloatTweenCallback m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000283")]
	private float m_StartValue; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000284")]
	private float m_TargetValue; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000285")]
	private float m_Duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000286")]
	private bool m_IgnoreTimeScale; //Field offset: 0x14

	[Token(Token = "0x17000166")]
	public override float duration
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x600057C")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x600057D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000167")]
	public override bool ignoreTimeScale
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x600057E")]
		 get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[Token(Token = "0x600057F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000164")]
	public float startValue
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x6000578")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x6000579")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000165")]
	public float targetValue
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x600057A")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x600057B")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x3466FE0", Offset = "0x34663E0", Length = "0xB7")]
	[Token(Token = "0x6000581")]
	public void AddOnChangedCallback(UnityAction<Single> callback) { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x600057C")]
	public override float get_duration() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x600057E")]
	public override bool get_ignoreTimeScale() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[Token(Token = "0x6000578")]
	public float get_startValue() { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x600057A")]
	public float get_targetValue() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000583")]
	public float GetDuration() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000582")]
	public bool GetIgnoreTimescale() { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x600057D")]
	public void set_duration(float value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x600057F")]
	public void set_ignoreTimeScale(bool value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x6000579")]
	public void set_startValue(float value) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x600057B")]
	public void set_targetValue(float value) { }

	[Address(RVA = "0x34670A0", Offset = "0x34664A0", Length = "0x80")]
	[Token(Token = "0x6000580")]
	public override void TweenValue(float floatPercentage) { }

	[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
	[Token(Token = "0x6000584")]
	public override bool ValidTarget() { }

}

