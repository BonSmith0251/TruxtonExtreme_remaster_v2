namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000E3")]
internal sealed class StpHistory : CameraHistoryItem
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000540")]
	private HistoryContext[] m_historyContexts; //Field offset: 0x20

	[Address(RVA = "0x2DC7220", Offset = "0x2DC6620", Length = "0x55")]
	[Token(Token = "0x6000636")]
	public StpHistory() { }

	[Address(RVA = "0x1DDF3B0", Offset = "0x1DDE7B0", Length = "0x2B")]
	[Token(Token = "0x6000634")]
	internal HistoryContext GetHistoryContext(int eyeIndex) { }

	[Address(RVA = "0x2DC6FB0", Offset = "0x2DC63B0", Length = "0xCE")]
	[Token(Token = "0x6000632")]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[Address(RVA = "0x2DC7080", Offset = "0x2DC6480", Length = "0x65")]
	[Token(Token = "0x6000633")]
	public virtual void Reset() { }

	[Address(RVA = "0x2DC70F0", Offset = "0x2DC64F0", Length = "0x125")]
	[Token(Token = "0x6000635")]
	internal bool Update(UniversalCameraData cameraData) { }

}

