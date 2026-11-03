namespace UnityEngine.InputSystem.Editor;

[Token(Token = "0x2000173")]
internal struct SampleFrequencyCalculator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000945")]
	private double m_LastUpdateTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000946")]
	private int m_SampleCount; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000947")]
	private float <targetFrequency>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000948")]
	private float <frequency>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000437")]
	public private float frequency
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F9C")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000F9D")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000436")]
	public private float targetFrequency
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F9A")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000F9B")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x29FC8F0", Offset = "0x29FBCF0", Length = "0x12")]
	[Token(Token = "0x6000F99")]
	public SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup) { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F9C")]
	public float get_frequency() { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F9A")]
	public float get_targetFrequency() { }

	[Address(RVA = "0x29FC840", Offset = "0x29FBC40", Length = "0x9")]
	[Token(Token = "0x6000F9E")]
	public void ProcessSample(InputEventPtr eventPtr) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000F9D")]
	private void set_frequency(float value) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000F9B")]
	private void set_targetFrequency(float value) { }

	[Address(RVA = "0x29FC890", Offset = "0x29FBC90", Length = "0x56")]
	[Token(Token = "0x6000F9F")]
	public bool Update() { }

	[Address(RVA = "0x29FC850", Offset = "0x29FBC50", Length = "0x3C")]
	[Token(Token = "0x6000FA0")]
	public bool Update(double realtimeSinceStartup) { }

}

