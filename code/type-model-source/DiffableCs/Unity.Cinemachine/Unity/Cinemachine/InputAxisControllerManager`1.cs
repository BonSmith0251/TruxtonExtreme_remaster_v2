namespace Unity.Cinemachine;

[Token(Token = "0x20000CD")]
internal class InputAxisControllerManager
{
	[Token(Token = "0x20000CE")]
	internal sealed class DefaultInitializer : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x60003DC")]
		public DefaultInitializer(object object, IntPtr method) { }

		[Address(RVA = "0x17D38A0", Offset = "0x17D2CA0", Length = "0x8E")]
		[Token(Token = "0x60003DE")]
		public override IAsyncResult BeginInvoke(in AxisDescriptor axis, Controller<T> controller, AsyncCallback callback, object object) { }

		[Address(RVA = "0x17D39C0", Offset = "0x17D2DC0", Length = "0xA")]
		[Token(Token = "0x60003DF")]
		public override void EndInvoke(in AxisDescriptor axis, IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60003DD")]
		public override void Invoke(in AxisDescriptor axis, Controller<T> controller) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NonReorderable]
	[Token(Token = "0x4000305")]
	public List<Controller<T>> Controllers; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000306")]
	private readonly List<AxisDescriptor> m_Axes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000307")]
	private readonly List<IInputAxisOwner> m_AxisOwners; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000308")]
	private readonly List<IInputAxisResetSource> m_AxisResetters; //Field offset: 0x0

	[Address(RVA = "0x1CA0E10", Offset = "0x1CA0210", Length = "0x162")]
	[Token(Token = "0x60003DA")]
	public InputAxisControllerManager`1() { }

	[Address(RVA = "0x1CA0140", Offset = "0x1C9F540", Length = "0x125")]
	[CompilerGenerated]
	[Token(Token = "0x60003DB")]
	internal static int <CreateControllers>g__GetControllerIndex|9_0(List<Controller<T>> list, IInputAxisOwner owner, string axisName) { }

	[Address(RVA = "0x1C9E690", Offset = "0x1C9DA90", Length = "0x604")]
	[Token(Token = "0x60003D7")]
	public void CreateControllers(GameObject root, bool scanRecursively, bool enabled, DefaultInitializer<T> defaultInitializer) { }

	[Address(RVA = "0x1C9F3D0", Offset = "0x1C9E7D0", Length = "0x255")]
	[Token(Token = "0x60003D4")]
	public void OnDisable() { }

	[Address(RVA = "0x1C9F9F0", Offset = "0x1C9EDF0", Length = "0xEB")]
	[Token(Token = "0x60003D6")]
	private void OnResetInput() { }

	[Address(RVA = "0x1C9FAE0", Offset = "0x1C9EEE0", Length = "0x2CC")]
	[Token(Token = "0x60003D8")]
	private void RegisterResetHandlers(GameObject root, bool scanRecursively) { }

	[Address(RVA = "0x1CA00E0", Offset = "0x1C9F4E0", Length = "0x57")]
	[Token(Token = "0x60003D5")]
	public void Reset() { }

	[Address(RVA = "0x1CA04C0", Offset = "0x1C9F8C0", Length = "0x1A9")]
	[Token(Token = "0x60003D9")]
	public void UpdateControllers(object context, float deltaTime) { }

	[Address(RVA = "0x1CA0C00", Offset = "0x1CA0000", Length = "0x9E")]
	[Token(Token = "0x60003D3")]
	public void Validate() { }

}

