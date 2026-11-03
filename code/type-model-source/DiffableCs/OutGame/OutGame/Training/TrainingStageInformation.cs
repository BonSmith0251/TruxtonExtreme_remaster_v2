namespace OutGame.Training;

[Token(Token = "0x200007A")]
public class TrainingStageInformation : StageInformation
{

	[Token(Token = "0x170000B8")]
	public virtual PlayMode StageMode
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000309")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x21C5A80", Offset = "0x21C4E80", Length = "0x8")]
	[Token(Token = "0x6000307")]
	public TrainingStageInformation(int stage, InGameResult tresult) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000309")]
	public virtual PlayMode get_StageMode() { }

	[Address(RVA = "0x21C5A50", Offset = "0x21C4E50", Length = "0x2C")]
	[Token(Token = "0x6000308")]
	public virtual string StageName() { }

}

