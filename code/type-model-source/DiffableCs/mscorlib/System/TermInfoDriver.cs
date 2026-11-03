namespace System;

[Token(Token = "0x20001C8")]
internal class TermInfoDriver : IConsoleDriver
{
	[Token(Token = "0x4000724")]
	private static Int32* native_terminal_size; //Field offset: 0x0
	[Token(Token = "0x4000725")]
	private static int terminal_size; //Field offset: 0x8
	[Token(Token = "0x4000726")]
	private static readonly String[] locations; //Field offset: 0x10
	[Token(Token = "0x400074D")]
	private static readonly Int32[] _consoleColorToAnsiCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000727")]
	private TermInfoReader reader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000728")]
	private int cursorLeft; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000729")]
	private int cursorTop; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400072A")]
	private string title; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400072B")]
	private string titleFormat; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400072C")]
	private bool cursorVisible; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400072D")]
	private string csrVisible; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400072E")]
	private string csrInvisible; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400072F")]
	private string clear; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000730")]
	private string bell; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000731")]
	private string term; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000732")]
	private StreamReader stdin; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000733")]
	private CStreamWriter stdout; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000734")]
	private int windowWidth; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000735")]
	private int windowHeight; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000736")]
	private int bufferHeight; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000737")]
	private int bufferWidth; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000738")]
	private Char[] buffer; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000739")]
	private int readpos; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400073A")]
	private int writepos; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400073B")]
	private string keypadXmit; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400073C")]
	private string keypadLocal; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400073D")]
	private bool inited; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400073E")]
	private object initLock; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400073F")]
	private bool initKeys; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000740")]
	private string origPair; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000741")]
	private string origColors; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000742")]
	private string cursorAddress; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000743")]
	private ConsoleColor fgcolor; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000744")]
	private string setfgcolor; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000745")]
	private string setbgcolor; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000746")]
	private int maxColors; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000747")]
	private bool noGetPosition; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000748")]
	private Hashtable keymap; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000749")]
	private ByteMatcher rootmap; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400074A")]
	private int rl_startx; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400074B")]
	private int rl_starty; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400074C")]
	private Byte[] control_characters; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400074E")]
	private Char[] echobuf; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400074F")]
	private int echon; //Field offset: 0x118

	[Token(Token = "0x17000169")]
	public override bool Initialized
	{
		[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
		[Token(Token = "0x6001045")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700016A")]
	public override int WindowHeight
	{
		[Address(RVA = "0x208F6F0", Offset = "0x208EAF0", Length = "0x2C")]
		[Token(Token = "0x600104E")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700016B")]
	public override int WindowWidth
	{
		[Address(RVA = "0x208F720", Offset = "0x208EB20", Length = "0x2C")]
		[Token(Token = "0x600104F")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x208EDD0", Offset = "0x208E1D0", Length = "0x199")]
	[Token(Token = "0x6001062")]
	private static TermInfoDriver() { }

	[Address(RVA = "0x208EF70", Offset = "0x208E370", Length = "0x767")]
	[Token(Token = "0x6001044")]
	public TermInfoDriver(string term) { }

	[Address(RVA = "0x20895A0", Offset = "0x20889A0", Length = "0x195")]
	[Token(Token = "0x6001061")]
	private void AddStringMapping(TermInfoStrings s) { }

	[Address(RVA = "0x2089740", Offset = "0x2088B40", Length = "0x107")]
	[Token(Token = "0x6001050")]
	private void AddToBuffer(int b) { }

	[Address(RVA = "0x2089850", Offset = "0x2088C50", Length = "0x18")]
	[Token(Token = "0x6001051")]
	private void AdjustBuffer() { }

	[Address(RVA = "0x2089870", Offset = "0x2088C70", Length = "0x159")]
	[Token(Token = "0x600104D")]
	private void CheckWindowDimensions() { }

	[Address(RVA = "0x20899D0", Offset = "0x2088DD0", Length = "0x11C")]
	[Token(Token = "0x6001052")]
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	[Address(RVA = "0x2089B20", Offset = "0x2088F20", Length = "0x2817")]
	[Token(Token = "0x600105F")]
	private void CreateKeyMap() { }

	[Address(RVA = "0x208C390", Offset = "0x208B790", Length = "0x192")]
	[Token(Token = "0x6001057")]
	private void Echo(ConsoleKeyInfo key) { }

	[Address(RVA = "0x208C340", Offset = "0x208B740", Length = "0x46")]
	[Token(Token = "0x6001058")]
	private void EchoFlush() { }

	[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
	[Token(Token = "0x6001045")]
	public override bool get_Initialized() { }

	[Address(RVA = "0x208F6F0", Offset = "0x208EAF0", Length = "0x2C")]
	[Token(Token = "0x600104E")]
	public override int get_WindowHeight() { }

	[Address(RVA = "0x208F720", Offset = "0x208EB20", Length = "0x2C")]
	[Token(Token = "0x600104F")]
	public override int get_WindowWidth() { }

	[Address(RVA = "0x208C530", Offset = "0x208B930", Length = "0x2DC")]
	[Token(Token = "0x600104C")]
	private void GetCursorPosition() { }

	[Address(RVA = "0x208C810", Offset = "0x208BC10", Length = "0x3FC")]
	[Token(Token = "0x6001053")]
	private object GetKeyFromBuffer(bool cooked) { }

	[Address(RVA = "0x208CC10", Offset = "0x208C010", Length = "0x82")]
	[Token(Token = "0x6001047")]
	private void IncrementX() { }

	[Address(RVA = "0x208CE90", Offset = "0x208C290", Length = "0xB14")]
	[Token(Token = "0x6001046")]
	public override void Init() { }

	[Address(RVA = "0x208CCA0", Offset = "0x208C0A0", Length = "0x1EA")]
	[Token(Token = "0x6001060")]
	private void InitKeys() { }

	[Address(RVA = "0x208D9B0", Offset = "0x208CDB0", Length = "0x32")]
	[Token(Token = "0x6001055")]
	private bool InputPending() { }

	[Address(RVA = "0x208D9F0", Offset = "0x208CDF0", Length = "0x4D")]
	[Token(Token = "0x600104B")]
	public bool IsSpecialKey(char c) { }

	[Address(RVA = "0x208DA40", Offset = "0x208CE40", Length = "0x104")]
	[Token(Token = "0x600104A")]
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	[Address(RVA = "0x208DB60", Offset = "0x208CF60", Length = "0xFB")]
	[Token(Token = "0x6001056")]
	private void QueueEcho(char c) { }

	[Address(RVA = "0x208E1B0", Offset = "0x208D5B0", Length = "0x351")]
	[Token(Token = "0x6001059")]
	public int Read(out Char[] dest, int index, int count) { }

	[Address(RVA = "0x208DE80", Offset = "0x208D280", Length = "0xB3")]
	[Token(Token = "0x600105A")]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x208DC60", Offset = "0x208D060", Length = "0x211")]
	[Token(Token = "0x6001054")]
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	[Address(RVA = "0x208DF40", Offset = "0x208D340", Length = "0xA")]
	[Token(Token = "0x600105B")]
	public override string ReadLine() { }

	[Address(RVA = "0x208DF50", Offset = "0x208D350", Length = "0xA")]
	[Token(Token = "0x600105C")]
	public string ReadToEnd() { }

	[Address(RVA = "0x208DF60", Offset = "0x208D360", Length = "0x249")]
	[Token(Token = "0x600105D")]
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	[Address(RVA = "0x208E510", Offset = "0x208D910", Length = "0x175")]
	[Token(Token = "0x6001042")]
	private static string SearchTerminfo(string term) { }

	[Address(RVA = "0x208E690", Offset = "0x208DA90", Length = "0x3AA")]
	[Token(Token = "0x600105E")]
	public override void SetCursorPosition(int left, int top) { }

	[Address(RVA = "0x208EA40", Offset = "0x208DE40", Length = "0x10D")]
	[Token(Token = "0x6001041")]
	private static string TryTermInfoDir(string dir, string term) { }

	[Address(RVA = "0x208EB50", Offset = "0x208DF50", Length = "0x28")]
	[Token(Token = "0x6001043")]
	private void WriteConsole(string str) { }

	[Address(RVA = "0x208EB80", Offset = "0x208DF80", Length = "0x4D")]
	[Token(Token = "0x6001049")]
	public void WriteSpecialKey(char c) { }

	[Address(RVA = "0x208EBD0", Offset = "0x208DFD0", Length = "0x58")]
	[Token(Token = "0x6001048")]
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

}

