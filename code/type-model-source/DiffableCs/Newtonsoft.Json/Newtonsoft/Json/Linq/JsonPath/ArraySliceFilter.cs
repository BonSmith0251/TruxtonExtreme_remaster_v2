namespace Newtonsoft.Json.Linq.JsonPath;

[Token(Token = "0x2000195")]
internal class ArraySliceFilter : PathFilter
{
	[CompilerGenerated]
	[Token(Token = "0x2000196")]
	private sealed class <ExecuteFilter>d__12 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000780")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(1)]
		[Token(Token = "0x4000781")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000782")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000783")]
		public ArraySliceFilter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000784")]
		private IEnumerable<JToken> current; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000785")]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000786")]
		private JsonSelectSettings settings; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000787")]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000788")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000789")]
		private JArray <a>5__3; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400078A")]
		private int <stepCount>5__4; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400078B")]
		private int <stopIndex>5__5; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400078C")]
		private bool <positiveStep>5__6; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400078D")]
		private int <i>5__7; //Field offset: 0x6C

		[Token(Token = "0x1700023C")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E1A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700023D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000E1C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E16")]
		public <ExecuteFilter>d__12(int <>1__state) { }

		[Address(RVA = "0x21A5260", Offset = "0x21A4660", Length = "0x50")]
		[Token(Token = "0x6000E19")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21A4790", Offset = "0x21A3B90", Length = "0x93D")]
		[Token(Token = "0x6000E18")]
		private override bool MoveNext() { }

		[Address(RVA = "0x21A50D0", Offset = "0x21A44D0", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E1D")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E1A")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x21A50D0", Offset = "0x21A44D0", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x6000E1E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000E1C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21A5190", Offset = "0x21A4590", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000E1B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21A51D0", Offset = "0x21A45D0", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x6000E17")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400077D")]
	private Nullable<Int32> <Start>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400077E")]
	private Nullable<Int32> <End>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400077F")]
	private Nullable<Int32> <Step>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700023A")]
	public Nullable<Int32> End
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E0F")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E10")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000239")]
	public Nullable<Int32> Start
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E0D")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E0E")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700023B")]
	public Nullable<Int32> Step
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E11")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E12")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000E15")]
	public ArraySliceFilter() { }

	[Address(RVA = "0x218EFE0", Offset = "0x218E3E0", Length = "0xAB")]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__12))]
	[NullableContext(1)]
	[Token(Token = "0x6000E13")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E0F")]
	public Nullable<Int32> get_End() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E0D")]
	public Nullable<Int32> get_Start() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E11")]
	public Nullable<Int32> get_Step() { }

	[Address(RVA = "0x218F090", Offset = "0x218E490", Length = "0x13")]
	[Token(Token = "0x6000E14")]
	private bool IsValid(int index, int stopIndex, bool positiveStep) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E10")]
	public void set_End(Nullable<Int32> value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E0E")]
	public void set_Start(Nullable<Int32> value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E12")]
	public void set_Step(Nullable<Int32> value) { }

}

