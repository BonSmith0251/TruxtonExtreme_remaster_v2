namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200016F")]
internal class SharedDecalEntityManager : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000855")]
	private DecalEntityManager m_DecalEntityManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000856")]
	private int m_ReferenceCounter; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60007F8")]
	public SharedDecalEntityManager() { }

	[Address(RVA = "0x2DDD360", Offset = "0x2DDC760", Length = "0x18F")]
	[Token(Token = "0x60007F2")]
	public override void Dispose() { }

	[Address(RVA = "0x2DDD4F0", Offset = "0x2DDC8F0", Length = "0x290")]
	[Token(Token = "0x60007F0")]
	public DecalEntityManager Get() { }

	[Address(RVA = "0x2DDD790", Offset = "0x2DDCB90", Length = "0x1D")]
	[Token(Token = "0x60007F6")]
	private void OnAllDecalPropertyChange() { }

	[Address(RVA = "0x2DDD7B0", Offset = "0x2DDCBB0", Length = "0x56")]
	[Token(Token = "0x60007F3")]
	private void OnDecalAdd(DecalProjector decalProjector) { }

	[Address(RVA = "0x2DDD810", Offset = "0x2DDCC10", Length = "0x6B")]
	[Token(Token = "0x60007F7")]
	private void OnDecalMaterialChange(DecalProjector decalProjector) { }

	[Address(RVA = "0x2DDD880", Offset = "0x2DDCC80", Length = "0x56")]
	[Token(Token = "0x60007F5")]
	private void OnDecalPropertyChange(DecalProjector decalProjector) { }

	[Address(RVA = "0x2DDD8E0", Offset = "0x2DDCCE0", Length = "0x27")]
	[Token(Token = "0x60007F4")]
	private void OnDecalRemove(DecalProjector decalProjector) { }

	[Address(RVA = "0x2DDD910", Offset = "0x2DDCD10", Length = "0x1A4")]
	[Token(Token = "0x60007F1")]
	public void Release(DecalEntityManager decalEntityManager) { }

}

