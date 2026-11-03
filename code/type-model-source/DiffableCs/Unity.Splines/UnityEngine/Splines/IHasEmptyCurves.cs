namespace UnityEngine.Splines;

[Token(Token = "0x2000013")]
public interface IHasEmptyCurves
{

	[Token(Token = "0x17000018")]
	public IReadOnlyList<Int32> EmptyCurves
	{
		[Token(Token = "0x600006A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600006A")]
	public IReadOnlyList<Int32> get_EmptyCurves() { }

}

