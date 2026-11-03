namespace InGame.Kernel;

[Token(Token = "0x2000029")]
public class InGameEnemyClipsManager
{
	[CompilerGenerated]
	[Token(Token = "0x200002A")]
	private sealed class <Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000120")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000121")]
		public InGameEnemyClipsManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700003C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000195")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700003D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000197")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000192")]
		public <Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x1CDE0A0", Offset = "0x1CDD4A0", Length = "0x3B7")]
		[Token(Token = "0x6000194")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000195")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000197")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CDE460", Offset = "0x1CDD860", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000196")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000193")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000118")]
	private static readonly string _enemyDataLabel; //Field offset: 0x0
	[Token(Token = "0x4000119")]
	private static readonly String[] _changeTableEneX; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400011A")]
	private Dictionary<String, EnemyData> _enemydataClips; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011B")]
	private int _eneXCounter; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400011C")]
	private int _eneXReachMax; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011D")]
	private bool _isEneXSwap; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400011E")]
	private bool _isEneXDead; //Field offset: 0x21

	[Token(Token = "0x1700003B")]
	public int EneXReachMax
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600018F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1CD3540", Offset = "0x1CD2940", Length = "0x133")]
	[Token(Token = "0x6000191")]
	private static InGameEnemyClipsManager() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000190")]
	public InGameEnemyClipsManager() { }

	[Address(RVA = "0x1CD2D40", Offset = "0x1CD2140", Length = "0xB8")]
	[Token(Token = "0x600018B")]
	public void AddEnemyData(EnemyData ed, string ename) { }

	[Address(RVA = "0x1CD2D20", Offset = "0x1CD2120", Length = "0x14")]
	[Token(Token = "0x6000184")]
	public void AddEneXCounter() { }

	[Address(RVA = "0x1CD2E00", Offset = "0x1CD2200", Length = "0xF9")]
	[Token(Token = "0x600018E")]
	private string CheckNameData(string tname) { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600018F")]
	public int get_EneXReachMax() { }

	[Address(RVA = "0x1CD2F00", Offset = "0x1CD2300", Length = "0x174")]
	[Token(Token = "0x6000188")]
	public EnemyData GetData(string tname) { }

	[Address(RVA = "0x1CD3080", Offset = "0x1CD2480", Length = "0x13F")]
	[Token(Token = "0x600018A")]
	public List<String> GetEneXBTNames() { }

	[Address(RVA = "0x1CD31C0", Offset = "0x1CD25C0", Length = "0x13F")]
	[Token(Token = "0x6000189")]
	public List<String> GetEneXNames() { }

	[Address(RVA = "0x1CD3300", Offset = "0x1CD2700", Length = "0x67")]
	[IteratorStateMachine(typeof(<Initialize>d__1))]
	[Token(Token = "0x6000182")]
	public IEnumerator Initialize() { }

	[Address(RVA = "0x1CD3370", Offset = "0x1CD2770", Length = "0x8B")]
	[Token(Token = "0x600018D")]
	public bool IsEneX(string tname) { }

	[Address(RVA = "0x1CD3400", Offset = "0x1CD2800", Length = "0x53")]
	[Token(Token = "0x600018C")]
	public bool IsPool(string ename) { }

	[Address(RVA = "0x1CD3460", Offset = "0x1CD2860", Length = "0x2F")]
	[Token(Token = "0x6000186")]
	public void NextStage() { }

	[Address(RVA = "0x1CD3490", Offset = "0x1CD2890", Length = "0xC")]
	[Token(Token = "0x6000185")]
	public void ResetEneXCounter() { }

	[Address(RVA = "0x1CD34A0", Offset = "0x1CD28A0", Length = "0x14")]
	[Token(Token = "0x6000183")]
	public void SetSwapFlag(bool isSwap, bool rount1st) { }

	[Address(RVA = "0x1CD34C0", Offset = "0x1CD28C0", Length = "0x7D")]
	[Token(Token = "0x6000187")]
	public void Terminate() { }

}

