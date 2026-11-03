namespace Unity.Cinemachine;

[ExecuteAlways]
[SaveDuringPlay]
[Token(Token = "0x20000CF")]
public abstract class InputAxisControllerBase : MonoBehaviour, IInputAxisController
{
	[Token(Token = "0x20000D0")]
	internal class Controller
	{
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[Token(Token = "0x400030D")]
		public string Name; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[Token(Token = "0x400030E")]
		public object Owner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030F")]
		[Tooltip("When enabled, this controller will drive the input axis")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[HideFoldout]
		[Token(Token = "0x4000310")]
		public T Input; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000311")]
		public float InputValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[HideFoldout]
		[Token(Token = "0x4000312")]
		public DefaultInputAxisDriver Driver; //Field offset: 0x0

		[Address(RVA = "0x17C83A0", Offset = "0x17C77A0", Length = "0xB")]
		[Token(Token = "0x60003EA")]
		public Controller() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000309")]
	[Tooltip("If set, a recursive search for IInputAxisOwners behaviours will be performed.  Otherwise, only behaviours attached directly to this GameObject will be considered, and child objects will be ignored")]
	public bool ScanRecursively; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[HideIfNoComponent(typeof(CinemachineVirtualCameraBase))]
	[Token(Token = "0x400030A")]
	[Tooltip("If set, input will not be processed while the Cinemachine Camera is participating in a blend.")]
	public bool SuppressInputWhileBlending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400030B")]
	public bool IgnoreTimeScale; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Header("Driven Axes")]
	[InputAxisControllerManager]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x400030C")]
	internal InputAxisControllerManager<T> m_ControllerManager; //Field offset: 0x0

	[Token(Token = "0x170000D6")]
	public List<Controller<T>> Controllers
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x60003E0")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x1C9E4A0", Offset = "0x1C9D8A0", Length = "0x1C6")]
	[Token(Token = "0x60003E9")]
	protected InputAxisControllerBase`1() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x60003E0")]
	public List<Controller<T>> get_Controllers() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003E6")]
	protected override void InitializeControllerDefaultsForAxis(in AxisDescriptor axis, Controller<T> controller) { }

	[Address(RVA = "0x1C9DC30", Offset = "0x1C9D030", Length = "0x2A")]
	[Token(Token = "0x60003E4")]
	protected override void OnDisable() { }

	[Address(RVA = "0x1C9DC90", Offset = "0x1C9D090", Length = "0x14")]
	[Token(Token = "0x60003E3")]
	protected override void OnEnable() { }

	[Address(RVA = "0x1C9DCB0", Offset = "0x1C9D0B0", Length = "0xB4")]
	[Token(Token = "0x60003E1")]
	protected override void OnValidate() { }

	[Address(RVA = "0x1C9DE00", Offset = "0x1C9D200", Length = "0x9F")]
	[Token(Token = "0x60003E2")]
	protected override void Reset() { }

	[Address(RVA = "0x1C9DEA0", Offset = "0x1C9D2A0", Length = "0xE9")]
	[Token(Token = "0x60003E5")]
	public override void SynchronizeControllers() { }

	[Address(RVA = "0x1C9E080", Offset = "0x1C9D480", Length = "0x4A")]
	[Token(Token = "0x60003E7")]
	protected void UpdateControllers() { }

	[Address(RVA = "0x1C9E0D0", Offset = "0x1C9D4D0", Length = "0x236")]
	[Token(Token = "0x60003E8")]
	protected void UpdateControllers(float deltaTime) { }

}

