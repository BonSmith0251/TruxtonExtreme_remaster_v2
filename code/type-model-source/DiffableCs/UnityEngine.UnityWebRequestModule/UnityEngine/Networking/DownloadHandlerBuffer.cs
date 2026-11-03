namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
[Token(Token = "0x2000009")]
public sealed class DownloadHandlerBuffer : DownloadHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000015")]
	private NativeArray<Byte> m_NativeData; //Field offset: 0x18

	[Address(RVA = "0x347B0E0", Offset = "0x347A4E0", Length = "0x3E")]
	[Token(Token = "0x6000031")]
	public DownloadHandlerBuffer() { }

	[Address(RVA = "0x347AEC0", Offset = "0x347A2C0", Length = "0x33")]
	[Token(Token = "0x600002F")]
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	[Address(RVA = "0x347AF00", Offset = "0x347A300", Length = "0x7A")]
	[Token(Token = "0x6000033")]
	public virtual void Dispose() { }

	[Address(RVA = "0x347AF80", Offset = "0x347A380", Length = "0x11B")]
	[Token(Token = "0x6000032")]
	protected virtual NativeArray<Byte> GetNativeData() { }

	[Address(RVA = "0x347B0A0", Offset = "0x347A4A0", Length = "0x37")]
	[Token(Token = "0x6000030")]
	private void InternalCreateBuffer() { }

}

