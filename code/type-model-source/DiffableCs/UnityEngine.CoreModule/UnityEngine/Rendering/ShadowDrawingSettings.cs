namespace UnityEngine.Rendering;

[Token(Token = "0x20003F1")]
[UsedByNativeCode]
public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D00")]
	private CullingResults m_CullingResults; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D01")]
	private int m_LightIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D02")]
	private int m_SplitIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D03")]
	private int m_UseRenderingLayerMaskTest; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D04")]
	private uint m_BatchLayerMask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D05")]
	private ShadowSplitData m_SplitData; //Field offset: 0x20
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000D06")]
	private ShadowObjectsFilter m_ObjectsFilter; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000D07")]
	private BatchCullingProjectionType m_ProjectionType; //Field offset: 0x120

	[Token(Token = "0x1700046B")]
	public bool useRenderingLayerMaskTest
	{
		[Address(RVA = "0x30BEC20", Offset = "0x30BE020", Length = "0x9")]
		[Token(Token = "0x6001E83")]
		 set { } //Length: 9
	}

	[Address(RVA = "0x30CC9C0", Offset = "0x30CBDC0", Length = "0xA0")]
	[Token(Token = "0x6001E84")]
	public ShadowDrawingSettings(CullingResults cullingResults, int lightIndex) { }

	[Address(RVA = "0x30CC290", Offset = "0x30CB690", Length = "0x555")]
	[Token(Token = "0x6001E85")]
	public override bool Equals(ShadowDrawingSettings other) { }

	[Address(RVA = "0x30CC7F0", Offset = "0x30CBBF0", Length = "0x122")]
	[Token(Token = "0x6001E86")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30CC920", Offset = "0x30CBD20", Length = "0x9F")]
	[Token(Token = "0x6001E87")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30BEC20", Offset = "0x30BE020", Length = "0x9")]
	[Token(Token = "0x6001E83")]
	public void set_useRenderingLayerMaskTest(bool value) { }

}

