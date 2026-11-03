namespace OutGame.Gallery;

[Token(Token = "0x20001D8")]
public class AchievementMenuPresenter : PresenterBasic<Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20001D9")]
	private sealed class <_BeginView>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000826")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000827")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000828")]
		public AchievementMenuPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170002A3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BDA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002A4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BDC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000BD7")]
		public <_BeginView>d__0(int <>1__state) { }

		[Address(RVA = "0x221DF90", Offset = "0x221D390", Length = "0x48A")]
		[Token(Token = "0x6000BD9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BDA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BDC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x221E420", Offset = "0x221D820", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BDB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BD8")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000823")]
	private UITextMeshPro _rateValueText; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000824")]
	private UITextMeshPro _acquiredValueText; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000825")]
	private AchievementList _list; //Field offset: 0x58

	[Address(RVA = "0x2211080", Offset = "0x2210480", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__0))]
	[Token(Token = "0x6000BD1")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x22110F0", Offset = "0x22104F0", Length = "0x39")]
	[Token(Token = "0x6000BD5")]
	public AchievementMenuPresenter() { }

	[Address(RVA = "0x2211040", Offset = "0x2210440", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000BD6")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BD2")]
	public static bool IsNew() { }

	[Address(RVA = "0x2210F50", Offset = "0x2210350", Length = "0x1E")]
	[Token(Token = "0x6000BD4")]
	private void MoveList(int step) { }

	[Address(RVA = "0x2210F70", Offset = "0x2210370", Length = "0xC8")]
	[Token(Token = "0x6000BD3")]
	protected virtual bool Select(AppGamePad pad) { }

}

