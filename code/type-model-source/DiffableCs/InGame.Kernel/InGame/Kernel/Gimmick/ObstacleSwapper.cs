namespace InGame.Kernel.Gimmick;

[Token(Token = "0x200014C")]
public class ObstacleSwapper : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400095D")]
	private string _enemyDataName; //Field offset: 0x20

	[Token(Token = "0x170001C3")]
	public string EnemyDataName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000A57")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000A58")]
	public ObstacleSwapper() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000A57")]
	public string get_EnemyDataName() { }

}

