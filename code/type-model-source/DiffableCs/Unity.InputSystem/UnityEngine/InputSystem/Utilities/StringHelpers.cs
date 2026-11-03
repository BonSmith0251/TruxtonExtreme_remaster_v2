namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x200026B")]
internal static class StringHelpers
{
	[CompilerGenerated]
	[Token(Token = "0x200026C")]
	private sealed class <Split>d__9 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CE4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CE5")]
		private string <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CE6")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000CE7")]
		private string str; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000CE8")]
		public string <>3__str; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000CE9")]
		private Func<Char, Boolean> predicate; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000CEA")]
		public Func<Char, Boolean> <>3__predicate; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000CEB")]
		private int <length>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000CEC")]
		private int <position>5__3; //Field offset: 0x4C

		[Token(Token = "0x1700060E")]
		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600168C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700060F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600168E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6001689")]
		public <Split>d__9(int <>1__state) { }

		[Address(RVA = "0x292AAC0", Offset = "0x2929EC0", Length = "0x141")]
		[Token(Token = "0x600168B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x292AC10", Offset = "0x292A010", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x600168F")]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600168C")]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[Address(RVA = "0x292AC10", Offset = "0x292A010", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6001690")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600168E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x292ACC0", Offset = "0x292A0C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600168D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600168A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200026D")]
	private sealed class <Tokenize>d__8 : IEnumerable<Substring>, IEnumerable, IEnumerator<Substring>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CED")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CEE")]
		private Substring <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000CEF")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000CF0")]
		private string str; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000CF1")]
		public string <>3__str; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000CF2")]
		private int <length>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000CF3")]
		private int <endPos>5__3; //Field offset: 0x44

		[Token(Token = "0x17000610")]
		private override Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6001694")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000611")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x292B030", Offset = "0x292A430", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x6001696")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6001691")]
		public <Tokenize>d__8(int <>1__state) { }

		[Address(RVA = "0x292AD00", Offset = "0x292A100", Length = "0x24B")]
		[Token(Token = "0x6001693")]
		private override bool MoveNext() { }

		[Address(RVA = "0x292AF50", Offset = "0x292A350", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6001697")]
		private override IEnumerator<Substring> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>.GetEnumerator() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6001694")]
		private override Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.get_Current() { }

		[Address(RVA = "0x292AF50", Offset = "0x292A350", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6001698")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x292B030", Offset = "0x292A430", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x6001696")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x292AFF0", Offset = "0x292A3F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6001695")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6001692")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x2927950", Offset = "0x2926D50", Length = "0x269")]
	[Token(Token = "0x600167F")]
	public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator) { }

	[Address(RVA = "0x2927BF0", Offset = "0x2926FF0", Length = "0x23")]
	[Extension]
	[Token(Token = "0x6001674")]
	public static bool Contains(string str, char ch) { }

	[Address(RVA = "0x2927BC0", Offset = "0x2926FC0", Length = "0x23")]
	[Extension]
	[Token(Token = "0x6001675")]
	public static bool Contains(string str, string text, StringComparison comparison) { }

	[Address(RVA = "0x2927C20", Offset = "0x2927020", Length = "0x65")]
	[Extension]
	[Token(Token = "0x6001679")]
	public static int CountOccurrences(string str, char ch) { }

	[Address(RVA = "0x2927C90", Offset = "0x2927090", Length = "0x15F")]
	[Extension]
	[Token(Token = "0x6001672")]
	public static string Escape(string str, string chars = "
	\"", string replacements = "ntr\"") { }

	[Address(RVA = "0x2927DF0", Offset = "0x29271F0", Length = "0x1F6")]
	[Token(Token = "0x6001688")]
	public static string ExpandTemplateString(string template, Func<String, String> mapFunc) { }

	[Address(RVA = "0x2927FF0", Offset = "0x29273F0", Length = "0x18E")]
	[Token(Token = "0x6001678")]
	public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1) { }

	[Address(RVA = "0x2928180", Offset = "0x2927580", Length = "0x179")]
	[Extension]
	[Token(Token = "0x6001676")]
	public static string GetPlural(string str) { }

	[Address(RVA = "0x2928300", Offset = "0x2927700", Length = "0x4D")]
	[Extension]
	[Token(Token = "0x6001687")]
	public static bool InvariantEqualsIgnoreCase(string left, string right) { }

	[Address(RVA = "0x2928350", Offset = "0x2927750", Length = "0x5B")]
	[Extension]
	[Token(Token = "0x6001685")]
	public static bool IsPrintable(char ch) { }

	[Address(RVA = "0x914F70", Offset = "0x914370", Length = "0x325")]
	[Token(Token = "0x600167D")]
	public static string Join(IEnumerable<TValue> values, string separator) { }

	[Address(RVA = "0x9152A0", Offset = "0x9146A0", Length = "0x49")]
	[Token(Token = "0x600167C")]
	public static string Join(string separator, TValue[] values) { }

	[Address(RVA = "0x915B80", Offset = "0x914F80", Length = "0x381")]
	[Token(Token = "0x600167E")]
	public static string MakeUniqueName(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, String> getNameFunc) { }

	[Address(RVA = "0x29283B0", Offset = "0x29277B0", Length = "0x188")]
	[Token(Token = "0x6001677")]
	public static string NicifyMemorySize(long numBytes) { }

	[Address(RVA = "0x2928540", Offset = "0x2927940", Length = "0x80")]
	[Token(Token = "0x6001680")]
	public static int ParseInt(string str, int pos) { }

	[Address(RVA = "0x29286E0", Offset = "0x2927AE0", Length = "0xE9")]
	[Token(Token = "0x6001683")]
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize) { }

	[Address(RVA = "0x29285D0", Offset = "0x29279D0", Length = "0x100")]
	[Token(Token = "0x6001684")]
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset) { }

	[Address(RVA = "0x29287D0", Offset = "0x2927BD0", Length = "0x8E")]
	[Extension]
	[IteratorStateMachine(typeof(<Split>d__9))]
	[Token(Token = "0x600167B")]
	public static IEnumerable<String> Split(string str, Func<Char, Boolean> predicate) { }

	[Address(RVA = "0x2928860", Offset = "0x2927C60", Length = "0x71")]
	[Extension]
	[IteratorStateMachine(typeof(<Tokenize>d__8))]
	[Token(Token = "0x600167A")]
	public static IEnumerable<Substring> Tokenize(string str) { }

	[Address(RVA = "0x29288E0", Offset = "0x2927CE0", Length = "0x154")]
	[Extension]
	[Token(Token = "0x6001673")]
	public static string Unescape(string str, string chars = "ntr\"", string replacements = "
	\"") { }

	[Address(RVA = "0x2928A40", Offset = "0x2927E40", Length = "0xE6")]
	[Extension]
	[Token(Token = "0x6001686")]
	public static string WithAllWhitespaceStripped(string str) { }

	[Address(RVA = "0x2928CE0", Offset = "0x29280E0", Length = "0x1E")]
	[Token(Token = "0x6001681")]
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) { }

	[Address(RVA = "0x2928B30", Offset = "0x2927F30", Length = "0x1A3")]
	[Token(Token = "0x6001682")]
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset) { }

}

