namespace UnityEngine.InputSystem.Layouts;

[Token(Token = "0x2000211")]
internal struct InputDeviceBuilder : IDisposable
{
	[Token(Token = "0x2000212")]
	public struct RefInstance : IDisposable
	{

		[Address(RVA = "0x291F130", Offset = "0x291E530", Length = "0x94")]
		[Token(Token = "0x60013B5")]
		public override void Dispose() { }

	}

	[Token(Token = "0x4000BCA")]
	private const uint kSizeForControlUsingStateFromOtherControl = 4294967295; //Field offset: 0x0
	[Token(Token = "0x4000BCB")]
	private static InputDeviceBuilder s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000BCC")]
	private static int s_InstanceRef; //Field offset: 0x28
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BC5")]
	private InputDevice m_Device; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BC6")]
	private CacheRefInstance m_LayoutCacheRef; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BC7")]
	private Dictionary<String, ControlItem> m_ChildControlOverrides; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BC8")]
	private List<UInt32> m_StateOffsetToControlMap; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BC9")]
	private StringBuilder m_StringBuilder; //Field offset: 0x20

	[Token(Token = "0x170005A1")]
	internal static InputDeviceBuilder instance
	{
		[Address(RVA = "0x2916BB0", Offset = "0x2915FB0", Length = "0x33")]
		[Token(Token = "0x60013B3")]
		internal get { } //Length: 51
	}

	[Address(RVA = "0x29117C0", Offset = "0x2910BC0", Length = "0xBCA")]
	[Token(Token = "0x600139F")]
	private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem, int childIndex, string nameOverride = null) { }

	[Address(RVA = "0x29116F0", Offset = "0x2910AF0", Length = "0xC8")]
	[Token(Token = "0x60013A2")]
	private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref ControlItem controlItem) { }

	[Address(RVA = "0x2912390", Offset = "0x2911790", Length = "0x97B")]
	[Token(Token = "0x600139E")]
	private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls) { }

	[Address(RVA = "0x2912D10", Offset = "0x2912110", Length = "0x12F")]
	[Token(Token = "0x60013B1")]
	private void AddChildren(ref ControlBitRangeNode parent, ControlBitRangeNode left, ControlBitRangeNode right) { }

	[Address(RVA = "0x2912E40", Offset = "0x2912240", Length = "0x172")]
	[Token(Token = "0x60013B0")]
	private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex) { }

	[Address(RVA = "0x2912FC0", Offset = "0x29123C0", Length = "0xAC")]
	[Token(Token = "0x60013A7")]
	private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) { }

	[Address(RVA = "0x2913070", Offset = "0x2912470", Length = "0x243")]
	[Token(Token = "0x60013A8")]
	private static void AddProcessors(InputControl control, ref ControlItem controlItem, string layoutName) { }

	[Address(RVA = "0x29132C0", Offset = "0x29126C0", Length = "0x213")]
	[Token(Token = "0x60013A4")]
	private static void ApplyUseStateFrom(InputControl parent, ref ControlItem controlItem, InputControlLayout layout) { }

	[Address(RVA = "0x29134E0", Offset = "0x29128E0", Length = "0x7C")]
	[Token(Token = "0x60013A1")]
	private string ChildControlOverridePath(InputControl parent, InternedString controlName) { }

	[Address(RVA = "0x2913560", Offset = "0x2912960", Length = "0x891")]
	[Token(Token = "0x60013AB")]
	private static void ComputeStateLayout(InputControl control) { }

	[Address(RVA = "0x2913E00", Offset = "0x2913200", Length = "0xB")]
	[Token(Token = "0x600139A")]
	public override void Dispose() { }

	[Address(RVA = "0x2914360", Offset = "0x2913760", Length = "0x2C2")]
	[Token(Token = "0x60013AC")]
	private void FinalizeControlHierarchy() { }

	[Address(RVA = "0x2913E10", Offset = "0x2913210", Length = "0x541")]
	[Token(Token = "0x60013AD")]
	private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex) { }

	[Address(RVA = "0x2914630", Offset = "0x2913A30", Length = "0x57")]
	[Token(Token = "0x60013AA")]
	private static InputControlLayout FindOrLoadLayout(string name) { }

	[Address(RVA = "0x2914690", Offset = "0x2913A90", Length = "0x2B2")]
	[Token(Token = "0x6001399")]
	public InputDevice Finish() { }

	[Address(RVA = "0x2916BB0", Offset = "0x2915FB0", Length = "0x33")]
	[Token(Token = "0x60013B3")]
	internal static InputDeviceBuilder get_instance() { }

	[Address(RVA = "0x2914950", Offset = "0x2913D50", Length = "0x595")]
	[Token(Token = "0x60013AF")]
	private ushort GetBestMidPoint(ControlBitRangeNode parent, ushort startOffset) { }

	[Address(RVA = "0x2914EF0", Offset = "0x29142F0", Length = "0xCF")]
	[Token(Token = "0x60013B2")]
	private ushort GetControlIndex(InputControl control) { }

	[Address(RVA = "0x2915390", Offset = "0x2914790", Length = "0x4AC")]
	[Token(Token = "0x60013A3")]
	private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref ControlItem controlItem) { }

	[Address(RVA = "0x2914FC0", Offset = "0x29143C0", Length = "0x3C0")]
	[Token(Token = "0x60013A0")]
	private void InsertChildControlOverride(InputControl parent, ref ControlItem controlItem) { }

	[Address(RVA = "0x2915840", Offset = "0x2914C40", Length = "0x394")]
	[Token(Token = "0x60013AE")]
	private void InsertControlBitRangeNode(ref ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset) { }

	[Address(RVA = "0x2916390", Offset = "0x2915790", Length = "0xCF")]
	[Token(Token = "0x600139C")]
	private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) { }

	[Address(RVA = "0x2915BE0", Offset = "0x2914FE0", Length = "0x7AF")]
	[Token(Token = "0x600139D")]
	private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) { }

	[Address(RVA = "0x2916460", Offset = "0x2915860", Length = "0x3D")]
	[Token(Token = "0x60013B4")]
	internal static RefInstance Ref() { }

	[Address(RVA = "0x29164A0", Offset = "0x29158A0", Length = "0x70")]
	[Token(Token = "0x600139B")]
	private void Reset() { }

	[Address(RVA = "0x2916510", Offset = "0x2915910", Length = "0x382")]
	[Token(Token = "0x60013A6")]
	private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) { }

	[Address(RVA = "0x29168A0", Offset = "0x2915CA0", Length = "0xAF")]
	[Token(Token = "0x60013A9")]
	private static void SetFormat(InputControl control, ControlItem controlItem) { }

	[Address(RVA = "0x2916950", Offset = "0x2915D50", Length = "0x1DA")]
	[Token(Token = "0x6001398")]
	public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = null) { }

	[Address(RVA = "0x2916B30", Offset = "0x2915F30", Length = "0x78")]
	[Token(Token = "0x60013A5")]
	private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl) { }

}

