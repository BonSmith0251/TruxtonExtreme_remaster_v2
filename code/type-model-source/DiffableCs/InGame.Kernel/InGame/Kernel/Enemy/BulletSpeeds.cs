namespace InGame.Kernel.Enemy;

[CreateAssetMenu(menuName = "InGame/BulletSpeeds")]
[Token(Token = "0x2000151")]
public class BulletSpeeds : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000153")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000965")]
		public string v; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A66")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x1D73DE0", Offset = "0x1D731E0", Length = "0x25")]
		[Token(Token = "0x6000A67")]
		internal bool <GetASecondPass>b__0(Sheet p) { }

	}

	[Token(Token = "0x2000152")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000963")]
		public string _bulletName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000964")]
		public float _aSecondPass; //Field offset: 0x18

		[Address(RVA = "0x1D39B10", Offset = "0x1D38F10", Length = "0x36")]
		[Token(Token = "0x6000A65")]
		public Sheet() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000962")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1D60DF0", Offset = "0x1D601F0", Length = "0x77")]
	[Token(Token = "0x6000A64")]
	public BulletSpeeds() { }

	[Address(RVA = "0x1D60B50", Offset = "0x1D5FF50", Length = "0xF4")]
	[Token(Token = "0x6000A62")]
	public float GetASecondPass(string v) { }

	[Address(RVA = "0x1D60C50", Offset = "0x1D60050", Length = "0x195")]
	[Token(Token = "0x6000A63")]
	public Dictionary<BulletKind, Single> GetDictionary() { }

}

