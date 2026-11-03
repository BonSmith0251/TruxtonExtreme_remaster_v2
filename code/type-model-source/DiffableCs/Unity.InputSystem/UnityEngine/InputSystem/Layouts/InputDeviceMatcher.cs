namespace UnityEngine.InputSystem.Layouts;

[Token(Token = "0x2000215")]
public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher>
{
	[CompilerGenerated]
	[Token(Token = "0x2000218")]
	private sealed class <>c
	{
		[Token(Token = "0x4000BF0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000BF1")]
		public static Func<Char, Boolean> <>9__12_0; //Field offset: 0x8

		[Address(RVA = "0x2920460", Offset = "0x291F860", Length = "0x67")]
		[Token(Token = "0x60013E6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60013E7")]
		public <>c() { }

		[Address(RVA = "0x2920400", Offset = "0x291F800", Length = "0x58")]
		[Token(Token = "0x60013E8")]
		internal bool <With>b__12_0(char ch) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000219")]
	private sealed class <get_patterns>d__4 : IEnumerable<KeyValuePair`2<String, Object>>, IEnumerable, IEnumerator<KeyValuePair`2<String, Object>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BF2")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BF3")]
		private KeyValuePair<String, Object> <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BF4")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BF5")]
		public InputDeviceMatcher <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BF6")]
		public InputDeviceMatcher <>3__<>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BF7")]
		private int <count>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000BF8")]
		private int <i>5__3; //Field offset: 0x44

		[Token(Token = "0x170005AC")]
		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x60013EC")]
			private get { } //Length: 11
		}

		[Token(Token = "0x170005AD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2920750", Offset = "0x291FB50", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x60013EE")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60013E9")]
		public <get_patterns>d__4(int <>1__state) { }

		[Address(RVA = "0x2920540", Offset = "0x291F940", Length = "0x12F")]
		[Token(Token = "0x60013EB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2920670", Offset = "0x291FA70", Length = "0x9E")]
		[DebuggerHidden]
		[Token(Token = "0x60013EF")]
		private override IEnumerator<KeyValuePair`2<String, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x60013EC")]
		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

		[Address(RVA = "0x2920670", Offset = "0x291FA70", Length = "0x9E")]
		[DebuggerHidden]
		[Token(Token = "0x60013F0")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2920750", Offset = "0x291FB50", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x60013EE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2920710", Offset = "0x291FB10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60013ED")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60013EA")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000216")]
	public struct MatcherJson
	{
		[Token(Token = "0x2000217")]
		internal struct Capability
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000BEE")]
			public string path; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000BEF")]
			public string value; //Field offset: 0x8

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE2")]
		public string interface; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BE3")]
		public String[] interfaces; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BE4")]
		public string deviceClass; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BE5")]
		public String[] deviceClasses; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE6")]
		public string manufacturer; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE7")]
		public string manufacturerContains; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BE8")]
		public String[] manufacturers; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BE9")]
		public string product; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BEA")]
		public String[] products; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BEB")]
		public string version; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BEC")]
		public String[] versions; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BED")]
		public Capability[] capabilities; //Field offset: 0x58

		[Address(RVA = "0x291D760", Offset = "0x291CB60", Length = "0x459")]
		[Token(Token = "0x60013E4")]
		public static MatcherJson FromMatcher(InputDeviceMatcher matcher) { }

		[Address(RVA = "0x291DBC0", Offset = "0x291CFC0", Length = "0x73D")]
		[Token(Token = "0x60013E5")]
		public InputDeviceMatcher ToMatcher() { }

	}

	[Token(Token = "0x4000BDC")]
	private static readonly InternedString kInterfaceKey; //Field offset: 0x0
	[Token(Token = "0x4000BDD")]
	private static readonly InternedString kDeviceClassKey; //Field offset: 0x10
	[Token(Token = "0x4000BDE")]
	private static readonly InternedString kManufacturerKey; //Field offset: 0x20
	[Token(Token = "0x4000BDF")]
	private static readonly InternedString kManufacturerContainsKey; //Field offset: 0x30
	[Token(Token = "0x4000BE0")]
	private static readonly InternedString kProductKey; //Field offset: 0x40
	[Token(Token = "0x4000BE1")]
	private static readonly InternedString kVersionKey; //Field offset: 0x50
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BDB")]
	private KeyValuePair<InternedString, Object>[] m_Patterns; //Field offset: 0x0

	[Token(Token = "0x170005AA")]
	public bool empty
	{
		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x60013CE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005AB")]
	public IEnumerable<KeyValuePair`2<String, Object>> patterns
	{
		[Address(RVA = "0x2919470", Offset = "0x2918870", Length = "0x73")]
		[IteratorStateMachine(typeof(<get_patterns>d__4))]
		[Token(Token = "0x60013CF")]
		 get { } //Length: 115
	}

	[Address(RVA = "0x2918E90", Offset = "0x2918290", Length = "0x5DD")]
	[Token(Token = "0x60013E3")]
	private static InputDeviceMatcher() { }

	[Address(RVA = "0x2917650", Offset = "0x2916A50", Length = "0x9D")]
	[Token(Token = "0x60013DF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x29176F0", Offset = "0x2916AF0", Length = "0x14B")]
	[Token(Token = "0x60013DE")]
	public override bool Equals(InputDeviceMatcher other) { }

	[Address(RVA = "0x2917840", Offset = "0x2916C40", Length = "0x610")]
	[Token(Token = "0x60013DC")]
	public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[Token(Token = "0x60013CE")]
	public bool get_empty() { }

	[Address(RVA = "0x2919470", Offset = "0x2918870", Length = "0x73")]
	[IteratorStateMachine(typeof(<get_patterns>d__4))]
	[Token(Token = "0x60013CF")]
	public IEnumerable<KeyValuePair`2<String, Object>> get_patterns() { }

	[Address(RVA = "0xABFB80", Offset = "0xABEF80", Length = "0x20")]
	[Token(Token = "0x60013E2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2917E50", Offset = "0x2917250", Length = "0x93")]
	[Token(Token = "0x60013DB")]
	private static int GetNumPropertiesIn(InputDeviceDescription description) { }

	[Address(RVA = "0x2917EF0", Offset = "0x29172F0", Length = "0x645")]
	[Token(Token = "0x60013D8")]
	public float MatchPercentage(InputDeviceDescription deviceDescription) { }

	[Address(RVA = "0x2918590", Offset = "0x2917990", Length = "0xB7")]
	[Token(Token = "0x60013D9")]
	private static bool MatchSingleProperty(object pattern, string value) { }

	[Address(RVA = "0x2918540", Offset = "0x2917940", Length = "0x47")]
	[Token(Token = "0x60013DA")]
	private static bool MatchSinglePropertyContains(object pattern, string value) { }

	[Address(RVA = "0x29194F0", Offset = "0x29188F0", Length = "0x54")]
	[Token(Token = "0x60013E0")]
	public static bool op_Equality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	[Address(RVA = "0x2919550", Offset = "0x2918950", Length = "0x94")]
	[Token(Token = "0x60013E1")]
	public static bool op_Inequality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	[Address(RVA = "0x2918650", Offset = "0x2917A50", Length = "0x194")]
	[Token(Token = "0x60013DD")]
	public virtual string ToString() { }

	[Address(RVA = "0x2918C50", Offset = "0x2918050", Length = "0x234")]
	[Token(Token = "0x60013D7")]
	private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true) { }

	[Address(RVA = "0x842FD0", Offset = "0x8423D0", Length = "0xC3")]
	[Token(Token = "0x60013D6")]
	public InputDeviceMatcher WithCapability(string path, TValue value) { }

	[Address(RVA = "0x29187F0", Offset = "0x2917BF0", Length = "0x91")]
	[Token(Token = "0x60013D1")]
	public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true) { }

	[Address(RVA = "0x2918890", Offset = "0x2917C90", Length = "0x90")]
	[Token(Token = "0x60013D0")]
	public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true) { }

	[Address(RVA = "0x2918A70", Offset = "0x2917E70", Length = "0x91")]
	[Token(Token = "0x60013D2")]
	public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true) { }

	[Address(RVA = "0x2918920", Offset = "0x2917D20", Length = "0x142")]
	[Token(Token = "0x60013D3")]
	public InputDeviceMatcher WithManufacturerContains(string noRegExPattern) { }

	[Address(RVA = "0x2918B10", Offset = "0x2917F10", Length = "0x91")]
	[Token(Token = "0x60013D4")]
	public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true) { }

	[Address(RVA = "0x2918BB0", Offset = "0x2917FB0", Length = "0x91")]
	[Token(Token = "0x60013D5")]
	public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true) { }

}

