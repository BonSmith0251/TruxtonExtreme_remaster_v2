namespace UnityEngine.TextCore;

[Token(Token = "0x2000006")]
[UsedByNativeCode]
public class Glyph
{
	[FieldOffset(Offset = "0x10")]
	[NativeName("index")]
	[SerializeField]
	[Token(Token = "0x4000026")]
	private uint m_Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("metrics")]
	[SerializeField]
	[Token(Token = "0x4000027")]
	private GlyphMetrics m_Metrics; //Field offset: 0x14
	[FieldOffset(Offset = "0x28")]
	[NativeName("glyphRect")]
	[SerializeField]
	[Token(Token = "0x4000028")]
	private GlyphRect m_GlyphRect; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[NativeName("scale")]
	[SerializeField]
	[Token(Token = "0x4000029")]
	private float m_Scale; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("atlasIndex")]
	[SerializeField]
	[Token(Token = "0x400002A")]
	private int m_AtlasIndex; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[NativeName("type")]
	[SerializeField]
	[Token(Token = "0x400002B")]
	private GlyphClassDefinitionType m_ClassDefinitionType; //Field offset: 0x40

	[Token(Token = "0x17000023")]
	public int atlasIndex
	{
		[Address(RVA = "0x3171990", Offset = "0x3170D90", Length = "0x6")]
		[Token(Token = "0x6000035")]
		 get { } //Length: 6
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x6000036")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public GlyphRect glyphRect
	{
		[Address(RVA = "0x3115A30", Offset = "0x3114E30", Length = "0xB")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
		[Token(Token = "0x6000032")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001F")]
	public uint index
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 6
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x600002E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	public GlyphMetrics metrics
	{
		[Address(RVA = "0x198AFA0", Offset = "0x198A3A0", Length = "0x11")]
		[Token(Token = "0x600002F")]
		 get { } //Length: 17
		[Address(RVA = "0x31719A0", Offset = "0x3170DA0", Length = "0xE")]
		[Token(Token = "0x6000030")]
		 set { } //Length: 14
	}

	[Token(Token = "0x17000022")]
	public float scale
	{
		[Address(RVA = "0x31132E0", Offset = "0x31126E0", Length = "0x8")]
		[Token(Token = "0x6000033")]
		 get { } //Length: 8
		[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
		[Token(Token = "0x6000034")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x3171950", Offset = "0x3170D50", Length = "0x33")]
	[Token(Token = "0x6000037")]
	public Glyph() { }

	[Address(RVA = "0x3171890", Offset = "0x3170C90", Length = "0x49")]
	[Token(Token = "0x6000038")]
	internal Glyph(GlyphMarshallingStruct glyphStruct) { }

	[Address(RVA = "0x31718E0", Offset = "0x3170CE0", Length = "0x64")]
	[Token(Token = "0x6000039")]
	public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	[Address(RVA = "0x3171990", Offset = "0x3170D90", Length = "0x6")]
	[Token(Token = "0x6000035")]
	public int get_atlasIndex() { }

	[Address(RVA = "0x3115A30", Offset = "0x3114E30", Length = "0xB")]
	[Token(Token = "0x6000031")]
	public GlyphRect get_glyphRect() { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x600002D")]
	public uint get_index() { }

	[Address(RVA = "0x198AFA0", Offset = "0x198A3A0", Length = "0x11")]
	[Token(Token = "0x600002F")]
	public GlyphMetrics get_metrics() { }

	[Address(RVA = "0x31132E0", Offset = "0x31126E0", Length = "0x8")]
	[Token(Token = "0x6000033")]
	public float get_scale() { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x6000036")]
	public void set_atlasIndex(int value) { }

	[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
	[Token(Token = "0x6000032")]
	public void set_glyphRect(GlyphRect value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x600002E")]
	public void set_index(uint value) { }

	[Address(RVA = "0x31719A0", Offset = "0x3170DA0", Length = "0xE")]
	[Token(Token = "0x6000030")]
	public void set_metrics(GlyphMetrics value) { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[Token(Token = "0x6000034")]
	public void set_scale(float value) { }

}

