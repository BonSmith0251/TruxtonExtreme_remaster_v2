namespace UnityEngine.Rendering;

[Token(Token = "0x20003D9")]
public struct FilteringSettings : IEquatable<FilteringSettings>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C8A")]
	private RenderQueueRange m_RenderQueueRange; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C8B")]
	private int m_LayerMask; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C8C")]
	private uint m_RenderingLayerMask; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C8D")]
	private uint m_BatchLayerMask; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C8E")]
	private int m_ExcludeMotionVectorObjects; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C8F")]
	private int m_ForceAllMotionVectorObjects; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C90")]
	private SortingLayerRange m_SortingLayerRange; //Field offset: 0x1C

	[Token(Token = "0x1700042D")]
	public uint batchLayerMask
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6001DB3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000429")]
	public static FilteringSettings defaultValue
	{
		[Address(RVA = "0x30BEB10", Offset = "0x30BDF10", Length = "0xC8")]
		[Token(Token = "0x6001DAD")]
		 get { } //Length: 200
	}

	[Token(Token = "0x1700042E")]
	public bool excludeMotionVectorObjects
	{
		[Address(RVA = "0x30BEC10", Offset = "0x30BE010", Length = "0x9")]
		[Token(Token = "0x6001DB4")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700042F")]
	public bool forceAllMotionVectorObjects
	{
		[Address(RVA = "0x30BEC20", Offset = "0x30BE020", Length = "0x9")]
		[Token(Token = "0x6001DB5")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700042B")]
	public int layerMask
	{
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6001DB1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700042C")]
	public uint renderingLayerMask
	{
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x6001DB2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700042A")]
	public RenderQueueRange renderQueueRange
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x6001DAF")]
		 get { } //Length: 6
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x6001DB0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000430")]
	public SortingLayerRange sortingLayerRange
	{
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6001DB6")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x30BEA20", Offset = "0x30BDE20", Length = "0xE2")]
	[Token(Token = "0x6001DAE")]
	public FilteringSettings(Nullable<RenderQueueRange> renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295, int excludeMotionVectorObjects = 0) { }

	[Address(RVA = "0x30BE840", Offset = "0x30BDC40", Length = "0xB4")]
	[Token(Token = "0x6001DB7")]
	public override bool Equals(FilteringSettings other) { }

	[Address(RVA = "0x30BE900", Offset = "0x30BDD00", Length = "0x99")]
	[Token(Token = "0x6001DB8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30BEB10", Offset = "0x30BDF10", Length = "0xC8")]
	[Token(Token = "0x6001DAD")]
	public static FilteringSettings get_defaultValue() { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6001DAF")]
	public RenderQueueRange get_renderQueueRange() { }

	[Address(RVA = "0x30BE9A0", Offset = "0x30BDDA0", Length = "0x76")]
	[Token(Token = "0x6001DB9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30BEBE0", Offset = "0x30BDFE0", Length = "0x27")]
	[Token(Token = "0x6001DBA")]
	public static bool op_Equality(FilteringSettings left, FilteringSettings right) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6001DB3")]
	public void set_batchLayerMask(uint value) { }

	[Address(RVA = "0x30BEC10", Offset = "0x30BE010", Length = "0x9")]
	[Token(Token = "0x6001DB4")]
	public void set_excludeMotionVectorObjects(bool value) { }

	[Address(RVA = "0x30BEC20", Offset = "0x30BE020", Length = "0x9")]
	[Token(Token = "0x6001DB5")]
	public void set_forceAllMotionVectorObjects(bool value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6001DB1")]
	public void set_layerMask(int value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[Token(Token = "0x6001DB2")]
	public void set_renderingLayerMask(uint value) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6001DB0")]
	public void set_renderQueueRange(RenderQueueRange value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6001DB6")]
	public void set_sortingLayerRange(SortingLayerRange value) { }

}

