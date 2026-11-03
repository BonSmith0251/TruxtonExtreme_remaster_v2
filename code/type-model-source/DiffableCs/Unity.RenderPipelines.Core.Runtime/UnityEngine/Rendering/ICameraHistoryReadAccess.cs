namespace UnityEngine.Rendering;

[Token(Token = "0x200001A")]
public interface ICameraHistoryReadAccess
{
	[Token(Token = "0x200001B")]
	internal sealed class HistoryRequestDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C4A150", Offset = "0x1C49550", Length = "0x124")]
		[Token(Token = "0x60000BE")]
		public HistoryRequestDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x60000C0")]
		public override IAsyncResult BeginInvoke(IPerFrameHistoryAccessTracker historyAccess, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60000C1")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60000BF")]
		public override void Invoke(IPerFrameHistoryAccessTracker historyAccess) { }

	}


	[Token(Token = "0x14000001")]
	public event HistoryRequestDelegate OnGatherHistoryRequests
	{
		[CompilerGenerated]
		[Token(Token = "0x60000BC")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x60000BD")]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	[Token(Token = "0x60000BC")]
	public void add_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

	[Token(Token = "0x60000BB")]
	public Type GetHistoryForRead() { }

	[CompilerGenerated]
	[Token(Token = "0x60000BD")]
	public void remove_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

}

