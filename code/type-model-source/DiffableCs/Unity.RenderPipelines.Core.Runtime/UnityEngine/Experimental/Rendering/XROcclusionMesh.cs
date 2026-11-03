namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x2000010")]
internal class XROcclusionMesh
{
	[Token(Token = "0x4000047")]
	private static readonly ProfilingSampler k_OcclusionMeshProfilingSampler; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000043")]
	private XRPass m_Pass; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000044")]
	private Mesh m_CombinedMesh; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000045")]
	private Material m_Material; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000046")]
	private int m_CombinedMeshHashCode; //Field offset: 0x28

	[Token(Token = "0x1700000A")]
	internal bool hasValidOcclusionMesh
	{
		[Address(RVA = "0x2BCBA10", Offset = "0x2BCAE10", Length = "0xBF")]
		[Token(Token = "0x600003C")]
		internal get { } //Length: 191
	}

	[Address(RVA = "0x2BCB980", Offset = "0x2BCAD80", Length = "0x87")]
	[Token(Token = "0x6000042")]
	private static XROcclusionMesh() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600003A")]
	internal XROcclusionMesh(XRPass xrPass) { }

	[Address(RVA = "0x2BCAC30", Offset = "0x2BCA030", Length = "0x40D")]
	[Token(Token = "0x6000041")]
	private void CreateOcclusionMeshCombined() { }

	[Address(RVA = "0x2BCBA10", Offset = "0x2BCAE10", Length = "0xBF")]
	[Token(Token = "0x600003C")]
	internal bool get_hasValidOcclusionMesh() { }

	[Address(RVA = "0x2BCB040", Offset = "0x2BCA440", Length = "0x9F")]
	[Token(Token = "0x600003F")]
	private bool IsOcclusionMeshSupported() { }

	[Address(RVA = "0x2BCB0E0", Offset = "0x2BCA4E0", Length = "0x4EA")]
	[Token(Token = "0x600003D")]
	internal void RenderOcclusionMesh(CommandBuffer cmd, float occlusionMeshScale, bool yFlip = false) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600003B")]
	internal void SetMaterial(Material mat) { }

	[Address(RVA = "0x2BCB5D0", Offset = "0x2BCA9D0", Length = "0x169")]
	[Token(Token = "0x6000040")]
	private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode) { }

	[Address(RVA = "0x2BCB740", Offset = "0x2BCAB40", Length = "0x23E")]
	[Token(Token = "0x600003E")]
	internal void UpdateCombinedMesh() { }

}

