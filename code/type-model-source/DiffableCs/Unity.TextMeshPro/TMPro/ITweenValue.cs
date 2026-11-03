namespace TMPro;

[Token(Token = "0x2000035")]
internal interface ITweenValue
{

	[Token(Token = "0x17000042")]
	public float duration
	{
		[Token(Token = "0x600017D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000041")]
	public bool ignoreTimeScale
	{
		[Token(Token = "0x600017C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600017D")]
	public float get_duration() { }

	[Token(Token = "0x600017C")]
	public bool get_ignoreTimeScale() { }

	[Token(Token = "0x600017B")]
	public void TweenValue(float floatPercentage) { }

	[Token(Token = "0x600017E")]
	public bool ValidTarget() { }

}

