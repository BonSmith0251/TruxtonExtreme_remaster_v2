namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20000FE")]
public class XAppCaptureScreenshotFile
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CF")]
	internal XAppCaptureScreenshotFile interop; //Field offset: 0x10

	[Obsolete("Please use FileSize instead, (UnityUpgradable) -> FileSize", True)]
	[Token(Token = "0x17000054")]
	public long fileSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000615")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000616")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000050")]
	public long FileSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600060D")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x600060E")]
		 set { } //Length: 5
	}

	[Obsolete("Please use Height instead, (UnityUpgradable) -> Height", True)]
	[Token(Token = "0x17000056")]
	public uint height
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000619")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x600061A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000052")]
	public uint Height
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000611")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x6000612")]
		 set { } //Length: 4
	}

	[Obsolete("Please use Path instead, (UnityUpgradable) -> Path", True)]
	[Token(Token = "0x17000053")]
	public string path
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000613")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000614")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700004F")]
	public string Path
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600060B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x600060C")]
		 set { } //Length: 12
	}

	[Obsolete("Please use Width instead, (UnityUpgradable) -> Width", True)]
	[Token(Token = "0x17000055")]
	public uint width
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000617")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000618")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000051")]
	public uint Width
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600060F")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000610")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B7C1B0", Offset = "0x2B7B5B0", Length = "0x3D")]
	[Token(Token = "0x6000609")]
	internal XAppCaptureScreenshotFile(XAppCaptureScreenshotFile interop) { }

	[Address(RVA = "0x2B7C180", Offset = "0x2B7B580", Length = "0x23")]
	[Token(Token = "0x600060A")]
	internal XAppCaptureScreenshotFile() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000615")]
	public long get_fileSize() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600060D")]
	public long get_FileSize() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000619")]
	public uint get_height() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000611")]
	public uint get_Height() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000613")]
	public string get_path() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600060B")]
	public string get_Path() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000617")]
	public uint get_width() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600060F")]
	public uint get_Width() { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000616")]
	public void set_fileSize(long value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x600060E")]
	public void set_FileSize(long value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x600061A")]
	public void set_height(uint value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x6000612")]
	public void set_Height(uint value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000614")]
	public void set_path(string value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x600060C")]
	public void set_Path(string value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000618")]
	public void set_width(uint value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000610")]
	public void set_Width(uint value) { }

}

