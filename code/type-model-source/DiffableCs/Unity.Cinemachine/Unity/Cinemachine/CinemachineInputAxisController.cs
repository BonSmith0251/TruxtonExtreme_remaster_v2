namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Input Axis Controller")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineInputAxisController.html")]
[SaveDuringPlay]
[Token(Token = "0x2000143")]
public class CinemachineInputAxisController : InputAxisControllerBase<Reader>
{
	[Token(Token = "0x2000145")]
	internal sealed class Reader : IInputAxisReader
	{
		[Token(Token = "0x2000146")]
		internal sealed class ControlValueReader : MulticastDelegate
		{

			[Address(RVA = "0x287D770", Offset = "0x287CB70", Length = "0xB5")]
			[Token(Token = "0x600065F")]
			public ControlValueReader(object object, IntPtr method) { }

			[Address(RVA = "0x287D6C0", Offset = "0x287CAC0", Length = "0xA5")]
			[Token(Token = "0x6000661")]
			public override IAsyncResult BeginInvoke(InputAction action, Hints hint, object context, ControlValueReader defaultReader, AsyncCallback callback, object object) { }

			[Address(RVA = "0x64F590", Offset = "0x64E990", Length = "0x29")]
			[Token(Token = "0x6000662")]
			public override float EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
			[Token(Token = "0x6000660")]
			public override float Invoke(InputAction action, Hints hint, object context, ControlValueReader defaultReader) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400055A")]
		[Tooltip("Action for the Input package (if used).")]
		public InputActionReference InputAction; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400055B")]
		[Tooltip("The input value is multiplied by this amount prior to processing.  Controls the input power.  Set it to a negative value to invert the input")]
		public float Gain; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400055C")]
		internal InputAction m_CachedAction; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400055D")]
		[Tooltip("Enable this if the input value is inherently dependent on frame time.  For example, mouse deltas will naturally be bigger for longer frames, so in this case the default deltaTime scaling should be canceled.")]
		public bool CancelDeltaTime; //Field offset: 0x28

		[Address(RVA = "0x1CC73D0", Offset = "0x1CC67D0", Length = "0xE")]
		[Token(Token = "0x600065D")]
		public Reader() { }

		[Address(RVA = "0x287FA10", Offset = "0x287EE10", Length = "0x184")]
		[CompilerGenerated]
		[Token(Token = "0x600065E")]
		internal static InputAction <ResolveAndReadInputAction>g__GetFirstMatch|6_0(in InputUser user, InputActionReference aRef) { }

		[Address(RVA = "0x287F1C0", Offset = "0x287E5C0", Length = "0x107")]
		[Token(Token = "0x600065A")]
		public override float GetValue(object context, Hints hint) { }

		[Address(RVA = "0x287F2D0", Offset = "0x287E6D0", Length = "0x288")]
		[Token(Token = "0x600065C")]
		private float ReadInput(InputAction action, Hints hint, object context, ControlValueReader defaultReader) { }

		[Address(RVA = "0x287F560", Offset = "0x287E960", Length = "0x4A9")]
		[Token(Token = "0x600065B")]
		private float ResolveAndReadInputAction(CinemachineInputAxisController context, Hints hint) { }

	}

	[Token(Token = "0x2000144")]
	public sealed class SetControlDefaultsForAxis : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x6000656")]
		public SetControlDefaultsForAxis(object object, IntPtr method) { }

		[Address(RVA = "0x287FBA0", Offset = "0x287EFA0", Length = "0x91")]
		[Token(Token = "0x6000658")]
		public override IAsyncResult BeginInvoke(in AxisDescriptor axis, ref Controller<Reader> controller, AsyncCallback callback, object object) { }

		[Address(RVA = "0x287FC40", Offset = "0x287F040", Length = "0x1B")]
		[Token(Token = "0x6000659")]
		public override void EndInvoke(in AxisDescriptor axis, ref Controller<Reader> controller, IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000657")]
		public override void Invoke(in AxisDescriptor axis, ref Controller<Reader> controller) { }

	}

	[Token(Token = "0x4000558")]
	internal static SetControlDefaultsForAxis SetControlDefaults; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000556")]
	[Tooltip("Leave this at -1 for single-player games.  For multi-player games, set this to be the player index, and the actions will be read from that player's controls")]
	public int PlayerIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000557")]
	[Tooltip("If set, Input Actions will be auto-enabled at start")]
	public bool AutoEnableInputs; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000559")]
	public ControlValueReader ReadControlValueOverride; //Field offset: 0x38

	[Address(RVA = "0x286ED20", Offset = "0x286E120", Length = "0x44")]
	[Token(Token = "0x6000655")]
	public CinemachineInputAxisController() { }

	[Address(RVA = "0x286EC00", Offset = "0x286E000", Length = "0x5B")]
	[Token(Token = "0x6000653")]
	protected virtual void InitializeControllerDefaultsForAxis(in AxisDescriptor axis, Controller<Reader> controller) { }

	[Address(RVA = "0x286EC60", Offset = "0x286E060", Length = "0x45")]
	[Token(Token = "0x6000652")]
	protected virtual void Reset() { }

	[Address(RVA = "0x286ECB0", Offset = "0x286E0B0", Length = "0x6B")]
	[Token(Token = "0x6000654")]
	private void Update() { }

}

