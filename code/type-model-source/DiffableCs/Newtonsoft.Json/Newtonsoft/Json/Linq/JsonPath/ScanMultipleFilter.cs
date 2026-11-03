namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001A9")]
internal class ScanMultipleFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x20001AA")]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007E4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007E5")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007E6")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007E7")]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007E8")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40007E9")]
		public ScanMultipleFilter <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007EA")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40007EB")]
		private JToken <c>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x40007EC")]
		private JToken <value>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Nullable(0)]
		[Token(Token = "0x40007ED")]
		private JProperty <property>5__5; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40007EE")]
		private Enumerator<String> <>7__wrap5; //Field offset: 0x60

		[Token(Token = "0x1700024A")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E90")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700024B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E92")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E8B")]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[Address(RVA = "0x21A8300", Offset = "0x21A7700", Length = "0x50")]
		[Token(Token = "0x6000E8E")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A8620", Offset = "0x21A7A20", Length = "0x41")]
		[Token(Token = "0x6000E8F")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x21A6E50", Offset = "0x21A6250", Length = "0x4ED")]
		[Token(Token = "0x6000E8D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A7340", Offset = "0x21A6740", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000E93")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E90")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A7340", Offset = "0x21A6740", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000E94")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E92")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A78C0", Offset = "0x21A6CC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E91")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A7A40", Offset = "0x21A6E40", Length = "0x143")]
		[DebuggerHidden]
		[Token(Token = "0x6000E8C")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007E3")]
	private List<String> _names; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000E89")]
	public ScanMultipleFilter(List<String> names) { }

	[Address(RVA = "0x21A4700", Offset = "0x21A3B00", Length = "0x8E")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[Token(Token = "0x6000E8A")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

