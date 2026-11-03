namespace UnityEngine.Splines;

[Obsolete("Use ISplineContainer instead.")]
[Token(Token = "0x2000016")]
public interface ISplineProvider
{

	[Token(Token = "0x1700001C")]
	public IEnumerable<Spline> Splines
	{
		[Token(Token = "0x6000074")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000074")]
	public IEnumerable<Spline> get_Splines() { }

}

