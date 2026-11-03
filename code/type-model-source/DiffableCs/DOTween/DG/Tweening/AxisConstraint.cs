namespace DG.Tweening;

[Flags]
[Token(Token = "0x2000003")]
public enum AxisConstraint : int
{
	None = 0,
	X = 2,
	Y = 4,
	Z = 8,
	W = 16,
}

