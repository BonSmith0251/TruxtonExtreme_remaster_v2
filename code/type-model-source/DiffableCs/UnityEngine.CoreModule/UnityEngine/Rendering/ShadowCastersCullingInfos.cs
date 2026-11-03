namespace UnityEngine.Rendering;

[Token(Token = "0x20003D2")]
public struct ShadowCastersCullingInfos
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C6C")]
	public NativeArray<ShadowSplitData> splitBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C6D")]
	public NativeArray<LightShadowCasterCullingInfo> perLightInfos; //Field offset: 0x10

}

