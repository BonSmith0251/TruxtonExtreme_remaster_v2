namespace InGame.Kernel.Enemy;

[CreateAssetMenu(menuName = "InGame/BulletSounds")]
[Token(Token = "0x200014F")]
public class BulletSounds : ScriptableObject
{
	[Token(Token = "0x2000150")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000960")]
		public string _bulletName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000961")]
		public BulletSE _seID; //Field offset: 0x18

		[Address(RVA = "0x1D72B20", Offset = "0x1D71F20", Length = "0x3D")]
		[Token(Token = "0x6000A61")]
		public Sheet() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400095F")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1D60AD0", Offset = "0x1D5FED0", Length = "0x77")]
	[Token(Token = "0x6000A60")]
	public BulletSounds() { }

	[Address(RVA = "0x1D60930", Offset = "0x1D5FD30", Length = "0x194")]
	[Token(Token = "0x6000A5F")]
	public Dictionary<BulletKind, ID> GetDictionary() { }

}

