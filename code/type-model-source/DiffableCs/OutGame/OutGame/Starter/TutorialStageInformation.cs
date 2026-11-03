namespace OutGame.Starter;

[Token(Token = "0x20000C7")]
public class TutorialStageInformation : StageInformation
{

	[Token(Token = "0x1700012E")]
	public virtual PlayMode StageMode
	{
		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x60004E3")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x21C5A80", Offset = "0x21C4E80", Length = "0x8")]
	[Token(Token = "0x60004E1")]
	public TutorialStageInformation(int stageIndex, InGameResult tresult) { }

	[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
	[Token(Token = "0x60004E3")]
	public virtual PlayMode get_StageMode() { }

	[Address(RVA = "0x21DDA70", Offset = "0x21DCE70", Length = "0x2C")]
	[Token(Token = "0x60004E2")]
	public virtual string StageName() { }

}

