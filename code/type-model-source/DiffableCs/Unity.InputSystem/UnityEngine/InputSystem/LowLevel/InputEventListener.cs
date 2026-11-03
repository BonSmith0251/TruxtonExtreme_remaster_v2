namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001BD")]
public struct InputEventListener : IObservable<InputEventPtr>
{
	[Token(Token = "0x20001BF")]
	private class DisposableObserver : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A34")]
		public IObserver<InputEventPtr> observer; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600109C")]
		public DisposableObserver() { }

		[Address(RVA = "0x29EB1C0", Offset = "0x29EA5C0", Length = "0x13C")]
		[Token(Token = "0x600109B")]
		public override void Dispose() { }

	}

	[Token(Token = "0x20001BE")]
	public class ObserverState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A32")]
		public InlinedArray<IObserver`1<InputEventPtr>> observers; //Field offset: 0x10
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A33")]
		public Action<InputEventPtr, InputDevice> onEventDelegate; //Field offset: 0x28

		[Address(RVA = "0x29FBAA0", Offset = "0x29FAEA0", Length = "0x7D")]
		[Token(Token = "0x6001099")]
		public ObserverState() { }

		[Address(RVA = "0x29FB980", Offset = "0x29FAD80", Length = "0x110")]
		[CompilerGenerated]
		[Token(Token = "0x600109A")]
		private void <.ctor>b__2_0(InputEventPtr eventPtr, InputDevice device) { }

	}

	[Token(Token = "0x4000A31")]
	internal static ObserverState s_ObserverState; //Field offset: 0x0

	[Address(RVA = "0x29F7570", Offset = "0x29F6970", Length = "0x16C")]
	[Token(Token = "0x6001096")]
	public static InputEventListener op_Addition(InputEventListener _, Action<InputEventPtr, InputDevice> callback) { }

	[Address(RVA = "0x29F76E0", Offset = "0x29F6AE0", Length = "0x16C")]
	[Token(Token = "0x6001097")]
	public static InputEventListener op_Subtraction(InputEventListener _, Action<InputEventPtr, InputDevice> callback) { }

	[Address(RVA = "0x29F7370", Offset = "0x29F6770", Length = "0x1FC")]
	[Token(Token = "0x6001098")]
	public override IDisposable Subscribe(IObserver<InputEventPtr> observer) { }

}

