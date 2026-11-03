namespace OutGame.Gallery;

[Token(Token = "0x20001FD")]
public class RankingStoryPresenter : RankingPresenterBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001FF")]
	private sealed class <_Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008B9")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008BA")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008BB")]
		public RankingStoryPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170002DA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000CB1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002DB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000CB3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000CAE")]
		public <_Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x2228270", Offset = "0x2227670", Length = "0x114")]
		[Token(Token = "0x6000CB0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000CB1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000CB3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2228390", Offset = "0x2227790", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000CB2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000CAF")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20001FE")]
	internal class Value : ValueRankingBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008B8")]
		public readonly PlayActor Actor; //Field offset: 0x18

		[Address(RVA = "0x22283D0", Offset = "0x22277D0", Length = "0x20")]
		[Token(Token = "0x6000CAC")]
		public Value() { }

		[Address(RVA = "0x22283F0", Offset = "0x22277F0", Length = "0x27")]
		[Token(Token = "0x6000CAD")]
		public Value(PlayActor actor) { }

	}

	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40008B5")]
	private RankDisplay[] _rankingTable; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008B6")]
	private PlayActor _actor; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008B7")]
	public List<String[]> _rankingString; //Field offset: 0x98

	[Token(Token = "0x170002D9")]
	protected virtual String[] RankingString
	{
		[Address(RVA = "0x2218D70", Offset = "0x2218170", Length = "0x4D")]
		[Token(Token = "0x6000CA9")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x22161D0", Offset = "0x22155D0", Length = "0x61")]
	[Token(Token = "0x6000CA7")]
	protected virtual void _clearRank() { }

	[Address(RVA = "0x2216DC0", Offset = "0x22161C0", Length = "0x111")]
	[Token(Token = "0x6000CA8")]
	protected virtual void _dispRank(int rankIndex, int focusRankIndex = -1) { }

	[Address(RVA = "0x22187C0", Offset = "0x2217BC0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_Initialize>d__1))]
	[Token(Token = "0x6000CA4")]
	protected virtual IEnumerator _Initialize() { }

	[Address(RVA = "0x2218830", Offset = "0x2217C30", Length = "0x53F")]
	[Token(Token = "0x6000CAA")]
	public RankingStoryPresenter() { }

	[Address(RVA = "0x2216610", Offset = "0x2215A10", Length = "0x67")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000CAB")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x2218D70", Offset = "0x2218170", Length = "0x4D")]
	[Token(Token = "0x6000CA9")]
	protected virtual String[] get_RankingString() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CA5")]
	public static bool IsNew() { }

	[Address(RVA = "0x2218DC0", Offset = "0x22181C0", Length = "0x9A")]
	[Token(Token = "0x6000CA6")]
	protected virtual ID rankingTableId() { }

}

