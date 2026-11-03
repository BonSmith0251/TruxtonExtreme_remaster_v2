namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000047")]
internal class PixelPerfectCameraInternal : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000183")]
	private IPixelPerfectCamera m_Component; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000184")]
	private PixelPerfectCamera m_SerializableComponent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000185")]
	internal float originalOrthoSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000186")]
	internal bool hasPostProcessLayer; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000187")]
	internal bool cropFrameXAndY; //Field offset: 0x25
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x4000188")]
	internal bool cropFrameXOrY; //Field offset: 0x26
	[FieldOffset(Offset = "0x27")]
	[Token(Token = "0x4000189")]
	internal bool useStretchFill; //Field offset: 0x27
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400018A")]
	internal int zoom; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400018B")]
	internal bool useOffscreenRT; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400018C")]
	internal int offscreenRTWidth; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400018D")]
	internal int offscreenRTHeight; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400018E")]
	internal Rect pixelRect; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400018F")]
	internal float orthoSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000190")]
	internal float unitsPerPixel; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000191")]
	internal int cinemachineVCamZoom; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000192")]
	internal bool requiresUpscaling; //Field offset: 0x54

	[Address(RVA = "0x2D2BA20", Offset = "0x2D2AE20", Length = "0xC0")]
	[Token(Token = "0x60001EA")]
	internal PixelPerfectCameraInternal(IPixelPerfectCamera component) { }

	[Address(RVA = "0x2D2AED0", Offset = "0x2D2A2D0", Length = "0x5BD")]
	[Token(Token = "0x60001ED")]
	internal void CalculateCameraProperties(int screenWidth, int screenHeight) { }

	[Address(RVA = "0x2D2B490", Offset = "0x2D2A890", Length = "0x2C0")]
	[Token(Token = "0x60001EE")]
	internal Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight) { }

	[Address(RVA = "0x2D2B760", Offset = "0x2D2AB60", Length = "0x17F")]
	[Token(Token = "0x60001EF")]
	internal float CorrectCinemachineOrthoSize(float targetOrthoSize) { }

	[Address(RVA = "0x2D2B8E0", Offset = "0x2D2ACE0", Length = "0x6F")]
	[Token(Token = "0x60001EC")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x2D2B950", Offset = "0x2D2AD50", Length = "0xCA")]
	[Token(Token = "0x60001EB")]
	public override void OnBeforeSerialize() { }

}

