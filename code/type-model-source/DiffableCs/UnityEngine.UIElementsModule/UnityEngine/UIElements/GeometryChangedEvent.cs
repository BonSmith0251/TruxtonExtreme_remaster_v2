namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Geometry (7))]
[Token(Token = "0x20001EC")]
public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001ED")]
	private sealed class <>c
	{
		[Token(Token = "0x400086B")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E0530", Offset = "0x33DF930", Length = "0x67")]
		[Token(Token = "0x6000DD0")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DD1")]
		public <>c() { }

		[Address(RVA = "0x33DF190", Offset = "0x33DE590", Length = "0x90")]
		[Token(Token = "0x6000DD2")]
		internal GeometryChangedEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000868")]
	private Rect <oldRect>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000869")]
	private Rect <newRect>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400086A")]
	private int <layoutPass>k__BackingField; //Field offset: 0x88

	[Token(Token = "0x17000272")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int layoutPass
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DCD")]
		internal get { } //Length: 7
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000DCE")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000271")]
	public private Rect newRect
	{
		[Address(RVA = "0x16D0810", Offset = "0x16CFC10", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000DCB")]
		 get { } //Length: 11
		[Address(RVA = "0x16D0A50", Offset = "0x16CFE50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000DCC")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000270")]
	public private Rect oldRect
	{
		[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000DC9")]
		 get { } //Length: 11
		[Address(RVA = "0x16D0B80", Offset = "0x16CFF80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000DCA")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x33D1140", Offset = "0x33D0540", Length = "0xD1")]
	[Token(Token = "0x6000DC5")]
	private static GeometryChangedEvent() { }

	[Address(RVA = "0x33D1220", Offset = "0x33D0620", Length = "0x64")]
	[Token(Token = "0x6000DCF")]
	public GeometryChangedEvent() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCD")]
	internal int get_layoutPass() { }

	[Address(RVA = "0x16D0810", Offset = "0x16CFC10", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCB")]
	public Rect get_newRect() { }

	[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000DC9")]
	public Rect get_oldRect() { }

	[Address(RVA = "0x33D0F90", Offset = "0x33D0390", Length = "0x7C")]
	[Token(Token = "0x6000DC6")]
	public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) { }

	[Address(RVA = "0x33D1010", Offset = "0x33D0410", Length = "0x43")]
	[Token(Token = "0x6000DC7")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D1060", Offset = "0x33D0460", Length = "0xD9")]
	[Token(Token = "0x6000DC8")]
	private void LocalInit() { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCE")]
	internal void set_layoutPass(int value) { }

	[Address(RVA = "0x16D0A50", Offset = "0x16CFE50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCC")]
	private void set_newRect(Rect value) { }

	[Address(RVA = "0x16D0B80", Offset = "0x16CFF80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCA")]
	private void set_oldRect(Rect value) { }

}

