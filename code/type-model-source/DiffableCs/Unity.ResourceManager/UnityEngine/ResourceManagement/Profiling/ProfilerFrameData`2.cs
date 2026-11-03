namespace UnityEngine.ResourceManagement.Profiling;

[DefaultMember("Item")]
[Token(Token = "0x2000078")]
internal class ProfilerFrameData
{
	[CompilerGenerated]
	[Token(Token = "0x2000079")]
	private sealed class <Enumerate>d__17 : IEnumerable<KeyValuePair`2<T1, T2>>, IEnumerable, IEnumerator<KeyValuePair`2<T1, T2>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000149")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014A")]
		private KeyValuePair<T1, T2> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014B")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014C")]
		public ProfilerFrameData<T1, T2> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014D")]
		private Enumerator<T1, T2> <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x1700007F")]
		private override KeyValuePair<T1, T2> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.Current
		{
			[Address(RVA = "0x11496A0", Offset = "0x1148AA0", Length = "0xAC")]
			[DebuggerHidden]
			[Token(Token = "0x60002A6")]
			private get { } //Length: 172
		}

		[Token(Token = "0x17000080")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1149810", Offset = "0x1148C10", Length = "0xAD")]
			[DebuggerHidden]
			[Token(Token = "0x60002A8")]
			private get { } //Length: 173
		}

		[Address(RVA = "0x113F950", Offset = "0x113ED50", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x60002A2")]
		public <Enumerate>d__17(int <>1__state) { }

		[Address(RVA = "0x16F3C30", Offset = "0x16F3030", Length = "0x12C")]
		[Token(Token = "0x60002A5")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x16F3590", Offset = "0x16F2990", Length = "0x4FD")]
		[Token(Token = "0x60002A4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x16F3A90", Offset = "0x16F2E90", Length = "0x170")]
		[DebuggerHidden]
		[Token(Token = "0x60002A9")]
		private override IEnumerator<KeyValuePair`2<T1, T2>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator() { }

		[Address(RVA = "0x11496A0", Offset = "0x1148AA0", Length = "0xAC")]
		[DebuggerHidden]
		[Token(Token = "0x60002A6")]
		private override KeyValuePair<T1, T2> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.get_Current() { }

		[Address(RVA = "0x16F3C10", Offset = "0x16F3010", Length = "0x18")]
		[DebuggerHidden]
		[Token(Token = "0x60002AA")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x1149810", Offset = "0x1148C10", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x60002A8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60002A7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x113F5E0", Offset = "0x113E9E0", Length = "0x95")]
		[DebuggerHidden]
		[Token(Token = "0x60002A3")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000145")]
	private Dictionary<T1, T2> m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000146")]
	private T2[] m_Array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000147")]
	private uint m_Version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000148")]
	private uint m_ArrayVersion; //Field offset: 0x0

	[Token(Token = "0x1700007C")]
	internal Dictionary<T1, T2> Data
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000297")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700007E")]
	public T2 Item
	{
		[Address(RVA = "0xE37470", Offset = "0xE36870", Length = "0x290")]
		[Token(Token = "0x600029D")]
		 get { } //Length: 656
		[Address(RVA = "0xE37830", Offset = "0xE36C30", Length = "0x464")]
		[Token(Token = "0x600029E")]
		 set { } //Length: 1124
	}

	[Token(Token = "0x1700007D")]
	public T2[] Values
	{
		[Address(RVA = "0xE37710", Offset = "0xE36B10", Length = "0x111")]
		[Token(Token = "0x600029C")]
		 get { } //Length: 273
	}

	[Address(RVA = "0xE373E0", Offset = "0xE367E0", Length = "0x83")]
	[Token(Token = "0x6000298")]
	public ProfilerFrameData`2() { }

	[Address(RVA = "0xE37350", Offset = "0xE36750", Length = "0x8C")]
	[Token(Token = "0x6000299")]
	public ProfilerFrameData`2(int count) { }

	[Address(RVA = "0xE36D80", Offset = "0xE36180", Length = "0x215")]
	[Token(Token = "0x600029A")]
	public bool Add(T1 key, T2 value) { }

	[Address(RVA = "0xE36FA0", Offset = "0xE363A0", Length = "0xE7")]
	[Token(Token = "0x60002A0")]
	public bool ContainsKey(T1 key) { }

	[Address(RVA = "0xE37090", Offset = "0xE36490", Length = "0xC5")]
	[IteratorStateMachine(typeof(<Enumerate>d__17))]
	[Token(Token = "0x60002A1")]
	public IEnumerable<KeyValuePair`2<T1, T2>> Enumerate() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000297")]
	internal Dictionary<T1, T2> get_Data() { }

	[Address(RVA = "0xE37470", Offset = "0xE36870", Length = "0x290")]
	[Token(Token = "0x600029D")]
	public T2 get_Item(T1 key) { }

	[Address(RVA = "0xE37710", Offset = "0xE36B10", Length = "0x111")]
	[Token(Token = "0x600029C")]
	public T2[] get_Values() { }

	[Address(RVA = "0xE37160", Offset = "0xE36560", Length = "0xFE")]
	[Token(Token = "0x600029B")]
	internal bool Remove(T1 key) { }

	[Address(RVA = "0xE37830", Offset = "0xE36C30", Length = "0x464")]
	[Token(Token = "0x600029E")]
	public void set_Item(T1 key, T2 value) { }

	[Address(RVA = "0xE37260", Offset = "0xE36660", Length = "0xEF")]
	[Token(Token = "0x600029F")]
	public bool TryGetValue(T1 key, out T2 value) { }

}

