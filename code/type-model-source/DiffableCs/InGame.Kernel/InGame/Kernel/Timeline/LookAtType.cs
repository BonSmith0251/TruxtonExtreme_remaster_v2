namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F6")]
public enum LookAtType : int
{
	None = 0,
	Forward = 1,
	Back = 2,
	Left = 3,
	Right = 4,
	Up = 5,
	Down = 6,
	Player1 = 7,
	RollForward = 20,
	DriftS = 30,
	DriftM = 31,
	DriftL = 32,
}

