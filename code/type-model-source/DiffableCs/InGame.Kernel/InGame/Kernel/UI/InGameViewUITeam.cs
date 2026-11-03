namespace InGame.Kernel.UI;

[Token(Token = "0x20000BA")]
public class InGameViewUITeam : InGameViewUI
{
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000595")]
	private InGameTeamGauge[] _playerMarks; //Field offset: 0x98

	[Address(RVA = "0x1D38560", Offset = "0x1D37960", Length = "0x5B")]
	[Token(Token = "0x60006C6")]
	public InGameViewUITeam() { }

	[Address(RVA = "0x1D38180", Offset = "0x1D37580", Length = "0xF4")]
	[Token(Token = "0x60006C3")]
	public virtual void Initialize(InGameManager ingm) { }

	[Address(RVA = "0x1D38280", Offset = "0x1D37680", Length = "0xB3")]
	[Token(Token = "0x60006C4")]
	public virtual void Terminate(InGameManager ingm) { }

	[Address(RVA = "0x1D38340", Offset = "0x1D37740", Length = "0x211")]
	[Token(Token = "0x60006C5")]
	public virtual void UpdateParameters(InGameManager gm, float tssize, float tstall) { }

}

