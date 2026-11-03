namespace OutGame.Story;

[Token(Token = "0x200019A")]
public class StoryPlayModel : ModelGamePlayBase
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400072D")]
	private PlayActor _actor; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400072E")]
	private int _episodeIndex; //Field offset: 0x7C

	[Address(RVA = "0x2219180", Offset = "0x2218580", Length = "0x8D")]
	[Token(Token = "0x6000A23")]
	public StoryPlayModel(AssetReference aStage, PlayActor nactor, int episodeIndex) { }

	[Address(RVA = "0x2218F70", Offset = "0x2218370", Length = "0xBE")]
	[Token(Token = "0x6000A26")]
	protected virtual long GetHighScore() { }

	[Address(RVA = "0x2219030", Offset = "0x2218430", Length = "0x10")]
	[Token(Token = "0x6000A27")]
	public virtual bool IsSkipTakeOffMovie() { }

	[Address(RVA = "0x2219040", Offset = "0x2218440", Length = "0x94")]
	[Token(Token = "0x6000A24")]
	public StageInformation PrepareResults(InGameManager gm) { }

	[Address(RVA = "0x22190E0", Offset = "0x22184E0", Length = "0x9E")]
	[Token(Token = "0x6000A25")]
	public void UpdateSaveData(ArmsKind tarm, int npow, int tspeed) { }

}

