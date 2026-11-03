namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x2000017")]
internal class XRVisibleMesh
{
	[Token(Token = "0x4000088")]
	private static readonly ProfilingSampler k_VisibleMeshProfilingSampler; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000085")]
	private XRPass m_Pass; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000086")]
	private Mesh m_CombinedMesh; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000087")]
	private int m_CombinedMeshHashCode; //Field offset: 0x20

	[Token(Token = "0x17000029")]
	internal bool hasValidVisibleMesh
	{
		[Address(RVA = "0x2BD36F0", Offset = "0x2BD2AF0", Length = "0xBF")]
		[Token(Token = "0x60000B0")]
		internal get { } //Length: 191
	}

	[Address(RVA = "0x2BD3660", Offset = "0x2BD2A60", Length = "0x87")]
	[Token(Token = "0x60000B6")]
	private static XRVisibleMesh() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60000AE")]
	internal XRVisibleMesh(XRPass xrPass) { }

	[Address(RVA = "0x2BD2B00", Offset = "0x2BD1F00", Length = "0x40D")]
	[Token(Token = "0x60000B5")]
	private void CreateVisibleMeshCombined() { }

	[Address(RVA = "0x2BD2F10", Offset = "0x2BD2310", Length = "0x9D")]
	[Token(Token = "0x60000AF")]
	internal void Dispose() { }

	[Address(RVA = "0x2BD36F0", Offset = "0x2BD2AF0", Length = "0xBF")]
	[Token(Token = "0x60000B0")]
	internal bool get_hasValidVisibleMesh() { }

	[Address(RVA = "0x2BD2FB0", Offset = "0x2BD23B0", Length = "0x78")]
	[Token(Token = "0x60000B3")]
	private bool IsVisibleMeshSupported() { }

	[Address(RVA = "0x2BD3030", Offset = "0x2BD2430", Length = "0x273")]
	[Token(Token = "0x60000B1")]
	internal void RenderVisibleMeshCustomMaterial(CommandBuffer cmd, float occlusionMeshScale, Material material, MaterialPropertyBlock materialBlock, int shaderPass, bool yFlip = false) { }

	[Address(RVA = "0x2BD32B0", Offset = "0x2BD26B0", Length = "0x169")]
	[Token(Token = "0x60000B4")]
	private bool TryGetVisibleMeshCombinedHashCode(out int hashCode) { }

	[Address(RVA = "0x2BD3420", Offset = "0x2BD2820", Length = "0x23E")]
	[Token(Token = "0x60000B2")]
	internal void UpdateCombinedMesh() { }

}

