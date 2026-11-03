namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20000FD")]
public class XAppCaptureRecordClipResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CE")]
	internal XAppCaptureRecordClipResult interop; //Field offset: 0x10

	[Obsolete("Please use DurationInMs instead, (UnityUpgradable) -> DurationInMs", True)]
	[Token(Token = "0x1700004A")]
	public uint durationInMs
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60005FF")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x6000600")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000042")]
	public uint DurationInMs
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60005EF")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60005F0")]
		 set { } //Length: 4
	}

	[Obsolete("Please use Encoding instead, (UnityUpgradable) -> Encoding", True)]
	[Token(Token = "0x1700004D")]
	public XAppCaptureVideoEncoding encoding
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x6000605")]
		 get { } //Length: 5
		[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
		[Token(Token = "0x6000606")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000045")]
	public XAppCaptureVideoEncoding Encoding
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x60005F5")]
		 get { } //Length: 5
		[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
		[Token(Token = "0x60005F6")]
		 set { } //Length: 4
	}

	[Obsolete("Please use FileSize instead, (UnityUpgradable) -> FileSize", True)]
	[Token(Token = "0x17000048")]
	public long fileSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60005FB")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x60005FC")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000040")]
	public long FileSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60005EB")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x60005EC")]
		 set { } //Length: 5
	}

	[Obsolete("Please use Height instead, (UnityUpgradable) -> Height", True)]
	[Token(Token = "0x1700004C")]
	public uint height
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000603")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6000604")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000044")]
	public uint Height
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60005F3")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x60005F4")]
		 set { } //Length: 4
	}

	[Obsolete("Please use Path instead, (UnityUpgradable) -> Path", True)]
	[Token(Token = "0x17000047")]
	public string path
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60005F9")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x60005FA")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700003F")]
	public string Path
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60005E9")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x60005EA")]
		 set { } //Length: 12
	}

	[Obsolete("Please use StartTime instead, (UnityUpgradable) -> StartTime", True)]
	[Token(Token = "0x17000049")]
	public long startTime
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60005FD")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x60005FE")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000041")]
	public long StartTime
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60005ED")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x60005EE")]
		 set { } //Length: 5
	}

	[Obsolete("Please use StartTimePreciseOffsetHns instead, (UnityUpgradable) -> StartTimePreciseOffsetHns", True)]
	[Token(Token = "0x1700004E")]
	public uint startTimePreciseOffsetHns
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000607")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x6000608")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public uint StartTimePreciseOffsetHns
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60005F7")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x60005F8")]
		 set { } //Length: 4
	}

	[Obsolete("Please use Width instead, (UnityUpgradable) -> Width", True)]
	[Token(Token = "0x1700004B")]
	public uint width
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000601")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x6000602")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000043")]
	public uint Width
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60005F1")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x60005F2")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B7C120", Offset = "0x2B7B520", Length = "0x43")]
	[Token(Token = "0x60005E7")]
	internal XAppCaptureRecordClipResult(XAppCaptureRecordClipResult interop) { }

	[Address(RVA = "0x2B7C0F0", Offset = "0x2B7B4F0", Length = "0x25")]
	[Token(Token = "0x60005E8")]
	public XAppCaptureRecordClipResult() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60005FF")]
	public uint get_durationInMs() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60005EF")]
	public uint get_DurationInMs() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x6000605")]
	public XAppCaptureVideoEncoding get_encoding() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x60005F5")]
	public XAppCaptureVideoEncoding get_Encoding() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60005FB")]
	public long get_fileSize() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60005EB")]
	public long get_FileSize() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000603")]
	public uint get_height() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60005F3")]
	public uint get_Height() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60005F9")]
	public string get_path() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60005E9")]
	public string get_Path() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60005FD")]
	public long get_startTime() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60005ED")]
	public long get_StartTime() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000607")]
	public uint get_startTimePreciseOffsetHns() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60005F7")]
	public uint get_StartTimePreciseOffsetHns() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000601")]
	public uint get_width() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60005F1")]
	public uint get_Width() { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000600")]
	public void set_durationInMs(uint value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60005F0")]
	public void set_DurationInMs(uint value) { }

	[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
	[Token(Token = "0x6000606")]
	public void set_encoding(XAppCaptureVideoEncoding value) { }

	[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
	[Token(Token = "0x60005F6")]
	public void set_Encoding(XAppCaptureVideoEncoding value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x60005FC")]
	public void set_fileSize(long value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x60005EC")]
	public void set_FileSize(long value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6000604")]
	public void set_height(uint value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x60005F4")]
	public void set_Height(uint value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x60005FA")]
	public void set_path(string value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x60005EA")]
	public void set_Path(string value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x60005FE")]
	public void set_startTime(long value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x60005EE")]
	public void set_StartTime(long value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6000608")]
	public void set_startTimePreciseOffsetHns(uint value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x60005F8")]
	public void set_StartTimePreciseOffsetHns(uint value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x6000602")]
	public void set_width(uint value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x60005F2")]
	public void set_Width(uint value) { }

}

