namespace OutGame.Utility;

[CreateAssetMenu(menuName = "InGame/AssetTable")]
[Token(Token = "0x2000068")]
public class AssetReferenceTable : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000185")]
	private AssetReference[] _assetTables; //Field offset: 0x18

	[Token(Token = "0x1700009A")]
	public int Count
	{
		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x6000295")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700009B")]
	public AssetReference[] Tables
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000296")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000298")]
	public AssetReferenceTable() { }

	[Address(RVA = "0x1F12AF0", Offset = "0x1F11EF0", Length = "0x2B")]
	[Token(Token = "0x6000297")]
	public AssetReference Get(int tindex) { }

	[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
	[Token(Token = "0x6000295")]
	public int get_Count() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000296")]
	public AssetReference[] get_Tables() { }

}

