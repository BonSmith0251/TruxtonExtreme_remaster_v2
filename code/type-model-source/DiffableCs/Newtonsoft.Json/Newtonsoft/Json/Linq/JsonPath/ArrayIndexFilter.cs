namespace Newtonsoft.Json.Linq.JsonPath;

[Token(Token = "0x2000191")]
internal class ArrayIndexFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x2000192")]
	private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000767")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(1)]
		[Token(Token = "0x4000768")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000769")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x400076A")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x400076B")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400076C")]
		public ArrayIndexFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400076D")]
		private JsonSelectSettings settings; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400076E")]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x400076F")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000770")]
		private IEnumerator<JToken> <>7__wrap2; //Field offset: 0x58

		[Token(Token = "0x17000235")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000DFC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000236")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000DFE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000DF7")]
		public <ExecuteFilter>d__4(int <>1__state) { }

		[Address(RVA = "0x21A8DD0", Offset = "0x21A81D0", Length = "0x50")]
		[Token(Token = "0x6000DFA")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A8E20", Offset = "0x21A8220", Length = "0x50")]
		[Token(Token = "0x6000DFB")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x21A86C0", Offset = "0x21A7AC0", Length = "0x4B4")]
		[Token(Token = "0x6000DF9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A8B80", Offset = "0x21A7F80", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000DFF")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000DFC")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A8B80", Offset = "0x21A7F80", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E00")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000DFE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A8C40", Offset = "0x21A8040", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000DFD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A8C80", Offset = "0x21A8080", Length = "0x14D")]
		[DebuggerHidden]
		[Token(Token = "0x6000DF8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000766")]
	private Nullable<Int32> <Index>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000234")]
	public Nullable<Int32> Index
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DF3")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DF4")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000DF6")]
	public ArrayIndexFilter() { }

	[Address(RVA = "0x218EE80", Offset = "0x218E280", Length = "0xAB")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__4))]
	[NullableContext(1)]
	[Token(Token = "0x6000DF5")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DF3")]
	public Nullable<Int32> get_Index() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DF4")]
	public void set_Index(Nullable<Int32> value) { }

}

