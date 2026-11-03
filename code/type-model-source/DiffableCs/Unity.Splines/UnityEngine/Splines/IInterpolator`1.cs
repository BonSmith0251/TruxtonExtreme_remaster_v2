namespace UnityEngine.Splines;

[Token(Token = "0x200002E")]
public interface IInterpolator
{

	[Token(Token = "0x60001A2")]
	public T Interpolate(T from, T to, float t) { }

}

