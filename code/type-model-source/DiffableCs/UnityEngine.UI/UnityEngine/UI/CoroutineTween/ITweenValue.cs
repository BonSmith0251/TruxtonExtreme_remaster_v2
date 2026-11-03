namespace UnityEngine.UI.CoroutineTween;

[Token(Token = "0x200008A")]
internal interface ITweenValue
{

	[Token(Token = "0x1700015E")]
	public float duration
	{
		[Token(Token = "0x6000566")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700015D")]
	public bool ignoreTimeScale
	{
		[Token(Token = "0x6000565")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000566")]
	public float get_duration() { }

	[Token(Token = "0x6000565")]
	public bool get_ignoreTimeScale() { }

	[Token(Token = "0x6000564")]
	public void TweenValue(float floatPercentage) { }

	[Token(Token = "0x6000567")]
	public bool ValidTarget() { }

}

