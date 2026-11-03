namespace UnityEngine.Rendering.Universal;

[Obsolete("Deprecated in favor of RTHandle. #from(2022.1) #breakingFrom(2023.1)", True)]
[Token(Token = "0x200019A")]
public struct RenderTargetHandle
{
	[Token(Token = "0x400090A")]
	public static readonly RenderTargetHandle CameraTarget; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000908")]
	private int <id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000909")]
	private RenderTargetIdentifier <rtid>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000218")]
	public int id
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60008D4")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60008D3")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000219")]
	private RenderTargetIdentifier rtid
	{
		[Address(RVA = "0xAEF370", Offset = "0xAEE770", Length = "0x1D")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60008D6")]
		private get { } //Length: 29
		[Address(RVA = "0x2DEAD50", Offset = "0x2DEA150", Length = "0x1A")]
		[CompilerGenerated]
		[Token(Token = "0x60008D5")]
		private set { } //Length: 26
	}

	[Address(RVA = "0x2DEA8C0", Offset = "0x2DE9CC0", Length = "0x53")]
	[Token(Token = "0x60008E3")]
	private static RenderTargetHandle() { }

	[Address(RVA = "0x2DEA920", Offset = "0x2DE9D20", Length = "0x6B")]
	[Token(Token = "0x60008D7")]
	public RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier) { }

	[Address(RVA = "0x2DEA990", Offset = "0x2DE9D90", Length = "0x2B7")]
	[Token(Token = "0x60008D8")]
	public RenderTargetHandle(RTHandle rtHandle) { }

	[Address(RVA = "0x2DEA400", Offset = "0x2DE9800", Length = "0xBA")]
	[Token(Token = "0x60008DF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2DEA260", Offset = "0x2DE9660", Length = "0x198")]
	[Token(Token = "0x60008DE")]
	public bool Equals(RenderTargetHandle other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60008D4")]
	public int get_id() { }

	[Address(RVA = "0xAEF370", Offset = "0xAEE770", Length = "0x1D")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60008D6")]
	private RenderTargetIdentifier get_rtid() { }

	[Address(RVA = "0x2DEA4C0", Offset = "0x2DE98C0", Length = "0x13C")]
	[Token(Token = "0x60008D9")]
	internal static RenderTargetHandle GetCameraTarget(ref CameraData cameraData) { }

	[Address(RVA = "0x2DEA600", Offset = "0x2DE9A00", Length = "0x42")]
	[Token(Token = "0x60008E0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2DEA650", Offset = "0x2DE9A50", Length = "0x46")]
	[Token(Token = "0x60008DD")]
	public bool HasInternalRenderTargetId() { }

	[Address(RVA = "0x2DEA6A0", Offset = "0x2DE9AA0", Length = "0x145")]
	[Token(Token = "0x60008DC")]
	public RenderTargetIdentifier Identifier() { }

	[Address(RVA = "0x2DEA7F0", Offset = "0x2DE9BF0", Length = "0x6B")]
	[Token(Token = "0x60008DB")]
	public void Init(RenderTargetIdentifier renderTargetIdentifier) { }

	[Address(RVA = "0x2DEA860", Offset = "0x2DE9C60", Length = "0x5A")]
	[Token(Token = "0x60008DA")]
	public void Init(string shaderProperty) { }

	[Address(RVA = "0x2DEAC50", Offset = "0x2DEA050", Length = "0x76")]
	[Token(Token = "0x60008E1")]
	public static bool op_Equality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	[Address(RVA = "0x2DEACD0", Offset = "0x2DEA0D0", Length = "0x78")]
	[Token(Token = "0x60008E2")]
	public static bool op_Inequality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60008D3")]
	public void set_id(int value) { }

	[Address(RVA = "0x2DEAD50", Offset = "0x2DEA150", Length = "0x1A")]
	[CompilerGenerated]
	[Token(Token = "0x60008D5")]
	private void set_rtid(RenderTargetIdentifier value) { }

}

