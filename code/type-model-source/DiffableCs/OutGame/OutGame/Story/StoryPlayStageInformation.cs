namespace OutGame.Story;

[Token(Token = "0x200019B")]
public class StoryPlayStageInformation : StageInformation
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400072F")]
	private PlayActor _actor; //Field offset: 0x38

	[Token(Token = "0x1700022E")]
	public virtual PlayActor Actor
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000A2A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700022F")]
	public virtual PlayMode StageMode
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A2B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2219A50", Offset = "0x2218E50", Length = "0x2D")]
	[Token(Token = "0x6000A28")]
	public StoryPlayStageInformation(int stage, InGameResult tresult, PlayActor actor) { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000A2A")]
	public virtual PlayActor get_Actor() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A2B")]
	public virtual PlayMode get_StageMode() { }

	[Address(RVA = "0x22199C0", Offset = "0x2218DC0", Length = "0x85")]
	[Token(Token = "0x6000A29")]
	public virtual string StageName() { }

}

