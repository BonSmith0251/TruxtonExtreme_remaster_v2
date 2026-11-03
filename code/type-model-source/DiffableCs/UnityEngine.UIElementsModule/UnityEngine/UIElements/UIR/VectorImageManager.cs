namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005E9")]
internal class VectorImageManager : IDisposable
{
	[Token(Token = "0x4001589")]
	public static List<VectorImageManager> instances; //Field offset: 0x0
	[Token(Token = "0x400158A")]
	private static ProfilerMarker s_MarkerRegister; //Field offset: 0x8
	[Token(Token = "0x400158B")]
	private static ProfilerMarker s_MarkerUnregister; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400158C")]
	private readonly AtlasBase m_Atlas; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400158D")]
	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400158E")]
	private VectorImageRenderInfoPool m_RenderInfoPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400158F")]
	private GradientRemapPool m_GradientRemapPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001590")]
	private GradientSettingsAtlas m_GradientSettingsAtlas; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001591")]
	private bool m_LoggedExhaustedSettingsAtlas; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4001592")]
	private bool <disposed>k__BackingField; //Field offset: 0x39

	[Token(Token = "0x17000A8F")]
	public Texture2D atlas
	{
		[Address(RVA = "0x332E440", Offset = "0x332D840", Length = "0x20")]
		[Token(Token = "0x6002A62")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000A90")]
	protected private bool disposed
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002A64")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002A65")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x332DDF0", Offset = "0x332D1F0", Length = "0x100")]
	[Token(Token = "0x6002A6D")]
	private static VectorImageManager() { }

	[Address(RVA = "0x332DEF0", Offset = "0x332D2F0", Length = "0x54A")]
	[Token(Token = "0x6002A63")]
	public VectorImageManager(AtlasBase atlas) { }

	[Address(RVA = "0x332D2D0", Offset = "0x332C6D0", Length = "0xF3")]
	[Token(Token = "0x6002A69")]
	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	[Address(RVA = "0x332D3D0", Offset = "0x332C7D0", Length = "0x2F")]
	[Token(Token = "0x6002A68")]
	public void Commit() { }

	[Address(RVA = "0x332D520", Offset = "0x332C920", Length = "0x61")]
	[Token(Token = "0x6002A66")]
	public override void Dispose() { }

	[Address(RVA = "0x332D400", Offset = "0x332C800", Length = "0x113")]
	[Token(Token = "0x6002A67")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x332E440", Offset = "0x332D840", Length = "0x20")]
	[Token(Token = "0x6002A62")]
	public Texture2D get_atlas() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002A64")]
	protected bool get_disposed() { }

	[Address(RVA = "0x332D590", Offset = "0x332C990", Length = "0x4C6")]
	[Token(Token = "0x6002A6B")]
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	[Address(RVA = "0x332DA60", Offset = "0x332CE60", Length = "0x225")]
	[Token(Token = "0x6002A6A")]
	public void RemoveUser(VectorImage vi) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002A65")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x332DC90", Offset = "0x332D090", Length = "0x153")]
	[Token(Token = "0x6002A6C")]
	private void Unregister(VectorImage vi, VectorImageRenderInfo renderInfo) { }

}

