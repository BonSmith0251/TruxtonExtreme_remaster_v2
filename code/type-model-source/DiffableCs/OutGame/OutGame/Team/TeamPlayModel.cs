namespace OutGame.Team;

[Token(Token = "0x2000092")]
public class TeamPlayModel : ModelGamePlayBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000093")]
	private sealed class <RequestNextStage>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000236")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000237")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000238")]
		public TeamPlayModel <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000239")]
		private InGameManager <gm>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400023A")]
		private PlayerInformation <pinfo>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400023B")]
		private StageInformation <stgInfo>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400023C")]
		private bool <isNext>5__5; //Field offset: 0x40

		[Token(Token = "0x170000E2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003B0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000E3")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003B2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003AD")]
		public <RequestNextStage>d__2(int <>1__state) { }

		[Address(RVA = "0x21DE910", Offset = "0x21DDD10", Length = "0x44")]
		[Token(Token = "0x60003AF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003B0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003B2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21DEEC0", Offset = "0x21DE2C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003B1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003AE")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000235")]
	private bool _isDouble; //Field offset: 0x78

	[Address(RVA = "0x21DA870", Offset = "0x21D9C70", Length = "0x63")]
	[Token(Token = "0x60003A4")]
	public TeamPlayModel(AssetReferenceTable stages) { }

	[Address(RVA = "0x21DA640", Offset = "0x21D9A40", Length = "0x76")]
	[Token(Token = "0x60003A8")]
	protected virtual long GetHighScore() { }

	[Address(RVA = "0x21DA6C0", Offset = "0x21D9AC0", Length = "0x83")]
	[Token(Token = "0x60003AA")]
	protected virtual bool IsSkipRequestMovie() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60003A9")]
	public virtual bool IsSkipTakeOffMovie() { }

	[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
	[Token(Token = "0x60003AC")]
	protected virtual bool IsTeamDouble() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60003AB")]
	protected virtual bool IsTeamMode() { }

	[Address(RVA = "0x21DA750", Offset = "0x21D9B50", Length = "0xA2")]
	[Token(Token = "0x60003A5")]
	public StageInformation PrepareResults(InGameManager gm, bool isComplete) { }

	[Address(RVA = "0x21DA800", Offset = "0x21D9C00", Length = "0x67")]
	[IteratorStateMachine(typeof(<RequestNextStage>d__2))]
	[Token(Token = "0x60003A6")]
	public IEnumerator RequestNextStage() { }

	[Address(RVA = "0x1D14EE0", Offset = "0x1D142E0", Length = "0x4")]
	[Token(Token = "0x60003A7")]
	public void SetDouble(bool isDouble) { }

}

