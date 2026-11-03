namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001A7")]
internal class ScanFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x20001A8")]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007DA")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(1)]
		[Token(Token = "0x40007DB")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007DC")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007DD")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007DE")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40007DF")]
		public ScanFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007E0")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40007E1")]
		private JToken <c>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x40007E2")]
		private JToken <value>5__4; //Field offset: 0x50

		[Token(Token = "0x17000248")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E84")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000249")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E86")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E80")]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[Address(RVA = "0x21A8490", Offset = "0x21A7890", Length = "0x50")]
		[Token(Token = "0x6000E83")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A5D10", Offset = "0x21A5110", Length = "0x3CB")]
		[Token(Token = "0x6000E82")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A7580", Offset = "0x21A6980", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000E87")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E84")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A7580", Offset = "0x21A6980", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000E88")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E86")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A7A00", Offset = "0x21A6E00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E85")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A80D0", Offset = "0x21A74D0", Length = "0x8E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E81")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007D9")]
	internal string Name; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000E7E")]
	public ScanFilter(string name) { }

	[Address(RVA = "0x21A4670", Offset = "0x21A3A70", Length = "0x8E")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[NullableContext(1)]
	[Token(Token = "0x6000E7F")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

