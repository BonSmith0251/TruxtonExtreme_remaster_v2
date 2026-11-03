namespace UnityEngine.InputSystem;

[Extension]
[Token(Token = "0x200007D")]
public static class InputControlPath
{
	[CompilerGenerated]
	[Token(Token = "0x2000083")]
	private sealed class <>c
	{
		[Token(Token = "0x40002EC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002ED")]
		public static Func<Substring, String> <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x2944340", Offset = "0x2943740", Length = "0x67")]
		[Token(Token = "0x6000625")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000626")]
		public <>c() { }

		[Address(RVA = "0x29441B0", Offset = "0x29435B0", Length = "0x13")]
		[Token(Token = "0x6000627")]
		internal string <TryGetDeviceUsages>b__9_0(Substring x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000084")]
	private sealed class <Parse>d__34 : IEnumerable<ParsedPathComponent>, IEnumerable, IEnumerator<ParsedPathComponent>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002EE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002EF")]
		private ParsedPathComponent <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40002F0")]
		private int <>l__initialThreadId; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40002F1")]
		private string path; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40002F2")]
		public string <>3__path; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40002F3")]
		private PathParser <parser>5__2; //Field offset: 0x80

		[Token(Token = "0x170001A9")]
		private override ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.Current
		{
			[Address(RVA = "0xABF770", Offset = "0xABEB70", Length = "0x2B")]
			[DebuggerHidden]
			[Token(Token = "0x600062B")]
			private get { } //Length: 43
		}

		[Token(Token = "0x170001AA")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x29440F0", Offset = "0x29434F0", Length = "0x69")]
			[DebuggerHidden]
			[Token(Token = "0x600062D")]
			private get { } //Length: 105
		}

		[Address(RVA = "0x2944160", Offset = "0x2943560", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000628")]
		public <Parse>d__34(int <>1__state) { }

		[Address(RVA = "0x2943E30", Offset = "0x2943230", Length = "0x1DE")]
		[Token(Token = "0x600062A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2944010", Offset = "0x2943410", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600062E")]
		private override IEnumerator<ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator() { }

		[Address(RVA = "0xABF770", Offset = "0xABEB70", Length = "0x2B")]
		[DebuggerHidden]
		[Token(Token = "0x600062B")]
		private override ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current() { }

		[Address(RVA = "0x2944010", Offset = "0x2943410", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600062F")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x29440F0", Offset = "0x29434F0", Length = "0x69")]
		[DebuggerHidden]
		[Token(Token = "0x600062D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x29440B0", Offset = "0x29434B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600062C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000629")]
		private override void System.IDisposable.Dispose() { }

	}

	[Flags]
	[Token(Token = "0x200007E")]
	internal enum HumanReadableStringOptions : int
	{
		None = 0,
		OmitDevice = 2,
		UseShortNames = 4,
	}

	[Token(Token = "0x2000080")]
	internal struct ParsedPathComponent
	{
		[CompilerGenerated]
		[Token(Token = "0x2000081")]
		private sealed class <>c
		{
			[Token(Token = "0x40002E5")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40002E6")]
			public static Func<Substring, String> <>9__7_0; //Field offset: 0x8

			[Address(RVA = "0x2944260", Offset = "0x2943660", Length = "0x67")]
			[Token(Token = "0x600061E")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600061F")]
			public <>c() { }

			[Address(RVA = "0x29441B0", Offset = "0x29435B0", Length = "0x13")]
			[Token(Token = "0x6000620")]
			internal string <get_usages>b__7_0(Substring x) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E1")]
		internal Substring m_Layout; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002E2")]
		internal InlinedArray<Substring> m_Usages; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002E3")]
		internal Substring m_Name; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002E4")]
		internal Substring m_DisplayName; //Field offset: 0x40

		[Token(Token = "0x170001A5")]
		public string displayName
		{
			[Address(RVA = "0x29425F0", Offset = "0x29419F0", Length = "0xB")]
			[Token(Token = "0x6000617")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170001A7")]
		internal bool isDoubleWildcard
		{
			[Address(RVA = "0x2942600", Offset = "0x2941A00", Length = "0x6D")]
			[Token(Token = "0x6000619")]
			internal get { } //Length: 109
		}

		[Token(Token = "0x170001A6")]
		internal bool isWildcard
		{
			[Address(RVA = "0x2942670", Offset = "0x2941A70", Length = "0x6D")]
			[Token(Token = "0x6000618")]
			internal get { } //Length: 109
		}

		[Token(Token = "0x170001A2")]
		public string layout
		{
			[Address(RVA = "0x29426E0", Offset = "0x2941AE0", Length = "0x7")]
			[Token(Token = "0x6000614")]
			 get { } //Length: 7
		}

		[Token(Token = "0x170001A4")]
		public string name
		{
			[Address(RVA = "0x29426F0", Offset = "0x2941AF0", Length = "0xB")]
			[Token(Token = "0x6000616")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170001A3")]
		public IEnumerable<String> usages
		{
			[Address(RVA = "0x2942700", Offset = "0x2941B00", Length = "0x146")]
			[Token(Token = "0x6000615")]
			 get { } //Length: 326
		}

		[Address(RVA = "0x29416D0", Offset = "0x2940AD0", Length = "0x109")]
		[Token(Token = "0x600061D")]
		private static bool ComparePathElementToString(Substring pathElement, string element) { }

		[Address(RVA = "0x29425F0", Offset = "0x29419F0", Length = "0xB")]
		[Token(Token = "0x6000617")]
		public string get_displayName() { }

		[Address(RVA = "0x2942600", Offset = "0x2941A00", Length = "0x6D")]
		[Token(Token = "0x6000619")]
		internal bool get_isDoubleWildcard() { }

		[Address(RVA = "0x2942670", Offset = "0x2941A70", Length = "0x6D")]
		[Token(Token = "0x6000618")]
		internal bool get_isWildcard() { }

		[Address(RVA = "0x29426E0", Offset = "0x2941AE0", Length = "0x7")]
		[Token(Token = "0x6000614")]
		public string get_layout() { }

		[Address(RVA = "0x29426F0", Offset = "0x2941AF0", Length = "0xB")]
		[Token(Token = "0x6000616")]
		public string get_name() { }

		[Address(RVA = "0x2942700", Offset = "0x2941B00", Length = "0x146")]
		[Token(Token = "0x6000615")]
		public IEnumerable<String> get_usages() { }

		[Address(RVA = "0x29417E0", Offset = "0x2940BE0", Length = "0x3EC")]
		[Token(Token = "0x600061C")]
		public bool Matches(InputControl control) { }

		[Address(RVA = "0x2941C20", Offset = "0x2941020", Length = "0x9CE")]
		[Token(Token = "0x600061A")]
		internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options) { }

		[Address(RVA = "0x2941BD0", Offset = "0x2940FD0", Length = "0x4A")]
		[Token(Token = "0x600061B")]
		private static string ToHumanReadableString(Substring substring) { }

	}

	[Token(Token = "0x200007F")]
	private enum PathComponentType : int
	{
		Name = 0,
		DisplayName = 1,
		Usage = 2,
		Layout = 3,
	}

	[Token(Token = "0x2000082")]
	private struct PathParser
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E7")]
		private string path; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002E8")]
		private int length; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40002E9")]
		private int leftIndexInPath; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002EA")]
		private int rightIndexInPath; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002EB")]
		public ParsedPathComponent current; //Field offset: 0x18

		[Token(Token = "0x170001A8")]
		public bool isAtEnd
		{
			[Address(RVA = "0x2942EB0", Offset = "0x29422B0", Length = "0xA")]
			[Token(Token = "0x6000621")]
			 get { } //Length: 10
		}

		[Address(RVA = "0x2942E50", Offset = "0x2942250", Length = "0x50")]
		[Token(Token = "0x6000622")]
		public PathParser(string path) { }

		[Address(RVA = "0x2942EB0", Offset = "0x29422B0", Length = "0xA")]
		[Token(Token = "0x6000621")]
		public bool get_isAtEnd() { }

		[Address(RVA = "0x2942850", Offset = "0x2941C50", Length = "0x512")]
		[Token(Token = "0x6000623")]
		public bool MoveToNextComponent() { }

		[Address(RVA = "0x2942D70", Offset = "0x2942170", Length = "0xD0")]
		[Token(Token = "0x6000624")]
		private Substring ParseComponentPart(char terminator) { }

	}

	[Token(Token = "0x40002D4")]
	public const string Wildcard = "*"; //Field offset: 0x0
	[Token(Token = "0x40002D5")]
	public const string DoubleWildcard = "**"; //Field offset: 0x0
	[Token(Token = "0x40002D6")]
	public const char Separator = '\u2F'; //Field offset: 0x0
	[Token(Token = "0x40002D7")]
	internal const char SeparatorReplacement = '\u20'; //Field offset: 0x0

	[Address(RVA = "0x2933B70", Offset = "0x2932F70", Length = "0x25")]
	[Extension]
	[Token(Token = "0x60005F8")]
	internal static string CleanSlashes(string pathComponent) { }

	[Address(RVA = "0x2933BA0", Offset = "0x2932FA0", Length = "0xDE")]
	[Token(Token = "0x60005F9")]
	public static string Combine(InputControl parent, string path) { }

	[Address(RVA = "0x2933C80", Offset = "0x2933080", Length = "0x1C9")]
	[Token(Token = "0x6000601")]
	private static bool ControlLayoutMatchesPathComponent(ref ControlItem controlItem, ref PathParser parser) { }

	[Address(RVA = "0x2934240", Offset = "0x2933640", Length = "0x15A")]
	[Token(Token = "0x60005FF")]
	private static string FindControlLayoutRecursive(ref PathParser parser, string layoutName) { }

	[Address(RVA = "0x2933E50", Offset = "0x2933250", Length = "0x3EA")]
	[Token(Token = "0x6000600")]
	private static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout) { }

	[Address(RVA = "0x83C790", Offset = "0x83BB90", Length = "0x312")]
	[Token(Token = "0x600060F")]
	private static TControl MatchByUsageAtDeviceRootRecursive(InputDevice device, string path, int indexInPath, ref InputControlList<TControl>& matches, bool matchMultiple) { }

	[Address(RVA = "0x83CAB0", Offset = "0x83BEB0", Length = "0x154")]
	[Token(Token = "0x6000610")]
	private static TControl MatchChildrenRecursive(InputControl control, string path, int indexInPath, ref InputControlList<TControl>& matches, bool matchMultiple) { }

	[Address(RVA = "0x29343A0", Offset = "0x29337A0", Length = "0x38A")]
	[Token(Token = "0x600060B")]
	internal static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref ControlItem controlItem, bool matchAlias = false) { }

	[Address(RVA = "0x83CC10", Offset = "0x83C010", Length = "0x55E")]
	[Token(Token = "0x600060E")]
	private static TControl MatchControlsRecursive(InputControl control, string path, int indexInPath, ref InputControlList<TControl>& matches, bool matchMultiple) { }

	[Address(RVA = "0x2934B50", Offset = "0x2933F50", Length = "0x196")]
	[Token(Token = "0x600060A")]
	public static bool Matches(string expected, InputControl control) { }

	[Address(RVA = "0x2934910", Offset = "0x2933D10", Length = "0x1A5")]
	[Token(Token = "0x600060C")]
	public static bool MatchesPrefix(string expected, InputControl control) { }

	[Address(RVA = "0x2934AC0", Offset = "0x2933EC0", Length = "0x8B")]
	[Token(Token = "0x600060D")]
	private static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false) { }

	[Address(RVA = "0x2934730", Offset = "0x2933B30", Length = "0x1D4")]
	[Token(Token = "0x6000611")]
	private static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0) { }

	[Address(RVA = "0x2934CF0", Offset = "0x29340F0", Length = "0x71")]
	[IteratorStateMachine(typeof(<Parse>d__34))]
	[Token(Token = "0x6000613")]
	public static IEnumerable<ParsedPathComponent> Parse(string path) { }

	[Address(RVA = "0x2934D70", Offset = "0x2934170", Length = "0xC2")]
	[Token(Token = "0x6000612")]
	private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) { }

	[Address(RVA = "0x2934E40", Offset = "0x2934240", Length = "0x16B")]
	[Token(Token = "0x6000602")]
	private static bool StringMatches(Substring str, InternedString matchTo) { }

	[Address(RVA = "0x2934FF0", Offset = "0x29343F0", Length = "0x637")]
	[Token(Token = "0x60005FB")]
	public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = 0, InputControl control = null) { }

	[Address(RVA = "0x2934FB0", Offset = "0x29343B0", Length = "0x31")]
	[Token(Token = "0x60005FA")]
	public static string ToHumanReadableString(string path, HumanReadableStringOptions options = 0, InputControl control = null) { }

	[Address(RVA = "0x2935630", Offset = "0x2934A30", Length = "0x58")]
	[Token(Token = "0x6000608")]
	public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0) { }

	[Address(RVA = "0x83D170", Offset = "0x83C570", Length = "0x243")]
	[Token(Token = "0x6000609")]
	public static TControl TryFindChild(InputControl control, string path, int indexInPath = 0) { }

	[Address(RVA = "0x83D3C0", Offset = "0x83C7C0", Length = "0x102")]
	[Token(Token = "0x6000606")]
	public static TControl TryFindControl(InputControl control, string path, int indexInPath = 0) { }

	[Address(RVA = "0x2935690", Offset = "0x2934A90", Length = "0x58")]
	[Token(Token = "0x6000603")]
	public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0) { }

	[Address(RVA = "0x83D4D0", Offset = "0x83C8D0", Length = "0x120")]
	[Token(Token = "0x6000607")]
	public static int TryFindControls(InputControl control, string path, int indexInPath, ref InputControlList<TControl>& matches) { }

	[Address(RVA = "0x2935760", Offset = "0x2934B60", Length = "0x12A")]
	[Token(Token = "0x6000604")]
	public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0) { }

	[Address(RVA = "0x29356F0", Offset = "0x2934AF0", Length = "0x6D")]
	[Token(Token = "0x6000605")]
	public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl>& matches, int indexInPath = 0) { }

	[Address(RVA = "0x2935890", Offset = "0x2934C90", Length = "0x250")]
	[Token(Token = "0x60005FE")]
	public static string TryGetControlLayout(string path) { }

	[Address(RVA = "0x2935AF0", Offset = "0x2934EF0", Length = "0x15B")]
	[Token(Token = "0x60005FD")]
	public static string TryGetDeviceLayout(string path) { }

	[Address(RVA = "0x2935C50", Offset = "0x2935050", Length = "0x1EB")]
	[Token(Token = "0x60005FC")]
	public static String[] TryGetDeviceUsages(string path) { }

}

