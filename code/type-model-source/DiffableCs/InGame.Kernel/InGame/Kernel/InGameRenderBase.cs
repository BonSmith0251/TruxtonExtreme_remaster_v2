namespace InGame.Kernel;

[Token(Token = "0x2000084")]
public abstract class InGameRenderBase : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000432")]
	protected Renderer[] _renderers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000433")]
	protected MeshRenderer[] _meshes; //Field offset: 0x28

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000514")]
	protected InGameRenderBase() { }

	[Address(RVA = "0x1D21340", Offset = "0x1D20740", Length = "0xD9")]
	[Token(Token = "0x6000513")]
	public void ChangeLayer(int tid) { }

	[Address(RVA = "0x1D21420", Offset = "0x1D20820", Length = "0x78")]
	[Token(Token = "0x600050C")]
	public override void Initialize() { }

	[Address(RVA = "0x1D214A0", Offset = "0x1D208A0", Length = "0x14")]
	[Token(Token = "0x600050E")]
	private void OnDestroy() { }

	[Address(RVA = "0x1D214C0", Offset = "0x1D208C0", Length = "0xDF")]
	[Token(Token = "0x600050F")]
	public void SetMaterialByName(string tname, Material tmat) { }

	[Address(RVA = "0x1D215A0", Offset = "0x1D209A0", Length = "0x76")]
	[Token(Token = "0x6000510")]
	public void SetRenderers(bool isEnable) { }

	[Address(RVA = "0x1D21780", Offset = "0x1D20B80", Length = "0xAF")]
	[Token(Token = "0x6000511")]
	public override void SetSortingLayer(int tid) { }

	[Address(RVA = "0x1D21620", Offset = "0x1D20A20", Length = "0x15A")]
	[Token(Token = "0x6000512")]
	public void SetSortingLayerIfDefault(int tid) { }

	[Address(RVA = "0x1D21830", Offset = "0x1D20C30", Length = "0x34")]
	[Token(Token = "0x600050D")]
	public override void Terminate() { }

}

