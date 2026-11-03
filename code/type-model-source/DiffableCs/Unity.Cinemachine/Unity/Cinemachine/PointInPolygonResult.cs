namespace Unity.Cinemachine;

[Flags]
[Token(Token = "0x2000174")]
internal enum PointInPolygonResult : int
{
	IsOn = 0,
	IsInside = 1,
	IsOutside = 2,
}

