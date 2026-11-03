namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000E6")]
public interface IEnemyDataContain
{

	[Token(Token = "0x600077B")]
	public List<String> GetBulletTemplateNames() { }

	[Token(Token = "0x6000779")]
	public List<String> GetEnemyNames() { }

	[Token(Token = "0x600077A")]
	public List<String> GetRouteNames() { }

	[Token(Token = "0x600077E")]
	public bool IsClone() { }

	[Token(Token = "0x6000780")]
	public bool IsContainEnemyData() { }

	[Token(Token = "0x600077F")]
	public bool IsEnemyClip() { }

	[Token(Token = "0x600077D")]
	public bool IsGround() { }

	[Token(Token = "0x600077C")]
	public string RuinObject() { }

}

