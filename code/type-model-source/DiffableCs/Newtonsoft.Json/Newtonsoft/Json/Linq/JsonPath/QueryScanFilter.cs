namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001A4")]
internal class QueryScanFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x20001A5")]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007CC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007CD")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007CE")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007CF")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007D0")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40007D1")]
		public QueryScanFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x40007D2")]
		private JToken root; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40007D3")]
		public JToken <>3__root; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x40007D4")]
		private JsonSelectSettings settings; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Nullable(0)]
		[Token(Token = "0x40007D5")]
		public JsonSelectSettings <>3__settings; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007D6")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007D7")]
		private IEnumerator<JToken> <>7__wrap2; //Field offset: 0x68

		[Token(Token = "0x17000246")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E76")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000247")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E78")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E71")]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[Address(RVA = "0x21A8350", Offset = "0x21A7750", Length = "0x50")]
		[Token(Token = "0x6000E74")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A8580", Offset = "0x21A7980", Length = "0x50")]
		[Token(Token = "0x6000E75")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x21A60E0", Offset = "0x21A54E0", Length = "0x416")]
		[Token(Token = "0x6000E73")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A77B0", Offset = "0x21A6BB0", Length = "0xCF")]
		[DebuggerHidden]
		[Token(Token = "0x6000E79")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E76")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A77B0", Offset = "0x21A6BB0", Length = "0xCF")]
		[DebuggerHidden]
		[Token(Token = "0x6000E7A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E78")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A7900", Offset = "0x21A6D00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E77")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A7F80", Offset = "0x21A7380", Length = "0x14D")]
		[DebuggerHidden]
		[Token(Token = "0x6000E72")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007CB")]
	internal QueryExpression Expression; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000E6F")]
	public QueryScanFilter(QueryExpression expression) { }

	[Address(RVA = "0x21A3850", Offset = "0x21A2C50", Length = "0xCA")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[Token(Token = "0x6000E70")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

