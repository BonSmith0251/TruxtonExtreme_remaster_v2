namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001A2")]
internal class QueryFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x20001A3")]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007BF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007C0")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007C1")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007C2")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007C3")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40007C4")]
		public QueryFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x40007C5")]
		private JToken root; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40007C6")]
		public JToken <>3__root; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x40007C7")]
		private JsonSelectSettings settings; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Nullable(0)]
		[Token(Token = "0x40007C8")]
		public JsonSelectSettings <>3__settings; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007C9")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007CA")]
		private IEnumerator<JToken> <>7__wrap2; //Field offset: 0x68

		[Token(Token = "0x17000244")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E6A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000245")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E6C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E65")]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[Address(RVA = "0x21A82B0", Offset = "0x21A76B0", Length = "0x50")]
		[Token(Token = "0x6000E68")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A8530", Offset = "0x21A7930", Length = "0x50")]
		[Token(Token = "0x6000E69")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x21A6500", Offset = "0x21A5900", Length = "0x335")]
		[Token(Token = "0x6000E67")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A74B0", Offset = "0x21A68B0", Length = "0xCF")]
		[DebuggerHidden]
		[Token(Token = "0x6000E6D")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E6A")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A74B0", Offset = "0x21A68B0", Length = "0xCF")]
		[DebuggerHidden]
		[Token(Token = "0x6000E6E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E6C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A7980", Offset = "0x21A6D80", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E6B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A7CE0", Offset = "0x21A70E0", Length = "0x14A")]
		[DebuggerHidden]
		[Token(Token = "0x6000E66")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007BE")]
	internal QueryExpression Expression; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000E63")]
	public QueryFilter(QueryExpression expression) { }

	[Address(RVA = "0x21A3780", Offset = "0x21A2B80", Length = "0xCA")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[Token(Token = "0x6000E64")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

