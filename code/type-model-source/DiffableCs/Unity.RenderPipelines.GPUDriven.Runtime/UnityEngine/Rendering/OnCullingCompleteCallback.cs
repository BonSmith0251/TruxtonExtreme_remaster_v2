namespace UnityEngine.Rendering;

[Token(Token = "0x2000054")]
internal sealed class OnCullingCompleteCallback : MulticastDelegate
{

	[Address(RVA = "0x2CECE80", Offset = "0x2CEC280", Length = "0xA6")]
	[Token(Token = "0x600016E")]
	public OnCullingCompleteCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2CECD70", Offset = "0x2CEC170", Length = "0xC9")]
	[Token(Token = "0x6000170")]
	public override IAsyncResult BeginInvoke(JobHandle jobHandle, in BatchCullingContext cullingContext, in BatchCullingOutput cullingOutput, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2CECE40", Offset = "0x2CEC240", Length = "0xA")]
	[Token(Token = "0x6000171")]
	public override void EndInvoke(in BatchCullingContext cullingContext, in BatchCullingOutput cullingOutput, IAsyncResult result) { }

	[Address(RVA = "0x2CECE50", Offset = "0x2CEC250", Length = "0x2A")]
	[Token(Token = "0x600016F")]
	public override void Invoke(JobHandle jobHandle, in BatchCullingContext cullingContext, in BatchCullingOutput cullingOutput) { }

}

