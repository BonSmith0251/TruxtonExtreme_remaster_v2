namespace OutGame.Menus;

[Token(Token = "0x20000EB")]
public abstract class GamePlayPresenterBase : PresenterBase
{

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x60005D4")]
	protected GamePlayPresenterBase() { }

	[Address(RVA = "0x21EADA0", Offset = "0x21EA1A0", Length = "0x129")]
	[Token(Token = "0x60005D3")]
	protected void InGameTerminate() { }

	[Address(RVA = "0x21EAED0", Offset = "0x21EA2D0", Length = "0xB5")]
	[Token(Token = "0x60005D2")]
	public virtual bool IsEnableBack() { }

	[Address(RVA = "0x21EAF90", Offset = "0x21EA390", Length = "0xC1")]
	[Token(Token = "0x60005D1")]
	public virtual void OnClickReturn() { }

}

