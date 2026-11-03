namespace System.IO.Enumeration;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000687")]
public struct FileSystemEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A64")]
	internal FILE_FULL_DIR_INFORMATION* _info; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001A65")]
	private ReadOnlySpan<Char> <Directory>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A66")]
	private ReadOnlySpan<Char> <RootDirectory>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A67")]
	private ReadOnlySpan<Char> <OriginalRootDirectory>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170007AB")]
	public FileAttributes Attributes
	{
		[Address(RVA = "0x1FF5880", Offset = "0x1FF4C80", Length = "0x19")]
		[Token(Token = "0x6003133")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170007A7")]
	public private ReadOnlySpan<Char> Directory
	{
		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600312C")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600312D")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170007AA")]
	public ReadOnlySpan<Char> FileName
	{
		[Address(RVA = "0x1FF58A0", Offset = "0x1FF4CA0", Length = "0x28")]
		[Token(Token = "0x6003132")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170007AC")]
	public bool IsDirectory
	{
		[Address(RVA = "0x1FF58D0", Offset = "0x1FF4CD0", Length = "0x1D")]
		[Token(Token = "0x6003134")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170007A9")]
	public private ReadOnlySpan<Char> OriginalRootDirectory
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6003130")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6003131")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170007A8")]
	public private ReadOnlySpan<Char> RootDirectory
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600312E")]
		 get { } //Length: 11
		[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600312F")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x1FF5880", Offset = "0x1FF4C80", Length = "0x19")]
	[Token(Token = "0x6003133")]
	public FileAttributes get_Attributes() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600312C")]
	public ReadOnlySpan<Char> get_Directory() { }

	[Address(RVA = "0x1FF58A0", Offset = "0x1FF4CA0", Length = "0x28")]
	[Token(Token = "0x6003132")]
	public ReadOnlySpan<Char> get_FileName() { }

	[Address(RVA = "0x1FF58D0", Offset = "0x1FF4CD0", Length = "0x1D")]
	[Token(Token = "0x6003134")]
	public bool get_IsDirectory() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6003130")]
	public ReadOnlySpan<Char> get_OriginalRootDirectory() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600312E")]
	public ReadOnlySpan<Char> get_RootDirectory() { }

	[Address(RVA = "0x1FF5660", Offset = "0x1FF4A60", Length = "0x20")]
	[Token(Token = "0x600312B")]
	internal static void Initialize(ref FileSystemEntry entry, FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<Char> directory, ReadOnlySpan<Char> rootDirectory, ReadOnlySpan<Char> originalRootDirectory) { }

	[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600312D")]
	private void set_Directory(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6003131")]
	private void set_OriginalRootDirectory(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600312F")]
	private void set_RootDirectory(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1FF5680", Offset = "0x1FF4A80", Length = "0x1FB")]
	[Token(Token = "0x6003135")]
	public string ToSpecifiedFullPath() { }

}

