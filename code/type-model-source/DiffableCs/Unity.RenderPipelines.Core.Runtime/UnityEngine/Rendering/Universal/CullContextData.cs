namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000235")]
public class CullContextData : ContextItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E5")]
	internal Nullable<ScriptableRenderContext> m_RenderContext; //Field offset: 0x10

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000FD9")]
	public CullContextData() { }

	[Address(RVA = "0x2C6F5C0", Offset = "0x2C6E9C0", Length = "0xFB")]
	[Token(Token = "0x6000FD7")]
	public CullingResults Cull(ref ScriptableCullingParameters parameters) { }

	[Address(RVA = "0x2C6F4B0", Offset = "0x2C6E8B0", Length = "0x10D")]
	[Token(Token = "0x6000FD8")]
	public void CullShadowCasters(CullingResults cullingResults, ShadowCastersCullingInfos shadowCastersCullingInfos) { }

	[Address(RVA = "0x2C6F6C0", Offset = "0x2C6EAC0", Length = "0x8")]
	[Token(Token = "0x6000FD5")]
	public virtual void Reset() { }

	[Address(RVA = "0x2C6F6D0", Offset = "0x2C6EAD0", Length = "0x5C")]
	[Token(Token = "0x6000FD6")]
	public void SetRenderContext(in ScriptableRenderContext renderContext) { }

}

