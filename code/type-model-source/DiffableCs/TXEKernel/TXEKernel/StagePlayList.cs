namespace TXEKernel;

[CreateAssetMenu(menuName = "KANAI/PlayList")]
[Token(Token = "0x200009A")]
public class StagePlayList : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200009C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000337")]
		public PlayStage tstage; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600051F")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x1E17C30", Offset = "0x1E17030", Length = "0x1C")]
		[Token(Token = "0x6000520")]
		internal bool <GetBGMID>b__0(Sheet p) { }

	}

	[Token(Token = "0x200009B")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000330")]
		public PlayStage _stage; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000331")]
		public BGM _outset; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000332")]
		public InGameBGM _ontheway1; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000333")]
		public InGameBGM _ontheway2; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000334")]
		public BossBGM _boss; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000335")]
		public BossBGM _epilogue; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000336")]
		public BGM _finale; //Field offset: 0x28

		[Address(RVA = "0x26F7C50", Offset = "0x26F7050", Length = "0x1F")]
		[Token(Token = "0x600051E")]
		public Sheet() { }

		[Address(RVA = "0x26F7C00", Offset = "0x26F7000", Length = "0x41")]
		[Token(Token = "0x600051D")]
		public BGM GetBGM(PlaySection ts) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400032D")]
	public List<Sheet> palette; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400032E")]
	private BGM _gameoverBGM; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400032F")]
	private BGM _resultBGM; //Field offset: 0x24

	[Token(Token = "0x170001B2")]
	public BGM GameoverBGM
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000519")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001B3")]
	public BGM ResultBGM
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x600051A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x26F88E0", Offset = "0x26F7CE0", Length = "0x85")]
	[Token(Token = "0x600051C")]
	public StagePlayList() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000519")]
	public BGM get_GameoverBGM() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x600051A")]
	public BGM get_ResultBGM() { }

	[Address(RVA = "0x26F87B0", Offset = "0x26F7BB0", Length = "0x124")]
	[Token(Token = "0x600051B")]
	public BGM GetBGMID(PlayStage tstage, PlaySection tsection) { }

}

