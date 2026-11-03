namespace UnityEngine.Rendering;

[Token(Token = "0x20003E3")]
public struct RendererListParams : IEquatable<RendererListParams>
{
	[Token(Token = "0x4000CBF")]
	public static readonly RendererListParams Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CC0")]
	public CullingResults cullingResults; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CC1")]
	public DrawingSettings drawSettings; //Field offset: 0x10
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000CC2")]
	public FilteringSettings filteringSettings; //Field offset: 0xD8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000CC3")]
	public ShaderTagId tagName; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000CC4")]
	public bool isPassTagName; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000CC5")]
	public Nullable<NativeArray`1<ShaderTagId>> tagValues; //Field offset: 0x100
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000CC6")]
	public Nullable<NativeArray`1<RenderStateBlock>> stateBlocks; //Field offset: 0x118

	[Token(Token = "0x17000438")]
	internal int numStateBlocks
	{
		[Address(RVA = "0x30C7D70", Offset = "0x30C7170", Length = "0x64")]
		[Token(Token = "0x6001DCE")]
		internal get { } //Length: 100
	}

	[Token(Token = "0x17000439")]
	internal IntPtr stateBlocksPtr
	{
		[Address(RVA = "0x30C7DE0", Offset = "0x30C71E0", Length = "0x91")]
		[Token(Token = "0x6001DCF")]
		internal get { } //Length: 145
	}

	[Token(Token = "0x1700043A")]
	internal IntPtr tagsValuePtr
	{
		[Address(RVA = "0x30C7E80", Offset = "0x30C7280", Length = "0x91")]
		[Token(Token = "0x6001DD0")]
		internal get { } //Length: 145
	}

	[Address(RVA = "0x30C7C00", Offset = "0x30C7000", Length = "0x3F")]
	[Token(Token = "0x6001DD5")]
	private static RendererListParams() { }

	[Address(RVA = "0x30C7C40", Offset = "0x30C7040", Length = "0x127")]
	[Token(Token = "0x6001DCD")]
	public RendererListParams(CullingResults cullingResults, DrawingSettings drawSettings, FilteringSettings filteringSettings) { }

	[Address(RVA = "0x30C6D10", Offset = "0x30C6110", Length = "0x7F6")]
	[Token(Token = "0x6001DD2")]
	public override bool Equals(RendererListParams other) { }

	[Address(RVA = "0x30C6BD0", Offset = "0x30C5FD0", Length = "0x132")]
	[Token(Token = "0x6001DD3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30C7D70", Offset = "0x30C7170", Length = "0x64")]
	[Token(Token = "0x6001DCE")]
	internal int get_numStateBlocks() { }

	[Address(RVA = "0x30C7DE0", Offset = "0x30C71E0", Length = "0x91")]
	[Token(Token = "0x6001DCF")]
	internal IntPtr get_stateBlocksPtr() { }

	[Address(RVA = "0x30C7E80", Offset = "0x30C7280", Length = "0x91")]
	[Token(Token = "0x6001DD0")]
	internal IntPtr get_tagsValuePtr() { }

	[Address(RVA = "0x30C7510", Offset = "0x30C6910", Length = "0x1FA")]
	[Token(Token = "0x6001DD4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30C7710", Offset = "0x30C6B10", Length = "0x4EF")]
	[Token(Token = "0x6001DD1")]
	internal void Validate() { }

}

