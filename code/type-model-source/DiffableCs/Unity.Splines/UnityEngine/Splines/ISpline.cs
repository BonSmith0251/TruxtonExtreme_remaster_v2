namespace UnityEngine.Splines;

[Token(Token = "0x2000014")]
public interface ISpline : IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>
{

	[Token(Token = "0x17000019")]
	public bool Closed
	{
		[Token(Token = "0x600006B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600006B")]
	public bool get_Closed() { }

	[Token(Token = "0x600006D")]
	public BezierCurve GetCurve(int index) { }

	[Token(Token = "0x6000070")]
	public float GetCurveInterpolation(int curveIndex, float curveDistance) { }

	[Token(Token = "0x600006E")]
	public float GetCurveLength(int index) { }

	[Token(Token = "0x600006F")]
	public float3 GetCurveUpVector(int index, float t) { }

	[Token(Token = "0x600006C")]
	public float GetLength() { }

}

