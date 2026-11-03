namespace Unity.Jobs;

[Token(Token = "0x2000006")]
public class EarlyInitHelpers
{
	[Token(Token = "0x2000007")]
	internal sealed class EarlyInitFunction : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x600000A")]
		public EarlyInitFunction(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x600000C")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600000D")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x600000B")]
		public override void Invoke() { }

	}

	[Token(Token = "0x4000006")]
	private static List<EarlyInitFunction> s_PendingDelegates; //Field offset: 0x0

	[Address(RVA = "0x28AFB40", Offset = "0x28AEF40", Length = "0x7")]
	[Token(Token = "0x6000005")]
	private static EarlyInitHelpers() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000009")]
	public EarlyInitHelpers() { }

	[Address(RVA = "0x28AF7F0", Offset = "0x28AEBF0", Length = "0x16B")]
	[Token(Token = "0x6000007")]
	public static void AddEarlyInitFunction(EarlyInitFunction func) { }

	[Address(RVA = "0x28AF960", Offset = "0x28AED60", Length = "0x16A")]
	[Token(Token = "0x6000006")]
	public static void FlushEarlyInits() { }

	[Address(RVA = "0x28AFAD0", Offset = "0x28AEED0", Length = "0x63")]
	[Token(Token = "0x6000008")]
	public static void JobReflectionDataCreationFailed(Exception ex) { }

}

