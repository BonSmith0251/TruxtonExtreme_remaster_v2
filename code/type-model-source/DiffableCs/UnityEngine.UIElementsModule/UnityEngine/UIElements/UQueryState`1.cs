namespace UnityEngine.UIElements;

[Token(Token = "0x20004D8")]
public struct UQueryState : IEnumerable<T>, IEnumerable, IEquatable<UQueryState`1<T>>
{
	[Token(Token = "0x20004DA")]
	private class ActionQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001058")]
		private Action<T> <callBack>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170009B6")]
		internal Action<T> callBack
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60024E0")]
			internal get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60024E1")]
			internal set { } //Length: 13
		}

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x60024E3")]
		public ActionQueryMatcher() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60024E0")]
		internal Action<T> get_callBack() { }

		[Address(RVA = "0x1B5CE00", Offset = "0x1B5C200", Length = "0x6D")]
		[Token(Token = "0x60024E2")]
		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60024E1")]
		internal void set_callBack(Action<T> value) { }

	}

	[Token(Token = "0x20004DB")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001059")]
		private List<VisualElement> iterationList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400105A")]
		private int currentIndex; //Field offset: 0x0

		[Token(Token = "0x170009B7")]
		public override T Current
		{
			[Address(RVA = "0x1991AE0", Offset = "0x1990EE0", Length = "0xB9")]
			[Token(Token = "0x60024E5")]
			 get { } //Length: 185
		}

		[Token(Token = "0x170009B8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1990D50", Offset = "0x1990150", Length = "0x36")]
			[Token(Token = "0x60024E6")]
			private get { } //Length: 54
		}

		[Address(RVA = "0x1991550", Offset = "0x1990950", Length = "0x207")]
		[Token(Token = "0x60024E4")]
		internal Enumerator(UQueryState<T> queryState) { }

		[Address(RVA = "0x198B8A0", Offset = "0x198ACA0", Length = "0x66")]
		[Token(Token = "0x60024E9")]
		public override void Dispose() { }

		[Address(RVA = "0x1991AE0", Offset = "0x1990EE0", Length = "0xB9")]
		[Token(Token = "0x60024E5")]
		public override T get_Current() { }

		[Address(RVA = "0x198E210", Offset = "0x198D610", Length = "0x46")]
		[Token(Token = "0x60024E7")]
		public override bool MoveNext() { }

		[Address(RVA = "0xABED80", Offset = "0xABE180", Length = "0x8")]
		[Token(Token = "0x60024E8")]
		public override void Reset() { }

		[Address(RVA = "0x1990D50", Offset = "0x1990150", Length = "0x36")]
		[Token(Token = "0x60024E6")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x20004D9")]
	private class ListQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001057")]
		private List<TElement> <matches>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170009B5")]
		public List<TElement> matches
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60024DB")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60024DC")]
			 set { } //Length: 13
		}

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x60024DF")]
		public ListQueryMatcher`1() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60024DB")]
		public List<TElement> get_matches() { }

		[Address(RVA = "0xB0D510", Offset = "0xB0C910", Length = "0xCF")]
		[Token(Token = "0x60024DD")]
		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		[Address(RVA = "0xB0D5E0", Offset = "0xB0C9E0", Length = "0x13")]
		[Token(Token = "0x60024DE")]
		public void Reset() { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60024DC")]
		public void set_matches(List<TElement> value) { }

	}

	[Token(Token = "0x4001052")]
	private static ActionQueryMatcher<T> s_Action; //Field offset: 0x0
	[Token(Token = "0x4001055")]
	private static readonly ListQueryMatcher<T, T> s_List; //Field offset: 0x0
	[Token(Token = "0x4001056")]
	private static readonly ListQueryMatcher<T, VisualElement> s_EnumerationList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001053")]
	private readonly VisualElement m_Element; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001054")]
	internal readonly List<RuleMatcher> m_Matchers; //Field offset: 0x0

	[Address(RVA = "0x11190E0", Offset = "0x11184E0", Length = "0x2C7")]
	[Token(Token = "0x60024DA")]
	private static UQueryState`1() { }

	[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
	[Token(Token = "0x60024CD")]
	internal UQueryState`1(VisualElement element, List<RuleMatcher> matchers) { }

	[Address(RVA = "0x1118550", Offset = "0x1117950", Length = "0x8E")]
	[Token(Token = "0x60024D7")]
	public override bool Equals(UQueryState<T> other) { }

	[Address(RVA = "0x11185E0", Offset = "0x11179E0", Length = "0x1A4")]
	[Token(Token = "0x60024D8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1118790", Offset = "0x1117B90", Length = "0xD6")]
	[Token(Token = "0x60024D0")]
	public T First() { }

	[Address(RVA = "0x1118870", Offset = "0x1117C70", Length = "0x232")]
	[Token(Token = "0x60024D3")]
	public void ForEach(Action<T> funcCall) { }

	[Address(RVA = "0x1118AB0", Offset = "0x1117EB0", Length = "0x5B")]
	[Token(Token = "0x60024D4")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1118B10", Offset = "0x1117F10", Length = "0xAE")]
	[Token(Token = "0x60024D9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1118BC0", Offset = "0x1117FC0", Length = "0x75")]
	[Token(Token = "0x60024CE")]
	public UQueryState<T> RebuildOn(VisualElement element) { }

	[Address(RVA = "0x1118C40", Offset = "0x1118040", Length = "0xDC")]
	[Token(Token = "0x60024CF")]
	private T Single(SingleQueryMatcher matcher) { }

	[Address(RVA = "0x1118D20", Offset = "0x1118120", Length = "0x105")]
	[Token(Token = "0x60024D5")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0x1118D20", Offset = "0x1118120", Length = "0x105")]
	[Token(Token = "0x60024D6")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1118F30", Offset = "0x1118330", Length = "0x1A9")]
	[Token(Token = "0x60024D1")]
	public void ToList(List<T> results) { }

	[Address(RVA = "0x1118E30", Offset = "0x1118230", Length = "0xF9")]
	[Token(Token = "0x60024D2")]
	public List<T> ToList() { }

}

