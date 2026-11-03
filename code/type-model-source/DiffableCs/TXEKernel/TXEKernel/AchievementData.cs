namespace TXEKernel;

[Token(Token = "0x20000FB")]
public class AchievementData : MonoBehaviour
{
	[Token(Token = "0x20000FC")]
	internal class Data
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400050C")]
		public Sprite icon; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400050D")]
		public string achievementName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400050E")]
		public string achievementConditions; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000739")]
		public Data() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400050B")]
	private Data[] _datas; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000738")]
	public AchievementData() { }

	[Address(RVA = "0x1DDF3B0", Offset = "0x1DDE7B0", Length = "0x2B")]
	[Token(Token = "0x6000737")]
	public Data getData(ID achievementIndex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000735")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000736")]
	private void Update() { }

}

