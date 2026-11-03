namespace UnityEngine.Rendering.Universal;

[MovedFrom(False, "UnityEngine.Experimental.Rendering.Universal", "com.unity.render-pipelines.universal", null)]
[Token(Token = "0x200006C")]
public abstract class ShadowCasterGroup2D : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000269")]
	internal int m_ShadowGroup; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400026A")]
	internal int m_Priority; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400026B")]
	private List<ShadowCaster2D> m_ShadowCasters; //Field offset: 0x28

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60002A4")]
	protected ShadowCasterGroup2D() { }

	[Address(RVA = "0x2D3DCB0", Offset = "0x2D3D0B0", Length = "0x9C")]
	[Token(Token = "0x600029F")]
	internal override void CacheValues() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60002A0")]
	public List<ShadowCaster2D> GetShadowCasters() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60002A1")]
	public int GetShadowGroup() { }

	[Address(RVA = "0x2D3DD50", Offset = "0x2D3D150", Length = "0x118")]
	[Token(Token = "0x60002A2")]
	public void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

	[Address(RVA = "0x2D3DE70", Offset = "0x2D3D270", Length = "0x51")]
	[Token(Token = "0x60002A3")]
	public void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

}

