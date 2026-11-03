namespace OutGame.Team;

[Token(Token = "0x2000094")]
public class TeamStageInformation : StageInformation
{

	[Token(Token = "0x170000E4")]
	public virtual PlayMode StageMode
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x60003B5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x21DB170", Offset = "0x21DA570", Length = "0x3A")]
	[Token(Token = "0x60003B3")]
	public TeamStageInformation(int stage, InGameResult tresult) { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x60003B5")]
	public virtual PlayMode get_StageMode() { }

	[Address(RVA = "0x21DB030", Offset = "0x21DA430", Length = "0x138")]
	[Token(Token = "0x60003B4")]
	public virtual string StageName() { }

}

