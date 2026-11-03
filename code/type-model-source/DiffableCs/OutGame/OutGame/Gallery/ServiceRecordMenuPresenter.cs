namespace OutGame.Gallery;

[Token(Token = "0x2000201")]
public class ServiceRecordMenuPresenter : PresenterBasic<Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x2000202")]
	private sealed class <_BeginView>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008C6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008C7")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008C8")]
		public ServiceRecordMenuPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170002DD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000CC6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002DE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000CC8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000CC3")]
		public <_BeginView>d__0(int <>1__state) { }

		[Address(RVA = "0x2227D70", Offset = "0x2227170", Length = "0x4BD")]
		[Token(Token = "0x6000CC5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000CC6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000CC8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2228230", Offset = "0x2227630", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000CC7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000CC4")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008BE")]
	private String[] _nextString; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40008BF")]
	private UITextMeshPro _playerLevel; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40008C0")]
	private UITextMeshPro _nextLevelString; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40008C1")]
	private UITextMeshPro _nextLevel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40008C2")]
	private UITextMeshPro _nextItem; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40008C3")]
	private ServiceRecordList _list; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008C4")]
	private long _nextLevelIndexMax; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008C5")]
	private long _nextLevelIndex; //Field offset: 0x80

	[Address(RVA = "0x2227110", Offset = "0x2226510", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__0))]
	[Token(Token = "0x6000CBB")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x2227180", Offset = "0x2226580", Length = "0x1F8")]
	[Token(Token = "0x6000CC1")]
	public ServiceRecordMenuPresenter() { }

	[Address(RVA = "0x2226F40", Offset = "0x2226340", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000CC2")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x2227380", Offset = "0x2226780", Length = "0x9ED")]
	[Token(Token = "0x6000CC0")]
	private void addList(string labelKey) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CBC")]
	public static bool IsNew() { }

	[Address(RVA = "0x2226D90", Offset = "0x2226190", Length = "0x1E")]
	[Token(Token = "0x6000CBF")]
	private void MoveList(int step) { }

	[Address(RVA = "0x2226DB0", Offset = "0x22261B0", Length = "0x182")]
	[Token(Token = "0x6000CBD")]
	protected virtual bool Select(AppGamePad pad) { }

	[Address(RVA = "0x2226F80", Offset = "0x2226380", Length = "0x18C")]
	[Token(Token = "0x6000CBE")]
	protected virtual void UpdateMenu(int next, bool seFlg = true) { }

}

