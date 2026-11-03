namespace InGame.Kernel;

[Token(Token = "0x2000006")]
public class AreaInformation
{
	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <>c
	{
		[Token(Token = "0x4000023")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000024")]
		public static Comparison<AreaInformation> <>9__30_0; //Field offset: 0x8

		[Address(RVA = "0x1CDF730", Offset = "0x1CDEB30", Length = "0x67")]
		[Token(Token = "0x600002F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000030")]
		public <>c() { }

		[Address(RVA = "0x1CDF560", Offset = "0x1CDE960", Length = "0x46")]
		[Token(Token = "0x6000031")]
		internal int <GetAreaLists>b__30_0(AreaInformation a, AreaInformation b) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001A")]
	private double _end; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001B")]
	private double _start; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001C")]
	private double _duration; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001D")]
	private bool _isGhost; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400001E")]
	private bool _isStop; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x400001F")]
	private bool _isNoRestart; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000020")]
	private bool _isTerminate; //Field offset: 0x2B
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000021")]
	private bool _isLoop; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000022")]
	private string _areaName; //Field offset: 0x30

	[Token(Token = "0x1700000D")]
	public string AreaName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000007")]
	public double duration
	{
		[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000005")]
	public double end
	{
		[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
		[Token(Token = "0x6000025")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000008")]
	public bool IsGhost
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000C")]
	public bool IsLoop
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000A")]
	public bool IsNoRestart
	{
		[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public bool IsStop
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000B")]
	public bool IsTerminate
	{
		[Address(RVA = "0x1CC53B0", Offset = "0x1CC47B0", Length = "0x5")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000006")]
	public double start
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1CC5230", Offset = "0x1CC4630", Length = "0x158")]
	[Token(Token = "0x6000022")]
	public AreaInformation(TimelineClip tclip) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600002D")]
	public string get_AreaName() { }

	[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
	[Token(Token = "0x6000027")]
	public double get_duration() { }

	[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
	[Token(Token = "0x6000025")]
	public double get_end() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000028")]
	public bool get_IsGhost() { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[Token(Token = "0x600002C")]
	public bool get_IsLoop() { }

	[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
	[Token(Token = "0x600002A")]
	public bool get_IsNoRestart() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x6000029")]
	public bool get_IsStop() { }

	[Address(RVA = "0x1CC53B0", Offset = "0x1CC47B0", Length = "0x5")]
	[Token(Token = "0x600002B")]
	public bool get_IsTerminate() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[Token(Token = "0x6000026")]
	public double get_start() { }

	[Address(RVA = "0x1CC4CD0", Offset = "0x1CC40D0", Length = "0x535")]
	[Token(Token = "0x600002E")]
	public static List<AreaInformation> GetAreaLists(TimelineAsset tlasset) { }

	[Address(RVA = "0x1CC5210", Offset = "0x1CC4610", Length = "0x5")]
	[Token(Token = "0x6000023")]
	public void SetNoRestart() { }

	[Address(RVA = "0x1CC5220", Offset = "0x1CC4620", Length = "0x9")]
	[Token(Token = "0x6000024")]
	public void SetTerminate() { }

}

