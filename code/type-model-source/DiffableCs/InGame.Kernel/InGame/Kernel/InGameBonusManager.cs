namespace InGame.Kernel;

[Token(Token = "0x2000009")]
public class InGameBonusManager
{
	[Token(Token = "0x200000A")]
	private class WaveBonusData
	{
		[CompilerGenerated]
		[Token(Token = "0x200000B")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400003A")]
			public string fenemyName; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000064")]
			public <>c__DisplayClass6_0() { }

			[Address(RVA = "0x1CDF6F0", Offset = "0x1CDEAF0", Length = "0x34")]
			[Token(Token = "0x6000065")]
			internal bool <CheckBonus>b__0(PawnEnemy n) { }

			[Address(RVA = "0x1CDF6F0", Offset = "0x1CDEAF0", Length = "0x34")]
			[Token(Token = "0x6000066")]
			internal bool <CheckBonus>b__1(PawnEnemy n) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000037")]
		private int _remainCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000038")]
		private int _bonusType; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000039")]
		private String[] _filter; //Field offset: 0x18

		[Token(Token = "0x17000014")]
		public int BonusType
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x6000060")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1CE17E0", Offset = "0x1CE0BE0", Length = "0x95")]
		[Token(Token = "0x6000061")]
		public WaveBonusData(int remain, int btype, String[] efilter) { }

		[Address(RVA = "0x1CE1580", Offset = "0x1CE0980", Length = "0x25E")]
		[Token(Token = "0x6000062")]
		public PawnEnemy CheckBonus(List<PawnEnemy> penemys) { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000060")]
		public int get_BonusType() { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000063")]
		public void SetRemain(int ncount) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000035")]
	private Dictionary<Int32, WaveBonusData> _waveBonus; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000036")]
	private HashSet<Int32> _wipeouts; //Field offset: 0x18

	[Address(RVA = "0x1CC8F50", Offset = "0x1CC8350", Length = "0x124")]
	[Token(Token = "0x600005C")]
	private void _setCompleteBonus(int _bonus, Vector3 emitPos, int playerNo, string enemyStr, bool isGround) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600005F")]
	public InGameBonusManager() { }

	[Address(RVA = "0x1CC8840", Offset = "0x1CC7C40", Length = "0x8B")]
	[Token(Token = "0x6000059")]
	public void EndWave(int hashCode) { }

	[Address(RVA = "0x1CC88D0", Offset = "0x1CC7CD0", Length = "0xB3")]
	[Token(Token = "0x6000055")]
	public void Initialize() { }

	[Address(RVA = "0x1CC8990", Offset = "0x1CC7D90", Length = "0x5B")]
	[Token(Token = "0x600005D")]
	public bool IsContains(int hashCode) { }

	[Address(RVA = "0x1CC89F0", Offset = "0x1CC7DF0", Length = "0x5B")]
	[Token(Token = "0x600005E")]
	public bool IsWipeout(int hashCode) { }

	[Address(RVA = "0x1CC8A50", Offset = "0x1CC7E50", Length = "0x65")]
	[Token(Token = "0x6000056")]
	public void Reset() { }

	[Address(RVA = "0x1CC8AC0", Offset = "0x1CC7EC0", Length = "0x12E")]
	[Token(Token = "0x600005B")]
	public void SetCompleteBonus(int hashCode) { }

	[Address(RVA = "0x1CC8BF0", Offset = "0x1CC7FF0", Length = "0x134")]
	[Token(Token = "0x6000058")]
	public void SetWave(int hashCode, int enemyCount, WaveBonus tbonus, String[] filter) { }

	[Address(RVA = "0x1CC8D30", Offset = "0x1CC8130", Length = "0x13")]
	[Token(Token = "0x6000057")]
	public void Terminate() { }

	[Address(RVA = "0x1CC8D50", Offset = "0x1CC8150", Length = "0x1F1")]
	[Token(Token = "0x600005A")]
	public void UpdateDeadEnemy(int hashCode, List<PawnEnemy> _deadlists) { }

}

