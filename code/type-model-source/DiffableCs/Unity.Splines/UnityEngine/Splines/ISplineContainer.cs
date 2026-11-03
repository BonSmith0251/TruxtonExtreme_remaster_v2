namespace UnityEngine.Splines;

[Token(Token = "0x2000015")]
public interface ISplineContainer
{

	[Token(Token = "0x1700001B")]
	public KnotLinkCollection KnotLinkCollection
	{
		[Token(Token = "0x6000073")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001A")]
	public IReadOnlyList<Spline> Splines
	{
		[Token(Token = "0x6000071")]
		 get { } //Length: 0
		[Token(Token = "0x6000072")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000073")]
	public KnotLinkCollection get_KnotLinkCollection() { }

	[Token(Token = "0x6000071")]
	public IReadOnlyList<Spline> get_Splines() { }

	[Token(Token = "0x6000072")]
	public void set_Splines(IReadOnlyList<Spline> value) { }

}

