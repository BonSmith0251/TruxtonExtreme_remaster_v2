namespace UnityEngine;

[Token(Token = "0x2000007")]
public enum FFTWindow : int
{
	Rectangular = 0,
	Triangle = 1,
	Hamming = 2,
	Hanning = 3,
	Blackman = 4,
	BlackmanHarris = 5,
}

