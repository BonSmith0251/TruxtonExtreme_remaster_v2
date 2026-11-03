namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000255")]
internal class ForDeviceEventObservable : IObservable<InputEventPtr>
{
	[Token(Token = "0x2000256")]
	private class ForDevice : IObserver<InputEventPtr>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CB5")]
		private IObserver<InputEventPtr> m_Observer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CB6")]
		private InputDevice m_Device; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CB7")]
		private Type m_DeviceType; //Field offset: 0x20

		[Address(RVA = "0x2921FD0", Offset = "0x29213D0", Length = "0x6B")]
		[Token(Token = "0x60015D9")]
		public ForDevice(Type deviceType, InputDevice device, IObserver<InputEventPtr> observer) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60015DA")]
		public override void OnCompleted() { }

		[Address(RVA = "0x2921E00", Offset = "0x2921200", Length = "0x49")]
		[Token(Token = "0x60015DB")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0x2921E50", Offset = "0x2921250", Length = "0x17C")]
		[Token(Token = "0x60015DC")]
		public override void OnNext(InputEventPtr value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CB2")]
	private IObservable<InputEventPtr> m_Source; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CB3")]
	private InputDevice m_Device; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CB4")]
	private Type m_DeviceType; //Field offset: 0x20

	[Address(RVA = "0x2921D90", Offset = "0x2921190", Length = "0x6B")]
	[Token(Token = "0x60015D7")]
	public ForDeviceEventObservable(IObservable<InputEventPtr> source, Type deviceType, InputDevice device) { }

	[Address(RVA = "0x2921C50", Offset = "0x2921050", Length = "0x13B")]
	[Token(Token = "0x60015D8")]
	public override IDisposable Subscribe(IObserver<InputEventPtr> observer) { }

}

