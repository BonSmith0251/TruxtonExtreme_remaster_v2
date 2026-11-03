namespace TXEKernel;

[Token(Token = "0x20000F0")]
public static class TXEPlayMode
{
	[Token(Token = "0x40004DB")]
	private static readonly Dictionary<PlayStage, String> _stageNames; //Field offset: 0x0
	[Token(Token = "0x40004DC")]
	private static readonly Dictionary<PlayActor, String> _actorNames; //Field offset: 0x8
	[Token(Token = "0x40004DD")]
	public static readonly int RoundMax; //Field offset: 0x10

	[Address(RVA = "0x2716BD0", Offset = "0x2715FD0", Length = "0x327")]
	[Token(Token = "0x60006F0")]
	private static TXEPlayMode() { }

	[Address(RVA = "0x2716970", Offset = "0x2715D70", Length = "0xDB")]
	[Token(Token = "0x60006EE")]
	public static string GetActorName(PlayActor nactor) { }

	[Address(RVA = "0x2716A50", Offset = "0x2715E50", Length = "0x21")]
	[Token(Token = "0x60006EB")]
	public static PlayActor GetNextActor(PlayActor nactor, int nstep) { }

	[Address(RVA = "0x2716A80", Offset = "0x2715E80", Length = "0xD9")]
	[Token(Token = "0x60006EC")]
	public static string GetStageName(PlayStage nstage) { }

	[Address(RVA = "0x2716B60", Offset = "0x2715F60", Length = "0x49")]
	[Token(Token = "0x60006ED")]
	public static int GetStageNo(PlayStage nstage, PlayActor nactor) { }

	[Address(RVA = "0x2716BB0", Offset = "0x2715FB0", Length = "0x13")]
	[Token(Token = "0x60006EF")]
	public static PlayStage GetStageOrder(int nstage) { }

}

