namespace UnityEngine.VFX;

[Token(Token = "0x200000D")]
public enum VFXSpawnerLoopState : int
{
	Finished = 0,
	DelayingBeforeLoop = 1,
	Looping = 2,
	DelayingAfterLoop = 3,
}

