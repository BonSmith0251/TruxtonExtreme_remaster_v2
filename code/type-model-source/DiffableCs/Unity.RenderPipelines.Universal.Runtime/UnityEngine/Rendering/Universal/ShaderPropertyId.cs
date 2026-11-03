namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F5")]
internal static class ShaderPropertyId
{
	[Token(Token = "0x4000ACA")]
	public static readonly int glossyEnvironmentColor; //Field offset: 0x0
	[Token(Token = "0x4000ACB")]
	public static readonly int subtractiveShadowColor; //Field offset: 0x4
	[Token(Token = "0x4000ACC")]
	public static readonly int glossyEnvironmentCubeMap; //Field offset: 0x8
	[Token(Token = "0x4000ACD")]
	public static readonly int glossyEnvironmentCubeMapHDR; //Field offset: 0xC
	[Token(Token = "0x4000ACE")]
	public static readonly int ambientSkyColor; //Field offset: 0x10
	[Token(Token = "0x4000ACF")]
	public static readonly int ambientEquatorColor; //Field offset: 0x14
	[Token(Token = "0x4000AD0")]
	public static readonly int ambientGroundColor; //Field offset: 0x18
	[Token(Token = "0x4000AD1")]
	public static readonly int time; //Field offset: 0x1C
	[Token(Token = "0x4000AD2")]
	public static readonly int sinTime; //Field offset: 0x20
	[Token(Token = "0x4000AD3")]
	public static readonly int cosTime; //Field offset: 0x24
	[Token(Token = "0x4000AD4")]
	public static readonly int deltaTime; //Field offset: 0x28
	[Token(Token = "0x4000AD5")]
	public static readonly int timeParameters; //Field offset: 0x2C
	[Token(Token = "0x4000AD6")]
	public static readonly int lastTimeParameters; //Field offset: 0x30
	[Token(Token = "0x4000AD7")]
	public static readonly int scaledScreenParams; //Field offset: 0x34
	[Token(Token = "0x4000AD8")]
	public static readonly int worldSpaceCameraPos; //Field offset: 0x38
	[Token(Token = "0x4000AD9")]
	public static readonly int screenParams; //Field offset: 0x3C
	[Token(Token = "0x4000ADA")]
	public static readonly int alphaToMaskAvailable; //Field offset: 0x40
	[Token(Token = "0x4000ADB")]
	public static readonly int projectionParams; //Field offset: 0x44
	[Token(Token = "0x4000ADC")]
	public static readonly int zBufferParams; //Field offset: 0x48
	[Token(Token = "0x4000ADD")]
	public static readonly int orthoParams; //Field offset: 0x4C
	[Token(Token = "0x4000ADE")]
	public static readonly int globalMipBias; //Field offset: 0x50
	[Token(Token = "0x4000ADF")]
	public static readonly int screenSize; //Field offset: 0x54
	[Token(Token = "0x4000AE0")]
	public static readonly int screenCoordScaleBias; //Field offset: 0x58
	[Token(Token = "0x4000AE1")]
	public static readonly int screenSizeOverride; //Field offset: 0x5C
	[Token(Token = "0x4000AE2")]
	public static readonly int viewMatrix; //Field offset: 0x60
	[Token(Token = "0x4000AE3")]
	public static readonly int projectionMatrix; //Field offset: 0x64
	[Token(Token = "0x4000AE4")]
	public static readonly int viewAndProjectionMatrix; //Field offset: 0x68
	[Token(Token = "0x4000AE5")]
	public static readonly int inverseViewMatrix; //Field offset: 0x6C
	[Token(Token = "0x4000AE6")]
	public static readonly int inverseProjectionMatrix; //Field offset: 0x70
	[Token(Token = "0x4000AE7")]
	public static readonly int inverseViewAndProjectionMatrix; //Field offset: 0x74
	[Token(Token = "0x4000AE8")]
	public static readonly int cameraProjectionMatrix; //Field offset: 0x78
	[Token(Token = "0x4000AE9")]
	public static readonly int inverseCameraProjectionMatrix; //Field offset: 0x7C
	[Token(Token = "0x4000AEA")]
	public static readonly int worldToCameraMatrix; //Field offset: 0x80
	[Token(Token = "0x4000AEB")]
	public static readonly int cameraToWorldMatrix; //Field offset: 0x84
	[Token(Token = "0x4000AEC")]
	public static readonly int shadowBias; //Field offset: 0x88
	[Token(Token = "0x4000AED")]
	public static readonly int lightDirection; //Field offset: 0x8C
	[Token(Token = "0x4000AEE")]
	public static readonly int lightPosition; //Field offset: 0x90
	[Token(Token = "0x4000AEF")]
	public static readonly int cameraWorldClipPlanes; //Field offset: 0x94
	[Token(Token = "0x4000AF0")]
	public static readonly int billboardNormal; //Field offset: 0x98
	[Token(Token = "0x4000AF1")]
	public static readonly int billboardTangent; //Field offset: 0x9C
	[Token(Token = "0x4000AF2")]
	public static readonly int billboardCameraParams; //Field offset: 0xA0
	[Token(Token = "0x4000AF3")]
	public static readonly int previousViewProjectionNoJitter; //Field offset: 0xA4
	[Token(Token = "0x4000AF4")]
	public static readonly int viewProjectionNoJitter; //Field offset: 0xA8
	[Token(Token = "0x4000AF5")]
	public static readonly int previousViewProjectionNoJitterStereo; //Field offset: 0xAC
	[Token(Token = "0x4000AF6")]
	public static readonly int viewProjectionNoJitterStereo; //Field offset: 0xB0
	[Token(Token = "0x4000AF7")]
	public static readonly int blitTexture; //Field offset: 0xB4
	[Token(Token = "0x4000AF8")]
	public static readonly int blitScaleBias; //Field offset: 0xB8
	[Token(Token = "0x4000AF9")]
	public static readonly int sourceTex; //Field offset: 0xBC
	[Token(Token = "0x4000AFA")]
	public static readonly int scaleBias; //Field offset: 0xC0
	[Token(Token = "0x4000AFB")]
	public static readonly int scaleBiasRt; //Field offset: 0xC4
	[Token(Token = "0x4000AFC")]
	public static readonly int rtHandleScale; //Field offset: 0xC8
	[Token(Token = "0x4000AFD")]
	public static readonly int rendererColor; //Field offset: 0xCC
	[Token(Token = "0x4000AFE")]
	public static readonly int ditheringTexture; //Field offset: 0xD0
	[Token(Token = "0x4000AFF")]
	public static readonly int ditheringTextureInvSize; //Field offset: 0xD4
	[Token(Token = "0x4000B00")]
	public static readonly int renderingLayerMaxInt; //Field offset: 0xD8
	[Token(Token = "0x4000B01")]
	public static readonly int overlayUITexture; //Field offset: 0xDC
	[Token(Token = "0x4000B02")]
	public static readonly int hdrOutputLuminanceParams; //Field offset: 0xE0
	[Token(Token = "0x4000B03")]
	public static readonly int hdrOutputGradingParams; //Field offset: 0xE4
	[Token(Token = "0x4000B04")]
	public static readonly int offscreenUIViewportParams; //Field offset: 0xE8
	[Token(Token = "0x4000B05")]
	public static readonly int screenSpaceIrradiance; //Field offset: 0xEC

	[Address(RVA = "0x2E09980", Offset = "0x2E08D80", Length = "0xA90")]
	[Token(Token = "0x6000AB9")]
	private static ShaderPropertyId() { }

}

