namespace System.IO;

[Token(Token = "0x200065D")]
public class EnumerationOptions
{
	[CompilerGenerated]
	[Token(Token = "0x4001979")]
	private static readonly EnumerationOptions <Compatible>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x400197A")]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x400197B")]
	private static readonly EnumerationOptions <Default>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400197C")]
	private bool <RecurseSubdirectories>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400197D")]
	private bool <IgnoreInaccessible>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400197E")]
	private int <BufferSize>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400197F")]
	private FileAttributes <AttributesToSkip>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001980")]
	private MatchType <MatchType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001981")]
	private MatchCasing <MatchCasing>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001982")]
	private bool <ReturnSpecialDirectories>k__BackingField; //Field offset: 0x24

	[Token(Token = "0x17000770")]
	public FileAttributes AttributesToSkip
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F7A")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F7B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700076F")]
	public int BufferSize
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F79")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700076A")]
	internal static EnumerationOptions Compatible
	{
		[Address(RVA = "0x1FD5090", Offset = "0x1FD4490", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6002F70")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x1700076B")]
	private static EnumerationOptions CompatibleRecursive
	{
		[Address(RVA = "0x1FD5040", Offset = "0x1FD4440", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6002F71")]
		private get { } //Length: 79
	}

	[Token(Token = "0x1700076C")]
	internal static EnumerationOptions Default
	{
		[Address(RVA = "0x1FD50E0", Offset = "0x1FD44E0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6002F72")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700076E")]
	public bool IgnoreInaccessible
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002F77")]
		 get { } //Length: 5
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F78")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000772")]
	public MatchCasing MatchCasing
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F7E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000771")]
	public MatchType MatchType
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F7C")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F7D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700076D")]
	public bool RecurseSubdirectories
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002F75")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002F76")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000773")]
	public bool ReturnSpecialDirectories
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002F7F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FD4EE0", Offset = "0x1FD42E0", Length = "0x122")]
	[Token(Token = "0x6002F80")]
	private static EnumerationOptions() { }

	[Address(RVA = "0x1FD5010", Offset = "0x1FD4410", Length = "0x21")]
	[Token(Token = "0x6002F73")]
	public EnumerationOptions() { }

	[Address(RVA = "0x1FD4D90", Offset = "0x1FD4190", Length = "0x150")]
	[Token(Token = "0x6002F74")]
	internal static EnumerationOptions FromSearchOption(SearchOption searchOption) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F7A")]
	public FileAttributes get_AttributesToSkip() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F79")]
	public int get_BufferSize() { }

	[Address(RVA = "0x1FD5090", Offset = "0x1FD4490", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6002F70")]
	internal static EnumerationOptions get_Compatible() { }

	[Address(RVA = "0x1FD5040", Offset = "0x1FD4440", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6002F71")]
	private static EnumerationOptions get_CompatibleRecursive() { }

	[Address(RVA = "0x1FD50E0", Offset = "0x1FD44E0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6002F72")]
	internal static EnumerationOptions get_Default() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002F77")]
	public bool get_IgnoreInaccessible() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F7E")]
	public MatchCasing get_MatchCasing() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F7C")]
	public MatchType get_MatchType() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002F75")]
	public bool get_RecurseSubdirectories() { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002F7F")]
	public bool get_ReturnSpecialDirectories() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F7B")]
	public void set_AttributesToSkip(FileAttributes value) { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F78")]
	public void set_IgnoreInaccessible(bool value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F7D")]
	public void set_MatchType(MatchType value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002F76")]
	public void set_RecurseSubdirectories(bool value) { }

}

