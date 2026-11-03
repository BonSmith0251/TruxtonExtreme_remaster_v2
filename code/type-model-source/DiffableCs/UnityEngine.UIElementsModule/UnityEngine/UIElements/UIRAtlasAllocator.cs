namespace UnityEngine.UIElements;

[Token(Token = "0x20002CB")]
internal class UIRAtlasAllocator : IDisposable
{
	[Token(Token = "0x20002CE")]
	private class AreaNode
	{
		[CompilerGenerated]
		[Token(Token = "0x20002CF")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B5C")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x340CE60", Offset = "0x340C260", Length = "0x67")]
			[Token(Token = "0x6001396")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001397")]
			public <>c() { }

			[Address(RVA = "0x340CDC0", Offset = "0x340C1C0", Length = "0x44")]
			[Token(Token = "0x6001398")]
			internal AreaNode <.cctor>b__9_0() { }

		}

		[Token(Token = "0x4000B58")]
		private static ObjectPool<AreaNode> s_Pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B59")]
		public RectInt rect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B5A")]
		public AreaNode previous; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B5B")]
		public AreaNode next; //Field offset: 0x28

		[Address(RVA = "0x33F9FF0", Offset = "0x33F93F0", Length = "0x107")]
		[Token(Token = "0x6001395")]
		private static AreaNode() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001394")]
		public AreaNode() { }

		[Address(RVA = "0x33F9D60", Offset = "0x33F9160", Length = "0xB2")]
		[Token(Token = "0x6001390")]
		public static AreaNode Acquire(RectInt rect) { }

		[Address(RVA = "0x33F9E20", Offset = "0x33F9220", Length = "0xD6")]
		[Token(Token = "0x6001393")]
		public void AddAfter(AreaNode previous) { }

		[Address(RVA = "0x33F9F00", Offset = "0x33F9300", Length = "0x78")]
		[Token(Token = "0x6001391")]
		public void Release() { }

		[Address(RVA = "0x33F9F80", Offset = "0x33F9380", Length = "0x6C")]
		[Token(Token = "0x6001392")]
		public void RemoveFromChain() { }

	}

	[Token(Token = "0x20002CC")]
	private class Row
	{
		[CompilerGenerated]
		[Token(Token = "0x20002CD")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B57")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x340CED0", Offset = "0x340C2D0", Length = "0x67")]
			[Token(Token = "0x600138D")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600138E")]
			public <>c() { }

			[Address(RVA = "0x340CD40", Offset = "0x340C140", Length = "0x44")]
			[Token(Token = "0x600138F")]
			internal Row <.cctor>b__21_0() { }

		}

		[Token(Token = "0x4000B51")]
		private static ObjectPool<Row> s_Pool; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B52")]
		private int <offsetX>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000B53")]
		private int <offsetY>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B54")]
		private int <width>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000B55")]
		private int <height>k__BackingField; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B56")]
		public int Cursor; //Field offset: 0x20

		[Token(Token = "0x170003D3")]
		private int height
		{
			[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001388")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170003D0")]
		public private int offsetX
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x6001382")]
			 get { } //Length: 85
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001383")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170003D1")]
		public private int offsetY
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001384")]
			 get { } //Length: 4
			[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001385")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170003D2")]
		public private int width
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001386")]
			 get { } //Length: 4
			[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001387")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x340BA60", Offset = "0x340AE60", Length = "0x107")]
		[Token(Token = "0x600138C")]
		private static Row() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600138B")]
		public Row() { }

		[Address(RVA = "0x340B900", Offset = "0x340AD00", Length = "0xB2")]
		[Token(Token = "0x6001389")]
		public static Row Acquire(int offsetX, int offsetY, int width, int height) { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6001382")]
		public int get_offsetX() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001384")]
		public int get_offsetY() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001386")]
		public int get_width() { }

		[Address(RVA = "0x340B9C0", Offset = "0x340ADC0", Length = "0x90")]
		[Token(Token = "0x600138A")]
		public void Release() { }

		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001388")]
		private void set_height(int value) { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001383")]
		private void set_offsetX(int value) { }

		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001385")]
		private void set_offsetY(int value) { }

		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001387")]
		private void set_width(int value) { }

	}

	[Token(Token = "0x4000B4F")]
	private static ProfilerMarker s_MarkerTryAllocate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B44")]
	private readonly int <maxAtlasSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B45")]
	private readonly int <maxImageWidth>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B46")]
	private readonly int <maxImageHeight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000B47")]
	private int <virtualWidth>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B48")]
	private int <virtualHeight>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B49")]
	private int <physicalWidth>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B4A")]
	private int <physicalHeight>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B4B")]
	private AreaNode m_FirstUnpartitionedArea; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B4C")]
	private Row[] m_OpenRows; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B4D")]
	private int m_1SidePadding; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000B4E")]
	private int m_2SidePadding; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B50")]
	private bool <disposed>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170003CF")]
	protected private bool disposed
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001378")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001379")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003C8")]
	public int maxAtlasSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600136D")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170003CA")]
	public int maxImageHeight
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600136F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003C9")]
	public int maxImageWidth
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600136E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003CE")]
	public private int physicalHeight
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001376")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001377")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003CD")]
	public private int physicalWidth
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001374")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001375")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003CC")]
	public private int virtualHeight
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001372")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001373")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003CB")]
	public private int virtualWidth
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001370")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001371")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x340E020", Offset = "0x340D420", Length = "0x5E")]
	[Token(Token = "0x6001381")]
	private static UIRAtlasAllocator() { }

	[Address(RVA = "0x340E080", Offset = "0x340D480", Length = "0x2E2")]
	[Token(Token = "0x600137D")]
	public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1) { }

	[Address(RVA = "0x340D520", Offset = "0x340C920", Length = "0x125")]
	[Token(Token = "0x6001380")]
	private void BuildAreas() { }

	[Address(RVA = "0x340D650", Offset = "0x340CA50", Length = "0x143")]
	[Token(Token = "0x600137B")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x340D7A0", Offset = "0x340CBA0", Length = "0x61")]
	[Token(Token = "0x600137A")]
	public override void Dispose() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001378")]
	protected bool get_disposed() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600136D")]
	public int get_maxAtlasSize() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600136F")]
	public int get_maxImageHeight() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600136E")]
	public int get_maxImageWidth() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001376")]
	public int get_physicalHeight() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001374")]
	public int get_physicalWidth() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001372")]
	public int get_virtualHeight() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001370")]
	public int get_virtualWidth() { }

	[Address(RVA = "0x340D810", Offset = "0x340CC10", Length = "0x16E")]
	[Token(Token = "0x600137C")]
	private static int GetLog2OfNextPower(int n) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001379")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001377")]
	private void set_physicalHeight(int value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001375")]
	private void set_physicalWidth(int value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001373")]
	private void set_virtualHeight(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001371")]
	private void set_virtualWidth(int value) { }

	[Address(RVA = "0x340D980", Offset = "0x340CD80", Length = "0x3C1")]
	[Token(Token = "0x600137E")]
	public bool TryAllocate(int width, int height, out RectInt location) { }

	[Address(RVA = "0x340DD50", Offset = "0x340D150", Length = "0x2CE")]
	[Token(Token = "0x600137F")]
	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

}

