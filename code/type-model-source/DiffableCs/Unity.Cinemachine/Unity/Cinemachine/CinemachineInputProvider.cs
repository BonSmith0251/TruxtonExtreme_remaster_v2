namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[Obsolete("CinemachineInputProvider has been deprecated. Use InputAxisController instead.")]
[Token(Token = "0x200011D")]
public class CinemachineInputProvider : MonoBehaviour, IInputAxisProvider
{
	[CompilerGenerated]
	[Token(Token = "0x200011E")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004AE")]
		public InputActionReference aRef; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000580")]
		public <>c__DisplayClass7_0() { }

		[Address(RVA = "0x287FFA0", Offset = "0x287F3A0", Length = "0x78")]
		[Token(Token = "0x6000581")]
		internal bool <ResolveForPlayer>b__1(InputAction x) { }

	}

	[Token(Token = "0x40004AC")]
	private const int NUM_AXES = 3; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004A8")]
	[Tooltip("Leave this at -1 for single-player games.  For multi-player games, set this to be the player index, and the actions will be read from that player's controls")]
	public int PlayerIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004A9")]
	[Tooltip("If set, Input Actions will be auto-enabled at start")]
	public bool AutoEnableInputs; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004AA")]
	[Tooltip("Vector2 action for XY movement")]
	public InputActionReference XYAxis; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004AB")]
	[Tooltip("Float action for Z movement")]
	public InputActionReference ZAxis; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004AD")]
	private InputAction[] m_cachedActions; //Field offset: 0x38

	[Address(RVA = "0x286F960", Offset = "0x286ED60", Length = "0x12")]
	[Token(Token = "0x600057E")]
	public CinemachineInputProvider() { }

	[Address(RVA = "0x286F840", Offset = "0x286EC40", Length = "0x110")]
	[CompilerGenerated]
	[Token(Token = "0x600057F")]
	internal static InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(in InputUser user, InputActionReference aRef) { }

	[Address(RVA = "0x286F240", Offset = "0x286E640", Length = "0x104")]
	[Token(Token = "0x600057B")]
	public override float GetAxisValue(int axis) { }

	[Address(RVA = "0x286F350", Offset = "0x286E750", Length = "0x13")]
	[Token(Token = "0x600057D")]
	protected override void OnDisable() { }

	[Address(RVA = "0x286F370", Offset = "0x286E770", Length = "0x4C2")]
	[Token(Token = "0x600057C")]
	protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef) { }

}

