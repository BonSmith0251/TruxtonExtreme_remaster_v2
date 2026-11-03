namespace TXEKernel;

[Token(Token = "0x20000DE")]
public abstract class TXEKernelHybridCollisions : HybridCollisions
{
	[Token(Token = "0x20000DF")]
	internal enum attackType : int
	{
		none = -1,
		blue = 0,
		green = 1,
		red = 2,
		gold = 3,
		silver = 4,
		black = 5,
		pink = 6,
		bomb = 100,
		stageClear = 110,
		friendlyFire = 111,
	}

	[Token(Token = "0x20000E0")]
	internal enum toleType : int
	{
		normal = 0,
		veryhigh = 1,
		high = 2,
		low = 3,
		verylow = 4,
	}


	[Address(RVA = "0x2715170", Offset = "0x2714570", Length = "0x49")]
	[Token(Token = "0x60006AF")]
	protected TXEKernelHybridCollisions() { }

}

