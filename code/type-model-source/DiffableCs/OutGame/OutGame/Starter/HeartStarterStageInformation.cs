namespace OutGame.Starter;

[Token(Token = "0x200009F")]
public class HeartStarterStageInformation : StageInformation
{

	[Token(Token = "0x170000F6")]
	public virtual bool InfiniteLives
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60003FD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000F5")]
	public virtual PlayMode StageMode
	{
		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x60003FC")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x21C5A80", Offset = "0x21C4E80", Length = "0x8")]
	[Token(Token = "0x60003FA")]
	public HeartStarterStageInformation(int stage, InGameResult tresult) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60003FD")]
	public virtual bool get_InfiniteLives() { }

	[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
	[Token(Token = "0x60003FC")]
	public virtual PlayMode get_StageMode() { }

	[Address(RVA = "0x21D77E0", Offset = "0x21D6BE0", Length = "0x2C")]
	[Token(Token = "0x60003FB")]
	public virtual string StageName() { }

}

