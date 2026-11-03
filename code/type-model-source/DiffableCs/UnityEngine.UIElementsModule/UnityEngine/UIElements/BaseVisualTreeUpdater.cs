namespace UnityEngine.UIElements;

[Token(Token = "0x200056A")]
internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011FD")]
	private long frameCount; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011FE")]
	private Action<BaseVisualElementPanel> panelChanged; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011FF")]
	private BaseVisualElementPanel m_Panel; //Field offset: 0x20

	[Token(Token = "0x1400002E")]
	public event Action<BaseVisualElementPanel> panelChanged
	{
		[Address(RVA = "0x32D6ED0", Offset = "0x32D62D0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6002770")]
		 add { } //Length: 172
		[Address(RVA = "0x32D6FB0", Offset = "0x32D63B0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6002771")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000A2A")]
	public override BaseVisualElementPanel panel
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x6002772")]
		 get { } //Length: 7
		[Address(RVA = "0x32D7060", Offset = "0x32D6460", Length = "0x44")]
		[Token(Token = "0x6002773")]
		 set { } //Length: 68
	}

	[Token(Token = "0x17000A2C")]
	public abstract ProfilerMarker profilerMarker
	{
		[Token(Token = "0x6002775")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000A29")]
	private override long UnityEngine.UIElements.IVisualTreeUpdater.FrameCount
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x600276E")]
		private get { } //Length: 7
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x600276F")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000A2B")]
	public VisualElement visualTree
	{
		[Address(RVA = "0x32D6F80", Offset = "0x32D6380", Length = "0x2A")]
		[Token(Token = "0x6002774")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600277A")]
	protected BaseVisualTreeUpdater() { }

	[Address(RVA = "0x32D6ED0", Offset = "0x32D62D0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6002770")]
	public void add_panelChanged(Action<BaseVisualElementPanel> value) { }

	[Address(RVA = "0x32D6E60", Offset = "0x32D6260", Length = "0x61")]
	[Token(Token = "0x6002776")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002777")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x6002772")]
	public override BaseVisualElementPanel get_panel() { }

	[Token(Token = "0x6002775")]
	public abstract ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x32D6F80", Offset = "0x32D6380", Length = "0x2A")]
	[Token(Token = "0x6002774")]
	public VisualElement get_visualTree() { }

	[Token(Token = "0x6002779")]
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32D6FB0", Offset = "0x32D63B0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6002771")]
	public void remove_panelChanged(Action<BaseVisualElementPanel> value) { }

	[Address(RVA = "0x32D7060", Offset = "0x32D6460", Length = "0x44")]
	[Token(Token = "0x6002773")]
	public override void set_panel(BaseVisualElementPanel value) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x600276E")]
	private override long UnityEngine.UIElements.IVisualTreeUpdater.get_FrameCount() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x600276F")]
	private override void UnityEngine.UIElements.IVisualTreeUpdater.set_FrameCount(long value) { }

	[Token(Token = "0x6002778")]
	public abstract void Update() { }

}

