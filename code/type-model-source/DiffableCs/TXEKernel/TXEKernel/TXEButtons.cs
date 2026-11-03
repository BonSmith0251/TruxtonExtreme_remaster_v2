namespace TXEKernel;

[Flags]
[Token(Token = "0x200000A")]
public enum TXEButtons : int
{
	UP = 1,
	DOWN = 2,
	LEFT = 4,
	RIGHT = 8,
	SHOT = 16,
	BOMB = 32,
	EXBOOST = 64,
	CHANGESPEED = 128,
	SPEEDUP = 256,
	SPEEDDOWN = 512,
	SLOWSPEED = 1024,
	PAUSE = 2048,
	RUP = 4096,
	RDOWN = 8192,
	RLEFT = 16384,
	RRIGHT = 32768,
	DEBUG = 65536,
	None = 0,
	BUTTONS = 69616,
	DIRECTIONS = 15,
	RDIRECTIONS = 61440,
	ALL = 131071,
}

